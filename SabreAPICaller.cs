using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using System.Threading.Tasks;
using ServiceStack.Text;
using TraveLayer.CustomTypes.Sabre.Response;
using System.Net;

namespace TrippismApi.TraveLayer
{
    public class SabreAPICaller : IAsyncSabreAPICaller
    {
        Uri _TokenUri;
        public string LongTermToken
        {
            get
            {
                return _longTermToken;
            }
            set
            {
                _longTermToken = value;
            }
        }
        private string _longTermToken = String.Empty;
        public Uri TokenUri
        {
            set
            {
                this._TokenUri = value;
            }
        }

        public string SabreTokenKey
        {
            get
            {
                return "TrippismApi.SabreToken";
            }
        }

        public string SabreTokenExpireKey
        {
            get
            {
                return "TrippismApi.SabreToken.ExpireIn";
            }
        }

        public string TokenExpireIn
        {
            get;
            set;
        }

        Uri _BaseAPIUri;
        public Uri BaseAPIUri
        {
            get
            {
                return this._BaseAPIUri;
            }
            set
            {
                this._BaseAPIUri = value;
            }
        }
        String _ClientId;
        public String ClientId
        {
            set
            {
                this._ClientId = value;
            }
        }
        String _ClientSecret;
        public String ClientSecret
        {
            set
            {
                this._ClientSecret = value;
            }
        }
        String _Accept;
        public String Accept
        {
            set
            {
                this._Accept = value;
            }
        }
        String _ContentType;
        public String ContentType
        {
            set
            {
                this._ContentType = value;
            }
        }
        String _Authorization;
        public String Authorization
        {
            set
            {
                this._Authorization = value;
            }
        }
        private async Task HandleErrorResponse(HttpResponseMessage response)
{
    JsonObject error = await response.Content.ReadAsAsync<JsonObject>();
    string errorType = error.Get<string>("error");
    string errorDescription = error.Get<string>("error_description");
    throw new HttpRequestException(string.Format("Sabre request failed: {0} {1}", errorType, errorDescription));
}

public async Task<String> GetToken(string url)
{
    using (var client = new HttpClient())
    {
        // ... omitted for brevity

        HttpResponseMessage sabreResponse = await client.PostAsync(_TokenUri + url, requestContent).ConfigureAwait(false);

        if (!sabreResponse.IsSuccessStatusCode)
        {
            await HandleErrorResponse(sabreResponse);
        }

        JsonObject response = await sabreResponse.Content.ReadAsAsync<JsonObject>();
        LongTermToken = response.Get<string>("access_token");
        TokenExpireIn = response.Get<string>("expires_in");
    }
    return LongTermToken;
}public SabreAPICaller()
        {
            _TokenUri = new Uri(ConfigurationManager.AppSettings["SabreTokenUri"].ToString());
            _BaseAPIUri = new Uri(ConfigurationManager.AppSettings["SabreBaseAPIUri"].ToString());
            _ClientId = ConfigurationManager.AppSettings["SabreClientID"].ToString();
            _ClientSecret = ConfigurationManager.AppSettings["SabreClientSecret"].ToString();
        }
        public async Task<String> GetToken(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_Accept));

                byte[] cidbytes = System.Text.Encoding.UTF8.GetBytes(_ClientId);
                string cidbase64 = Convert.ToBase64String(cidbytes);

                byte[] secdbytes = System.Text.Encoding.UTF8.GetBytes(_ClientSecret);
                string secdbase64 = Convert.ToBase64String(secdbytes);

                string cre = String.Format("{0}:{1}", cidbase64, secdbase64);
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(cre);
                string base64 = Convert.ToBase64String(bytes);

                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", base64));

                /*POST https://api.test.sabre.com/v1/auth/token HTTP/1.1
                POST https: //api.sabre.com/v1/auth/token/ HTTP/1.1
                Accept: application/json
                Authorization: Basic VmpFNmJYRTBOMjVwTjJVNU5XeDFhM1l4ZHpwRVJWWkRSVTVVUlZJNlJWaFU6VTNkV1l6Qkhkak09
                Content-Type: application/x-www-form-urlencoded
                Host: api.test.sabre.com
                Content-Length: 29
                Expect: 100-continue
                Connection: Keep-Alive*/

                //grant_type=client_credentials

