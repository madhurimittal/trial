using ElectronNET.API.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ElectronNET.API.Extensions;
using static System.Collections.Specialized.BitVector32;

namespace ElectronNET.API
{
    public sealed class App
    {
        public event Action WindowAllClosed
        {
            add
            {
                if (_windowAllClosed == null)
                {
                    BridgeConnector.Socket.On("app-window-all-closed" + GetHashCode(), () =>
                    {
                        if (!Electron.WindowManager.IsQuitOnWindowAllClosed || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                        {
                            _windowAllClosed();
                        }
                    });

                    BridgeConnector.Socket.Emit("register-app-window-all-closed-event", GetHashCode());
                }
                _windowAllClosed += value;
            }
            remove
            {
                _windowAllClosed -= value;

                if(_windowAllClosed == null)
                    BridgeConnector.Socket.Off("app-window-all-closed" + GetHashCode());
            }
        }

        private event Action _windowAllClosed;

        public event Func<QuitEventArgs, Task> BeforeQuit
        {
            add
            {
                if (_beforeQuit == null)
                {
                    BridgeConnector.Socket.On("app-before-quit" + GetHashCode(), async () =>
                    {
                        await _beforeQuit(new QuitEventArgs());

                        if (_preventQuit)
                        {
                            _preventQuit = false;
                        }
                        else
                        {
                            if (_willQuit == null && _quitting == null)
                            {
                                Exit();
                            }
                            else if (_willQuit != null)
                            {
                                await _willQuit(new QuitEventArgs());

                                if (_preventQuit)
                                {
                                    _preventQuit = false;
                                }
                                else
                                {
                                    if (_quitting == null)
                                    {
                                        Exit();
                                    }
                                    else
                                    {
                                        await _quitting();
                                        Exit();
                                    }
                                }
                            }
                            else if (_quitting != null)
                            {
                                await _quitting();
                                Exit();
                            }
                        }
                    });

                    BridgeConnector.Socket.Emit("register-app-before-quit-event", GetHashCode());
                }
                _beforeQuit += value;
            }
            remove
            {
                _beforeQuit -= value;

                if (_beforeQuit == null)
                    BridgeConnector.Socket.Off("app-before-quit" + GetHashCode());
            }
        }

        private event Func<QuitEventArgs, Task> _beforeQuit;

        public event Func<QuitEventArgs, Task> WillQuit
        {
            add
            {
                if (_willQuit == null)
                {
                    BridgeConnector.Socket.On("app-will-quit" + GetHashCode(), async () =>
                    {
                        await _willQuit(new QuitEventArgs());

                        if (_preventQuit)
                        {
                            _preventQuit = false;
                        }
                        else
                        {
                            if (_quitting == null)
                            {
                                Exit();
                            }
                            else
                            {
                                await _quitting();
                                Exit();
                            }
                        }
                    });

                    BridgeConnector.Socket.Emit("register-app-will-quit-event", GetHashCode());
                }
                _willQuit += value;
            }
            remove
            {
                _willQuit -= value;

                if (_willQuit == null)
                    BridgeConnector.Socket.Off("app-will-quit" + GetHashCode());
            }
        }

        private event Func<QuitEventArgs, Task> _willQuit;

        public event Func<Task> Quitting
        {
            add
            {
                if (_quitting == null)
                {
                    BridgeConnector.Socket.On("app-will-quit" + GetHashCode() + "quitting", async () =>
                    {
                        if(_willQuit == null)
                        {
                            await _quitting();
                            Exit();
                        }
                    });

                    BridgeConnector.Socket.Emit("register-app-will-quit-event", GetHashCode() + "quitting");
                }
                _quitting += value;
            }
            remove
            {
                _quitting -= value;

                if (_quitting == null)
                    BridgeConnector.Socket.Off("app-will-quit" + GetHashCode() + "quitting");
            }
        }

        private event Func<Task> _quitting;

        public event Action BrowserWindowBlur
        {
            add
            {
                if (_browserWindowBlur == null)
                {
                    BridgeConnector.Socket.On("app-browser-window-blur" + GetHashCode(), () =>
                    {
                        _browserWindowBlur();
                    });

                    BridgeConnector.Socket.Emit("register-app-browser-window-blur-event", GetHashCode());
                }
                _browserWindowBlur += value;
            }
            remove
            {
                _browserWindowBlur -= value;

                if (_browserWindowBlur == null)
                    BridgeConnector.Socket.Off("app-browser-window-blur" + GetHashCode());
            }
        }

        private event Action _browserWindowBlur;

        public event Action BrowserWindowFocus
        {
            add
            {
                if (_browserWindowFocus == null)
                {
                    BridgeConnector.Socket.On("app-browser-window-focus" + GetHashCode(), () =>
                    {
                        _browserWindowFocus();
                    });

                    BridgeConnector.Socket.Emit("register-app-browser-window-focus-event", GetHashCode());
                }
                _browserWindowFocus += value;
            }
            remove
            {
                _browserWindowFocus -= value;

                if (_browserWindowFocus == null)
                    BridgeConnector.Socket.Off("app-browser-window-focus" + GetHashCode());
            }
        }

        private event Action _browserWindowFocus;

        public event Action BrowserWindowCreated
        {
            add
            {
                if (_browserWindowCreated == null)
                {
                    BridgeConnector.Socket.On("app-browser-window-created" + GetHashCode(), () =>
                    {
                        _browserWindowCreated();
                    });

                    BridgeConnector.Socket.Emit("register-app-browser-window-created-event", GetHashCode());
                }
                _browserWindowCreated += value;
            }
            remove
            {
                _browserWindowCreated -= value;

                if (_browserWindowCreated == null)
                    BridgeConnector.Socket.Off("app-browser-window-created" + GetHashCode());
            }
        }

        private event Action _browserWindowCreated;

        public event Action WebContentsCreated
        {
            add
            {
                if (_webContentsCreated == null)
                {
                    BridgeConnector.Socket.On("app-web-contents-created" + GetHashCode(), () =>
                    {
                        _webContentsCreated();
                    });

                    BridgeConnector.Socket.Emit("register-app-web-contents-created-event", GetHashCode());
                }
                _webContentsCreated += value;
            }
            remove
            {
                _webContentsCreated -= value;

                if (_webContentsCreated == null)
                    BridgeConnector.Socket.Off("app-web-contents-created" + GetHashCode());
            }
        }

        private event Action _webContentsCreated;

        public event Action<bool> AccessibilitySupportChanged
        {
            add
            {
                if (_accessibilitySupportChanged == null)
                {
                    BridgeConnector.Socket.On("app-accessibility-support-changed" + GetHashCode(), (state) =>
                    {
                        _accessibilitySupportChanged((bool)state);
                    });

                    BridgeConnector.Socket.Emit("register-app-accessibility-support-changed-event", GetHashCode());
                }
                _accessibilitySupportChanged += value;
            }
            remove
            {
                _accessibilitySupportChanged -= value;

                if (_accessibilitySupportChanged == null)
                    BridgeConnector.Socket.Off("app-accessibility-support-changed" + GetHashCode());
            }
        }

        private event Action<bool> _accessibilitySupportChanged;

        public event Action Ready 
        {
            add
            {
                if(IsReady)
                {
                    value();
                }

                _ready += value;
            }
            remove
            {
                _ready -= value;
            }
        }

        private event Action _ready;

        public bool IsReady 
        { 
            get { return _isReady; }
            internal set
            {
                _isReady = value;

                if(value)
                {
                    _ready?.Invoke();
                }
            }
        }
        private bool _isReady = false;

        public event Action<string> OpenFile
        {
            add
            {
                if (_openFile == null)
                {
                    BridgeConnector.Socket.On("app-open-file" + GetHashCode(), (file) =>
                    {
                        _openFile(file.ToString());
                    });

                    BridgeConnector.Socket.Emit("register-app-open-file-event", GetHashCode());
                }
                _openFile += value;
            }
            remove
            {
                _openFile -= value;

                if (_openFile == null)
                    BridgeConnector.Socket.Off("app-open-file" + GetHashCode());
            }
        }

        private event Action<string> _openFile;


        public event Action<string> OpenUrl
        {
            add
            {
                if (_openUrl == null)
                {
                    BridgeConnector.Socket.On("app-open-url" + GetHashCode(), (url) =>
                    {
                        _openUrl(url.ToString());
                    });

                    BridgeConnector.Socket.Emit("register-app-open-url-event", GetHashCode());
                }
                _openUrl += value;
            }
            remove
            {
                _openUrl -= value;

                if (_openUrl == null)
                    BridgeConnector.Socket.Off("app-open-url" + GetHashCode());
            }
        }

        private event Action<string> _openUrl;

        public string Name
        {
            [Obsolete("Use the asynchronous version NameAsync instead")]
            get
            {
                return NameAsync.Result;
            }
            set
            {
                BridgeConnector.Socket.Emit("appSetName", value);
            }
        }

        public Task<string> NameAsync
        {
            get
            {
                return Task.Run<string>(() =>
                {
                    var taskCompletionSource = new TaskCompletionSource<string>();

                    BridgeConnector.Socket.On("appGetNameCompleted", (result) =>
                    {
                        BridgeConnector.Socket.Off("appGetNameCompleted");
                        taskCompletionSource.SetResult((string)result);
                    });

                    BridgeConnector.Socket.Emit("appGetName");

                    return taskCompletionSource.Task;
                });
            }
        }


        internal App() 
        {
            CommandLine = new CommandLine();
        }

        internal static App Instance
        {
            get
            {
                if (_app == null)
                {
                    lock (_syncRoot)
                    {
                        if(_app == null)
                        {
                            _app = new App();
                        }
                    }
                }

                return _app;
            }
        }

        private static App _app;
        private static object _syncRoot = new object();

        private readonly JsonSerializer _jsonSerializer = new JsonSerializer()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public void Quit()
        {
            BridgeConnector.Socket.Emit("appQuit");
        }

        public void Exit(int exitCode = 0)
        {
            BridgeConnector.Socket.Emit("appExit", exitCode);
        }

        public void Relaunch()
        {
            BridgeConnector.Socket.Emit("appRelaunch");
        }

        public void Relaunch(RelaunchOptions relaunchOptions)
        {
            BridgeConnector.Socket.Emit("appRelaunch", JObject.FromObject(relaunchOptions, _jsonSerializer));
        }

        public void Focus()
        {
            BridgeConnector.Socket.Emit("appFocus");
        }

        public void Focus(FocusOptions focusOptions)
        {
            BridgeConnector.Socket.Emit("appFocus", JObject.FromObject(focusOptions, _jsonSerializer));
        }

        public void Hide()
        {
            BridgeConnector.Socket.Emit("appHide");
        }

        public void Show()
        {
            BridgeConnector.Socket.Emit("appShow");
        }

        public async Task<string> GetAppPathAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<string>();
            using(cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetAppPathCompleted", (path) =>
                {
                    BridgeConnector.Socket.Off("appGetAppPathCompleted");
                    taskCompletionSource.SetResult(path.ToString());
                });

                BridgeConnector.Socket.Emit("appGetAppPath");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }            
        }

        public void SetAppLogsPath(string path)
        {
            BridgeConnector.Socket.Emit("appSetAppLogsPath", path);
        }

        public async Task<string> GetPathAsync(PathName pathName, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<string>();
            using(cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetPathCompleted", (path) =>
                {
                    BridgeConnector.Socket.Off("appGetPathCompleted");

                    taskCompletionSource.SetResult(path.ToString());
                });

                BridgeConnector.Socket.Emit("appGetPath", pathName.GetDescription());

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }  
        }

        public void SetPath(PathName name, string path)
        {
            BridgeConnector.Socket.Emit("appSetPath", name.GetDescription(), path);
        }

        public async Task<string> GetVersionAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<string>();
            using(cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetVersionCompleted", (version) =>
                {
                    BridgeConnector.Socket.Off("appGetVersionCompleted");
                    taskCompletionSource.SetResult(version.ToString());
                });

                BridgeConnector.Socket.Emit("appGetVersion");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<string> GetLocaleAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<string>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetLocaleCompleted", (local) =>
                {
                    BridgeConnector.Socket.Off("appGetLocaleCompleted");
                    taskCompletionSource.SetResult(local.ToString());
                });

                BridgeConnector.Socket.Emit("appGetLocale");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public void AddRecentDocument(string path)
        {
            BridgeConnector.Socket.Emit("appAddRecentDocument", path);
        }

        public void ClearRecentDocuments()
        {
            BridgeConnector.Socket.Emit("appClearRecentDocuments");
        }

        public async Task<bool> SetAsDefaultProtocolClientAsync(string protocol, CancellationToken cancellationToken = default)
        {
            return await SetAsDefaultProtocolClientAsync(protocol, null, null, cancellationToken);
        }

        public async Task<bool> SetAsDefaultProtocolClientAsync(string protocol, string path, CancellationToken cancellationToken = default)
        {
            return await SetAsDefaultProtocolClientAsync(protocol, path, null, cancellationToken);
        }

        public async Task<bool> SetAsDefaultProtocolClientAsync(string protocol, string path, string[] args, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appSetAsDefaultProtocolClientCompleted", (success) =>
                {
                    BridgeConnector.Socket.Off("appSetAsDefaultProtocolClientCompleted");
                    taskCompletionSource.SetResult((bool) success);
                });

                BridgeConnector.Socket.Emit("appSetAsDefaultProtocolClient", protocol, path, args);

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<bool> RemoveAsDefaultProtocolClientAsync(string protocol, CancellationToken cancellationToken = default)
        {
            return await RemoveAsDefaultProtocolClientAsync(protocol, null, null, cancellationToken);
        }

        public async Task<bool> RemoveAsDefaultProtocolClientAsync(string protocol, string path, CancellationToken cancellationToken = default)
        {
            return await RemoveAsDefaultProtocolClientAsync(protocol, path, null, cancellationToken);
        }

        public async Task<bool> RemoveAsDefaultProtocolClientAsync(string protocol, string path, string[] args, CancellationToken cancellationToken = default)
        {           
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appRemoveAsDefaultProtocolClientCompleted", (success) =>
                {
                    BridgeConnector.Socket.Off("appRemoveAsDefaultProtocolClientCompleted");
                    taskCompletionSource.SetResult((bool) success);
                });

                BridgeConnector.Socket.Emit("appRemoveAsDefaultProtocolClient", protocol, path, args);

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<bool> IsDefaultProtocolClientAsync(string protocol, CancellationToken cancellationToken = default)
        {
            return await IsDefaultProtocolClientAsync(protocol, null, null, cancellationToken);
        }

        public async Task<bool> IsDefaultProtocolClientAsync(string protocol, string path, CancellationToken cancellationToken = default)
        {
            return await IsDefaultProtocolClientAsync(protocol, path, null, cancellationToken);
        }

        public async Task<bool> IsDefaultProtocolClientAsync(string protocol, string path, string[] args, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appIsDefaultProtocolClientCompleted", (success) =>
                {
                    BridgeConnector.Socket.Off("appIsDefaultProtocolClientCompleted");
                    taskCompletionSource.SetResult((bool) success);
                });

                BridgeConnector.Socket.Emit("appIsDefaultProtocolClient", protocol, path, args);

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<bool> SetUserTasksAsync(UserTask[] userTasks, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appSetUserTasksCompleted", (success) =>
                {
                    BridgeConnector.Socket.Off("appSetUserTasksCompleted");
                    taskCompletionSource.SetResult((bool) success);
                });

                BridgeConnector.Socket.Emit("appSetUserTasks", JArray.FromObject(userTasks, _jsonSerializer));

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<JumpListSettings> GetJumpListSettingsAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<JumpListSettings>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetJumpListSettingsCompleted", (jumpListSettings) =>
                {
                    BridgeConnector.Socket.Off("appGetJumpListSettingsCompleted");
                    taskCompletionSource.SetResult(JObject.Parse(jumpListSettings.ToString()).ToObject<JumpListSettings>());
                });

                BridgeConnector.Socket.Emit("appGetJumpListSettings");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public void SetJumpList(JumpListCategory[] categories)
        {
            BridgeConnector.Socket.Emit("appSetJumpList", JArray.FromObject(categories, _jsonSerializer));
        }

        public async Task<bool> RequestSingleInstanceLockAsync(Action<string[], string> newInstanceOpened, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appRequestSingleInstanceLockCompleted", (success) =>
                {
                    BridgeConnector.Socket.Off("appRequestSingleInstanceLockCompleted");
                    taskCompletionSource.SetResult((bool)success);
                });

                BridgeConnector.Socket.Off("secondInstance");
                BridgeConnector.Socket.On("secondInstance", (result) =>
                {
                    JArray results = (JArray)result;
                    string[] args = results.First.ToObject<string[]>();
                    string workingDirectory = results.Last.ToObject<string>();

                    newInstanceOpened(args, workingDirectory);
                });

                BridgeConnector.Socket.Emit("appRequestSingleInstanceLock");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public void ReleaseSingleInstanceLock()
        {
            BridgeConnector.Socket.Emit("appReleaseSingleInstanceLock");
        }

        public async Task<bool> HasSingleInstanceLockAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appHasSingleInstanceLockCompleted", (hasLock) =>
                {
                    BridgeConnector.Socket.Off("appHasSingleInstanceLockCompleted");
                    taskCompletionSource.SetResult((bool) hasLock);
                });

                BridgeConnector.Socket.Emit("appHasSingleInstanceLock");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public void SetUserActivity(string type, object userInfo)
        {
            SetUserActivity(type, userInfo, null);
        }

        public void SetUserActivity(string type, object userInfo, string webpageUrl)
        {
            BridgeConnector.Socket.Emit("appSetUserActivity", type, userInfo, webpageUrl);
        }

        public async Task<string> GetCurrentActivityTypeAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<string>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetCurrentActivityTypeCompleted", (activityType) =>
                {
                    BridgeConnector.Socket.Off("appGetCurrentActivityTypeCompleted");
                    taskCompletionSource.SetResult(activityType.ToString());
                });

                BridgeConnector.Socket.Emit("appGetCurrentActivityType");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public void InvalidateCurrentActivity()
        {
            BridgeConnector.Socket.Emit("appInvalidateCurrentActivity");
        }

        public void ResignCurrentActivity()
        {
            BridgeConnector.Socket.Emit("appResignCurrentActivity");
        }

        public void SetAppUserModelId(string id)
        {
            BridgeConnector.Socket.Emit("appSetAppUserModelId", id);
        }

        public async Task<int> ImportCertificateAsync(ImportCertificateOptions options, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<int>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appImportCertificateCompleted", (result) =>
                {
                    BridgeConnector.Socket.Off("appImportCertificateCompleted");
                    taskCompletionSource.SetResult((int) result);
                });

                BridgeConnector.Socket.Emit("appImportCertificate", JObject.FromObject(options, _jsonSerializer));

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<ProcessMetric[]> GetAppMetricsAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<ProcessMetric[]>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetAppMetricsCompleted", (result) =>
                {
                    BridgeConnector.Socket.Off("appGetAppMetricsCompleted");
                    var processMetrics = ((JArray)result).ToObject<ProcessMetric[]>();

                    taskCompletionSource.SetResult(processMetrics);
                });

                BridgeConnector.Socket.Emit("appGetAppMetrics");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<GPUFeatureStatus> GetGpuFeatureStatusAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<GPUFeatureStatus>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetGpuFeatureStatusCompleted", (result) =>
                {
                    BridgeConnector.Socket.Off("appGetGpuFeatureStatusCompleted");
                    var gpuFeatureStatus = ((JObject)result).ToObject<GPUFeatureStatus>();

                    taskCompletionSource.SetResult(gpuFeatureStatus);
                });

                BridgeConnector.Socket.Emit("appGetGpuFeatureStatus");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<bool> SetBadgeCountAsync(int count, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appSetBadgeCountCompleted", (success) =>
                {
                    BridgeConnector.Socket.Off("appSetBadgeCountCompleted");
                    taskCompletionSource.SetResult((bool) success);
                });

                BridgeConnector.Socket.Emit("appSetBadgeCount", count);

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<int> GetBadgeCountAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<int>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetBadgeCountCompleted", (count) =>
                {
                    BridgeConnector.Socket.Off("appGetBadgeCountCompleted");
                    taskCompletionSource.SetResult((int)count);
                });

                BridgeConnector.Socket.Emit("appGetBadgeCount");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public CommandLine CommandLine { get; internal set; }

        public async Task<bool> IsUnityRunningAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appIsUnityRunningCompleted", (isUnityRunning) =>
                {
                    BridgeConnector.Socket.Off("appIsUnityRunningCompleted");
                    taskCompletionSource.SetResult((bool)isUnityRunning);
                });

                BridgeConnector.Socket.Emit("appIsUnityRunning");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public async Task<LoginItemSettings> GetLoginItemSettingsAsync(CancellationToken cancellationToken = default)
        {
            return await GetLoginItemSettingsAsync(null, cancellationToken);
        }

        public async Task<LoginItemSettings> GetLoginItemSettingsAsync(LoginItemSettingsOptions options, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<LoginItemSettings>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appGetLoginItemSettingsCompleted", (loginItemSettings) =>
                {
                    BridgeConnector.Socket.Off("appGetLoginItemSettingsCompleted");

                    var result = ((JObject) loginItemSettings).ToObject<LoginItemSettings>();

                    taskCompletionSource.SetResult(result);
                });

                if (options == null)
                {
                    BridgeConnector.Socket.Emit("appGetLoginItemSettings");
                }
                else
                {
                    BridgeConnector.Socket.Emit("appGetLoginItemSettings", JObject.FromObject(options, _jsonSerializer));
                }

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public void SetLoginItemSettings(LoginSettings loginSettings)
        {
            BridgeConnector.Socket.Emit("appSetLoginItemSettings", JObject.FromObject(loginSettings, _jsonSerializer));
        }

        public async Task<bool> IsAccessibilitySupportEnabledAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => taskCompletionSource.TrySetCanceled()))
            {
                BridgeConnector.Socket.On("appIsAccessibilitySupportEnabledCompleted", (isAccessibilitySupportEnabled) =>
                {
                    BridgeConnector.Socket.Off("appIsAccessibilitySupportEnabledCompleted");
                    taskCompletionSource.SetResult((bool)isAccessibilitySupportEnabled);
                });

                BridgeConnector.Socket.Emit("appIsAccessibilitySupportEnabled");

                return await taskCompletionSource.Task
                    .ConfigureAwait(false);
            }
        }

        public void SetAccessibilitySupportEnabled(bool enabled)
        {
            BridgeConnector.Socket.Emit("appSetAboutPanelOptions", enabled);
        }

        public void ShowAboutPanel()
        {
            BridgeConnector.Socket.Emit("appShowAboutPanel");
        }

        public void SetAboutPanelOptions(AboutPanelOptions options)
        {
            BridgeConnector.Socket.Emit("appSetAboutPanelOptions", JObject.FromObject(options, _jsonSerializer));
        }

        public string UserAgentFallback
        {
            [Obsolete("Use the asynchronous version UserAgentFallbackAsync instead")]
            get
            {
                return UserAgentFallbackAsync.Result;
            }
            set
            {
                BridgeConnector.Socket.Emit("appSetUserAgentFallback", value);
            }
        }

        public Task<string> UserAgentFallbackAsync
        {
            get
            {
                return Task.Run<string>(() =>
                {
                    var taskCompletionSource = new TaskCompletionSource<string>();

                    BridgeConnector.Socket.On("appGetUserAgentFallbackCompleted", (result) =>
                    {
                        BridgeConnector.Socket.Off("appGetUserAgentFallbackCompleted");
                        taskCompletionSource.SetResult((string)result);
                    });

                    BridgeConnector.Socket.Emit("appGetUserAgentFallback");

                    return taskCompletionSource.Task;
                });
            }
        }

        internal void PreventQuit()
        {
            _preventQuit = true;
        }

        private bool _preventQuit = false;

        private const string ModuleName = "app";
        public void On(string eventName, Action action)
            => Events.Instance.On(ModuleName, eventName, action);
        public async Task On(string eventName, Action<object> action)
            => await Events.Instance.On(ModuleName, eventName, action);
        public void Once(string eventName, Action action)
            => Events.Instance.Once(ModuleName, eventName, action);
        public async Task Once(string eventName, Action<object> action)
            => await Events.Instance.Once(ModuleName, eventName, action);
    }
}