                HttpContent requestContent = new StringContent("grant_type=client_credentials", System.Text.Encoding.UTF8, _ContentType);
                HttpResponseMessage sabreResponse = await client.PostAsync(_TokenUri + url, requestContent).ConfigureAwait(false); ;

                // If client authentication failed then we get a JSON response from Azure Market Place
                if (!sabreResponse.IsSuccessStatusCode)
                {
                    JsonObject error = await sabreResponse.Content.ReadAsAsync<JsonObject>();
                    string errorType = error.Get<string>("error");
                    string errorDescription = error.Get<string>("error_description");
                    throw new HttpRequestException(string.Format("Sabre request failed: {0} {1}", errorType, errorDescription));
                }

                // "{  "access_token": "Shared/IDL:IceSess\\/SessMgr:1\\.0.IDL/Common/!ICESMS\\/ACPCRTC!ICESMSLB\\/CRT.LB!-3572677658411405181!1757770!0!!E2E-1",  "token_type": "bearer",  "expires_in": 900}"

                // Get the access token to attach to the original request from the response body
                JsonObject response = await sabreResponse.Content.ReadAsAsync<JsonObject>();

                //should we URLencode this ?
                //LongTermToken = HttpUtility.UrlEncode(response.Get<string>("access_token"));
                LongTermToken = response.Get<string>("access_token");

                // TODO : add them to the class
                // string _token_type = response.Value<string>("token_type");
                TokenExpireIn = response.Get<string>("expires_in");
            }
            return LongTermToken;
        }


        public async Task<APIResponse> Post(string Method, string Body)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(this._Accept));
                HttpContent requestContent = new StringContent(Body, System.Text.Encoding.UTF8, _ContentType);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_Authorization, LongTermToken);

                HttpResponseMessage sabreResponse = await client.PostAsync(this.BaseAPIUri + Method, requestContent).ConfigureAwait(false);

                // If client authentication failed then we get a JSON response from Sabre
                if (!sabreResponse.IsSuccessStatusCode)
                {
                    JsonObject error = await sabreResponse.Content.ReadAsAsync<JsonObject>();
                    string errorType = error.Get<string>("error");
                    string errorDescription = error.Get<string>("error_description");
                    string errorMessage = error.Get<string>("message");
                    string responseMessage = string.Join(" ", errorType, errorDescription, errorMessage).Trim();
                    return new APIResponse { StatusCode = sabreResponse.StatusCode, Response = responseMessage };
                }

                var response = await sabreResponse.Content.ReadAsStringAsync();
                return new APIResponse { StatusCode = HttpStatusCode.OK, Response = response };
            }
        }

        public async Task<APIResponse> Get(string Method)
        {
            //const string statusComplete = "Complete";
            //const string statusMessage = "No results were found";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_Accept));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_Authorization, LongTermToken);

                HttpResponseMessage sabreResponse = await client.GetAsync(this.BaseAPIUri + Method).ConfigureAwait(false);


                // If client authentication failed then we get a JSON response from Sabre
                if (!sabreResponse.IsSuccessStatusCode)
                {
                    JsonObject error = await sabreResponse.Content.ReadAsAsync<JsonObject>();
                    string errorType = error.Get<string>("error");
                    string errorDescription = error.Get<string>("error_description");
                    string message = error.Get<string>("message");
                    string status = error.Get<string>("status");
                    string errorMessage = error.Get<string>("message");
                    string responseMessage = string.Join(" ", errorType, errorDescription, errorMessage).Trim();
                    //return new APIResponse { StatusCode = sabreResponse.StatusCode, Response = responseMessage };

                    // RequestUrl and OriginalResponse are added for NLog
                    return new APIResponse { StatusCode = sabreResponse.StatusCode, Response = responseMessage, RequestUrl = this.BaseAPIUri + Method, OriginalResponse = sabreResponse };
                }

                var response = await sabreResponse.Content.ReadAsStringAsync();

                // Sample response format for testing:
                // const string sampleResponse = @"{"DestinationLocation":"JFK","Seasonality":[...]}";
                return new APIResponse { StatusCode = HttpStatusCode.OK, Response = response }; 

                // RequestUrl and OriginalResponse are added for NLog
                //return new APIResponse { StatusCode = sabreResponse.StatusCode, Response = response, RequestUrl = this.BaseAPIUri + Method, OriginalResponse = sabreResponse };
            }
        }

    }

private const string GrantType = "grant_type=client_credentials";
private const string ContentType = "application/x-www-form-urlencoded";
}
