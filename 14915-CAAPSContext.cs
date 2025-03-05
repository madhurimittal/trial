using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CaapsWebServer.DataLayer.DataModel
{
    public partial class CAAPSContext : DbContext
    {
        // public CAAPSContext()
        // {
        // }

        public CAAPSContext(DbContextOptions<CAAPSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountCaEventNotificationConfig> AccountCaEventNotificationConfigs { get; set; }
        public virtual DbSet<AccountCaEventNotificationConfigAudit> AccountCaEventNotificationConfigAudits { get; set; }
        public virtual DbSet<AccountInformation> AccountInformations { get; set; }
        public virtual DbSet<AccountInformationsAudit> AccountInformationsAudits { get; set; }
        public virtual DbSet<AccountMst> AccountMsts { get; set; }
        public virtual DbSet<AccountMstAudit> AccountMstAudits { get; set; }
        public virtual DbSet<AccountOwner> AccountOwners { get; set; }
        public virtual DbSet<AccountOwnersAudit> AccountOwnersAudits { get; set; }
        public virtual DbSet<AccountsAudit> AccountsAudits { get; set; }
        public virtual DbSet<AckData> AckDatas { get; set; }
        public virtual DbSet<AckDatasAudit> AckDatasAudits { get; set; }
        public virtual DbSet<AdditionalInformation> AdditionalInformations { get; set; }
        public virtual DbSet<AdditionalInformationsAudit> AdditionalInformationsAudits { get; set; }
        public virtual DbSet<AMHAcknowledgement> AMHAcknowledgements { get; set; }
        public virtual DbSet<AMHAcknowledgementAudit> AMHAcknowledgementAudits { get; set; }
        public virtual DbSet<ApplicationMst> ApplicationMsts { get; set; }
        public virtual DbSet<ApplicationMstAudit> ApplicationMstAudits { get; set; }
        public virtual DbSet<AssetClassMst> AssetClassMsts { get; set; }
        public virtual DbSet<AssetClassMstAudit> AssetClassMstAudits { get; set; }
        public virtual DbSet<AuditTrailDetail> AuditTrailDetails { get; set; }
        public virtual DbSet<AuditTrailOperationalDetail> AuditTrailOperationalDetails { get; set; }
        public virtual DbSet<CaEventArchiveConfig> CaEventArchiveConfigs { get; set; }
        public virtual DbSet<CaEventArchiveConfigAudit> CaEventArchiveConfigAudits { get; set; }
        public virtual DbSet<CaEventConfig> CaEventConfigs { get; set; }
        public virtual DbSet<CaEventConfigAudit> CaEventConfigAudits { get; set; }
        public virtual DbSet<CaOptionTypeConfig> CaOptionTypeConfigs { get; set; }
        public virtual DbSet<CaEventConflict> CaEventConflicts { get; set; }
        public virtual DbSet<CaEventConflictsAudit> CaEventConflictsAudits { get; set; }
        public virtual DbSet<CaEventElection> CaEventElections { get; set; }
        public virtual DbSet<CaEventElectionAudit> CaEventElectionAudits { get; set; }
        public virtual DbSet<CaEventElectionInstructionsMapping> CaEventElectionInstructionsMappings { get; set; }
        public virtual DbSet<CaEventElectionInstructionsMappingAudit> CaEventElectionInstructionsMappingAudits { get; set; }
        public virtual DbSet<CaEventElectionMapping> CaEventElectionMappings { get; set; }
        public virtual DbSet<CaEventElectionMappingAudit> CaEventElectionMappingAudits { get; set; }
        public virtual DbSet<CaEventElectionOptionNewSecurityDetail> CaEventElectionOptionNewSecurityDetails { get; set; }
        public virtual DbSet<CaEventElectionOptionNewSecurityDetailsAudit> CaEventElectionOptionNewSecurityDetailsAudits { get; set; }
        public virtual DbSet<CaEventElectionOptionsDtl> CaEventElectionOptionsDtls { get; set; }
        public virtual DbSet<CaEventElectionOptionsDtlAudit> CaEventElectionOptionsDtlAudits { get; set; }
        public virtual DbSet<CaEventElectionPosition> CaEventElectionPositions { get; set; }
        public virtual DbSet<CaEventElectionPositionAudit> CaEventElectionPositionAudits { get; set; }
        public virtual DbSet<CaEventEventTypeMapping> CaEventEventTypeMappings { get; set; }
        public virtual DbSet<CaEventEventTypeMappingAudit> CaEventEventTypeMappingAudits { get; set; }
        public virtual DbSet<CaEventGpdConfig> CaEventGpdConfigs { get; set; }
        public virtual DbSet<CaEventGpdConfigAudit> CaEventGpdConfigAudits { get; set; }
        public virtual DbSet<CaEventInstruction> CaEventInstructions { get; set; }
        public virtual DbSet<CaEventInstructionStatu> CaEventInstructionStatus { get; set; }
        public virtual DbSet<CaEventInstructionStatusAudit> CaEventInstructionStatusAudits { get; set; }
        public virtual DbSet<CaEventInstructionsAudit> CaEventInstructionsAudits { get; set; }
        public virtual DbSet<CaEventMst> CaEventMsts { get; set; }
        public virtual DbSet<CaEventMstAudit> CaEventMstAudits { get; set; }
        public virtual DbSet<CaEventNotificationClientConfig> CaEventNotificationClientConfigs { get; set; }
        public virtual DbSet<CaEventNotificationClientConfigAudit> CaEventNotificationClientConfigAudits { get; set; }
        public virtual DbSet<CaEventNotificationSystemConfig> CaEventNotificationSystemConfigs { get; set; }
        public virtual DbSet<CaEventNotificationSystemConfigAudit> CaEventNotificationSystemConfigAudits { get; set; }
        public virtual DbSet<CaEventPaymentStatus> CaEventPaymentStatus { get; set; }
        public virtual DbSet<CaEventPaymentStatusAudit> CaEventPaymentStatusAudits { get; set; }
        public virtual DbSet<CaEventPaymnetNotificationMapping> CaEventPaymnetNotificationMappings { get; set; }
        public virtual DbSet<CaEventPaymnetNotificationMappingAudit> CaEventPaymnetNotificationMappingAudits { get; set; }
        public virtual DbSet<CaEventRiskProfileMst> CaEventRiskProfileMsts { get; set; }
        public virtual DbSet<CaEventRiskProfileMstAudit> CaEventRiskProfileMstAudits { get; set; }
        public virtual DbSet<CaEventRiskType> CaEventRiskTypes { get; set; }
        public virtual DbSet<CaEventRiskTypesAudit> CaEventRiskTypesAudits { get; set; }
        public virtual DbSet<CaEventStatusNotificationClientConfig> CaEventStatusNotificationClientConfigs { get; set; }
        public virtual DbSet<CaEventStatusNotificationClientConfigAudit> CaEventStatusNotificationClientConfigAudits { get; set; }
        public virtual DbSet<CaEventTypeMst> CaEventTypeMsts { get; set; }
        public virtual DbSet<CaEventTypeMstAudit> CaEventTypeMstAudits { get; set; }
        public virtual DbSet<CaOptionException> CaOptionExceptions { get; set; }
        public virtual DbSet<CaOptionExceptionAudit> CaOptionExceptionAudits { get; set; }
        public virtual DbSet<CaOptionLink> CaOptionLinks { get; set; }
        public virtual DbSet<CaOptionLinkAudit> CaOptionLinkAudits { get; set; }
        public virtual DbSet<CaUnsupportedEventProcess> CaUnsupportedEventProcesses { get; set; }
        public virtual DbSet<CaUnsupportedEventProcessAudit> CaUnsupportedEventProcessAudits { get; set; }
        public virtual DbSet<CashMovement> CashMovements { get; set; }
        public virtual DbSet<CashMovementsAudit> CashMovementsAudits { get; set; }
        public virtual DbSet<ClientPositionArchiveDtl> ClientPositionArchiveDtls { get; set; }
        public virtual DbSet<ClientPositionArchiveDtlAudit> ClientPositionArchiveDtlAudits { get; set; }
        public virtual DbSet<ClientPositionDtl> ClientPositionDtls { get; set; }
        public virtual DbSet<ClientPositionDtlAudit> ClientPositionDtlAudits { get; set; }
        public virtual DbSet<ClientSecurityContractInfo> ClientSecurityContractInfoes { get; set; }
        public virtual DbSet<ClientSecurityContractInfoAudit> ClientSecurityContractInfoAudits { get; set; }
        public virtual DbSet<ClientSecurityCreditRating> ClientSecurityCreditRatings { get; set; }
        public virtual DbSet<ClientSecurityCreditRatingAudit> ClientSecurityCreditRatingAudits { get; set; }
        public virtual DbSet<ClientSecurityCrossReference> ClientSecurityCrossReferences { get; set; }
        public virtual DbSet<ClientSecurityCrossReferenceAudit> ClientSecurityCrossReferenceAudits { get; set; }
        public virtual DbSet<ClientSecurityEquityDtl> ClientSecurityEquityDtls { get; set; }
        public virtual DbSet<ClientSecurityEquityDtlAudit> ClientSecurityEquityDtlAudits { get; set; }
        public virtual DbSet<ClientSecurityFixedIncomeDtl> ClientSecurityFixedIncomeDtls { get; set; }
        public virtual DbSet<ClientSecurityFixedIncomeDtlAudit> ClientSecurityFixedIncomeDtlAudits { get; set; }
        public virtual DbSet<ClientSecurityIndustryMapping> ClientSecurityIndustryMappings { get; set; }
        public virtual DbSet<ClientSecurityIndustryMappingAudit> ClientSecurityIndustryMappingAudits { get; set; }
        public virtual DbSet<ClientSecurityIndustryMst> ClientSecurityIndustryMsts { get; set; }
        public virtual DbSet<ClientSecurityIndustryMstAudit> ClientSecurityIndustryMstAudits { get; set; }
        public virtual DbSet<ClientSecurityMst> ClientSecurityMsts { get; set; }
        public virtual DbSet<ClientSecurityMstAudit> ClientSecurityMstAudits { get; set; }
        public virtual DbSet<ClientSecurityUnderlyer> ClientSecurityUnderlyers { get; set; }
        public virtual DbSet<ClientSecurityUnderlyerAudit> ClientSecurityUnderlyerAudits { get; set; }
        public virtual DbSet<CorporateActionDetail> CorporateActionDetails { get; set; }
        public virtual DbSet<CorporateActionDetailsAudit> CorporateActionDetailsAudits { get; set; }
        public virtual DbSet<CorporateActionOption> CorporateActionOptions { get; set; }
        public virtual DbSet<CorporateActionOptionsAudit> CorporateActionOptionsAudits { get; set; }
        public virtual DbSet<CountryMst> CountryMsts { get; set; }
        public virtual DbSet<CountryMstAudit> CountryMstAudits { get; set; }
        public virtual DbSet<CurrencyMst> CurrencyMsts { get; set; }
        public virtual DbSet<CurrencyMstAudit> CurrencyMstAudits { get; set; }
        public virtual DbSet<DbCache> DbCaches { get; set; }
        public virtual DbSet<EmailTemplateMst> EmailTemplateMsts { get; set; }
        public virtual DbSet<EmailTemplateMstAudit> EmailTemplateMstAudits { get; set; }
        public virtual DbSet<ErrorMst> ErrorMsts { get; set; }
        public virtual DbSet<ErrorMstAudit> ErrorMstAudits { get; set; }
        public virtual DbSet<FileImportConfiguration> FileImportConfigurations { get; set; }
        public virtual DbSet<FileImportConfigurationAudit> FileImportConfigurationAudits { get; set; }
        public virtual DbSet<FileImportMst> FileImportMsts { get; set; }
        public virtual DbSet<FileImportMstAudit> FileImportMstAudits { get; set; }
        public virtual DbSet<FinancialInstrument> FinancialInstruments { get; set; }
        public virtual DbSet<FinancialInstrumentAttribute> FinancialInstrumentAttributes { get; set; }
        public virtual DbSet<FinancialInstrumentAttributesAudit> FinancialInstrumentAttributesAudits { get; set; }
        public virtual DbSet<FinancialInstrumentsAudit> FinancialInstrumentsAudits { get; set; }
        public virtual DbSet<FunctionOfMessage> FunctionOfMessages { get; set; }
        public virtual DbSet<FunctionOfMessagesAudit> FunctionOfMessagesAudits { get; set; }
        public virtual DbSet<GeneralInformation> GeneralInformations { get; set; }
        public virtual DbSet<GeneralInformationsAudit> GeneralInformationsAudits { get; set; }
        public virtual DbSet<GlodenRecordSourceMapping> GlodenRecordSourceMappings { get; set; }
        public virtual DbSet<GlodenRecordSourceMappingAudit> GlodenRecordSourceMappingAudits { get; set; }
        public virtual DbSet<GoldenRecordInternalChatDetail> GoldenRecordInternalChatDetails { get; set; }
        public virtual DbSet<GoldenRecordInternalChatDetailsAudit> GoldenRecordInternalChatDetailsAudits { get; set; }
        public virtual DbSet<GoldenRecordMst> GoldenRecordMsts { get; set; }
        public virtual DbSet<GoldenRecordMstAudit> GoldenRecordMstAudits { get; set; }
        public virtual DbSet<GoldenRecordResponseDeadlineDatesDtl> GoldenRecordResponseDeadlineDatesDtls { get; set; }
        public virtual DbSet<GoldenRecordResponseDeadlineDatesDtlAudit> GoldenRecordResponseDeadlineDatesDtlAudits { get; set; }
        public virtual DbSet<GoldenRecordSourceEventMapping> GoldenRecordSourceEventMappings { get; set; }
        public virtual DbSet<GoldenRecordSourceEventMappingAudit> GoldenRecordSourceEventMappingAudits { get; set; }
        public virtual DbSet<GoldenRecordSourceEventMt568Mapping> GoldenRecordSourceEventMt568Mapping { get; set; }
        public virtual DbSet<GoldenRecordSourceEventMt568MappingAudit> GoldenRecordSourceEventMt568MappingAudit { get; set; }
        public virtual DbSet<HolidayMst> HolidayMsts { get; set; }
        public virtual DbSet<HolidayMstAudit> HolidayMstAudits { get; set; }
        public virtual DbSet<IntermediateSecuritiesAudit> IntermediateSecuritiesAudits { get; set; }
        public virtual DbSet<IntermediateSecurity> IntermediateSecurities { get; set; }
        public virtual DbSet<LinkedMessage> LinkedMessages { get; set; }
        public virtual DbSet<LinkedMessagesAudit> LinkedMessagesAudits { get; set; }
        public virtual DbSet<LinkedReference> LinkedReferences { get; set; }
        public virtual DbSet<LinkedReferencesAudit> LinkedReferencesAudits { get; set; }
        public virtual DbSet<Mamount> Mamounts { get; set; }
        public virtual DbSet<MamountsAudit> MamountsAudits { get; set; }
        public virtual DbSet<Mbalance> Mbalances { get; set; }
        public virtual DbSet<MbalancesAudit> MbalancesAudits { get; set; }
        public virtual DbSet<McaoptionNumber> McaoptionNumbers { get; set; }
        public virtual DbSet<McaoptionNumberAudit> McaoptionNumberAudits { get; set; }
        public virtual DbSet<McouponNumber> McouponNumbers { get; set; }
        public virtual DbSet<McouponNumbersAudit> McouponNumbersAudits { get; set; }
        public virtual DbSet<Mcurrency> Mcurrencies { get; set; }
        public virtual DbSet<McurrencyAudit> McurrencyAudits { get; set; }
        public virtual DbSet<Mdate> Mdates { get; set; }
        public virtual DbSet<MdateAudit> MdateAudits { get; set; }
        public virtual DbSet<MdateTime> MdateTimes { get; set; }
        public virtual DbSet<MdateTimeAudit> MdateTimeAudits { get; set; }
        public virtual DbSet<MessageData> MessageDatas { get; set; }
        public virtual DbSet<MessageDatasAudit> MessageDatasAudits { get; set; }
        public virtual DbSet<Mflag> Mflags { get; set; }
        public virtual DbSet<MflagAudit> MflagAudits { get; set; }
        public virtual DbSet<Mindicator> Mindicators { get; set; }
        public virtual DbSet<MindicatorsAudit> MindicatorsAudits { get; set; }
        public virtual DbSet<Mnarrative> Mnarratives { get; set; }
        public virtual DbSet<MnarrativesAudit> MnarrativesAudits { get; set; }
        public virtual DbSet<Mplace> Mplaces { get; set; }
        public virtual DbSet<MplacesAudit> MplacesAudits { get; set; }
        public virtual DbSet<Mprice> Mprices { get; set; }
        public virtual DbSet<MpricesAudit> MpricesAudits { get; set; }
        public virtual DbSet<Mrate> Mrates { get; set; }
        public virtual DbSet<MratesAudit> MratesAudits { get; set; }
        public virtual DbSet<Mreference> Mreferences { get; set; }
        public virtual DbSet<MreferencesAudit> MreferencesAudits { get; set; }
        public virtual DbSet<Msecurity> Msecurities { get; set; }
        public virtual DbSet<MsecurityAudit> MsecurityAudits { get; set; }
        public virtual DbSet<Mt564messages> Mt564messages { get; set; }
        public virtual DbSet<Mt564messagesAudit> Mt564messagesAudit { get; set; }
        public virtual DbSet<Mt565AccountInformations> Mt565AccountInformations { get; set; }
        public virtual DbSet<Mt565AccountInformationsAudit> Mt565AccountInformationsAudit { get; set; }
        public virtual DbSet<Mt565AccountOwners> Mt565AccountOwners { get; set; }
        public virtual DbSet<Mt565AccountOwnersAudit> Mt565AccountOwnersAudit { get; set; }
        public virtual DbSet<Mt565AdditionalInformations> Mt565AdditionalInformations { get; set; }
        public virtual DbSet<Mt565AdditionalInformationsAudit> Mt565AdditionalInformationsAudit { get; set; }
        public virtual DbSet<Mt565Mamount> Mt565Mamount { get; set; }
        public virtual DbSet<Mt565MamountAudit> Mt565MamountAudit { get; set; }
        public virtual DbSet<Mt565Mbalance> Mt565Mbalance { get; set; }
        public virtual DbSet<Mt565MbalanceAudit> Mt565MbalanceAudit { get; set; }
        public virtual DbSet<Mt565MbeneficialOwnerDetails> Mt565MbeneficialOwnerDetails { get; set; }
        public virtual DbSet<Mt565MbeneficialOwnerDetailsAudit> Mt565MbeneficialOwnerDetailsAudit { get; set; }
        public virtual DbSet<Mt565McorporateActionInstruction> Mt565McorporateActionInstruction { get; set; }
        public virtual DbSet<Mt565McorporateActionInstructionAudit> Mt565McorporateActionInstructionAudit { get; set; }
        public virtual DbSet<Mt565Mcurrency> Mt565Mcurrency { get; set; }
        public virtual DbSet<Mt565McurrencyAudit> Mt565McurrencyAudit { get; set; }
        public virtual DbSet<Mt565Mdate> Mt565Mdate { get; set; }
        public virtual DbSet<Mt565MdateAudit> Mt565MdateAudit { get; set; }
        public virtual DbSet<Mt565MessageData> Mt565MessageData { get; set; }
        public virtual DbSet<Mt565MessageDataAudit> Mt565MessageDataAudit { get; set; }
        public virtual DbSet<Mt565MfinancialInstrumentAttribute> Mt565MfinancialInstrumentAttribute { get; set; }
        public virtual DbSet<Mt565MfinancialInstrumentAttributeAudit> Mt565MfinancialInstrumentAttributeAudit { get; set; }
        public virtual DbSet<Mt565MfunctionOfMessage> Mt565MfunctionOfMessage { get; set; }
        public virtual DbSet<Mt565MfunctionOfMessageAudit> Mt565MfunctionOfMessageAudit { get; set; }
        public virtual DbSet<Mt565MgeneralInformation> Mt565MgeneralInformation { get; set; }
        public virtual DbSet<Mt565MgeneralInformationAudit> Mt565MgeneralInformationAudit { get; set; }
        public virtual DbSet<Mt565Mindicator> Mt565Mindicator { get; set; }
        public virtual DbSet<Mt565MindicatorAudit> Mt565MindicatorAudit { get; set; }
        public virtual DbSet<Mt565MlinkedMessage> Mt565MlinkedMessage { get; set; }
        public virtual DbSet<Mt565MlinkedMessageAudit> Mt565MlinkedMessageAudit { get; set; }
        public virtual DbSet<Mt565Mnarrative> Mt565Mnarrative { get; set; }
        public virtual DbSet<Mt565MnarrativeAudit> Mt565MnarrativeAudit { get; set; }
        public virtual DbSet<Mt565Mparty> Mt565Mparty { get; set; }
        public virtual DbSet<Mt565MpartyAudit> Mt565MpartyAudit { get; set; }
        public virtual DbSet<Mt565Mplace> Mt565Mplace { get; set; }
        public virtual DbSet<Mt565MplaceAudit> Mt565MplaceAudit { get; set; }
        public virtual DbSet<Mt565MplaceOfListning> Mt565MplaceOfListning { get; set; }
        public virtual DbSet<Mt565MplaceOfListningAudit> Mt565MplaceOfListningAudit { get; set; }
        public virtual DbSet<Mt565MplaceOfSafekeeping> Mt565MplaceOfSafekeeping { get; set; }
        public virtual DbSet<Mt565MplaceOfSafekeepingAudit> Mt565MplaceOfSafekeepingAudit { get; set; }
        public virtual DbSet<Mt565MpreparationDateTime> Mt565MpreparationDateTime { get; set; }
        public virtual DbSet<Mt565MpreparationDateTimeAudit> Mt565MpreparationDateTimeAudit { get; set; }
        public virtual DbSet<Mt565Mprice> Mt565Mprice { get; set; }
        public virtual DbSet<Mt565MpriceAudit> Mt565MpriceAudit { get; set; }
        public virtual DbSet<Mt565Mqualifier> Mt565Mqualifier { get; set; }
        public virtual DbSet<Mt565MqualifierAudit> Mt565MqualifierAudit { get; set; }
        public virtual DbSet<Mt565MquantityOfInstrument> Mt565MquantityOfInstrument { get; set; }
        public virtual DbSet<Mt565MquantityOfInstrumentAudit> Mt565MquantityOfInstrumentAudit { get; set; }
        public virtual DbSet<Mt565Mrate> Mt565Mrate { get; set; }
        public virtual DbSet<Mt565MrateAudit> Mt565MrateAudit { get; set; }
        public virtual DbSet<Mt565Mreference> Mt565Mreference { get; set; }
        public virtual DbSet<Mt565MreferenceAudit> Mt565MreferenceAudit { get; set; }
        public virtual DbSet<Mt565MsafekeepingAccount> Mt565MsafekeepingAccount { get; set; }
        public virtual DbSet<Mt565MsafekeepingAccountAudit> Mt565MsafekeepingAccountAudit { get; set; }
        public virtual DbSet<Mt565Msecurity> Mt565Msecurity { get; set; }
        public virtual DbSet<Mt565MsecurityAudit> Mt565MsecurityAudit { get; set; }
        public virtual DbSet<Mt565Mt565message> Mt565Mt565message { get; set; }
        public virtual DbSet<Mt565Mt565messageAudit> Mt565Mt565messageAudit { get; set; }
        public virtual DbSet<Mt565MtypeOfInstrument> Mt565MtypeOfInstrument { get; set; }
        public virtual DbSet<Mt565MtypeOfInstrumentAudit> Mt565MtypeOfInstrumentAudit { get; set; }
        public virtual DbSet<Mt565MunderlyingSecurities> Mt565MunderlyingSecurities { get; set; }
        public virtual DbSet<Mt565MunderlyingSecuritiesAudit> Mt565MunderlyingSecuritiesAudit { get; set; }
        public virtual DbSet<NotificationMessage> NotificationMessages { get; set; }
        public virtual DbSet<NotificationMessagesAudit> NotificationMessagesAudits { get; set; }
        public virtual DbSet<NotusedTt> NotusedTts { get; set; }
        public virtual DbSet<NotusedUserPermissionMapping> NotusedUserPermissionMappings { get; set; }
        public virtual DbSet<NotusedUserPermissionMappingAudit> NotusedUserPermissionMappingAudits { get; set; }
        public virtual DbSet<NumberCount> NumberCounts { get; set; }
        public virtual DbSet<NumberCountsAudit> NumberCountsAudits { get; set; }
        public virtual DbSet<OutBoundAccountMapping> OutBoundAccountMappings { get; set; }
        public virtual DbSet<OutBoundAccountMappingAudit> OutBoundAccountMappingAudits { get; set; }
        public virtual DbSet<OutboundEmailRefMst> OutboundEmailRefMsts { get; set; }
        public virtual DbSet<OutboundEmailRefMstAudit> OutboundEmailRefMstAudits { get; set; }
        public virtual DbSet<OutboundMst> OutboundMsts { get; set; }
        public virtual DbSet<OutboundMstAudit> OutboundMstAudits { get; set; }
        public virtual DbSet<OutboundReminderMapping> OutboundReminderMappings { get; set; }
        public virtual DbSet<OutboundReminderMappingAudit> OutboundReminderMappingAudits { get; set; }
        public virtual DbSet<OutboundSwiftRefMst> OutboundSwiftRefMsts { get; set; }
        public virtual DbSet<OutboundSwiftRefMstAudit> OutboundSwiftRefMstAudits { get; set; }
        public virtual DbSet<PageNumber> PageNumbers { get; set; }
        public virtual DbSet<PageNumbersAudit> PageNumbersAudits { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<PartyAudit> PartyAudits { get; set; }
        public virtual DbSet<PaymentCurrencyMapping> PaymentCurrencyMappings { get; set; }
        public virtual DbSet<PaymentCurrencyMappingAudit> PaymentCurrencyMappingAudits { get; set; }
        public virtual DbSet<PaymentEventTypeMapping> PaymentEventTypeMappings { get; set; }
        public virtual DbSet<PaymentEventTypeMappingAudit> PaymentEventTypeMappingAudits { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<PeriodAudit> PeriodAudits { get; set; }
        public virtual DbSet<PermissionMst> PermissionMsts { get; set; }
        public virtual DbSet<PermissionMstAudit> PermissionMstAudits { get; set; }
        public virtual DbSet<PlaceOfListning> PlaceOfListnings { get; set; }
        public virtual DbSet<PlaceOfListningAudit> PlaceOfListningAudits { get; set; }
        public virtual DbSet<PlaceOfSafekeeping> PlaceOfSafekeepings { get; set; }
        public virtual DbSet<PlaceOfSafekeepingAudit> PlaceOfSafekeepingAudits { get; set; }
        public virtual DbSet<PreparationDateTime> PreparationDateTimes { get; set; }
        public virtual DbSet<PreparationDateTimeAudit> PreparationDateTimeAudits { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsAudit> ProductsAudits { get; set; }
        public virtual DbSet<QuantityOfInstrument> QuantityOfInstruments { get; set; }
        public virtual DbSet<QuantityOfInstrumentAudit> QuantityOfInstrumentAudits { get; set; }
        public virtual DbSet<ReceivedCaEventDtl> ReceivedCaEventDtls { get; set; }
        public virtual DbSet<ReceivedCaEventDtlAudit> ReceivedCaEventDtlAudits { get; set; }
        public virtual DbSet<ReceivedMasterFileProcessingDtl> ReceivedMasterFileProcessingDtls { get; set; }
        public virtual DbSet<ReceivedMasterFileProcessingDtlAudit> ReceivedMasterFileProcessingDtlAudits { get; set; }
        public virtual DbSet<ReceivedPaymentAccountHistory> ReceivedPaymentAccountHistories { get; set; }
        public virtual DbSet<ReceivedPaymentAccountHistoryAudit> ReceivedPaymentAccountHistoryAudits { get; set; }
        public virtual DbSet<ReceivedPaymentFeedDtl> ReceivedPaymentFeedDtls { get; set; }
        public virtual DbSet<ReceivedPaymentFeedDtlAudit> ReceivedPaymentFeedDtlAudits { get; set; }
        public virtual DbSet<ReceivedPaymentFeedDtlExctractedMsg> ReceivedPaymentFeedDtlExctractedMsgs { get; set; }
        public virtual DbSet<ReceivedPaymentFeedDtlExctractedMsgAudit> ReceivedPaymentFeedDtlExctractedMsgAudits { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmt> ReceivedPaymentFeedReOrgAnnsmts { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmtAudit> ReceivedPaymentFeedReOrgAnnsmtAudits { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmtRate> ReceivedPaymentFeedReOrgAnnsmtRates { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmtRateAudit> ReceivedPaymentFeedReOrgAnnsmtRateAudits { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmtText> ReceivedPaymentFeedReOrgAnnsmtTexts { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmtTextAudit> ReceivedPaymentFeedReOrgAnnsmtTextAudits { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmtUser> ReceivedPaymentFeedReOrgAnnsmtUsers { get; set; }
        public virtual DbSet<ReceivedPaymentFeedReOrgAnnsmtUserAudit> ReceivedPaymentFeedReOrgAnnsmtUserAudits { get; set; }
        public virtual DbSet<ReceivedPaymentVendorAncmt> ReceivedPaymentVendorAncmts { get; set; }
        public virtual DbSet<ReceivedPaymentVendorAncmtAudit> ReceivedPaymentVendorAncmtAudits { get; set; }
        public virtual DbSet<ReceivedPaymentVendorCashDiv> ReceivedPaymentVendorCashDivs { get; set; }
        public virtual DbSet<ReceivedPaymentVendorCashDivAudit> ReceivedPaymentVendorCashDivAudits { get; set; }
        public virtual DbSet<ReceivedPaymentVendorIntPymnt> ReceivedPaymentVendorIntPymnts { get; set; }
        public virtual DbSet<ReceivedPaymentVendorIntPymntAudit> ReceivedPaymentVendorIntPymntAudits { get; set; }
        public virtual DbSet<ReceivedPaymentVendorPrncpPydn> ReceivedPaymentVendorPrncpPydns { get; set; }
        public virtual DbSet<ReceivedPaymentVendorPrncpPydnAudit> ReceivedPaymentVendorPrncpPydnAudits { get; set; }
        public virtual DbSet<ReceivedPaymentVendorStkDiv> ReceivedPaymentVendorStkDivs { get; set; }
        public virtual DbSet<ReceivedPaymentVendorStkDivAudit> ReceivedPaymentVendorStkDivAudits { get; set; }
        public virtual DbSet<RoleApplicationPermissionMapping> RoleApplicationPermissionMappings { get; set; }
        public virtual DbSet<RoleApplicationPermissionMappingAudit> RoleApplicationPermissionMappingAudits { get; set; }
        public virtual DbSet<RoleMst> RoleMsts { get; set; }
        public virtual DbSet<RoleMstAudit> RoleMstAudits { get; set; }
        public virtual DbSet<SafekeepingAccount> SafekeepingAccounts { get; set; }
        public virtual DbSet<SafekeepingAccountAudit> SafekeepingAccountAudits { get; set; }
        public virtual DbSet<SecurityMovement> SecurityMovements { get; set; }
        public virtual DbSet<SecurityMovementAudit> SecurityMovementAudits { get; set; }
        public virtual DbSet<SenderEntityBicDtl> SenderEntityBicDtls { get; set; }
        public virtual DbSet<SenderEntityBicDtlAudit> SenderEntityBicDtlAudits { get; set; }
        public virtual DbSet<SourceConfig> SourceConfigs { get; set; }
        public virtual DbSet<SourceConfigAudit> SourceConfigAudits { get; set; }
        public virtual DbSet<SystemConfigSearchParameter> SystemConfigSearchParameters { get; set; }
        public virtual DbSet<SystemConfigSearchParametersAudit> SystemConfigSearchParametersAudits { get; set; }
        public virtual DbSet<TypeOfInstrument> TypeOfInstruments { get; set; }
        public virtual DbSet<TypeOfInstrumentAudit> TypeOfInstrumentAudits { get; set; }
        public virtual DbSet<UnderlyingSecuritiesAudit> UnderlyingSecuritiesAudits { get; set; }
        public virtual DbSet<UnderlyingSecurity> UnderlyingSecurities { get; set; }
        public virtual DbSet<UserLoginSourceMst> UserLoginSourceMsts { get; set; }
        public virtual DbSet<UserLoginSourceMstAudit> UserLoginSourceMstAudits { get; set; }
        public virtual DbSet<UserMst> UserMsts { get; set; }
        public virtual DbSet<UserMstAudit> UserMstAudits { get; set; }
        public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }
        public virtual DbSet<UserRoleMappingAudit> UserRoleMappingAudits { get; set; }
        public virtual DbSet<UserSourceMapping> UserSourceMappings { get; set; }
        public virtual DbSet<UserSourceMappingAudit> UserSourceMappingAudits { get; set; }
        public virtual DbSet<VwGoldenRecordFilteredData> VwGoldenRecordFilteredDatas { get; set; }
        public virtual DbSet<VwGoldenRecordMdate> VwGoldenRecordMdates { get; set; }
        public virtual DbSet<VwGoldenRecordTradingAccount> VwGoldenRecordTradingAccounts { get; set; }
        public virtual DbSet<VwPaymentFilterSearch> VwPaymentFilterSearches { get; set; }
        public virtual DbSet<WorkQueueMst> WorkQueueMsts { get; set; }
        public virtual DbSet<WorkQueueMstAudit> WorkQueueMstAudits { get; set; }
        public virtual DbSet<WorkQueueUserMapping> WorkQueueUserMappings { get; set; }
        public virtual DbSet<WorkQueueUserMappingAudit> WorkQueueUserMappingAudits { get; set; }
        public virtual DbSet<GoldenRecordSecurityDetail> GoldenRecordSecurityDetails{ get; set; }
        public virtual DbSet<GoldenRecordSecurityDetailAudit> GoldenRecordSecurityDetailAudits{ get; set; }
        public virtual DbSet<Trading_Account_Groups> TradingAccountGroups { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Ibanumber).HasColumnName("IBANumber");
            });

            modelBuilder.Entity<AccountCaEventNotificationConfig>(entity =>
            {
                entity.ToTable("Account_CA_Event_Notification_Config");

                entity.Property(e => e.AccountCaEventNotificationConfigId).HasColumnName("Account_CA_Event_Notification_Config_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventQualifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NotificationMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Notification_Method");
            });

            modelBuilder.Entity<AccountCaEventNotificationConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AccountCAEventNotificationConfigAudit_AuditId");

                entity.ToTable("Account_CA_Event_Notification_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountCaEventNotificationConfigId).HasColumnName("Account_CA_Event_Notification_Config_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventQualifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.NotificationMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Notification_Method");
            });

            modelBuilder.Entity<AccountInformation>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.AccountOwnerPrimaryId, "IX_AccountInformations_AccountOwnerPrimaryId");

                entity.HasIndex(e => e.MunderlyingSecuritiesPrimaryId, "IX_AccountInformations_MUnderlyingSecuritiesPrimaryId");

                entity.HasIndex(e => e.PlaceOfSafekeepingPrimaryId, "IX_AccountInformations_PlaceOfSafekeepingPrimaryId");

                entity.HasIndex(e => e.SafekeepingAccountPrimaryId, "IX_AccountInformations_SafekeepingAccountPrimaryId");

                entity.Property(e => e.MunderlyingSecuritiesPrimaryId).HasColumnName("MUnderlyingSecuritiesPrimaryId");

                entity.HasOne(d => d.AccountOwnerPrimary)
                    .WithMany(p => p.AccountInformations)
                    .HasForeignKey(d => d.AccountOwnerPrimaryId);

                entity.HasOne(d => d.MunderlyingSecuritiesPrimary)
                    .WithMany(p => p.AccountInformations)
                    .HasForeignKey(d => d.MunderlyingSecuritiesPrimaryId);

                entity.HasOne(d => d.PlaceOfSafekeepingPrimary)
                    .WithMany(p => p.AccountInformations)
                    .HasForeignKey(d => d.PlaceOfSafekeepingPrimaryId);

                entity.HasOne(d => d.SafekeepingAccountPrimary)
                    .WithMany(p => p.AccountInformations)
                    .HasForeignKey(d => d.SafekeepingAccountPrimaryId);
            });

            modelBuilder.Entity<AccountInformationsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AccountInformationsAudit_AuditId");

                entity.ToTable("AccountInformations_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MunderlyingSecuritiesPrimaryId).HasColumnName("MUnderlyingSecuritiesPrimaryId");
            });

            modelBuilder.Entity<AccountMst>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_AccountMst_AccountID");

                entity.ToTable("Account_Mst");

                entity.HasIndex(e => e.LegalEntityCdrId, "idx_AccountMst_LECDRId");

                entity.HasIndex(e => new { e.LegalEntityCdrId, e.TradingAccountNumber }, "idx_AccountMst_LECDRIdTradingAccNum");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.Bic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIC");

                entity.Property(e => e.CibcEntity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CIBC_ENTITY");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.EmailEnabled)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Email_Enabled");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LegalEntityCdrId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.LegalEntityName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Name");

                entity.Property(e => e.ParentCompanyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Company_Name");

                entity.Property(e => e.SwiftMessageEnabled)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Swift_Message_Enabled")
                    .HasComment("");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");

                entity.Property(e => e.CibcLob)
                    .HasColumnName("CIBC_LOB");
            });

            modelBuilder.Entity<AccountMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AccountMstAudit_AuditId");

                entity.ToTable("Account_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.Bic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIC");

                entity.Property(e => e.CibcEntity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CIBC_ENTITY");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.EmailEnabled)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Email_Enabled");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LegalEntityCdrId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.LegalEntityName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Name");

                entity.Property(e => e.ParentCompanyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Company_Name");

                entity.Property(e => e.SwiftMessageEnabled)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Swift_Message_Enabled");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<AccountOwner>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);
            });

            modelBuilder.Entity<AccountOwnersAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AccountOwnersAudit_AuditId");

                entity.ToTable("AccountOwners_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<AccountsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AccountsAudit_AuditId");

                entity.ToTable("Accounts_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.Ibanumber).HasColumnName("IBANumber");
            });

            modelBuilder.Entity<AckData>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);
            });

            modelBuilder.Entity<AckDatasAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AckDatasAudit_AuditId");

                entity.ToTable("AckDatas_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<AdditionalInformation>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);
            });

            modelBuilder.Entity<AdditionalInformationsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AdditionalInformationsAudit_AuditId");

                entity.ToTable("AdditionalInformations_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<ApplicationMst>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("pk_Application_Mst_ApplicationID");

                entity.ToTable("Application_Mst");

                entity.HasIndex(e => e.ApplicationName, "idx_Application_Mst_AplicationName");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_Id");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Application_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ApplicationMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("pk_ApplicationMstAudit_AuditID");

                entity.ToTable("Application_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_Id");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Application_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<AssetClassMst>(entity =>
            {
                entity.HasKey(e => e.AssetClassId)
                    .HasName("PK_AssetClassMst_AssetClassId");

                entity.ToTable("Asset_Class_Mst");

                entity.Property(e => e.AssetClassId).HasColumnName("Asset_Class_Id");

                entity.Property(e => e.AssetClassName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Class_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuantityTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Quantity_Type_Code");
            });

            modelBuilder.Entity<AssetClassMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AssetClassMstAudit_AuditId");

                entity.ToTable("Asset_Class_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AssetClassId).HasColumnName("Asset_Class_Id");

                entity.Property(e => e.AssetClassName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Class_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.QuantityTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Quantity_Type_Code");
            });

            modelBuilder.Entity<AuditTrailDetail>(entity =>
            {
                entity.HasKey(e => e.AuditTrailId)
                    .HasName("PK_AuditTrailDetails_AuditTrailId");

                entity.ToTable("AuditTrail_Details");

                entity.Property(e => e.AuditTrailId).HasColumnName("Audit_Trail_Id");

                entity.Property(e => e.ActionCategory)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Action_Category");

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Action_Type");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryByName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Entry_By_Name");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Log_Type");

                entity.Property(e => e.MessageText).HasColumnName("Message_Text");

                entity.Property(e => e.NewValue).HasColumnName("New_Value");

                entity.Property(e => e.OldValue).HasColumnName("Old_Value");

                entity.Property(e => e.SourceIpAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_IP_Address");
            });

            modelBuilder.Entity<AuditTrailOperationalDetail>(entity =>
            {
                entity.HasKey(e => e.AuditTrailOperationId)
                    .HasName("PK_AuditTrailOperationalDetails_AuditTrailOperationId");

                entity.ToTable("AuditTrail_Operational_Details");

                entity.Property(e => e.AuditTrailOperationId).HasColumnName("Audit_Trail_Operation_Id");

                entity.Property(e => e.ActionCategory)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Action_Category");

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Action_Type");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryByName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Entry_By_Name");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Log_Type");

                entity.Property(e => e.MessageText).HasColumnName("Message_Text");

                entity.Property(e => e.NewValue).HasColumnName("New_Value");

                entity.Property(e => e.OldValue).HasColumnName("Old_Value");
            });

            modelBuilder.Entity<CaEventArchiveConfig>(entity =>
            {
                entity.ToTable("CA_Event_Archive_Config");

                entity.Property(e => e.CaEventArchiveConfigId).HasColumnName("CA_Event_Archive_Config_Id");

                entity.Property(e => e.ArchiveDateDaysFromId).HasColumnName("Archive_Date_Days_From_ID");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventQualifier)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.CfiIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CFI_Indicator");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Issue");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InactiveDateDaysFromIrd).HasColumnName("Inactive_Date_Days_From_IRD");

                entity.Property(e => e.InactiveReferenceDateLaterOf)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Inactive_Reference_Date_Later_Of");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrimarySource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Source");

                entity.Property(e => e.SecondarySource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Secondary_Source");

                entity.Property(e => e.SpecializedSource1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Specialized_Source1");

                entity.Property(e => e.SpecializedSource2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Specialized_Source2");
            });

            modelBuilder.Entity<CaEventArchiveConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventArchiveConfigAudit_AuditId");

                entity.ToTable("CA_Event_Archive_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ArchiveDateDaysFromId).HasColumnName("Archive_Date_Days_From_ID");

                entity.Property(e => e.CaEventArchiveConfigId).HasColumnName("CA_Event_Archive_Config_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventQualifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.CfiIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CFI_Indicator");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Issue");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InactiveDateDaysFromIrd).HasColumnName("Inactive_Date_Days_From_IRD");

                entity.Property(e => e.InactiveReferenceDateLaterOf)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Inactive_Reference_Date_Later_Of");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.PrimarySource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Source");

                entity.Property(e => e.SecondarySource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Secondary_Source");

                entity.Property(e => e.SpecializedSource1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Specialized_Source1");

                entity.Property(e => e.SpecializedSource2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Specialized_Source2");
            });

            modelBuilder.Entity<CaEventConfig>(entity =>
            {
                entity.ToTable("CA_Event_Config");

                entity.Property(e => e.CaEventConfigId).HasColumnName("CA_Event_Config_Id");

                entity.Property(e => e.ArchiveDays)
                    .HasColumnName("Archive_Days")
                    .HasDefaultValueSql("((365))");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.ConbType)
                    .HasMaxLength(10)
                    .HasColumnName("CONB_Type")
                    .HasDefaultValueSql("('GPD')");

                entity.Property(e => e.CreateNoacOption).HasColumnName("Create_NOAC_Option");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GpdDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GPD_Date");

                entity.Property(e => e.GpdDateType)
                    .HasMaxLength(100)
                    .HasColumnName("GPD_Date_Type");

                entity.Property(e => e.GpdOffset).HasColumnName("GPD_Offset");

                entity.Property(e => e.InactiveDays)
                    .HasColumnName("Inactive_Days")
                    .HasDefaultValueSql("((21))");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaximumOfOptions).HasColumnName("Maximum_Of_Options");

                entity.Property(e => e.MinimumOfOptions).HasColumnName("Minimum_Of_Options");

                entity.Property(e => e.NoOfDefaultOptions).HasColumnName("No_Of_Default_Options");

                entity.Property(e => e.NoOfSourcesForAutoComplete).HasColumnName("No_Of_Sources_For_Auto_Complete");

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .HasColumnName("Position_Type")
                    .HasDefaultValueSql("('TRAD')");

                entity.Property(e => e.SupportedOptionType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Supported_Option_Type");

                entity.Property(e => e.isDebitSecAllow).HasColumnName("Is_Debit_SecMove_Allow");
            });

            modelBuilder.Entity<CaOptionTypeConfig>(entity =>
            {
                entity.HasKey(e => e.CaOptionTypeConfigId)
                   .HasName("PK_OptionTypeConfig_OptionTypeConfigId");

                entity.ToTable("Option_Type_Config");

                entity.HasIndex(e => new { e.CaOptionTypeConfigId }, "PK_OptionTypeConfig_OptionTypeConfigId")
                   .IsUnique();

                entity.Property(e => e.CaOptionTypeConfigId).HasColumnName("Option_Type_Config_Id");

                entity.Property(e => e.CaOptionType).HasColumnName("Option_Type");

                entity.Property(e => e.CaOptionDescription).HasColumnName("Option_Description");

                entity.Property(e => e.isDebitSecAllow).HasColumnName("Is_Debit_SecMove_Allow");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.EntryDtTime)
                   .HasColumnType("datetime")
                   .HasColumnName("Entry_Dt_Time")
                   .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<CaEventConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventConfigAudit_AuditId");

                entity.ToTable("CA_Event_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ArchiveDays).HasColumnName("Archive_Days");

                entity.Property(e => e.CaEventConfigId).HasColumnName("CA_Event_Config_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.ConbType)
                    .HasMaxLength(10)
                    .HasColumnName("CONB_Type");

                entity.Property(e => e.CreateNoacOption).HasColumnName("Create_NOAC_Option");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GpdDate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GPD_Date");

                entity.Property(e => e.GpdDateType)
                    .HasMaxLength(100)
                    .HasColumnName("GPD_Date_Type");

                entity.Property(e => e.GpdOffset).HasColumnName("GPD_Offset");

                entity.Property(e => e.InactiveDays).HasColumnName("Inactive_Days");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MaximumOfOptions).HasColumnName("Maximum_Of_Options");

                entity.Property(e => e.MinimumOfOptions).HasColumnName("Minimum_Of_Options");

                entity.Property(e => e.NoOfDefaultOptions).HasColumnName("No_Of_Default_Options");

                entity.Property(e => e.NoOfSourcesForAutoComplete).HasColumnName("No_Of_Sources_For_Auto_Complete");

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .HasColumnName("Position_Type");

                entity.Property(e => e.SupportedOptionType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Supported_Option_Type");
            });

            modelBuilder.Entity<CaEventConflict>(entity =>
            {
                entity.HasKey(e => e.ConflictId)
                    .HasName("PK_CAEventConflicts_ConflictId");

                entity.ToTable("CA_Event_Conflicts");

                entity.HasIndex(e => new { e.GoldenRecordId, e.FieldName, e.OptionNumber, e.MovementId }, "Unq_CAEventConflicts_GoldenRecIdFieldNmOptnNumMovementId")
                    .IsUnique();

                entity.Property(e => e.ConflictId).HasColumnName("Conflict_Id");

                entity.Property(e => e.ClientValue)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Client_Value");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExistingSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Existing_Source");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Field_Name");

                entity.Property(e => e.FieldStatus).HasColumnName("Field_Status");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MovementId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Movement_Id");

                entity.Property(e => e.NewEventId).HasColumnName("New_Event_Id");

                entity.Property(e => e.NewEventMovementId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Movement_Id");

                entity.Property(e => e.NewEventOptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Option_Number");

                entity.Property(e => e.NewEventSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Source");

                entity.Property(e => e.NewEventValue)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Value");

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_Number");

                entity.Property(e => e.ResolveBy).HasColumnName("Resolve_By");

                entity.Property(e => e.ResolveType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Resolve_Type");

                entity.Property(e => e.ResolveValue).HasColumnName("Resolve_Value");

                entity.Property(e => e.ReviewStatus).HasColumnName("Review_Status");
            });

            modelBuilder.Entity<CaEventConflictsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventConflictsAudit_AuditId");

                entity.ToTable("CA_Event_Conflicts_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientValue)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Client_Value");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ConflictId).HasColumnName("Conflict_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExistingSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Existing_Source");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Field_Name");

                entity.Property(e => e.FieldStatus).HasColumnName("Field_Status");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MovementId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Movement_Id");

                entity.Property(e => e.NewEventId).HasColumnName("New_Event_Id");

                entity.Property(e => e.NewEventMovementId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Movement_Id");

                entity.Property(e => e.NewEventOptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Option_Number");

                entity.Property(e => e.NewEventSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Source");

                entity.Property(e => e.NewEventValue)
                    .IsUnicode(false)
                    .HasColumnName("New_Event_Value");

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_Number");

                entity.Property(e => e.ResolveBy).HasColumnName("Resolve_By");

                entity.Property(e => e.ResolveType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Resolve_Type");

                entity.Property(e => e.ResolveValue).HasColumnName("Resolve_Value");

                entity.Property(e => e.ReviewStatus).HasColumnName("Review_Status");
            });

            modelBuilder.Entity<CaEventElection>(entity =>
            {
                entity.ToTable("CA_Event_Election");

                entity.Property(e => e.CaEventElectionId).HasColumnName("CA_Event_Election_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalComment).HasColumnName("Internal_Comment");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JsonMsg)
                    .IsUnicode(false)
                    .HasColumnName("JSON_Msg");

                entity.Property(e => e.MessageText).HasColumnName("Message_Text");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityTypeId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Security_Type_Id");

                entity.Property(e => e.SenderBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Sender_BIC");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<CaEventElectionAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventElectionAudit_AuditId");

                entity.ToTable("CA_Event_Election_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventElectionId).HasColumnName("CA_Event_Election_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InternalComment).HasColumnName("Internal_Comment");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.JsonMsg)
                    .IsUnicode(false)
                    .HasColumnName("JSON_Msg");

                entity.Property(e => e.MessageText).HasColumnName("Message_Text");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityTypeId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Security_Type_Id");

                entity.Property(e => e.SenderBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Sender_BIC");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<CaEventElectionInstructionsMapping>(entity =>
            {
                entity.ToTable("CA_Event_Election_Instructions_Mapping");

                entity.Property(e => e.CaEventElectionInstructionsMappingId).HasColumnName("CA_Event_Election_Instructions_Mapping_Id");

                entity.Property(e => e.CaEventElectionOptionsDtlId).HasColumnName("CA_Event_Election_Options_Dtl_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");

                entity.Property(e => e.Mt567SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT567_SEME_Ref");
            });

            modelBuilder.Entity<CaEventElectionInstructionsMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventElectionInstructionsMappingAudit_AuditId");

                entity.ToTable("CA_Event_Election_Instructions_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventElectionInstructionsMappingId).HasColumnName("CA_Event_Election_Instructions_Mapping_Id");

                entity.Property(e => e.CaEventElectionOptionsDtlId).HasColumnName("CA_Event_Election_Options_Dtl_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");

                entity.Property(e => e.Mt567SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT567_SEME_Ref");
            });

            modelBuilder.Entity<CaEventElectionMapping>(entity =>
            {
                entity.ToTable("CA_Event_Election_Mapping");

                entity.Property(e => e.CaEventElectionMappingId).HasColumnName("CA_Event_Election_Mapping_Id");

                entity.Property(e => e.CaEventElectionId).HasColumnName("CA_Event_Election_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("Is_Default")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mt564SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT564_SEME_Ref");

                entity.Property(e => e.Mt565MsgId).HasColumnName("MT565_MsgID");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");
            });

            modelBuilder.Entity<CaEventElectionMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventElectionMappingAudit_AuditId");

                entity.ToTable("CA_Event_Election_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventElectionId).HasColumnName("CA_Event_Election_Id");

                entity.Property(e => e.CaEventElectionMappingId).HasColumnName("CA_Event_Election_Mapping_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsDefault).HasColumnName("Is_Default");

                entity.Property(e => e.Mt564SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT564_SEME_Ref");

                entity.Property(e => e.Mt565MsgId).HasColumnName("MT565_MsgID");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");
            });

            modelBuilder.Entity<CaEventElectionOptionNewSecurityDetail>(entity =>
            {
                entity.HasKey(e => e.CaEventEleOptNewSecurityDtlId)
                    .HasName("PK_CAEventElectionOptionNewSecurityDetails_CAEventEleOptNewSecurityDtlId");

                entity.ToTable("CA_Event_Election_Option_New_Security_Details");

                entity.Property(e => e.CaEventEleOptNewSecurityDtlId).HasColumnName("CA_Event_Ele_Opt_New_Security_Dtl_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewSecurityDesc)
                    .HasMaxLength(500)
                    .HasColumnName("New_Security_Desc");

                entity.Property(e => e.NewSecurityId)
                    .HasMaxLength(200)
                    .HasColumnName("New_Security_ID");

                entity.Property(e => e.NewSecurityIdType)
                    .HasMaxLength(200)
                    .HasColumnName("New_SecurityID_Type");
            });

            modelBuilder.Entity<CaEventElectionOptionNewSecurityDetailsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventElectionOptionNewSecurityDetailsAudit_AuditId");

                entity.ToTable("CA_Event_Election_Option_New_Security_Details_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventEleOptNewSecurityDtlId).HasColumnName("CA_Event_Ele_Opt_New_Security_Dtl_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.NewSecurityDesc)
                    .HasMaxLength(500)
                    .HasColumnName("New_Security_Desc");

                entity.Property(e => e.NewSecurityId)
                    .HasMaxLength(200)
                    .HasColumnName("New_Security_ID");

                entity.Property(e => e.NewSecurityIdType)
                    .HasMaxLength(200)
                    .HasColumnName("New_SecurityID_Type");
            });

            modelBuilder.Entity<CaEventElectionOptionsDtl>(entity =>
            {
                entity.ToTable("CA_Event_Election_Options_Dtl");

                entity.Property(e => e.CaEventElectionOptionsDtlId).HasColumnName("CA_Event_Election_options_Dtl_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.CaEventElectionMappingId).HasColumnName("CA_Event_Election_Mapping_Id");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExecutionRequestedDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Execution_Requested_Dt_Time");

                entity.Property(e => e.ExternalComment).HasColumnName("External_Comment");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");

                entity.Property(e => e.Narrative)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_number");

                entity.Property(e => e.OptionStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Option_Status");

                entity.Property(e => e.OptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Option_Type");

                entity.Property(e => e.Party)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TradingAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account");
            });

            modelBuilder.Entity<CaEventElectionOptionsDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventElectionOptionsDtlAudit_AuditId");

                entity.ToTable("CA_Event_Election_Options_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.CaEventElectionMappingId).HasColumnName("CA_Event_Election_Mapping_Id");

                entity.Property(e => e.CaEventElectionOptionsDtlId).HasColumnName("CA_Event_Election_options_Dtl_Id");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExecutionRequestedDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Execution_Requested_Dt_Time");

                entity.Property(e => e.ExternalComment).HasColumnName("External_Comment");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");

                entity.Property(e => e.Narrative)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_number");

                entity.Property(e => e.OptionStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Option_Status");

                entity.Property(e => e.OptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Option_Type");

                entity.Property(e => e.Party)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TradingAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account");
            });

            modelBuilder.Entity<CaEventElectionPosition>(entity =>
            {
                entity.ToTable("CA_Event_Election_Position");

                entity.Property(e => e.CaEventElectionPositionId).HasColumnName("CA_Event_Election_Position_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Account_Type");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MemoCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Memo_Code");

                entity.Property(e => e.MemoQuantity)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Memo_Quantity");

                entity.Property(e => e.PositionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Date");

                entity.Property(e => e.SettleDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Settle_Date_Position");

                entity.Property(e => e.TradeDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Trade_Date_Position");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<CaEventElectionPositionAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventElectionPositionAudit_AuditId");

                entity.ToTable("CA_Event_Election_Position_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Account_Type");

                entity.Property(e => e.CaEventElectionPositionId).HasColumnName("CA_Event_Election_Position_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MemoCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Memo_Code");

                entity.Property(e => e.MemoQuantity)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Memo_Quantity");

                entity.Property(e => e.PositionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Date");

                entity.Property(e => e.SettleDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Settle_Date_Position");

                entity.Property(e => e.TradeDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Trade_Date_Position");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<CaEventEventTypeMapping>(entity =>
            {
                entity.ToTable("CA_Event_EventType_Mapping");

                entity.Property(e => e.CaEventEventTypeMappingId).HasColumnName("CA_Event_EventType_Mapping_Id");

                entity.Property(e => e.CaEventCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Code");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventType)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CaEventEventTypeMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventEventTypeMappingAudit_AuditId");

                entity.ToTable("CA_Event_EventType_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Code");

                entity.Property(e => e.CaEventEventTypeMappingId).HasColumnName("CA_Event_EventType_Mapping_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventType)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<CaEventGpdConfig>(entity =>
            {
                entity.ToTable("CA_Event_GPD_Config");

                entity.Property(e => e.CaEventGpdConfigId).HasColumnName("CA_Event_GPD_Config_Id");

                entity.Property(e => e.ConbType)
                    .HasMaxLength(10)
                    .HasColumnName("CONB_Type");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GpdDateType)
                    .HasMaxLength(100)
                    .HasColumnName("GPD_Date_Type");

                entity.Property(e => e.GpdOffset).HasColumnName("GPD_Offset");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .HasColumnName("Position_Type");
            });

            modelBuilder.Entity<CaEventGpdConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventGPDConfigAudit_AuditId");

                entity.ToTable("CA_Event_GPD_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventGpdConfigId).HasColumnName("CA_Event_GPD_Config_Id");

                entity.Property(e => e.ConbType)
                    .HasMaxLength(10)
                    .HasColumnName("CONB_Type");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GpdDateType)
                    .HasMaxLength(100)
                    .HasColumnName("GPD_Date_Type");

                entity.Property(e => e.GpdOffset).HasColumnName("GPD_Offset");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.PositionType)
                    .HasMaxLength(10)
                    .HasColumnName("Position_Type");
            });

            modelBuilder.Entity<CaEventInstruction>(entity =>
            {
                entity.HasKey(e => e.CaEventInstructionsId)
                    .HasName("PK_CAEventInstructions_CAEventInstructionsId");

                entity.ToTable("CA_Event_Instructions");

                entity.Property(e => e.CaEventInstructionsId).HasColumnName("CA_Event_Instructions_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.EventStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Status");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageDtl)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Message_Dtl");

                entity.Property(e => e.MessageSentStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Message_Sent_Status");

                entity.Property(e => e.Mt567SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT567_SEME_Ref");
            });

            modelBuilder.Entity<CaEventInstructionStatu>(entity =>
            {
                entity.HasKey(e => e.CaEventInstructionStatusId)
                    .HasName("PK_CAEventInstructionStatus_CAEventInstructionStatusId");

                entity.ToTable("CA_Event_Instruction_Status");

                entity.Property(e => e.CaEventInstructionStatusId).HasColumnName("CA_Event_Instruction_Status_Id");

                entity.Property(e => e.CaEventElectionOptionsDtlId).HasColumnName("CA_Event_Election_Options_Dtl_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.InstructionStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Instruction_Status");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");

                entity.Property(e => e.Mt567SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT567_SEME_Ref");
            });

            modelBuilder.Entity<CaEventInstructionStatusAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventInstructionStatusAudit_AuditId");

                entity.ToTable("CA_Event_Instruction_Status_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventElectionOptionsDtlId).HasColumnName("CA_Event_Election_Options_Dtl_Id");

                entity.Property(e => e.CaEventInstructionStatusId).HasColumnName("CA_Event_Instruction_Status_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.InstructionStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Instruction_Status");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Mt565SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT565_SEME_Ref");

                entity.Property(e => e.Mt567SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT567_SEME_Ref");
            });

            modelBuilder.Entity<CaEventInstructionsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventInstructionsAudit_AuditId");

                entity.ToTable("CA_Event_Instructions_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventInstructionsId).HasColumnName("CA_Event_Instructions_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.EventStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Event_Status");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MessageDtl)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Message_Dtl");

                entity.Property(e => e.MessageSentStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Message_Sent_Status");

                entity.Property(e => e.Mt567SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT567_SEME_Ref");
            });

            modelBuilder.Entity<CaEventMst>(entity =>
            {
                entity.ToTable("CA_Event_Mst");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEvent)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event");

                entity.Property(e => e.CaEventCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Code");

                entity.Property(e => e.CaEventDesc)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Desc");

                entity.Property(e => e.CaEventQualifier)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventShortDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Short_Description");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CaEventMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventMstAudit_AuditId");

                entity.ToTable("CA_Event_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEvent)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event");

                entity.Property(e => e.CaEventCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Code");

                entity.Property(e => e.CaEventDesc)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Desc");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventQualifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventShortDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Short_Description");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<CaEventNotificationClientConfig>(entity =>
            {
                entity.ToTable("CA_Event_Notification_Client_Config");

                entity.Property(e => e.CaEventNotificationClientConfigId).HasColumnName("CA_Event_Notification_Client_Config_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("Is_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LegalEntityCdrId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.RequireNotification).HasColumnName("Require_Notification");
            });

            modelBuilder.Entity<CaEventNotificationClientConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventNotificationClientConfigAudit_AuditId");

                entity.ToTable("CA_Event_Notification_Client_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventNotificationClientConfigId).HasColumnName("CA_Event_Notification_Client_Config_Id");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");

                entity.Property(e => e.LegalEntityCdrId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.RequireNotification).HasColumnName("Require_Notification");
            });

            modelBuilder.Entity<CaEventNotificationSystemConfig>(entity =>
            {
                entity.ToTable("CA_Event_Notification_System_Config");

                entity.Property(e => e.CaEventNotificationSystemConfigId).HasColumnName("CA_Event_Notification_System_Config_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendAutoNotification).HasColumnName("Send_Auto_Notification");
            });

            modelBuilder.Entity<CaEventNotificationSystemConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventNotificationSystemConfigAudit_AuditId");

                entity.ToTable("CA_Event_Notification_System_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventNotificationSystemConfigId).HasColumnName("CA_Event_Notification_System_Config_Id");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.SendAutoNotification).HasColumnName("Send_Auto_Notification");
            });

            modelBuilder.Entity<CaEventPaymentStatus>(entity =>
            {
                entity.HasKey(e => e.CaEventPaymentStatusId)
                    .HasName("PK_CAEventPaymentStatus_CAEventPaymentStatusId");

                entity.ToTable("CA_Event_Payment_Status");

                entity.Property(e => e.CaEventPaymentStatusId).HasColumnName("CA_Event_Payment_Status_Id");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Account_Number");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Account_Type");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.ConfirmedBalance).HasColumnName("Confirmed_Balance");

                entity.Property(e => e.EmailNotificationStatus).HasColumnName("Email_Notification_Status");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExceptionType).HasColumnName("Exception_Type");

                entity.Property(e => e.FailedDesc).HasColumnName("Failed_Desc");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.InternalComments).HasColumnName("Internal_Comments");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFailed).HasColumnName("Is_Failed");

                entity.Property(e => e.IsPaidOrReverse)
                    .HasMaxLength(2)
                    .HasColumnName("Is_Paid_Or_Reverse");

                entity.Property(e => e.MatchStatus).HasColumnName("Match_Status");

                entity.Property(e => e.MovementNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Movement_Number");

                entity.Property(e => e.NotificationStatus).HasColumnName("Notification_Status");

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_Number");

                entity.Property(e => e.OptionType).HasColumnName("Option_Type");

                entity.Property(e => e.OutputType)
                    .HasMaxLength(50)
                    .HasColumnName("Output_Type");

                entity.Property(e => e.PaymentLinkId)
                    .HasMaxLength(100)
                    .HasColumnName("Payment_Link_Id");

                entity.Property(e => e.PaymentLinkName)
                    .HasMaxLength(400)
                    .HasColumnName("Payment_Link_Name");

                entity.Property(e => e.PaymentLinkType)
                    .HasMaxLength(100)
                    .HasColumnName("Payment_Link_Type");

                entity.Property(e => e.PaymentStatus).HasColumnName("Payment_Status");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.SwiftNotificationStatus).HasColumnName("Swift_Notification_Status");
            });

            modelBuilder.Entity<CaEventPaymentStatusAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventPaymentStatusAudit_AuditId");

                entity.ToTable("CA_Event_Payment_Status_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Account_Number");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Account_Type");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.CaEventPaymentStatusId).HasColumnName("CA_Event_Payment_Status_Id");

                entity.Property(e => e.ConfirmedBalance).HasColumnName("Confirmed_Balance");

                entity.Property(e => e.EmailNotificationStatus).HasColumnName("Email_Notification_Status");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExceptionType).HasColumnName("Exception_Type");

                entity.Property(e => e.FailedDesc).HasColumnName("Failed_Desc");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.InternalComments).HasColumnName("Internal_Comments");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsFailed).HasColumnName("Is_Failed");

                entity.Property(e => e.IsPaidOrReverse)
                    .HasMaxLength(2)
                    .HasColumnName("Is_Paid_Or_Reverse");

                entity.Property(e => e.MatchStatus).HasColumnName("Match_Status");

                entity.Property(e => e.MovementNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Movement_Number");

                entity.Property(e => e.NotificationStatus).HasColumnName("Notification_Status");

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_Number");

                entity.Property(e => e.OptionType).HasColumnName("Option_Type");

                entity.Property(e => e.OutputType)
                    .HasMaxLength(50)
                    .HasColumnName("Output_Type");

                entity.Property(e => e.PaymentLinkId)
                    .HasMaxLength(100)
                    .HasColumnName("Payment_Link_Id");

                entity.Property(e => e.PaymentLinkName)
                    .HasMaxLength(400)
                    .HasColumnName("Payment_Link_Name");

                entity.Property(e => e.PaymentLinkType)
                    .HasMaxLength(100)
                    .HasColumnName("Payment_Link_Type");

                entity.Property(e => e.PaymentStatus).HasColumnName("Payment_Status");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.SwiftNotificationStatus).HasColumnName("Swift_Notification_Status");
            });

            modelBuilder.Entity<CaEventPaymnetNotificationMapping>(entity =>
            {
                entity.HasKey(e => e.CaEventPaymnetNotifMapId)
                    .HasName("PK_CAEventPaymnetNotifMapping_CAEventPaymnetNotifMapId");

                entity.ToTable("CA_Event_Paymnet_Notification_Mapping");

                entity.Property(e => e.CaEventPaymnetNotifMapId).HasColumnName("CA_Event_Paymnet_Notif_Map_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mt564SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT564_SEME_Ref");

                entity.Property(e => e.Mt566SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT566_SEME_Ref");

                entity.Property(e => e.OutputType)
                    .HasMaxLength(50)
                    .HasColumnName("Output_Type");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");
            });

            modelBuilder.Entity<CaEventPaymnetNotificationMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventPaymnetNotifMappingAudit_AuditId");

                entity.ToTable("CA_Event_Paymnet_Notification_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventPaymnetNotifMapId).HasColumnName("CA_Event_Paymnet_Notif_Map_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Mt564SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT564_SEME_Ref");

                entity.Property(e => e.Mt566SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MT566_SEME_Ref");

                entity.Property(e => e.OutputType)
                    .HasMaxLength(50)
                    .HasColumnName("Output_Type");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");
            });

            modelBuilder.Entity<CaEventRiskProfileMst>(entity =>
            {
                entity.HasKey(e => e.CaEventRiskProfileId)
                    .HasName("PK_CAEventRiskProfileMst_CAEventRiskProfileId");

                entity.ToTable("CA_Event_Risk_Profile_Mst");

                entity.Property(e => e.CaEventRiskProfileId).HasColumnName("CA_Event_Risk_Profile_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Name");

                entity.Property(e => e.CaEventNameRfv).HasColumnName("CA_Event_Name_RFV");

                entity.Property(e => e.CaEventQualifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventRfv).HasColumnName("CA_Event_RFV");

                entity.Property(e => e.CaMvc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CA_MVC");

                entity.Property(e => e.CaMvcEventTypeId).HasColumnName("CA_MVC_Event_Type_id");

                entity.Property(e => e.CaMvcRfv).HasColumnName("CA_MVC_RFV");

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Classification_Code");

                entity.Property(e => e.ClassificationCodeRfv).HasColumnName("Classification_Code_RFV");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Issue");

                entity.Property(e => e.CountryOfIssueRfv).HasColumnName("Country_Of_Issue_RFV");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RangeAccounts)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Range_Accounts");

                entity.Property(e => e.RangeAccountsRfv).HasColumnName("Range_Accounts_RFV");

                entity.Property(e => e.RangePositionsQty)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Range_Positions_Qty");

                entity.Property(e => e.RangePositionsQtyRfv).HasColumnName("Range_Positions_Qty_RFV");

                entity.Property(e => e.RiskProfileName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Profile_Name");

                entity.Property(e => e.TotalRisk).HasColumnName("Total_Risk");
            });

            modelBuilder.Entity<CaEventRiskProfileMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventRiskProfileMstAudit_AuditId");

                entity.ToTable("CA_Event_Risk_Profile_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventMstId).HasColumnName("CA_Event_Mst_Id");

                entity.Property(e => e.CaEventName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Name");

                entity.Property(e => e.CaEventNameRfv).HasColumnName("CA_Event_Name_RFV");

                entity.Property(e => e.CaEventQualifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Qualifier");

                entity.Property(e => e.CaEventRfv).HasColumnName("CA_Event_RFV");

                entity.Property(e => e.CaEventRiskProfileId).HasColumnName("CA_Event_Risk_Profile_Id");

                entity.Property(e => e.CaMvc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CA_MVC");

                entity.Property(e => e.CaMvcEventTypeId).HasColumnName("CA_MVC_Event_Type_id");

                entity.Property(e => e.CaMvcRfv).HasColumnName("CA_MVC_RFV");

                entity.Property(e => e.ClassificationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Classification_Code");

                entity.Property(e => e.ClassificationCodeRfv).HasColumnName("Classification_Code_RFV");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Issue");

                entity.Property(e => e.CountryOfIssueRfv).HasColumnName("Country_Of_Issue_RFV");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.RangeAccounts)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Range_Accounts");

                entity.Property(e => e.RangeAccountsRfv).HasColumnName("Range_Accounts_RFV");

                entity.Property(e => e.RangePositionsQty)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Range_Positions_Qty");

                entity.Property(e => e.RangePositionsQtyRfv).HasColumnName("Range_Positions_Qty_RFV");

                entity.Property(e => e.RiskProfileName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Profile_Name");

                entity.Property(e => e.TotalRisk).HasColumnName("Total_Risk");
            });

            modelBuilder.Entity<CaEventRiskType>(entity =>
            {
                entity.HasKey(e => e.CaEventRiskTypesId)
                    .HasName("PK_CAEventRiskTypes_CAEventRiskTypesId");

                entity.ToTable("CA_Event_Risk_Types");

                entity.Property(e => e.CaEventRiskTypesId).HasColumnName("CA_Event_Risk_Types_Id");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Color_Code");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxValue).HasColumnName("Max_Value");

                entity.Property(e => e.MinValue).HasColumnName("Min_Value");

                entity.Property(e => e.RiskTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Type_Name");
            });

            modelBuilder.Entity<CaEventRiskTypesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventRiskTypesAudit_AuditId");

                entity.ToTable("CA_Event_Risk_Types_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventRiskTypesId).HasColumnName("CA_Event_Risk_Types_Id");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Color_Code");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MaxValue).HasColumnName("Max_Value");

                entity.Property(e => e.MinValue).HasColumnName("Min_Value");

                entity.Property(e => e.RiskTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Risk_Type_Name");
            });

            modelBuilder.Entity<CaEventStatusNotificationClientConfig>(entity =>
            {
                entity.ToTable("CA_Event_Status_Notification_Client_Config");

                entity.Property(e => e.CaEventStatusNotificationClientConfigId).HasColumnName("CA_Event_Status_Notification_Client_Config_Id");

                entity.Property(e => e.CaEventStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Status");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("Is_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LegalEntityCdrId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.RequireNotification).HasColumnName("Require_Notification");
            });

            modelBuilder.Entity<CaEventStatusNotificationClientConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventStatusNotificationClientConfigAudit_AuditID");

                entity.ToTable("CA_Event_Status_Notification_Client_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Status");

                entity.Property(e => e.CaEventStatusNotificationClientConfigId).HasColumnName("CA_Event_Status_Notification_Client_Config_Id");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");

                entity.Property(e => e.LegalEntityCdrId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.RequireNotification).HasColumnName("Require_Notification");
            });

            modelBuilder.Entity<CaEventTypeMst>(entity =>
            {
                entity.HasKey(e => e.CaEventTypeId)
                    .HasName("PK_CAEventTypeMst_CAEventTypeId");

                entity.ToTable("CA_EventType_Mst");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.CaEventType)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType");

                entity.Property(e => e.CaEventTypeDesc)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType_Desc");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CaEventTypeMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAEventTypeMstAudit_AuditId");

                entity.ToTable("CA_EventType_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaEventType)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType");

                entity.Property(e => e.CaEventTypeDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType_Desc");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<CaOptionException>(entity =>
            {
                entity.ToTable("CA_Option_Exception");

                entity.HasIndex(e => new { e.GoldenRecordId, e.ExceptionType, e.SourceName, e.OptionNumber, e.MovementId }, "Unq_CAOptionException_GoldenRecIdExcTypeSrcNmOptNumMovmntId")
                    .IsUnique();

                entity.Property(e => e.CaOptionExceptionId).HasColumnName("CA_Option_Exception_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExceptionMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Exception_Message");

                entity.Property(e => e.ExceptionStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Exception_Status");

                entity.Property(e => e.ExceptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Exception_Type");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MovementId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Movement_Id");

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_Number");

                entity.Property(e => e.SourceBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_BIC");

                entity.Property(e => e.SourceEventId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Event_Id");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<CaOptionExceptionAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAOptionExceptionAudit_AuditId");

                entity.ToTable("CA_Option_Exception_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaOptionExceptionId).HasColumnName("CA_Option_Exception_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExceptionMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Exception_Message");

                entity.Property(e => e.ExceptionStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Exception_Status");

                entity.Property(e => e.ExceptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Exception_Type");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MovementId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Movement_Id");

                entity.Property(e => e.OptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Option_Number");

                entity.Property(e => e.SourceBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_BIC");

                entity.Property(e => e.SourceEventId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Event_Id");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<CaOptionLink>(entity =>
            {
                entity.ToTable("CA_Option_Link");

                entity.HasIndex(e => new { e.GoldenRecordId, e.SourceName, e.ClientOptionNumber, e.SourceOptionNumber }, "Unq_GoldenRecIdSourceNmCliOptNumSourceOptNum")
                    .IsUnique();

                entity.Property(e => e.CaOptionLinkId).HasColumnName("CA_Option_Link_Id");

                entity.Property(e => e.ClientLinkStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Client_Link_Status");

                entity.Property(e => e.ClientOptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Client_Option_Number");

                entity.Property(e => e.ClientOptionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Client_Option_Status");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SourceBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_BIC");

                entity.Property(e => e.SourceEventId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Event_Id");

                entity.Property(e => e.SourceLinkStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Link_Status");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.SourceOptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Source_Option_Number");

                entity.Property(e => e.SourceOptionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Option_Status");
            });

            modelBuilder.Entity<CaOptionLinkAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAOptionLinkAudit_AuditId");

                entity.ToTable("CA_Option_Link_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaOptionLinkId).HasColumnName("CA_Option_Link_Id");

                entity.Property(e => e.ClientLinkStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Client_Link_Status");

                entity.Property(e => e.ClientOptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Client_Option_Number");

                entity.Property(e => e.ClientOptionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Client_Option_Status");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.SourceBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_BIC");

                entity.Property(e => e.SourceEventId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Event_Id");

                entity.Property(e => e.SourceLinkStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Link_Status");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.SourceOptionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Source_Option_Number");

                entity.Property(e => e.SourceOptionStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Source_Option_Status");
            });

            modelBuilder.Entity<CaUnsupportedEventProcess>(entity =>
            {
                entity.ToTable("CA_Unsupported_Event_Process");

                entity.Property(e => e.CaUnsupportedEventProcessId).HasColumnName("CA_Unsupported_Event_Process_Id");

                entity.Property(e => e.EndDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("End_DateTime");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.EventName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Event_Name");

                entity.Property(e => e.EventStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Event_Status");

                entity.Property(e => e.EventType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Event_Type");

                entity.Property(e => e.FailedCount).HasColumnName("Failed_Count");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProcessEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_End_Time");

                entity.Property(e => e.ProcessStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_Start_Time");

                entity.Property(e => e.StartDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_DateTime");

                entity.Property(e => e.TotalCount).HasColumnName("Total_Count");
            });

            modelBuilder.Entity<CaUnsupportedEventProcessAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CAUnsupportedEventProcessAudit_AuditId");

                entity.ToTable("CA_Unsupported_Event_Process_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaUnsupportedEventProcessId).HasColumnName("CA_Unsupported_Event_Process_Id");

                entity.Property(e => e.EndDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("End_DateTime");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.EventName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Event_Name");

                entity.Property(e => e.EventStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Event_Status");

                entity.Property(e => e.EventType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Event_Type");

                entity.Property(e => e.FailedCount).HasColumnName("Failed_Count");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.ProcessEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_End_Time");

                entity.Property(e => e.ProcessStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_Start_Time");

                entity.Property(e => e.StartDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_DateTime");

                entity.Property(e => e.TotalCount).HasColumnName("Total_Count");
            });

            modelBuilder.Entity<CashMovement>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.AccountId, "IX_CashMovements_AccountId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_CashMovements_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.PlacePrimaryId, "IX_CashMovements_PlacePrimaryId");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MatchStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.NumberId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CashMovements)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.CashMovements)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.PlacePrimary)
                    .WithMany(p => p.CashMovements)
                    .HasForeignKey(d => d.PlacePrimaryId);
            });

            modelBuilder.Entity<CashMovementsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CashMovementsAudit_AuditId");

                entity.ToTable("CashMovements_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MatchStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.NumberId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientPositionArchiveDtl>(entity =>
            {
                entity.HasKey(e => e.ClientPositionArchiveId)
                    .HasName("PK_ClientPositionArchive_ClientPositionArchiveId");

                entity.ToTable("Client_Position_Archive_Dtl");

                entity.Property(e => e.ClientPositionArchiveId).HasColumnName("Client_Position_Archive_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.Accounttype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AggSettleDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Settle_Date_Position");

                entity.Property(e => e.AggTradeDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Trade_Date_Position");

                entity.Property(e => e.ArchivalDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Archival_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.ClientPositionDtlId).HasColumnName("Client_Position_Dtl_Id");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.LegalAccountName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Account_Name");

                entity.Property(e => e.ManagementCompanyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Management_Company_Name");

                entity.Property(e => e.MemoCode)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Memo_Code");

                entity.Property(e => e.MemoQuantity).HasColumnName("Memo_Quantity");

                entity.Property(e => e.PositionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Date");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<ClientPositionArchiveDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientPositionArchiveAudit_AuditId");

                entity.ToTable("Client_Position_Archive_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.Accounttype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AggSettleDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Settle_Date_Position");

                entity.Property(e => e.AggTradeDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Trade_Date_Position");

                entity.Property(e => e.ArchivalDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Archival_Dt_Time_UTC");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.ClientPositionArchiveId).HasColumnName("Client_Position_Archive_Id");

                entity.Property(e => e.ClientPositionDtlId).HasColumnName("Client_Position_Dtl_Id");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.LegalAccountName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Account_Name");

                entity.Property(e => e.ManagementCompanyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Management_Company_Name");

                entity.Property(e => e.MemoCode)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Memo_Code");

                entity.Property(e => e.MemoQuantity).HasColumnName("Memo_Quantity");

                entity.Property(e => e.PositionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Date");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<ClientPositionDtl>(entity =>
            {
                entity.ToTable("Client_Position_Dtl");

                entity.HasIndex(e => new { e.TradingAccountNumber, e.Accounttype, e.BloombergId }, "idx_ClientPositionDtl_TradingAccNumAccTypeBBGId");

                entity.Property(e => e.ClientPositionDtlId).HasColumnName("Client_Position_Dtl_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.Accounttype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AggSettleDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Settle_Date_Position");

                entity.Property(e => e.AggTradeDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Trade_Date_Position");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.LegalAccountName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Account_Name");

                entity.Property(e => e.ManagementCompanyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Management_Company_Name");

                entity.Property(e => e.MemoCode)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Memo_Code");

                entity.Property(e => e.MemoQuantity).HasColumnName("Memo_Quantity");

                entity.Property(e => e.PositionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Date");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<ClientPositionDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientPositionDtlAudit_AuditId");

                entity.ToTable("Client_Position_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.Accounttype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AggSettleDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Settle_Date_Position");

                entity.Property(e => e.AggTradeDatePosition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Agg_Trade_Date_Position");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.ClientPositionDtlId).HasColumnName("Client_Position_Dtl_Id");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.LegalAccountName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Account_Name");

                entity.Property(e => e.ManagementCompanyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Management_Company_Name");

                entity.Property(e => e.MemoCode)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Memo_Code");

                entity.Property(e => e.MemoQuantity).HasColumnName("Memo_Quantity");

                entity.Property(e => e.PositionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Date");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<ClientSecurityContractInfo>(entity =>
            {
                entity.ToTable("Client_Security_ContractInfo");

                entity.HasIndex(e => e.InternalSecurityId, "idx_ClientSecurityContractInfo_InternalSecId");

                entity.Property(e => e.ClientSecurityContractInfoId).HasColumnName("Client_Security_ContractInfo_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExerciseCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Exercise_Currency");

                entity.Property(e => e.ExercisePrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Exercise_Price");

                entity.Property(e => e.ExerciseType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Exercise_Type");

                entity.Property(e => e.Indicator)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OptionMultiplier)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Option_Multiplier");

                entity.Property(e => e.SecurityExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Security_Expiry_Date");
            });

            modelBuilder.Entity<ClientSecurityContractInfoAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityContractInfoAudit_AuditId");

                entity.ToTable("Client_Security_ContractInfo_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientSecurityContractInfoId).HasColumnName("Client_Security_ContractInfo_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExerciseCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Exercise_Currency");

                entity.Property(e => e.ExercisePrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Exercise_Price");

                entity.Property(e => e.ExerciseType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Exercise_Type");

                entity.Property(e => e.Indicator)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.OptionMultiplier)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Option_Multiplier");

                entity.Property(e => e.SecurityExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Security_Expiry_Date");
            });

            modelBuilder.Entity<ClientSecurityCreditRating>(entity =>
            {
                entity.ToTable("Client_Security_CreditRating");

                entity.HasIndex(e => new { e.InternalSecurityId, e.RatingAgencyName, e.EffectiveDate }, "idx_ClientSecurityCreditRating_InternalSecIdRatingAgencyNmEffectiveDt");

                entity.Property(e => e.ClientSecurityCreditRatingId).HasColumnName("Client_Security_CreditRating_Id");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Effective_Date");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RatingAgencyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Rating_Agency_Name");

                entity.Property(e => e.RatingValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Rating_Value");
            });

            modelBuilder.Entity<ClientSecurityCreditRatingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityCreditRatingAudit_AuditId");

                entity.ToTable("Client_Security_CreditRating_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientSecurityCreditRatingId).HasColumnName("Client_Security_CreditRating_Id");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Effective_Date");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.RatingAgencyName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Rating_Agency_Name");

                entity.Property(e => e.RatingValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Rating_Value");
            });

            modelBuilder.Entity<ClientSecurityCrossReference>(entity =>
            {
                entity.ToTable("Client_Security_Cross_Reference");

                entity.HasIndex(e => new { e.InternalSecurityId, e.SecurityIdType }, "idx_ClientSecurityCrossReference_InternalSecIdSecurityIDtype");

                entity.HasIndex(e => e.SecurityId, "idx_ClientSecurityCrossReference_SecurityID");

                entity.HasIndex(e => new { e.SecurityIdType, e.SecurityId }, "idx_ClientSecurityCrossReference_SecurityIDTypeSecurityID");

                entity.Property(e => e.ClientSecurityCrossReferenceId).HasColumnName("Client_Security_Cross_Reference_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SecurityId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SecurityID")
                    .HasComment("");

                entity.Property(e => e.SecurityIdType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SecurityID_Type");
            });

            modelBuilder.Entity<ClientSecurityCrossReferenceAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityCrossReferenceAudit_AuditId");

                entity.ToTable("Client_Security_Cross_Reference_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientSecurityCrossReferenceId).HasColumnName("Client_Security_Cross_Reference_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.SecurityId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SecurityID");

                entity.Property(e => e.SecurityIdType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SecurityID_Type");
            });

            modelBuilder.Entity<ClientSecurityEquityDtl>(entity =>
            {
                entity.ToTable("Client_Security_Equity_Dtl");

                entity.HasIndex(e => e.InternalSecurityId, "idx_ClientSecurityEquityDtl_InternalSecId");

                entity.Property(e => e.ClientSecurityEquityDtlId).HasColumnName("Client_Security_Equity_Dtl_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FreeFloat)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Free_Float");

                entity.Property(e => e.FundLeverageAmount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Fund_Leverage_Amount");

                entity.Property(e => e.FundLeverageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Fund_Leverage_Date");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IpoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IPO_Date");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsFundLeveraged).HasColumnName("Is_Fund_Leveraged");

                entity.Property(e => e.IsPrimarySecurity).HasColumnName("Is_Primary_Security");

                entity.Property(e => e.RelativeIndex)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Relative_Index");

                entity.Property(e => e.SecurityExchange)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Security_Exchange");

                entity.Property(e => e.SharesOutstanding)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Shares_Outstanding");

                entity.Property(e => e.SharesOutstandingAllClass)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Shares_Outstanding_All_Class");
            });

            modelBuilder.Entity<ClientSecurityEquityDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityEquityDtlAudit_AuditId");

                entity.ToTable("Client_Security_Equity_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientSecurityEquityDtlId).HasColumnName("Client_Security_Equity_Dtl_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.FreeFloat)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Free_Float");

                entity.Property(e => e.FundLeverageAmount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Fund_Leverage_Amount");

                entity.Property(e => e.FundLeverageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Fund_Leverage_Date");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IpoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IPO_Date");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsFundLeveraged).HasColumnName("Is_Fund_Leveraged");

                entity.Property(e => e.IsPrimarySecurity).HasColumnName("Is_Primary_Security");

                entity.Property(e => e.RelativeIndex)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Relative_Index");

                entity.Property(e => e.SecurityExchange)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Security_Exchange");

                entity.Property(e => e.SharesOutstanding)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Shares_Outstanding");

                entity.Property(e => e.SharesOutstandingAllClass)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Shares_Outstanding_All_Class");
            });

            modelBuilder.Entity<ClientSecurityFixedIncomeDtl>(entity =>
            {
                entity.ToTable("Client_Security_FixedIncome_Dtl");

                entity.HasIndex(e => e.InternalSecurityId, "idx_ClientSecurityFixedIncomeDtl_InternalSecId");

                entity.Property(e => e.ClientSecurityFixedIncomeDtlId).HasColumnName("Client_Security_FixedIncome_Dtl_Id");

                entity.Property(e => e.AmountIssued)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Amount_Issued");

                entity.Property(e => e.AmountOutstanding)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Amount_Outstanding");

                entity.Property(e => e.BondType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Bond_Type");

                entity.Property(e => e.CapitalTriggerType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Capital_Trigger_Type");

                entity.Property(e => e.CocoEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Coco_EndDate");

                entity.Property(e => e.CocoTrigger)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Coco_Trigger");

                entity.Property(e => e.ConversionRatio)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Conversion_Ratio");

                entity.Property(e => e.Coupon).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CouponFrequency).HasColumnName("Coupon_Frequency");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Type");

                entity.Property(e => e.CvModelDeltaS)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Cv_Model_Delta_S");

                entity.Property(e => e.CvModelDeltaV)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Cv_Model_Delta_V");

                entity.Property(e => e.DayCount).HasColumnName("Day_Count");

                entity.Property(e => e.DurationCvModelEff)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Cv_Model_Eff");

                entity.Property(e => e.DurationModBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Mod_Bid");

                entity.Property(e => e.DurationOAsEffBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_O_as_Eff_Bid");

                entity.Property(e => e.DurationOAsSpreadBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_O_as_Spread_Bid");

                entity.Property(e => e.DurationSpreadBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Spread_Bid");

                entity.Property(e => e.DurationStochOAsModBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Stoch_O_as_Mod_Bid");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FirstCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("First_Coupon_Date");

                entity.Property(e => e.InterestAccrualDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Interest_Accrual_Date");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCapitalCoco).HasColumnName("Is_Capital_Coco");

                entity.Property(e => e.IsCoco).HasColumnName("Is_Coco");

                entity.Property(e => e.IsCocoTriggerMet).HasColumnName("Is_Coco_Trigger_Met");

                entity.Property(e => e.IsConvertible).HasColumnName("Is_Convertible");

                entity.Property(e => e.IsDefaulted).HasColumnName("Is_Defaulted");

                entity.Property(e => e.IsExtendible).HasColumnName("Is_Extendible");

                entity.Property(e => e.IsFloater).HasColumnName("Is_Floater");

                entity.Property(e => e.IsMakeWholeCall).HasColumnName("Is_Make_Whole_Call");

                entity.Property(e => e.IsNonViable).HasColumnName("Is_NonViable");

                entity.Property(e => e.IsPercentOfParQuoted).HasColumnName("Is_Percent_Of_Par_Quoted");

                entity.Property(e => e.IsPerpetual).HasColumnName("Is_Perpetual");

                entity.Property(e => e.IsPutable).HasColumnName("Is_Putable");

                entity.Property(e => e.IsSenior).HasColumnName("Is_Senior");

                entity.Property(e => e.IsSinkable).HasColumnName("Is_Sinkable");

                entity.Property(e => e.IsSoftCall).HasColumnName("Is_SoftCall");

                entity.Property(e => e.IsStillCallable).HasColumnName("Is_Still_Callable");

                entity.Property(e => e.IsZeroCoupon).HasColumnName("Is_Zero_Coupon");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Issue_Date");

                entity.Property(e => e.MandatoryConversion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mandatory_Conversion");

                entity.Property(e => e.MaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Maturity_Date");

                entity.Property(e => e.ReportedFactor)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Reported_Factor");

                entity.Property(e => e.SpreadOAsBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Spread_O_as_Bid");

                entity.Property(e => e.SpreadYtmGovtBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Spread_YTM_Govt_Bid");

                entity.Property(e => e.TradeStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trade_Status");
            });

            modelBuilder.Entity<ClientSecurityFixedIncomeDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityFixedIncomeDtlAudit_AuditId");

                entity.ToTable("Client_Security_FixedIncome_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AmountIssued)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Amount_Issued");

                entity.Property(e => e.AmountOutstanding)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Amount_Outstanding");

                entity.Property(e => e.BondType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Bond_Type");

                entity.Property(e => e.CapitalTriggerType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Capital_Trigger_Type");

                entity.Property(e => e.ClientSecurityFixedIncomeDtlId).HasColumnName("Client_Security_FixedIncome_Dtl_Id");

                entity.Property(e => e.CocoEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Coco_EndDate");

                entity.Property(e => e.CocoTrigger)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Coco_Trigger");

                entity.Property(e => e.ConversionRatio)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Conversion_Ratio");

                entity.Property(e => e.Coupon).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CouponFrequency).HasColumnName("Coupon_Frequency");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Coupon_Type");

                entity.Property(e => e.CvModelDeltaS)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Cv_Model_Delta_S");

                entity.Property(e => e.CvModelDeltaV)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Cv_Model_Delta_V");

                entity.Property(e => e.DayCount).HasColumnName("Day_Count");

                entity.Property(e => e.DurationCvModelEff)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Cv_Model_Eff");

                entity.Property(e => e.DurationModBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Mod_Bid");

                entity.Property(e => e.DurationOAsEffBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_O_as_Eff_Bid");

                entity.Property(e => e.DurationOAsSpreadBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_O_as_Spread_Bid");

                entity.Property(e => e.DurationSpreadBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Spread_Bid");

                entity.Property(e => e.DurationStochOAsModBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Duration_Stoch_O_as_Mod_Bid");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.FirstCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("First_Coupon_Date");

                entity.Property(e => e.InterestAccrualDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Interest_Accrual_Date");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsCapitalCoco).HasColumnName("Is_Capital_Coco");

                entity.Property(e => e.IsCoco).HasColumnName("Is_Coco");

                entity.Property(e => e.IsCocoTriggerMet).HasColumnName("Is_Coco_Trigger_Met");

                entity.Property(e => e.IsConvertible).HasColumnName("Is_Convertible");

                entity.Property(e => e.IsDefaulted).HasColumnName("Is_Defaulted");

                entity.Property(e => e.IsExtendible).HasColumnName("Is_Extendible");

                entity.Property(e => e.IsFloater).HasColumnName("Is_Floater");

                entity.Property(e => e.IsMakeWholeCall).HasColumnName("Is_Make_Whole_Call");

                entity.Property(e => e.IsNonViable).HasColumnName("Is_NonViable");

                entity.Property(e => e.IsPercentOfParQuoted).HasColumnName("Is_Percent_Of_Par_Quoted");

                entity.Property(e => e.IsPerpetual).HasColumnName("Is_Perpetual");

                entity.Property(e => e.IsPutable).HasColumnName("Is_Putable");

                entity.Property(e => e.IsSenior).HasColumnName("Is_Senior");

                entity.Property(e => e.IsSinkable).HasColumnName("Is_Sinkable");

                entity.Property(e => e.IsSoftCall).HasColumnName("Is_SoftCall");

                entity.Property(e => e.IsStillCallable).HasColumnName("Is_Still_Callable");

                entity.Property(e => e.IsZeroCoupon).HasColumnName("Is_Zero_Coupon");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Issue_Date");

                entity.Property(e => e.MandatoryConversion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mandatory_Conversion");

                entity.Property(e => e.MaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Maturity_Date");

                entity.Property(e => e.ReportedFactor)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Reported_Factor");

                entity.Property(e => e.SpreadOAsBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Spread_O_as_Bid");

                entity.Property(e => e.SpreadYtmGovtBid)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Spread_YTM_Govt_Bid");

                entity.Property(e => e.TradeStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trade_Status");
            });

            modelBuilder.Entity<ClientSecurityIndustryMapping>(entity =>
            {
                entity.ToTable("Client_Security_Industry_Mapping");

                entity.HasIndex(e => new { e.ClientSecurityIndustryId, e.InternalSecurityId }, "idx_ClientSecurityIndustryMapping_ClientSecIndustryIdInternalSecId");

                entity.Property(e => e.ClientSecurityIndustryMappingId).HasColumnName("Client_Security_Industry_Mapping_Id");

                entity.Property(e => e.ClientSecurityIndustryId).HasColumnName("Client_Security_Industry_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ClientSecurityIndustryMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityIndustryMappingAudit_AuditId");

                entity.ToTable("Client_Security_Industry_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientSecurityIndustryId).HasColumnName("Client_Security_Industry_Id");

                entity.Property(e => e.ClientSecurityIndustryMappingId).HasColumnName("Client_Security_Industry_Mapping_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<ClientSecurityIndustryMst>(entity =>
            {
                entity.HasKey(e => e.ClientSecurityIndustryId)
                    .HasName("PK_ClientSecurityIndustryMst_ClientSecurityIndustryId");

                entity.ToTable("Client_Security_Industry_Mst");

                entity.HasIndex(e => new { e.Sector, e.IndustryGroup, e.IndustrySubGroup }, "idx_ClientSecurityIndustryMst_SectorIndustryGrpIndustrySubGrp");

                entity.Property(e => e.ClientSecurityIndustryId).HasColumnName("Client_Security_Industry_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IndustryGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Industry_Group");

                entity.Property(e => e.IndustrySubGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Industry_Sub_Group");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientSecurityIndustryMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityIndustryMstAudit_AuditId");

                entity.ToTable("Client_Security_Industry_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientSecurityIndustryId).HasColumnName("Client_Security_Industry_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IndustryGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Industry_Group");

                entity.Property(e => e.IndustrySubGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Industry_Sub_Group");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientSecurityMst>(entity =>
            {
                entity.HasKey(e => e.InternalSecurityId)
                    .HasName("PK_ClientSecurityMst_InternalSecurityId");

                entity.ToTable("Client_Security_Mst");

                entity.HasIndex(e => e.CibcInternalId, "Unq_ClientSecurityMst_CIBCInternalID")
                    .IsUnique();

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.AssetClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Class");

                entity.Property(e => e.AssetSubClass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Sub_Class");

                entity.Property(e => e.CibcInternalId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CIBC_Internal_ID");

                entity.Property(e => e.CountryOfDomicile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Domicile");

                entity.Property(e => e.CountryOfIncorporation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Incorporation");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Issue");

                entity.Property(e => e.CountryOfRisk)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Risk");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.EquityCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Equity_Currency");

                entity.Property(e => e.ExchangeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Exchange_Code");

                entity.Property(e => e.FeedName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Feed_Name");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Issuer_Name");

                entity.Property(e => e.LocalCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Local_Currency");

                entity.Property(e => e.LongName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Long_Name");

                entity.Property(e => e.ParAmount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Par_Amount");

                entity.Property(e => e.ParentCompany)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Company");

                entity.Property(e => e.PrimaryExchangeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Exchange_Code");

                entity.Property(e => e.PrimaryExchangeCodeMic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Exchange_Code_MIC");

                entity.Property(e => e.RequestDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("request_Date_Time");

                entity.Property(e => e.RequestId)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Request_ID");

                entity.Property(e => e.SecurityType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Security_Type");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Short_Name");

                entity.Property(e => e.Ticker)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Version_Number");
            });

            modelBuilder.Entity<ClientSecurityMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityMstAudit_AuditId");

                entity.ToTable("Client_Security_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Class");

                entity.Property(e => e.AssetSubClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Sub_Class");

                entity.Property(e => e.CibcInternalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CIBC_Internal_ID");

                entity.Property(e => e.CountryOfDomicile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Domicile");

                entity.Property(e => e.CountryOfIncorporation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Incorporation");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Issue");

                entity.Property(e => e.CountryOfRisk)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Risk");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.EquityCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Equity_Currency");

                entity.Property(e => e.ExchangeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Exchange_Code");

                entity.Property(e => e.FeedName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Feed_Name");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Issuer_Name");

                entity.Property(e => e.LocalCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Local_Currency");

                entity.Property(e => e.LongName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Long_Name");

                entity.Property(e => e.ParAmount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Par_Amount");

                entity.Property(e => e.ParentCompany)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Parent_Company");

                entity.Property(e => e.PrimaryExchangeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Exchange_Code");

                entity.Property(e => e.PrimaryExchangeCodeMic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Primary_Exchange_Code_MIC");

                entity.Property(e => e.RequestDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("request_Date_Time");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Request_ID");

                entity.Property(e => e.SecurityType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Security_Type");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Short_Name");

                entity.Property(e => e.Ticker)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Version_Number");
            });

            modelBuilder.Entity<ClientSecurityUnderlyer>(entity =>
            {
                entity.ToTable("Client_Security_Underlyer");

                entity.HasIndex(e => new { e.InternalSecurityId, e.UnderlyingCibcInternalId }, "idx_ClientSecurityUnderlyer_InternalSecIdUnderlyingCIBCInternalId");

                entity.Property(e => e.ClientSecurityUnderlyerId).HasColumnName("Client_Security_Underlyer_Id");

                entity.Property(e => e.ConversionRatio)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Conversion_Ratio");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnderlyingCibcInternalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Underlying_CIBC_Internal_ID");
            });

            modelBuilder.Entity<ClientSecurityUnderlyerAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ClientSecurityUnderlyerAudit_AuditId");

                entity.ToTable("Client_Security_Underlyer_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientSecurityUnderlyerId).HasColumnName("Client_Security_Underlyer_Id");

                entity.Property(e => e.ConversionRatio)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("Conversion_Ratio");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.UnderlyingCibcInternalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Underlying_CIBC_Internal_ID");
            });

            modelBuilder.Entity<CorporateActionDetail>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.NumberCountPrimaryId, "IX_CorporateActionDetails_NumberCountPrimaryId");

                entity.HasOne(d => d.NumberCountPrimary)
                    .WithMany(p => p.CorporateActionDetails)
                    .HasForeignKey(d => d.NumberCountPrimaryId);
            });

            modelBuilder.Entity<CorporateActionDetailsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CorporateActionDetailsAudit_AuditId");

                entity.ToTable("CorporateActionDetails_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<CorporateActionOption>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.CaoptionNumberPrimaryId, "IX_CorporateActionOptions_CaoptionNumberPrimaryId");

                entity.HasIndex(e => e.FinancialInstrumentPrimaryId, "IX_CorporateActionOptions_FinancialInstrumentPrimaryId");

                entity.HasIndex(e => e.MessageDataPrimaryId, "IX_CorporateActionOptions_MessageDataPrimaryId");

                entity.Property(e => e.LinkStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CaoptionNumberPrimary)
                    .WithMany(p => p.CorporateActionOptions)
                    .HasForeignKey(d => d.CaoptionNumberPrimaryId);

                entity.HasOne(d => d.FinancialInstrumentPrimary)
                    .WithMany(p => p.CorporateActionOptions)
                    .HasForeignKey(d => d.FinancialInstrumentPrimaryId);

                entity.HasOne(d => d.MessageDataPrimary)
                    .WithMany(p => p.CorporateActionOptions)
                    .HasForeignKey(d => d.MessageDataPrimaryId);
            });

            modelBuilder.Entity<CorporateActionOptionsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CorporateActionOptionsAudit_AuditId");

                entity.ToTable("CorporateActionOptions_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.LinkStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryMst>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_CountryMst_CountryId");

                entity.ToTable("Country_Mst");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.Property(e => e.Alpha2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Alpha_2");

                entity.Property(e => e.Alpha3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Alpha_3");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Country_Code");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Country_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IntermediateRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Intermediate_Region");

                entity.Property(e => e.IntermediateRegionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Intermediate_Region_Code");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");

                entity.Property(e => e.IsInEea).HasColumnName("Is_In_EEA");

                entity.Property(e => e.Iso3166SubDivision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISO_3166_SubDivision");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Region_Code");

                entity.Property(e => e.SubRegion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Region");

                entity.Property(e => e.SubRegionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Region_Code");
            });

            modelBuilder.Entity<CountryMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CountryMstAudit_AuditId");

                entity.ToTable("Country_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.Alpha2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Alpha_2");

                entity.Property(e => e.Alpha3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Alpha_3");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Country_Code");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Country_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IntermediateRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Intermediate_Region");

                entity.Property(e => e.IntermediateRegionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Intermediate_Region_Code");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");

                entity.Property(e => e.IsInEea).HasColumnName("Is_In_EEA");

                entity.Property(e => e.Iso3166SubDivision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISO_3166_SubDivision");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Region_Code");

                entity.Property(e => e.SubRegion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Region");

                entity.Property(e => e.SubRegionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Region_Code");
            });

            modelBuilder.Entity<CurrencyMst>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PK_CurrencyMst_CurrencyId");

                entity.ToTable("Currency_Mst");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_Id");

                entity.Property(e => e.AlphabeticCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Alphabetic_Code");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Currency_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");

                entity.Property(e => e.MinorUnit).HasColumnName("Minor_Unit");

                entity.Property(e => e.NumericCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Numeric_Code");
            });

            modelBuilder.Entity<CurrencyMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_CurrencyMstAudit_AuditId");

                entity.ToTable("Currency_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AlphabeticCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Alphabetic_Code");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_Id");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Currency_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");

                entity.Property(e => e.MinorUnit).HasColumnName("Minor_Unit");

                entity.Property(e => e.NumericCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Numeric_Code");
            });

            modelBuilder.Entity<DbCache>(entity =>
            {
                entity.ToTable("DbCache");

                entity.Property(e => e.Id).HasMaxLength(900);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<EmailTemplateMst>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_EmailTemplateMst_TemplateId");

                entity.ToTable("Email_Template_Mst");

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.Property(e => e.EmailBcc).HasColumnName("Email_BCC");

                entity.Property(e => e.EmailCc).HasColumnName("Email_CC");

                entity.Property(e => e.EmailFrom).HasColumnName("Email_From");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(500)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.EmailTo).HasColumnName("Email_To");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_Utc")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateContent).HasColumnName("Template_Content");

                entity.Property(e => e.TemplateUniqueId).HasColumnName("Template_Unique_Id");
            });

            modelBuilder.Entity<EmailTemplateMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_EmailTemplateMstAudit_AuditId");

                entity.ToTable("Email_Template_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EmailBcc).HasColumnName("Email_BCC");

                entity.Property(e => e.EmailCc).HasColumnName("Email_CC");

                entity.Property(e => e.EmailFrom).HasColumnName("Email_From");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(500)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.EmailTo).HasColumnName("Email_To");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_Utc");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.TemplateContent).HasColumnName("Template_Content");

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.Property(e => e.TemplateUniqueId).HasColumnName("Template_Unique_Id");
            });

            modelBuilder.Entity<ErrorMst>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_ErrorMist_ErrorId");

                entity.ToTable("Error_Mst");

                entity.Property(e => e.ErrorId).HasColumnName("Error_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Error).HasMaxLength(1000);

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ErrorMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ErrorMstAudit_AuditId");

                entity.ToTable("Error_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.Error).HasMaxLength(1000);

                entity.Property(e => e.ErrorId).HasColumnName("Error_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<FileImportConfiguration>(entity =>
            {
                entity.ToTable("File_Import_Configuration");

                entity.Property(e => e.FileImportConfigurationId).HasColumnName("File_Import_Configuration_Id");

                entity.Property(e => e.DataFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Data_Format");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("File_Extension");

                entity.Property(e => e.FileType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("File_Type");

                entity.Property(e => e.ImportFileCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Import_File_Category");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RemoteFolderPath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Remote_Folder_Path");

                entity.Property(e => e.SolaceQueueName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Solace_Queue_Name");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.StorageFilePath)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Storage_File_Path");
            });

            modelBuilder.Entity<FileImportConfigurationAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_FileImportConfigurationAudit_AuditId");

                entity.ToTable("File_Import_Configuration_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.DataFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Data_Format");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("File_Extension");

                entity.Property(e => e.FileImportConfigurationId).HasColumnName("File_Import_Configuration_Id");

                entity.Property(e => e.FileType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("File_Type");

                entity.Property(e => e.ImportFileCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Import_File_Category");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.RemoteFolderPath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Remote_Folder_Path");

                entity.Property(e => e.SolaceQueueName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Solace_Queue_Name");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.StorageFilePath)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Storage_File_Path");
            });

            modelBuilder.Entity<FileImportMst>(entity =>
            {
                entity.ToTable("File_Import_Mst");

                entity.Property(e => e.FileImportMstId).HasColumnName("File_Import_Mst_Id");

                entity.Property(e => e.EntryBy)
                    .HasColumnName("Entry_By")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorDetails).HasColumnName("Error_Details");

                entity.Property(e => e.FailedMsgCount).HasComment("");

                entity.Property(e => e.FileCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("File_Category");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("File_name");

                entity.Property(e => e.FolderPath)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Folder_Path");

                entity.Property(e => e.ImportDate)
                    .HasColumnType("date")
                    .HasColumnName("Import_Date");

                entity.Property(e => e.ImportDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Import_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Modified_Date");

                entity.Property(e => e.ProcessEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_End_Time");

                entity.Property(e => e.ProcessStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_Start_Time");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<FileImportMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_FileImportMstAudit_AuditId");

                entity.ToTable("File_Import_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ErrorDetails).HasColumnName("Error_Details");

                entity.Property(e => e.FileCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("File_Category");

                entity.Property(e => e.FileImportMstId).HasColumnName("File_Import_Mst_Id");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("File_name");

                entity.Property(e => e.FolderPath)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Folder_Path");

                entity.Property(e => e.ImportDate)
                    .HasColumnType("date")
                    .HasColumnName("Import_Date");

                entity.Property(e => e.ImportDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Import_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Modified_Date");

                entity.Property(e => e.ProcessEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_End_Time");

                entity.Property(e => e.ProcessStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Process_Start_Time");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<FinancialInstrument>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.CurrencyPrimaryId, "IX_FinancialInstruments_CurrencyPrimaryId");

                entity.HasIndex(e => e.IndicatorPrimaryId, "IX_FinancialInstruments_IndicatorPrimaryId");

                entity.HasIndex(e => e.PlacePrimaryId, "IX_FinancialInstruments_PlacePrimaryId");

                entity.HasIndex(e => e.PricePrimaryId, "IX_FinancialInstruments_PricePrimaryId");

                entity.HasOne(d => d.CurrencyPrimary)
                    .WithMany(p => p.FinancialInstruments)
                    .HasForeignKey(d => d.CurrencyPrimaryId);

                entity.HasOne(d => d.IndicatorPrimary)
                    .WithMany(p => p.FinancialInstruments)
                    .HasForeignKey(d => d.IndicatorPrimaryId);

                entity.HasOne(d => d.PlacePrimary)
                    .WithMany(p => p.FinancialInstruments)
                    .HasForeignKey(d => d.PlacePrimaryId);

                entity.HasOne(d => d.PricePrimary)
                    .WithMany(p => p.FinancialInstruments)
                    .HasForeignKey(d => d.PricePrimaryId);
            });

            modelBuilder.Entity<FinancialInstrumentAttribute>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.IndicatorPrimaryId, "IX_FinancialInstrumentAttributes_IndicatorPrimaryId");

                entity.HasIndex(e => e.PlacePrimaryId, "IX_FinancialInstrumentAttributes_PlacePrimaryId");

                entity.HasIndex(e => e.PricePrimaryId, "IX_FinancialInstrumentAttributes_PricePrimaryId");

                entity.HasOne(d => d.IndicatorPrimary)
                    .WithMany(p => p.FinancialInstrumentAttributes)
                    .HasForeignKey(d => d.IndicatorPrimaryId);

                entity.HasOne(d => d.PlacePrimary)
                    .WithMany(p => p.FinancialInstrumentAttributes)
                    .HasForeignKey(d => d.PlacePrimaryId);

                entity.HasOne(d => d.PricePrimary)
                    .WithMany(p => p.FinancialInstrumentAttributes)
                    .HasForeignKey(d => d.PricePrimaryId);
            });

            modelBuilder.Entity<FinancialInstrumentAttributesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_FinancialInstrumentAttributesAudit_AuditId");

                entity.ToTable("FinancialInstrumentAttributes_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<FinancialInstrumentsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_FinancialInstrumentsAudit_AuditId");

                entity.ToTable("FinancialInstruments_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<FunctionOfMessage>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);
            });

            modelBuilder.Entity<FunctionOfMessagesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_FunctionOfMessagesAudit_AuditId");

                entity.ToTable("FunctionOfMessages_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<GeneralInformation>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.FunctionOfMessagePrimaryId, "IX_GeneralInformations_FunctionOfMessagePrimaryId");

                entity.HasIndex(e => e.PageNumberPrimaryId, "IX_GeneralInformations_PageNumberPrimaryId");

                entity.HasIndex(e => e.PreparationDateTimePrimaryId, "IX_GeneralInformations_PreparationDateTimePrimaryId");

                entity.HasOne(d => d.FunctionOfMessagePrimary)
                    .WithMany(p => p.GeneralInformations)
                    .HasForeignKey(d => d.FunctionOfMessagePrimaryId);

                entity.HasOne(d => d.PageNumberPrimary)
                    .WithMany(p => p.GeneralInformations)
                    .HasForeignKey(d => d.PageNumberPrimaryId);

                entity.HasOne(d => d.PreparationDateTimePrimary)
                    .WithMany(p => p.GeneralInformations)
                    .HasForeignKey(d => d.PreparationDateTimePrimaryId);
            });

            modelBuilder.Entity<GeneralInformationsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GeneralInformationsAudit_AuditId");

                entity.ToTable("GeneralInformations_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<GlodenRecordSourceMapping>(entity =>
            {
                entity.ToTable("Gloden_Record_Source_Mapping");

                entity.Property(e => e.GlodenRecordSourceMappingId).HasColumnName("Gloden_Record_Source_Mapping_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReceivedCaEventDtlId).HasColumnName("Received_CA_Event_Dtl_Id");
            });

            modelBuilder.Entity<GlodenRecordSourceMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GlodenRecordSourceMappingAudit_AuditId");

                entity.ToTable("Gloden_Record_Source_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GlodenRecordSourceMappingId).HasColumnName("Gloden_Record_Source_Mapping_Id");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.ReceivedCaEventDtlId).HasColumnName("Received_CA_Event_Dtl_Id");
            });

            modelBuilder.Entity<GoldenRecordInternalChatDetail>(entity =>
            {
                entity.HasKey(e => e.GoldenRecordInternalChatId)
                    .HasName("PK_GoldenRecordInternalChatDtl_GoldenRecordInternalChatDtlId");

                entity.ToTable("Golden_Record_Internal_Chat_Details");

                entity.Property(e => e.GoldenRecordInternalChatId).HasColumnName("Golden_Record_Internal_Chat_Id");

                entity.Property(e => e.ChatText).HasColumnName("Chat_Text");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OriginatedFromAction)
                    .HasMaxLength(100)
                    .HasColumnName("Originated_From_Action");
            });

            modelBuilder.Entity<GoldenRecordInternalChatDetailsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GoldenRecordInternalChatDtlAudit_AuditId");

                entity.ToTable("Golden_Record_Internal_Chat_Details_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ChatText).HasColumnName("Chat_Text");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.GoldenRecordInternalChatId).HasColumnName("Golden_Record_Internal_Chat_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.OriginatedFromAction)
                    .HasMaxLength(100)
                    .HasColumnName("Originated_From_Action");
            });

            modelBuilder.Entity<GoldenRecordMst>(entity =>
            {
                entity.HasKey(e => e.GoldenRecordId)
                    .HasName("PK_GoldenRecordMst_GoldenRecordId");

                entity.ToTable("Golden_Record_Mst");

                entity.HasIndex(e => e.InternalSecurityId, "idx_GoldenRecordMst_InternalSecurityId");

                entity.HasIndex(e => e.IsActive, "idx_GoldenRecordMst_IsActive");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.BloombergId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.EarlyResponseDeadlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Early_Response_Deadline_Date");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.EventMvc)
                    .HasMaxLength(5)
                    .HasColumnName("Event_MVC");

                entity.Property(e => e.EventName)
                    .HasMaxLength(10)
                    .HasColumnName("Event_Name");

                entity.Property(e => e.GoldenRecordCreateDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Golden_Record_Create_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordMatchDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Golden_Record_Match_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordPriority).HasColumnName("Golden_Record_Priority");

                entity.Property(e => e.GoldenRecordStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Golden_Record_Status");

                entity.Property(e => e.GpdDateType)
                    .HasMaxLength(100)
                    .HasColumnName("GPD_Date_Type");

                entity.Property(e => e.HasEventPosition).HasColumnName("Has_Event_Position");

                entity.Property(e => e.HasTotalPendingCancellationQty)
                    .HasColumnName("Has_Total_Pending_Cancellation_Qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasTotalPendingInstructionsQty)
                    .HasColumnName("Has_Total_Pending_Instructions_Qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasTotalUnelectedQty)
                    .HasColumnName("Has_Total_Unelected_Qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InactiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Inactive_Date");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAdditionalTextUpdated).HasColumnName("Is_Additional_Text_Updated");

                entity.Property(e => e.IsAutoStp).HasColumnName("Is_Auto_STP");

                entity.Property(e => e.IsInformationConditionsUpdated).HasColumnName("Is_Information_Conditions_Updated");

                entity.Property(e => e.IsInformationToComplyUpdated).HasColumnName("Is_Information_To_Comply_Updated");

                entity.Property(e => e.IsNarrativeVersionUpdated).HasColumnName("Is_Narrative_Version_Updated");

                entity.Property(e => e.IsPositionCaptured)
                    .HasColumnName("Is_Position_Captured")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTaxationConditionsUpdated).HasColumnName("Is_Taxation_Conditions_Updated");

                entity.Property(e => e.IsTouched).HasColumnName("Is_Touched");

                entity.Property(e => e.IsoChangeType)
                    .HasMaxLength(1000)
                    .HasColumnName("ISO_Change_Type");

                entity.Property(e => e.IsoEffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_Effective_Date");

                entity.Property(e => e.IsoExDividendOrDistributionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_ExDividend_Or_Distribution_Date");

                entity.Property(e => e.IsoExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_Expiry_Date");

                entity.Property(e => e.IsoOfferor)
                    .HasMaxLength(1000)
                    .HasColumnName("ISO_Offeror");

                entity.Property(e => e.IsoRecordDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_Record_Date");

                entity.Property(e => e.MarketDeadlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Market_Deadline_Date");

                entity.Property(e => e.MatchDateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Match_Date_Name");

                entity.Property(e => e.MatchStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Match_status");

                entity.Property(e => e.MergedRecordId).HasColumnName("Merged_Record_Id");

                entity.Property(e => e.PositionFixDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Fix_Date");

                entity.Property(e => e.ProtectDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Protect_Date");

                entity.Property(e => e.ResponseDeadlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Response_Deadline_Date");

                entity.Property(e => e.ReviewByDate)
                    .HasColumnType("date")
                    .HasColumnName("Review_By_Date");

                entity.Property(e => e.SecurityDescription).HasColumnName("Security_Description");

                entity.Property(e => e.SecurityIdType)
                    .HasMaxLength(100)
                    .HasColumnName("SecurityID_Type");

                entity.Property(e => e.SecurityIdValue)
                    .HasMaxLength(100)
                    .HasColumnName("SecurityID_Value");

                entity.Property(e => e.ValidityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Validity_Date");
            });

            modelBuilder.Entity<GoldenRecordMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GoldenRecordMstAudit_AuditId");

                entity.ToTable("Golden_Record_Mst_Audit");

                entity.HasIndex(e => e.GoldenRecordId, "idx_GoldenRecordMstAudit_GoldenRecordId");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.EarlyResponseDeadlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Early_Response_Deadline_Date");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.EventMvc)
                    .HasMaxLength(5)
                    .HasColumnName("Event_MVC");

                entity.Property(e => e.EventName)
                    .HasMaxLength(10)
                    .HasColumnName("Event_Name");

                entity.Property(e => e.GoldenRecordCreateDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Golden_Record_Create_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.GoldenRecordMatchDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Golden_Record_Match_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordPriority).HasColumnName("Golden_Record_Priority");

                entity.Property(e => e.GoldenRecordStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Golden_Record_Status");

                entity.Property(e => e.GpdDateType)
                    .HasMaxLength(100)
                    .HasColumnName("GPD_Date_Type");

                entity.Property(e => e.HasEventPosition).HasColumnName("Has_Event_Position");

                entity.Property(e => e.HasTotalPendingCancellationQty).HasColumnName("Has_Total_Pending_Cancellation_Qty");

                entity.Property(e => e.HasTotalPendingInstructionsQty).HasColumnName("Has_Total_Pending_Instructions_Qty");

                entity.Property(e => e.HasTotalUnelectedQty).HasColumnName("Has_Total_Unelected_Qty");

                entity.Property(e => e.InactiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Inactive_Date");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsAdditionalTextUpdated).HasColumnName("Is_Additional_Text_Updated");

                entity.Property(e => e.IsAutoStp).HasColumnName("Is_Auto_STP");

                entity.Property(e => e.IsInformationConditionsUpdated).HasColumnName("Is_Information_Conditions_Updated");

                entity.Property(e => e.IsInformationToComplyUpdated).HasColumnName("Is_Information_To_Comply_Updated");

                entity.Property(e => e.IsNarrativeVersionUpdated).HasColumnName("Is_Narrative_Version_Updated");

                entity.Property(e => e.IsPositionCaptured).HasColumnName("Is_Position_Captured");

                entity.Property(e => e.IsTaxationConditionsUpdated).HasColumnName("Is_Taxation_Conditions_Updated");

                entity.Property(e => e.IsTouched).HasColumnName("Is_Touched");

                entity.Property(e => e.IsoChangeType)
                    .HasMaxLength(1000)
                    .HasColumnName("ISO_Change_Type");

                entity.Property(e => e.IsoEffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_Effective_Date");

                entity.Property(e => e.IsoExDividendOrDistributionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_ExDividend_Or_Distribution_Date");

                entity.Property(e => e.IsoExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_Expiry_Date");

                entity.Property(e => e.IsoOfferor)
                    .HasMaxLength(1000)
                    .HasColumnName("ISO_Offeror");

                entity.Property(e => e.IsoRecordDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ISO_Record_Date");

                entity.Property(e => e.MarketDeadlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Market_Deadline_Date");

                entity.Property(e => e.MatchDateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Match_Date_Name");

                entity.Property(e => e.MatchStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Match_status");

                entity.Property(e => e.MergedRecordId).HasColumnName("Merged_Record_Id");

                entity.Property(e => e.PositionFixDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Fix_Date");

                entity.Property(e => e.ProtectDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Protect_Date");

                entity.Property(e => e.ResponseDeadlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Response_Deadline_Date");

                entity.Property(e => e.ReviewByDate)
                    .HasColumnType("date")
                    .HasColumnName("Review_By_Date");

                entity.Property(e => e.SecurityDescription).HasColumnName("Security_Description");

                entity.Property(e => e.SecurityIdType)
                    .HasMaxLength(100)
                    .HasColumnName("SecurityID_Type");

                entity.Property(e => e.SecurityIdValue)
                    .HasMaxLength(100)
                    .HasColumnName("SecurityID_Value");

                entity.Property(e => e.ValidityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Validity_Date");
            });

            modelBuilder.Entity<GoldenRecordResponseDeadlineDatesDtl>(entity =>
            {
                entity.ToTable("Golden_Record_Response_Deadline_Dates_Dtl");

                entity.Property(e => e.GoldenRecordResponseDeadlineDatesDtlId).HasColumnName("Golden_Record_Response_Deadline_Dates_Dtl_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateType)
                    .HasMaxLength(500)
                    .HasColumnName("Date_Type");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GoldenRecordResponseDeadlineDatesDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GoldenRecordResponseDeadlineDatesDtlAudit_AuditId");

                entity.ToTable("Golden_Record_Response_Deadline_Dates_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateType)
                    .HasMaxLength(500)
                    .HasColumnName("Date_Type");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.GoldenRecordResponseDeadlineDatesDtlId).HasColumnName("Golden_Record_Response_Deadline_Dates_Dtl_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<GoldenRecordSourceEventMapping>(entity =>
            {
                entity.ToTable("Golden_Record_Source_Event_Mapping");

                entity.HasIndex(e => new { e.GoldenRecordId, e.SourceName, e.CorpId }, "Unq_GoldenRecordSourceEventMapping_GoldenRecIdSrcNmCORPId")
                    .IsUnique();

                entity.Property(e => e.GoldenRecordSourceEventMappingId).HasColumnName("Golden_Record_Source_Event_Mapping_Id");

                entity.Property(e => e.CorpId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CORP_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FunctionOfMessage)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Function_Of_Message");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Message_Type");

                entity.Property(e => e.ReceivedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Received_Id");

                entity.Property(e => e.SemeRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<GoldenRecordSourceEventMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GoldenRecordSourceEventMappingAudit_AuditId");

                entity.ToTable("Golden_Record_Source_Event_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CorpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CORP_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.FunctionOfMessage)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Function_Of_Message");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.GoldenRecordSourceEventMappingId).HasColumnName("Golden_Record_Source_Event_Mapping_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Message_Type");

                entity.Property(e => e.ReceivedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Received_Id");

                entity.Property(e => e.SemeRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<GoldenRecordSourceEventMt568Mapping>(entity =>
            {
                entity.ToTable("Golden_Record_Source_EventMT568_Mapping");

                entity.HasIndex(e => new { e.GoldenRecordId, e.SourceName, e.CorpId }, "Unq_GoldenRecordSourceEventMT568Mapping_GoldenRecIdSrcNmCORPId")
                    .IsUnique();

                entity.Property(e => e.GoldenRecordSourceEventMt568MappingId).HasColumnName("Golden_Record_Source_EventMT568_Mapping_Id");

                entity.Property(e => e.CorpId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CORP_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReceivedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Received_Id");

                entity.Property(e => e.SemeRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<GoldenRecordSourceEventMt568MappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GoldenRecordSourceEventMT568MappingAudit_AuditId");

                entity.ToTable("Golden_Record_Source_EventMT568_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CorpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CORP_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.GoldenRecordSourceEventMt568MappingId).HasColumnName("Golden_Record_Source_EventMT568_Mapping_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.ReceivedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Received_Id");

                entity.Property(e => e.SemeRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<HolidayMst>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK_HolidayMst_HolidayId");

                entity.ToTable("Holiday_Mst");

                entity.Property(e => e.HolidayId).HasColumnName("Holiday_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.HolidayDate)
                    .HasColumnType("date")
                    .HasColumnName("Holiday_Date");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(200)
                    .HasColumnName("Holiday_Name");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HolidayMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_HolidayMstAudit_AuditId");

                entity.ToTable("Holiday_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.HolidayDate)
                    .HasColumnType("date")
                    .HasColumnName("Holiday_Date");

                entity.Property(e => e.HolidayId).HasColumnName("Holiday_Id");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(200)
                    .HasColumnName("Holiday_Name");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            });

            modelBuilder.Entity<IntermediateSecuritiesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_IntermediateSecuritiesAudit_AuditId");

                entity.ToTable("IntermediateSecurities_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.FinancialInstrumentPrimaryId).HasColumnName("financialInstrumentPrimaryId");

                entity.Property(e => e.PeriodPrimaryId).HasColumnName("periodPrimaryId");

                entity.Property(e => e.QuantityOfInstrumentPrimaryId).HasColumnName("quantityOfInstrumentPrimaryId");
            });

            modelBuilder.Entity<IntermediateSecurity>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.PricePrimaryId, "IX_IntermediateSecurities_PricePrimaryId");

                entity.HasIndex(e => e.RatePrimaryId, "IX_IntermediateSecurities_RatePrimaryId");

                entity.HasIndex(e => e.FinancialInstrumentPrimaryId, "IX_IntermediateSecurities_financialInstrumentPrimaryId");

                entity.HasIndex(e => e.PeriodPrimaryId, "IX_IntermediateSecurities_periodPrimaryId");

                entity.HasIndex(e => e.QuantityOfInstrumentPrimaryId, "IX_IntermediateSecurities_quantityOfInstrumentPrimaryId");

                entity.Property(e => e.FinancialInstrumentPrimaryId).HasColumnName("financialInstrumentPrimaryId");

                entity.Property(e => e.PeriodPrimaryId).HasColumnName("periodPrimaryId");

                entity.Property(e => e.QuantityOfInstrumentPrimaryId).HasColumnName("quantityOfInstrumentPrimaryId");

                entity.HasOne(d => d.FinancialInstrumentPrimary)
                    .WithMany(p => p.IntermediateSecurities)
                    .HasForeignKey(d => d.FinancialInstrumentPrimaryId);

                entity.HasOne(d => d.PeriodPrimary)
                    .WithMany(p => p.IntermediateSecurities)
                    .HasForeignKey(d => d.PeriodPrimaryId)
                    .HasConstraintName("FK_IntermediateSecurities_Period_PeriodPrimaryId");

                entity.HasOne(d => d.PricePrimary)
                    .WithMany(p => p.IntermediateSecurities)
                    .HasForeignKey(d => d.PricePrimaryId);

                entity.HasOne(d => d.QuantityOfInstrumentPrimary)
                    .WithMany(p => p.IntermediateSecurities)
                    .HasForeignKey(d => d.QuantityOfInstrumentPrimaryId)
                    .HasConstraintName("FK_IntermediateSecurities_QuantityOfInstrument_QuantityOfInstrumentPrimaryId");

                entity.HasOne(d => d.RatePrimary)
                    .WithMany(p => p.IntermediateSecurities)
                    .HasForeignKey(d => d.RatePrimaryId);
            });

            modelBuilder.Entity<LinkedMessage>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.LinkedReferencePrimaryId, "IX_LinkedMessages_LinkedReferencePrimaryId");

                entity.HasIndex(e => e.MgeneralInformationPrimaryId, "IX_LinkedMessages_MGeneralInformationPrimaryId");

                entity.Property(e => e.MgeneralInformationPrimaryId).HasColumnName("MGeneralInformationPrimaryId");

                entity.HasOne(d => d.LinkedReferencePrimary)
                    .WithMany(p => p.LinkedMessages)
                    .HasForeignKey(d => d.LinkedReferencePrimaryId);

                entity.HasOne(d => d.MgeneralInformationPrimary)
                    .WithMany(p => p.LinkedMessages)
                    .HasForeignKey(d => d.MgeneralInformationPrimaryId);
            });

            modelBuilder.Entity<LinkedMessagesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_LinkedMessagesAudit_AuditId");

                entity.ToTable("LinkedMessages_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MgeneralInformationPrimaryId).HasColumnName("MGeneralInformationPrimaryId");
            });

            modelBuilder.Entity<LinkedReference>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);
            });

            modelBuilder.Entity<LinkedReferencesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_LinkedReferencesAudit_AuditId");

                entity.ToTable("LinkedReferences_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mamount>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MAmounts");

                entity.HasIndex(e => e.McashMovementPrimaryId, "IX_MAmounts_MCashMovementPrimaryId");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.HasOne(d => d.McashMovementPrimary)
                    .WithMany(p => p.Mamounts)
                    .HasForeignKey(d => d.McashMovementPrimaryId);
            });

            modelBuilder.Entity<MamountsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MAmountsAudit_AuditId");

                entity.ToTable("MAmounts_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");
            });

            modelBuilder.Entity<Mbalance>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MBalances");

                entity.HasIndex(e => e.MaccountInformationPrimaryId, "IX_MBalances_MAccountInformationPrimaryId");

                entity.HasIndex(e => e.MintermediateSecuritiesPrimaryId, "IX_MBalances_MIntermediateSecuritiesPrimaryId");

                entity.Property(e => e.MaccountInformationPrimaryId).HasColumnName("MAccountInformationPrimaryId");

                entity.Property(e => e.MintermediateSecuritiesPrimaryId).HasColumnName("MIntermediateSecuritiesPrimaryId");

                entity.HasOne(d => d.MaccountInformationPrimary)
                    .WithMany(p => p.Mbalances)
                    .HasForeignKey(d => d.MaccountInformationPrimaryId);

                entity.HasOne(d => d.MintermediateSecuritiesPrimary)
                    .WithMany(p => p.Mbalances)
                    .HasForeignKey(d => d.MintermediateSecuritiesPrimaryId);
            });

            modelBuilder.Entity<MbalancesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MBalancesAudit_AuditId");

                entity.ToTable("MBalances_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MaccountInformationPrimaryId).HasColumnName("MAccountInformationPrimaryId");

                entity.Property(e => e.MintermediateSecuritiesPrimaryId).HasColumnName("MIntermediateSecuritiesPrimaryId");
            });

            modelBuilder.Entity<McaoptionNumber>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MCAOptionNumber");
            });

            modelBuilder.Entity<McaoptionNumberAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MCAOptionNumberAudit_AuditId");

                entity.ToTable("MCAOptionNumber_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<McouponNumber>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MCouponNumbers");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MCouponNumbers_MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.McouponNumbers)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);
            });

            modelBuilder.Entity<McouponNumbersAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MCouponNumbersAudit_AuditId");

                entity.ToTable("MCouponNumbers_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");
            });

            modelBuilder.Entity<Mcurrency>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MCurrency");
            });

            modelBuilder.Entity<McurrencyAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MCurrencyAudit_AuditId");

                entity.ToTable("MCurrency_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mdate>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MDate");
            });

            modelBuilder.Entity<MdateAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MDateAudit_AuditId");

                entity.ToTable("MDate_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<MdateTime>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MDateTime");

                entity.HasIndex(e => e.McashMovementPrimaryId, "IX_MDateTime_MCashMovementPrimaryId");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MDateTime_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_MDateTime_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentAttributesPrimaryId, "IX_MDateTime_MFinancialInstrumentAttributesPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentPrimaryId, "IX_MDateTime_MFinancialInstrumentPrimaryId");

                entity.HasIndex(e => e.MintermediateSecuritiesPrimaryId, "IX_MDateTime_MIntermediateSecuritiesPrimaryId");

                entity.HasIndex(e => e.MsecurityMovementPrimaryId, "IX_MDateTime_MSecurityMovementPrimaryId");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");

                entity.Property(e => e.MintermediateSecuritiesPrimaryId).HasColumnName("MIntermediateSecuritiesPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");

                entity.Property(e => e.Utcindicator).HasColumnName("UTCIndicator");

                entity.HasOne(d => d.McashMovementPrimary)
                    .WithMany(p => p.MdateTimes)
                    .HasForeignKey(d => d.McashMovementPrimaryId);

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.MdateTimes)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.MdateTimes)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentAttributesPrimary)
                    .WithMany(p => p.MdateTimes)
                    .HasForeignKey(d => d.MfinancialInstrumentAttributesPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentPrimary)
                    .WithMany(p => p.MdateTimes)
                    .HasForeignKey(d => d.MfinancialInstrumentPrimaryId);

                entity.HasOne(d => d.MintermediateSecuritiesPrimary)
                    .WithMany(p => p.MdateTimes)
                    .HasForeignKey(d => d.MintermediateSecuritiesPrimaryId);

                entity.HasOne(d => d.MsecurityMovementPrimary)
                    .WithMany(p => p.MdateTimes)
                    .HasForeignKey(d => d.MsecurityMovementPrimaryId);
            });

            modelBuilder.Entity<MdateTimeAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MDateTimeAudit_AuditId");

                entity.ToTable("MDateTime_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");

                entity.Property(e => e.MintermediateSecuritiesPrimaryId).HasColumnName("MIntermediateSecuritiesPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");

                entity.Property(e => e.Utcindicator).HasColumnName("UTCIndicator");
            });

            modelBuilder.Entity<MessageData>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.AdditionalInformationPrimaryId, "IX_MessageDatas_AdditionalInformationPrimaryId");

                entity.HasIndex(e => e.CorporateActionDetailsPrimaryId, "IX_MessageDatas_CorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.GeneralInformationPrimaryId, "IX_MessageDatas_GeneralInformationPrimaryId");

                entity.HasIndex(e => e.IntermediateSecuritiesPrimaryId, "IX_MessageDatas_IntermediateSecuritiesPrimaryId");

                entity.HasIndex(e => e.UnderlyingSecuritiesPrimaryId, "IX_MessageDatas_UnderlyingSecuritiesPrimaryId");

                entity.HasOne(d => d.AdditionalInformationPrimary)
                    .WithMany(p => p.MessageDatas)
                    .HasForeignKey(d => d.AdditionalInformationPrimaryId);

                entity.HasOne(d => d.CorporateActionDetailsPrimary)
                    .WithMany(p => p.MessageDatas)
                    .HasForeignKey(d => d.CorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.GeneralInformationPrimary)
                    .WithMany(p => p.MessageDatas)
                    .HasForeignKey(d => d.GeneralInformationPrimaryId);

                entity.HasOne(d => d.IntermediateSecuritiesPrimary)
                    .WithMany(p => p.MessageDatas)
                    .HasForeignKey(d => d.IntermediateSecuritiesPrimaryId);

                entity.HasOne(d => d.UnderlyingSecuritiesPrimary)
                    .WithMany(p => p.MessageDatas)
                    .HasForeignKey(d => d.UnderlyingSecuritiesPrimaryId);
            });

            modelBuilder.Entity<MessageDatasAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MessageDatasAudit_AuditId");

                entity.ToTable("MessageDatas_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mflag>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MFlag");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MFlag_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_MFlag_MCorporateActionOptionPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.Mflags)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.Mflags)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);
            });

            modelBuilder.Entity<MflagAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MFlagAudit_AuditId");

                entity.ToTable("MFlag_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");
            });

            modelBuilder.Entity<Mindicator>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MIndicators");

                entity.HasIndex(e => e.McashMovementPrimaryId, "IX_MIndicators_MCashMovementPrimaryId");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MIndicators_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_MIndicators_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.MgeneralInformationPrimaryId, "IX_MIndicators_MGeneralInformationPrimaryId");

                entity.HasIndex(e => e.MintermediateSecuritiesPrimaryId, "IX_MIndicators_MIntermediateSecuritiesPrimaryId");

                entity.HasIndex(e => e.MsecurityMovementPrimaryId, "IX_MIndicators_MSecurityMovementPrimaryId");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MgeneralInformationPrimaryId).HasColumnName("MGeneralInformationPrimaryId");

                entity.Property(e => e.MintermediateSecuritiesPrimaryId).HasColumnName("MIntermediateSecuritiesPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");

                entity.HasOne(d => d.McashMovementPrimary)
                    .WithMany(p => p.Mindicators)
                    .HasForeignKey(d => d.McashMovementPrimaryId);

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.Mindicators)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.Mindicators)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.MgeneralInformationPrimary)
                    .WithMany(p => p.Mindicators)
                    .HasForeignKey(d => d.MgeneralInformationPrimaryId);

                entity.HasOne(d => d.MintermediateSecuritiesPrimary)
                    .WithMany(p => p.Mindicators)
                    .HasForeignKey(d => d.MintermediateSecuritiesPrimaryId);

                entity.HasOne(d => d.MsecurityMovementPrimary)
                    .WithMany(p => p.Mindicators)
                    .HasForeignKey(d => d.MsecurityMovementPrimaryId);
            });

            modelBuilder.Entity<MindicatorsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MIndicatorsAudit_AuditId");

                entity.ToTable("MIndicators_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MgeneralInformationPrimaryId).HasColumnName("MGeneralInformationPrimaryId");

                entity.Property(e => e.MintermediateSecuritiesPrimaryId).HasColumnName("MIntermediateSecuritiesPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");
            });

            modelBuilder.Entity<Mnarrative>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MNarratives");

                entity.HasIndex(e => e.MadditionalInformationPrimaryId, "IX_MNarratives_MAdditionalInformationPrimaryId");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MNarratives_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_MNarratives_MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.HasOne(d => d.MadditionalInformationPrimary)
                    .WithMany(p => p.Mnarratives)
                    .HasForeignKey(d => d.MadditionalInformationPrimaryId);

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.Mnarratives)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.Mnarratives)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);
            });

            modelBuilder.Entity<MnarrativesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MNarrativesAudit_AuditId");

                entity.ToTable("MNarratives_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");
            });

            modelBuilder.Entity<Mplace>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MPlaces");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MPlaces_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_MPlaces_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.MsecurityMovementPrimaryId, "IX_MPlaces_MSecurityMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.Mplaces)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.Mplaces)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.MsecurityMovementPrimary)
                    .WithMany(p => p.Mplaces)
                    .HasForeignKey(d => d.MsecurityMovementPrimaryId);
            });

            modelBuilder.Entity<MplacesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MPlacesAudit_AuditId");

                entity.ToTable("MPlaces_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");
            });

            modelBuilder.Entity<Mprice>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MPrices");

                entity.HasIndex(e => e.McashMovementPrimaryId, "IX_MPrices_MCashMovementPrimaryId");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MPrices_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_MPrices_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.MsecurityMovementPrimaryId, "IX_MPrices_MSecurityMovementPrimaryId");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");

                entity.HasOne(d => d.McashMovementPrimary)
                    .WithMany(p => p.Mprices)
                    .HasForeignKey(d => d.McashMovementPrimaryId);

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.Mprices)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.Mprices)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.MsecurityMovementPrimary)
                    .WithMany(p => p.Mprices)
                    .HasForeignKey(d => d.MsecurityMovementPrimaryId);
            });

            modelBuilder.Entity<MpricesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MPricesAudit_AuditId");

                entity.ToTable("MPrices_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");
            });

            modelBuilder.Entity<Mrate>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MRates");

                entity.HasIndex(e => e.McashMovementPrimaryId, "IX_MRates_MCashMovementPrimaryId");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_MRates_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_MRates_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentAttributesPrimaryId, "IX_MRates_MFinancialInstrumentAttributesPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentPrimaryId, "IX_MRates_MFinancialInstrumentPrimaryId");

                entity.HasIndex(e => e.MsecurityMovementPrimaryId, "IX_MRates_MSecurityMovementPrimaryId");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");

                entity.HasOne(d => d.McashMovementPrimary)
                    .WithMany(p => p.Mrates)
                    .HasForeignKey(d => d.McashMovementPrimaryId);

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.Mrates)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.Mrates)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentAttributesPrimary)
                    .WithMany(p => p.Mrates)
                    .HasForeignKey(d => d.MfinancialInstrumentAttributesPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentPrimary)
                    .WithMany(p => p.Mrates)
                    .HasForeignKey(d => d.MfinancialInstrumentPrimaryId);

                entity.HasOne(d => d.MsecurityMovementPrimary)
                    .WithMany(p => p.Mrates)
                    .HasForeignKey(d => d.MsecurityMovementPrimaryId);
            });

            modelBuilder.Entity<MratesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MRatesAudit_AuditId");

                entity.ToTable("MRates_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McashMovementPrimaryId).HasColumnName("MCashMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");
            });

            modelBuilder.Entity<Mreference>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MReferences");

                entity.HasIndex(e => e.MgeneralInformationPrimaryId, "IX_MReferences_MGeneralInformationPrimaryId");

                entity.Property(e => e.MgeneralInformationPrimaryId).HasColumnName("MGeneralInformationPrimaryId");

                entity.HasOne(d => d.MgeneralInformationPrimary)
                    .WithMany(p => p.Mreferences)
                    .HasForeignKey(d => d.MgeneralInformationPrimaryId);
            });

            modelBuilder.Entity<MreferencesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MReferencesAudit_AuditId");

                entity.ToTable("MReferences_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MgeneralInformationPrimaryId).HasColumnName("MGeneralInformationPrimaryId");
            });

            modelBuilder.Entity<Msecurity>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MSecurity");
            });

            modelBuilder.Entity<MsecurityAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MSecurityAudit_AuditId");

                entity.ToTable("MSecurity_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt564messages>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT564Messages");

                entity.HasIndex(e => e.MessageDataPrimaryId, "IX_MT564Messages_MessageDataPrimaryId");

                entity.HasIndex(e => e.GoldenRecordId, "idx_MT564Messages_GoldenRecordId");

                entity.Property(e => e.GoldenRecordId).HasColumnName("GoldenRecordID");

                entity.HasOne(d => d.MessageDataPrimary)
                    .WithMany(p => p.Mt564messages)
                    .HasForeignKey(d => d.MessageDataPrimaryId);
            });

            modelBuilder.Entity<Mt564messagesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT564MessagesAudit_AuditId");

                entity.ToTable("MT564Messages_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.GoldenRecordId).HasColumnName("GoldenRecordID");
            });

            modelBuilder.Entity<Mt565AccountInformations>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_AccountInformations");

                entity.HasIndex(e => e.AccountOwnerPrimaryId, "IX_MT565_AccountInformations_AccountOwnerPrimaryId");

                entity.HasIndex(e => e.MunderlyingSecuritiesMt565primaryId, "IX_MT565_AccountInformations_MUnderlyingSecuritiesMT565PrimaryId");

                entity.HasIndex(e => e.PlaceOfSafekeepingPrimaryId, "IX_MT565_AccountInformations_PlaceOfSafekeepingPrimaryId");

                entity.HasIndex(e => e.SafekeepingAccountPrimaryId, "IX_MT565_AccountInformations_SafekeepingAccountPrimaryId");

                entity.Property(e => e.MunderlyingSecuritiesMt565primaryId).HasColumnName("MUnderlyingSecuritiesMT565PrimaryId");

                entity.HasOne(d => d.AccountOwnerPrimary)
                    .WithMany(p => p.Mt565AccountInformations)
                    .HasForeignKey(d => d.AccountOwnerPrimaryId);

                entity.HasOne(d => d.MunderlyingSecuritiesMt565primary)
                    .WithMany(p => p.Mt565AccountInformations)
                    .HasForeignKey(d => d.MunderlyingSecuritiesMt565primaryId);

                entity.HasOne(d => d.PlaceOfSafekeepingPrimary)
                    .WithMany(p => p.Mt565AccountInformations)
                    .HasForeignKey(d => d.PlaceOfSafekeepingPrimaryId);

                entity.HasOne(d => d.SafekeepingAccountPrimary)
                    .WithMany(p => p.Mt565AccountInformations)
                    .HasForeignKey(d => d.SafekeepingAccountPrimaryId);
            });

            modelBuilder.Entity<Mt565AccountInformationsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565AccountInformationsAudit_AuditId");

                entity.ToTable("MT565_AccountInformations_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MunderlyingSecuritiesMt565primaryId).HasColumnName("MUnderlyingSecuritiesMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565AccountOwners>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_AccountOwners");
            });

            modelBuilder.Entity<Mt565AccountOwnersAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565AccountOwnersAudit_AuditId");

                entity.ToTable("MT565_AccountOwners_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565AdditionalInformations>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_AdditionalInformations");
            });

            modelBuilder.Entity<Mt565AdditionalInformationsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565AdditionalInformationsAudit_AuditId");

                entity.ToTable("MT565_AdditionalInformations_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565Mamount>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MAmount");
            });

            modelBuilder.Entity<Mt565MamountAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MAmountAudit_AuditId");

                entity.ToTable("MT565_MAmount_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565Mbalance>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MBalance");

                entity.HasIndex(e => e.MaccountInformationPrimaryId, "IX_MT565_MBalance_MAccountInformationPrimaryId");

                entity.Property(e => e.MaccountInformationPrimaryId).HasColumnName("MAccountInformationPrimaryId");

                entity.HasOne(d => d.MaccountInformationPrimary)
                    .WithMany(p => p.Mt565Mbalance)
                    .HasForeignKey(d => d.MaccountInformationPrimaryId);
            });

            modelBuilder.Entity<Mt565MbalanceAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MBalanceAudit_AuditId");

                entity.ToTable("MT565_MBalance_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MaccountInformationPrimaryId).HasColumnName("MAccountInformationPrimaryId");
            });

            modelBuilder.Entity<Mt565MbeneficialOwnerDetails>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MBeneficialOwnerDetails");

                entity.HasIndex(e => e.MessageDataMt565primaryId, "IX_MT565_MBeneficialOwnerDetails_MessageDataMT565PrimaryId");

                entity.HasIndex(e => e.QuantityOfSecuritiesOwnedPrimaryId, "IX_MT565_MBeneficialOwnerDetails_QuantityOfSecuritiesOwnedPrimaryId");

                entity.HasIndex(e => e.WithholdingTaxRatePrimaryId, "IX_MT565_MBeneficialOwnerDetails_WithholdingTaxRatePrimaryId");

                entity.Property(e => e.MessageDataMt565primaryId).HasColumnName("MessageDataMT565PrimaryId");

                entity.HasOne(d => d.MessageDataMt565primary)
                    .WithMany(p => p.Mt565MbeneficialOwnerDetails)
                    .HasForeignKey(d => d.MessageDataMt565primaryId);

                entity.HasOne(d => d.QuantityOfSecuritiesOwnedPrimary)
                    .WithMany(p => p.Mt565MbeneficialOwnerDetails)
                    .HasForeignKey(d => d.QuantityOfSecuritiesOwnedPrimaryId);

                entity.HasOne(d => d.WithholdingTaxRatePrimary)
                    .WithMany(p => p.Mt565MbeneficialOwnerDetails)
                    .HasForeignKey(d => d.WithholdingTaxRatePrimaryId);
            });

            modelBuilder.Entity<Mt565MbeneficialOwnerDetailsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MBeneficialOwnerDetailsAudit_AuditId");

                entity.ToTable("MT565_MBeneficialOwnerDetails_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MessageDataMt565primaryId).HasColumnName("MessageDataMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565McorporateActionInstruction>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MCorporateActionInstruction");

                entity.HasIndex(e => e.ExecutionRequestedDateTimePrimaryId, "IX_MT565_MCorporateActionInstruction_ExecutionRequestedDateTimePrimaryId");

                entity.HasIndex(e => e.FinancialInstrumentPrimaryId, "IX_MT565_MCorporateActionInstruction_FinancialInstrumentPrimaryId");

                entity.HasIndex(e => e.InstructedAmountPrimaryId, "IX_MT565_MCorporateActionInstruction_InstructedAmountPrimaryId");

                entity.HasIndex(e => e.ShareholderNumberReferencePrimaryId, "IX_MT565_MCorporateActionInstruction_ShareholderNumberReferencePrimaryId");

                entity.Property(e => e.CaoptionNumber).HasColumnName("CAOptionNumber");

                entity.HasOne(d => d.ExecutionRequestedDateTimePrimary)
                    .WithMany(p => p.Mt565McorporateActionInstruction)
                    .HasForeignKey(d => d.ExecutionRequestedDateTimePrimaryId);

                entity.HasOne(d => d.FinancialInstrumentPrimary)
                    .WithMany(p => p.Mt565McorporateActionInstruction)
                    .HasForeignKey(d => d.FinancialInstrumentPrimaryId);

                entity.HasOne(d => d.InstructedAmountPrimary)
                    .WithMany(p => p.Mt565McorporateActionInstruction)
                    .HasForeignKey(d => d.InstructedAmountPrimaryId);

                entity.HasOne(d => d.ShareholderNumberReferencePrimary)
                    .WithMany(p => p.Mt565McorporateActionInstruction)
                    .HasForeignKey(d => d.ShareholderNumberReferencePrimaryId);
            });

            modelBuilder.Entity<Mt565McorporateActionInstructionAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MCorporateActionInstructionAudit_AuditId");

                entity.ToTable("MT565_MCorporateActionInstruction_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.CaoptionNumber).HasColumnName("CAOptionNumber");
            });

            modelBuilder.Entity<Mt565Mcurrency>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MCurrency");

                entity.HasIndex(e => e.McorporateActionInstructionPrimaryId, "IX_MT565_MCurrency_MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.HasOne(d => d.McorporateActionInstructionPrimary)
                    .WithMany(p => p.Mt565Mcurrency)
                    .HasForeignKey(d => d.McorporateActionInstructionPrimaryId);
            });

            modelBuilder.Entity<Mt565McurrencyAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MCurrencyAudit_AuditId");

                entity.ToTable("MT565_MCurrency_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");
            });

            modelBuilder.Entity<Mt565Mdate>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MDate");

                entity.HasIndex(e => e.MfinancialInstrumentAttributeMt565primaryId, "IX_MT565_MDate_MFinancialInstrumentAttributeMT565PrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributeMt565primaryId).HasColumnName("MFinancialInstrumentAttributeMT565PrimaryId");

                entity.HasOne(d => d.MfinancialInstrumentAttributeMt565primary)
                    .WithMany(p => p.Mt565Mdate)
                    .HasForeignKey(d => d.MfinancialInstrumentAttributeMt565primaryId);
            });

            modelBuilder.Entity<Mt565MdateAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MDateAudit_AuditId");

                entity.ToTable("MT565_MDate_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MfinancialInstrumentAttributeMt565primaryId).HasColumnName("MFinancialInstrumentAttributeMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565MessageData>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MessageData");

                entity.HasIndex(e => e.AdditionalInformationPrimaryId, "IX_MT565_MessageData_AdditionalInformationPrimaryId");

                entity.HasIndex(e => e.CorporateActionInstructionPrimaryId, "IX_MT565_MessageData_CorporateActionInstructionPrimaryId");

                entity.HasIndex(e => e.GeneralInformationPrimaryId, "IX_MT565_MessageData_GeneralInformationPrimaryId");

                entity.HasOne(d => d.AdditionalInformationPrimary)
                    .WithMany(p => p.Mt565MessageData)
                    .HasForeignKey(d => d.AdditionalInformationPrimaryId);

                entity.HasOne(d => d.CorporateActionInstructionPrimary)
                    .WithMany(p => p.Mt565MessageData)
                    .HasForeignKey(d => d.CorporateActionInstructionPrimaryId);

                entity.HasOne(d => d.GeneralInformationPrimary)
                    .WithMany(p => p.Mt565MessageData)
                    .HasForeignKey(d => d.GeneralInformationPrimaryId);
            });

            modelBuilder.Entity<Mt565MessageDataAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MessageDataAudit_AuditId");

                entity.ToTable("MT565_MessageData_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565MfinancialInstrumentAttribute>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MFinancialInstrumentAttribute");

                entity.HasIndex(e => e.ClassificationTypePrimaryId, "IX_MT565_MFinancialInstrumentAttribute_ClassificationTypePrimaryId");

                entity.HasIndex(e => e.MunderlyingSecuritiesMt565primaryId, "IX_MT565_MFinancialInstrumentAttribute_MUnderlyingSecuritiesMT565PrimaryId");

                entity.HasIndex(e => e.MethodOfInterestComputationIndicatorPrimaryId, "IX_MT565_MFinancialInstrumentAttribute_MethodOfInterestComputationIndicatorPrimaryId");

                entity.HasIndex(e => e.PlaceOfListingPrimaryId, "IX_MT565_MFinancialInstrumentAttribute_PlaceOfListingPrimaryId");

                entity.Property(e => e.MunderlyingSecuritiesMt565primaryId).HasColumnName("MUnderlyingSecuritiesMT565PrimaryId");

                entity.HasOne(d => d.ClassificationTypePrimary)
                    .WithMany(p => p.Mt565MfinancialInstrumentAttribute)
                    .HasForeignKey(d => d.ClassificationTypePrimaryId);

                entity.HasOne(d => d.MethodOfInterestComputationIndicatorPrimary)
                    .WithMany(p => p.Mt565MfinancialInstrumentAttribute)
                    .HasForeignKey(d => d.MethodOfInterestComputationIndicatorPrimaryId);

                entity.HasOne(d => d.MunderlyingSecuritiesMt565primary)
                    .WithMany(p => p.Mt565MfinancialInstrumentAttribute)
                    .HasForeignKey(d => d.MunderlyingSecuritiesMt565primaryId);

                entity.HasOne(d => d.PlaceOfListingPrimary)
                    .WithMany(p => p.Mt565MfinancialInstrumentAttribute)
                    .HasForeignKey(d => d.PlaceOfListingPrimaryId);
            });

            modelBuilder.Entity<Mt565MfinancialInstrumentAttributeAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MFinancialInstrumentAttributeAudit_AuditId");

                entity.ToTable("MT565_MFinancialInstrumentAttribute_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MunderlyingSecuritiesMt565primaryId).HasColumnName("MUnderlyingSecuritiesMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565MfunctionOfMessage>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MFunctionOfMessage");
            });

            modelBuilder.Entity<Mt565MfunctionOfMessageAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MFunctionOfMessageAudit_AuditId");

                entity.ToTable("MT565_MFunctionOfMessage_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565MgeneralInformation>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MGeneralInformation");

                entity.HasIndex(e => e.FunctionOfMessagePrimaryId, "IX_MT565_MGeneralInformation_FunctionOfMessagePrimaryId");

                entity.HasIndex(e => e.IndicatorPrimaryId, "IX_MT565_MGeneralInformation_IndicatorPrimaryId");

                entity.HasIndex(e => e.PreparationDateTimePrimaryId, "IX_MT565_MGeneralInformation_PreparationDateTimePrimaryId");

                entity.HasOne(d => d.FunctionOfMessagePrimary)
                    .WithMany(p => p.Mt565MgeneralInformation)
                    .HasForeignKey(d => d.FunctionOfMessagePrimaryId);

                entity.HasOne(d => d.IndicatorPrimary)
                    .WithMany(p => p.Mt565MgeneralInformation)
                    .HasForeignKey(d => d.IndicatorPrimaryId);

                entity.HasOne(d => d.PreparationDateTimePrimary)
                    .WithMany(p => p.Mt565MgeneralInformation)
                    .HasForeignKey(d => d.PreparationDateTimePrimaryId);
            });

            modelBuilder.Entity<Mt565MgeneralInformationAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MGeneralInformationAudit_AuditId");

                entity.ToTable("MT565_MGeneralInformation_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565Mindicator>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MIndicator");

                entity.HasIndex(e => e.MbeneficialOwnerDetailsPrimaryId, "IX_MT565_MIndicator_MBeneficialOwnerDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionInstructionPrimaryId, "IX_MT565_MIndicator_MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.HasOne(d => d.MbeneficialOwnerDetailsPrimary)
                    .WithMany(p => p.Mt565Mindicator)
                    .HasForeignKey(d => d.MbeneficialOwnerDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionInstructionPrimary)
                    .WithMany(p => p.Mt565Mindicator)
                    .HasForeignKey(d => d.McorporateActionInstructionPrimaryId);
            });

            modelBuilder.Entity<Mt565MindicatorAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MIndicatorAudit_AuditId");

                entity.ToTable("MT565_MIndicator_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");
            });

            modelBuilder.Entity<Mt565MlinkedMessage>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MLinkedMessage");

                entity.HasIndex(e => e.LinkageTypeIndicatorPrimaryId, "IX_MT565_MLinkedMessage_LinkageTypeIndicatorPrimaryId");

                entity.HasIndex(e => e.LinkedReferencePrimaryId, "IX_MT565_MLinkedMessage_LinkedReferencePrimaryId");

                entity.HasIndex(e => e.MgeneralInformationMt565primaryId, "IX_MT565_MLinkedMessage_MGeneralInformationMT565PrimaryId");

                entity.Property(e => e.MgeneralInformationMt565primaryId).HasColumnName("MGeneralInformationMT565PrimaryId");

                entity.HasOne(d => d.LinkageTypeIndicatorPrimary)
                    .WithMany(p => p.Mt565MlinkedMessage)
                    .HasForeignKey(d => d.LinkageTypeIndicatorPrimaryId);

                entity.HasOne(d => d.LinkedReferencePrimary)
                    .WithMany(p => p.Mt565MlinkedMessage)
                    .HasForeignKey(d => d.LinkedReferencePrimaryId);

                entity.HasOne(d => d.MgeneralInformationMt565primary)
                    .WithMany(p => p.Mt565MlinkedMessage)
                    .HasForeignKey(d => d.MgeneralInformationMt565primaryId);
            });

            modelBuilder.Entity<Mt565MlinkedMessageAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MLinkedMessageAudit_AuditId");

                entity.ToTable("MT565_MLinkedMessage_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MgeneralInformationMt565primaryId).HasColumnName("MGeneralInformationMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565Mnarrative>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MNarrative");

                entity.HasIndex(e => e.MadditionalInformationPrimaryId, "IX_MT565_MNarrative_MAdditionalInformationPrimaryId");

                entity.HasIndex(e => e.MbeneficialOwnerDetailsPrimaryId, "IX_MT565_MNarrative_MBeneficialOwnerDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionInstructionPrimaryId, "IX_MT565_MNarrative_MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.HasOne(d => d.MadditionalInformationPrimary)
                    .WithMany(p => p.Mt565Mnarrative)
                    .HasForeignKey(d => d.MadditionalInformationPrimaryId);

                entity.HasOne(d => d.MbeneficialOwnerDetailsPrimary)
                    .WithMany(p => p.Mt565Mnarrative)
                    .HasForeignKey(d => d.MbeneficialOwnerDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionInstructionPrimary)
                    .WithMany(p => p.Mt565Mnarrative)
                    .HasForeignKey(d => d.McorporateActionInstructionPrimaryId);
            });

            modelBuilder.Entity<Mt565MnarrativeAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MNarrativeAudit_AuditId");

                entity.ToTable("MT565_MNarrative_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");
            });

            modelBuilder.Entity<Mt565Mparty>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MParty");

                entity.HasIndex(e => e.MadditionalInformationPrimaryId, "IX_MT565_MParty_MAdditionalInformationPrimaryId");

                entity.HasIndex(e => e.MbeneficialOwnerDetailsPrimaryId, "IX_MT565_MParty_MBeneficialOwnerDetailsPrimaryId");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");

                entity.HasOne(d => d.MadditionalInformationPrimary)
                    .WithMany(p => p.Mt565Mparty)
                    .HasForeignKey(d => d.MadditionalInformationPrimaryId);

                entity.HasOne(d => d.MbeneficialOwnerDetailsPrimary)
                    .WithMany(p => p.Mt565Mparty)
                    .HasForeignKey(d => d.MbeneficialOwnerDetailsPrimaryId);
            });

            modelBuilder.Entity<Mt565MpartyAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MPartyAudit_AuditId");

                entity.ToTable("MT565_MParty_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");
            });

            modelBuilder.Entity<Mt565Mplace>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MPlace");

                entity.HasIndex(e => e.MbeneficialOwnerDetailsPrimaryId, "IX_MT565_MPlace_MBeneficialOwnerDetailsPrimaryId");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");

                entity.HasOne(d => d.MbeneficialOwnerDetailsPrimary)
                    .WithMany(p => p.Mt565Mplace)
                    .HasForeignKey(d => d.MbeneficialOwnerDetailsPrimaryId);
            });

            modelBuilder.Entity<Mt565MplaceAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MPlaceAudit_AuditId");

                entity.ToTable("MT565_MPlace_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MbeneficialOwnerDetailsPrimaryId).HasColumnName("MBeneficialOwnerDetailsPrimaryId");
            });

            modelBuilder.Entity<Mt565MplaceOfListning>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MPlaceOfListning");
            });

            modelBuilder.Entity<Mt565MplaceOfListningAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MPlaceOfListningAudit_AuditId");

                entity.ToTable("MT565_MPlaceOfListning_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565MplaceOfSafekeeping>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MPlaceOfSafekeeping");
            });

            modelBuilder.Entity<Mt565MplaceOfSafekeepingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MPlaceOfSafekeepingAudit_AuditId");

                entity.ToTable("MT565_MPlaceOfSafekeeping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565MpreparationDateTime>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MPreparationDateTime");
            });

            modelBuilder.Entity<Mt565MpreparationDateTimeAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MPreparationDateTimeAudit_AuditId");

                entity.ToTable("MT565_MPreparationDateTime_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565Mprice>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MPrice");

                entity.HasIndex(e => e.McorporateActionInstructionPrimaryId, "IX_MT565_MPrice_MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.HasOne(d => d.McorporateActionInstructionPrimary)
                    .WithMany(p => p.Mt565Mprice)
                    .HasForeignKey(d => d.McorporateActionInstructionPrimaryId);
            });

            modelBuilder.Entity<Mt565MpriceAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MPriceAudit_AuditId");

                entity.ToTable("MT565_MPrice_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");
            });

            modelBuilder.Entity<Mt565Mqualifier>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MQualifier");
            });

            modelBuilder.Entity<Mt565MqualifierAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MQualifierAudit_AuditId");

                entity.ToTable("MT565_MQualifier_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565MquantityOfInstrument>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MQuantityOfInstrument");

                entity.HasIndex(e => e.McorporateActionInstructionPrimaryId, "IX_MT565_MQuantityOfInstrument_MCorporateActionInstructionPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentAttributeMt565primaryId, "IX_MT565_MQuantityOfInstrument_MFinancialInstrumentAttributeMT565PrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributeMt565primaryId).HasColumnName("MFinancialInstrumentAttributeMT565PrimaryId");

                entity.HasOne(d => d.McorporateActionInstructionPrimary)
                    .WithMany(p => p.Mt565MquantityOfInstrument)
                    .HasForeignKey(d => d.McorporateActionInstructionPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentAttributeMt565primary)
                    .WithMany(p => p.Mt565MquantityOfInstrument)
                    .HasForeignKey(d => d.MfinancialInstrumentAttributeMt565primaryId);
            });

            modelBuilder.Entity<Mt565MquantityOfInstrumentAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MQuantityOfInstrumentAudit_AuditId");

                entity.ToTable("MT565_MQuantityOfInstrument_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributeMt565primaryId).HasColumnName("MFinancialInstrumentAttributeMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565Mrate>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MRate");

                entity.HasIndex(e => e.McorporateActionInstructionPrimaryId, "IX_MT565_MRate_MCorporateActionInstructionPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentAttributeMt565primaryId, "IX_MT565_MRate_MFinancialInstrumentAttributeMT565PrimaryId");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributeMt565primaryId).HasColumnName("MFinancialInstrumentAttributeMT565PrimaryId");

                entity.HasOne(d => d.McorporateActionInstructionPrimary)
                    .WithMany(p => p.Mt565Mrate)
                    .HasForeignKey(d => d.McorporateActionInstructionPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentAttributeMt565primary)
                    .WithMany(p => p.Mt565Mrate)
                    .HasForeignKey(d => d.MfinancialInstrumentAttributeMt565primaryId);
            });

            modelBuilder.Entity<Mt565MrateAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MRateAudit_AuditId");

                entity.ToTable("MT565_MRate_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionInstructionPrimaryId).HasColumnName("MCorporateActionInstructionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributeMt565primaryId).HasColumnName("MFinancialInstrumentAttributeMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565Mreference>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MReference");

                entity.HasIndex(e => e.MgeneralInformationMt565primaryId, "IX_MT565_MReference_MGeneralInformationMT565PrimaryId");

                entity.Property(e => e.MgeneralInformationMt565primaryId).HasColumnName("MGeneralInformationMT565PrimaryId");

                entity.HasOne(d => d.MgeneralInformationMt565primary)
                    .WithMany(p => p.Mt565Mreference)
                    .HasForeignKey(d => d.MgeneralInformationMt565primaryId);
            });

            modelBuilder.Entity<Mt565MreferenceAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MReferenceAudit_AuditId");

                entity.ToTable("MT565_MReference_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MgeneralInformationMt565primaryId).HasColumnName("MGeneralInformationMT565PrimaryId");
            });

            modelBuilder.Entity<Mt565MsafekeepingAccount>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MSafekeepingAccount");
            });

            modelBuilder.Entity<Mt565MsafekeepingAccountAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MSafekeepingAccountAudit_AuditId");

                entity.ToTable("MT565_MSafekeepingAccount_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565Msecurity>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MSecurity");
            });

            modelBuilder.Entity<Mt565MsecurityAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MSecurityAudit_AuditId");

                entity.ToTable("MT565_MSecurity_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Mt565Mt565message>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MT565Message");

                entity.HasIndex(e => e.MessageDataPrimaryId, "IX_MT565_MT565Message_MessageDataPrimaryId");

                entity.Property(e => e.GoldenRecordId).HasColumnName("GoldenRecordID");

                entity.HasOne(d => d.MessageDataPrimary)
                    .WithMany(p => p.Mt565Mt565message)
                    .HasForeignKey(d => d.MessageDataPrimaryId);
            });

            modelBuilder.Entity<Mt565Mt565messageAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MT565MessageAudit_AuditId");

                entity.ToTable("MT565_MT565Message_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.GoldenRecordId).HasColumnName("GoldenRecordID");
            });

            modelBuilder.Entity<Mt565MtypeOfInstrument>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MTypeOfInstrument");

                entity.Property(e => e.Cficode).HasColumnName("CFICode");
            });

            modelBuilder.Entity<Mt565MtypeOfInstrumentAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MTypeOfInstrumentAudit_AuditId");

                entity.ToTable("MT565_MTypeOfInstrument_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.Cficode).HasColumnName("CFICode");
            });

            modelBuilder.Entity<Mt565MunderlyingSecurities>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("MT565_MUnderlyingSecurities");

                entity.HasIndex(e => e.FinancialInstrumentPrimaryId, "IX_MT565_MUnderlyingSecurities_FinancialInstrumentPrimaryId");

                entity.HasIndex(e => e.MessageDataMt565primaryId, "IX_MT565_MUnderlyingSecurities_MessageDataMT565PrimaryId");

                entity.Property(e => e.MessageDataMt565primaryId).HasColumnName("MessageDataMT565PrimaryId");

                entity.HasOne(d => d.FinancialInstrumentPrimary)
                    .WithMany(p => p.Mt565MunderlyingSecurities)
                    .HasForeignKey(d => d.FinancialInstrumentPrimaryId);

                entity.HasOne(d => d.MessageDataMt565primary)
                    .WithMany(p => p.Mt565MunderlyingSecurities)
                    .HasForeignKey(d => d.MessageDataMt565primaryId);
            });

            modelBuilder.Entity<Mt565MunderlyingSecuritiesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_MT565MUnderlyingSecuritiesAudit_AuditId");

                entity.ToTable("MT565_MUnderlyingSecurities_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MessageDataMt565primaryId).HasColumnName("MessageDataMT565PrimaryId");
            });

            modelBuilder.Entity<NotificationMessage>(entity =>
            {
                entity.ToTable("Notification_Messages");

                entity.Property(e => e.NotificationMessageId).HasColumnName("Notification_Message_Id");

                entity.Property(e => e.AdditionalDetails).HasColumnName("Additional_Details");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUiUpdate).HasColumnName("is_UI_Update");

                entity.Property(e => e.MessageAction)
                    .HasMaxLength(100)
                    .HasColumnName("Message_Action");

                entity.Property(e => e.MessageComponent)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Message_Component");

                entity.Property(e => e.MessageDateTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Message_DateTime_UTC");

                entity.Property(e => e.MessageGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_GUID");

                entity.Property(e => e.MessageLink)
                    .HasMaxLength(400)
                    .HasColumnName("Message_Link");

                entity.Property(e => e.MessagePriority)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Priority");

                entity.Property(e => e.MessageSeverity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Severity");

                entity.Property(e => e.MessageText).HasColumnName("Message_Text");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Type");
            });

            modelBuilder.Entity<NotificationMessagesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_NotificationMessagesAudit_AuditId");

                entity.ToTable("Notification_Messages_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AdditionalDetails).HasColumnName("Additional_Details");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsUiUpdate).HasColumnName("is_UI_Update");

                entity.Property(e => e.MessageAction)
                    .HasMaxLength(100)
                    .HasColumnName("Message_Action");

                entity.Property(e => e.MessageComponent)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Message_Component");

                entity.Property(e => e.MessageDateTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Message_DateTime_UTC");

                entity.Property(e => e.MessageGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_GUID");

                entity.Property(e => e.MessageLink)
                    .HasMaxLength(400)
                    .HasColumnName("Message_Link");

                entity.Property(e => e.MessagePriority)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Priority");

                entity.Property(e => e.MessageSeverity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Severity");

                entity.Property(e => e.MessageText).HasColumnName("Message_Text");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Type");

                entity.Property(e => e.NotificationMessageId).HasColumnName("Notification_Message_Id");
            });

            modelBuilder.Entity<NotusedTt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NOTUSED_tt");

                entity.Property(e => e.Bic)
                    .HasMaxLength(255)
                    .HasColumnName("BIC");

                entity.Property(e => e.F7).HasMaxLength(255);

                entity.Property(e => e.LegalEntityCdrId).HasColumnName("LEGAL_ENTITY_CDR_ID");

                entity.Property(e => e.LegalEntityName)
                    .HasMaxLength(255)
                    .HasColumnName("LEGAL_ENTITY_NAME");

                entity.Property(e => e.ParentCompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("PARENT_COMPANY_NAME");

                entity.Property(e => e.SwiftMessageEnabled).HasColumnName("SWIFT_MESSAGE_ENABLED");

                entity.Property(e => e.TradingAccountNumber).HasColumnName("TRADING_ACCOUNT_NUMBER");
            });

            modelBuilder.Entity<NotusedUserPermissionMapping>(entity =>
            {
                entity.HasKey(e => e.UserAppPermissionId)
                    .HasName("PK_UserPermissionMapping_UserAppPermissionId");

                entity.ToTable("NOTUSED_User_Permission_Mapping");

                entity.HasIndex(e => e.UserId, "idx_User_Permission_Mapping_UserID");

                entity.Property(e => e.UserAppPermissionId).HasColumnName("User_App_Permission_Id");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<NotusedUserPermissionMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_UserPermissionMappingAudit_AuditID");

                entity.ToTable("NOTUSED_User_Permission_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.UserAppPermissionId).HasColumnName("User_App_Permission_Id");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<NumberCount>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);
            });

            modelBuilder.Entity<NumberCountsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_NumberCountsAudit_AuditId");

                entity.ToTable("NumberCounts_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<OutBoundAccountMapping>(entity =>
            {
                entity.ToTable("OutBound_Account_Mapping");

                entity.Property(e => e.OutboundAccountMappingId).HasColumnName("Outbound_Account_Mapping_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OutboundId).HasColumnName("Outbound_Id");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<OutBoundAccountMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_OutBoundAccountMappingAudit_AuditId");

                entity.ToTable("OutBound_Account_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.OutboundAccountMappingId).HasColumnName("Outbound_Account_Mapping_Id");

                entity.Property(e => e.OutboundId).HasColumnName("Outbound_Id");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<OutboundEmailRefMst>(entity =>
            {
                entity.HasKey(e => e.OutboundEmailRefId)
                    .HasName("PK_OutboundEmailRefMst_OutboundEmailRefId");

                entity.ToTable("Outbound_Email_Ref_Mst");

                entity.Property(e => e.OutboundEmailRefId).HasColumnName("Outbound_Email_Ref_Id");

                entity.Property(e => e.AutoStp).HasColumnName("Auto_STP");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailMsg).HasColumnName("Email_Msg");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JsonMsg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("JSON_Msg");

                entity.Property(e => e.MsgType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Type");

                entity.Property(e => e.ResendCount).HasColumnName("Resend_Count");

                entity.Property(e => e.SemeRef)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");
            });

            modelBuilder.Entity<OutboundEmailRefMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_OutboundEmailRefMstAudit_AuditId");

                entity.ToTable("Outbound_Email_Ref_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AutoStp).HasColumnName("Auto_STP");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailMsg).HasColumnName("Email_Msg");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.JsonMsg)
                    .IsUnicode(false)
                    .HasColumnName("JSON_Msg");

                entity.Property(e => e.MsgType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Type");

                entity.Property(e => e.OutboundEmailRefId).HasColumnName("Outbound_Email_Ref_Id");

                entity.Property(e => e.ResendCount).HasColumnName("Resend_Count");

                entity.Property(e => e.SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");
            });

            modelBuilder.Entity<OutboundMst>(entity =>
            {
                entity.HasKey(e => e.OutboundId)
                    .HasName("PK_OutboundMst_OutboundId");

                entity.ToTable("Outbound_Mst");

                entity.Property(e => e.OutboundId).HasColumnName("Outbound_Id");

                entity.HasIndex(e => e.GoldenRecordId, "idx_OutboundMst_GoldenRecordId");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationRefId).HasColumnName("Destination_Ref_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorMessageText).HasColumnName("Error_Message_Text");

                entity.Property(e => e.GeneratedEventRef)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Generated_Event_Ref");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LegalEntityCdrId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.OutboundStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Outbound_Status");

                entity.Property(e => e.IsIgnore)
                    .HasColumnName("Is_Ignore");

                entity.Property(e => e.LinkageEventRef)
                  .HasColumnName("Linkage_Event_Ref");

                entity.Property(e => e.SendAction)
                    .HasColumnName("Send_Action");

                entity.Property(e => e.IsAccountGroup)
                    .HasColumnName("Is_AccountGroup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            });

            modelBuilder.Entity<OutboundMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_OutboundMstAudit_AuditId");

                entity.ToTable("Outbound_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.Destination)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationRefId).HasColumnName("Destination_Ref_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ErrorMessageText).HasColumnName("Error_Message_Text");

                entity.Property(e => e.GeneratedEventRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Generated_Event_Ref");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LegalEntityCdrId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Cdr_Id");

                entity.Property(e => e.OutboundId).HasColumnName("Outbound_Id");

                entity.Property(e => e.OutboundStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Outbound_Status");

                entity.Property(e => e.IsIgnore)
                    .HasColumnName("Is_Ignore");
                
                entity.Property(e => e.LinkageEventRef)
                    .HasColumnName("Linkage_Event_Ref");
                
                entity.Property(e => e.SendAction)
                    .HasColumnName("Send_Action");

                entity.Property(e => e.IsAccountGroup)
                    .HasColumnName("Is_AccountGroup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            });

            modelBuilder.Entity<OutboundReminderMapping>(entity =>
            {
                entity.ToTable("Outbound_Reminder_Mapping");

                entity.Property(e => e.OutboundReminderMappingId).HasColumnName("Outbound_Reminder_Mapping_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OutboundId).HasColumnName("Outbound_Id");

                entity.Property(e => e.SentStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Sent_Status");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<OutboundReminderMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_OutboundReminderMappingAudit_AuditId");

                entity.ToTable("Outbound_Reminder_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.OutboundId).HasColumnName("Outbound_Id");

                entity.Property(e => e.OutboundReminderMappingId).HasColumnName("Outbound_Reminder_Mapping_Id");

                entity.Property(e => e.SentStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Sent_Status");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<OutboundSwiftRefMst>(entity =>
            {
                entity.HasKey(e => e.OutboundSwiftRefId)
                    .HasName("PK_OutboundSwiftRefMst_OutboundSwiftRefId");

                entity.ToTable("Outbound_Swift_Ref_Mst");

                entity.HasIndex(e => e.SemeRef, "NonClusteredIndex-20210204-122450");

                entity.Property(e => e.OutboundSwiftRefId).HasColumnName("Outbound_Swift_Ref_Id");

                entity.Property(e => e.AutoStp).HasColumnName("Auto_STP");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JsonMsg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("JSON_Msg");

                entity.Property(e => e.MsgType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Type");

                entity.Property(e => e.ResendCount).HasColumnName("Resend_Count");

                entity.Property(e => e.SemeRef)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");

                entity.Property(e => e.SwiftMsg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_Msg");
            });

            modelBuilder.Entity<OutboundSwiftRefMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_OutboundSwiftRefMstAudit_AuditId");

                entity.ToTable("Outbound_Swift_Ref_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AutoStp).HasColumnName("Auto_STP");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.JsonMsg)
                    .IsUnicode(false)
                    .HasColumnName("JSON_Msg");

                entity.Property(e => e.MsgType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Type");

                entity.Property(e => e.OutboundSwiftRefId).HasColumnName("Outbound_Swift_Ref_Id");

                entity.Property(e => e.ResendCount).HasColumnName("Resend_Count");

                entity.Property(e => e.SemeRef)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEME_Ref");

                entity.Property(e => e.SwiftMsg)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_Msg");
            });

            modelBuilder.Entity<PageNumber>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);
            });

            modelBuilder.Entity<PageNumbersAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PageNumbersAudit_AuditId");

                entity.ToTable("PageNumbers_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("Party");

                entity.HasIndex(e => e.MadditionalInformationPrimaryId, "IX_Party_MAdditionalInformationPrimaryId");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");

                entity.HasOne(d => d.MadditionalInformationPrimary)
                    .WithMany(p => p.Parties)
                    .HasForeignKey(d => d.MadditionalInformationPrimaryId);
            });

            modelBuilder.Entity<PartyAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PartyAudit_AuditId");

                entity.ToTable("Party_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MadditionalInformationPrimaryId).HasColumnName("MAdditionalInformationPrimaryId");
            });

            modelBuilder.Entity<PaymentCurrencyMapping>(entity =>
            {
                entity.ToTable("Payment_Currency_Mapping");

                entity.Property(e => e.PaymentCurrencyMappingId).HasColumnName("Payment_Currency_Mapping_Id");

                entity.Property(e => e.ClientNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Client_Nbr");

                entity.Property(e => e.Comments).HasMaxLength(1000);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("Currency_Code");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_Id");

                entity.Property(e => e.DefaultForEntityRegion)
                    .HasMaxLength(10)
                    .HasColumnName("Default_For_Entity_Region");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsoCurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("ISO_Currency_Code");
            });

            modelBuilder.Entity<PaymentCurrencyMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PaymentCurrencyMappingAudit_AuditId");

                entity.ToTable("Payment_Currency_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ClientNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Client_Nbr");

                entity.Property(e => e.Comments).HasMaxLength(1000);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("Currency_Code");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_Id");

                entity.Property(e => e.DefaultForEntityRegion)
                    .HasMaxLength(10)
                    .HasColumnName("Default_For_Entity_Region");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsoCurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("ISO_Currency_Code");

                entity.Property(e => e.PaymentCurrencyMappingId).HasColumnName("Payment_Currency_Mapping_Id");
            });

            modelBuilder.Entity<PaymentEventTypeMapping>(entity =>
            {
                entity.ToTable("Payment_EventType_Mapping");

                entity.Property(e => e.PaymentEventTypeMappingId).HasColumnName("Payment_EventType_Mapping_Id");

                entity.Property(e => e.BpsaBatchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPSA_Batch_Code");

                entity.Property(e => e.BpsaEntryCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPSA_Entry_Code");

                entity.Property(e => e.CaEventCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Code");

                entity.Property(e => e.CaEventType)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PaymentEventTypeMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PaymentEventTypeMappingAudit_AuditId");

                entity.ToTable("Payment_EventType_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.BpsaBatchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPSA_Batch_Code");

                entity.Property(e => e.BpsaEntryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BPSA_Entry_Code");

                entity.Property(e => e.CaEventCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CA_Event_Code");

                entity.Property(e => e.CaEventType)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CA_EventType");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.PaymentEventTypeMappingId).HasColumnName("Payment_EventType_Mapping_Id");
            });

            modelBuilder.Entity<Period>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("Period");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_Period_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_Period_MCorporateActionOptionPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.Periods)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.Periods)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);
            });

            modelBuilder.Entity<PeriodAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PeriodAudit_AuditId");

                entity.ToTable("Period_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");
            });

            modelBuilder.Entity<PermissionMst>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("pk_Permission_mst_PermissionID");

                entity.ToTable("Permission_Mst");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermissionMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("pk_PermissionMstAudit_AuditID");

                entity.ToTable("Permission_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.PermissionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlaceOfListning>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("PlaceOfListning");
            });

            modelBuilder.Entity<PlaceOfListningAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PlaceOfListningAudit_AuditId");

                entity.ToTable("PlaceOfListning_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<PlaceOfSafekeeping>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("PlaceOfSafekeeping");
            });

            modelBuilder.Entity<PlaceOfSafekeepingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PlaceOfSafekeepingAudit_AuditId");

                entity.ToTable("PlaceOfSafekeeping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<PreparationDateTime>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("PreparationDateTime");
            });

            modelBuilder.Entity<PreparationDateTimeAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_PreparationDateTimeAudit_AuditId");

                entity.ToTable("PreparationDateTime_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<ProductsAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ProductsAudit_AuditId");

                entity.ToTable("Products_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<QuantityOfInstrument>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("QuantityOfInstrument");

                entity.HasIndex(e => e.McorporateActionDetailsPrimaryId, "IX_QuantityOfInstrument_MCorporateActionDetailsPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_QuantityOfInstrument_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentAttributesPrimaryId, "IX_QuantityOfInstrument_MFinancialInstrumentAttributesPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentPrimaryId, "IX_QuantityOfInstrument_MFinancialInstrumentPrimaryId");

                entity.HasIndex(e => e.MsecurityMovementPrimaryId, "IX_QuantityOfInstrument_MSecurityMovementPrimaryId");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");

                entity.HasOne(d => d.McorporateActionDetailsPrimary)
                    .WithMany(p => p.QuantityOfInstruments)
                    .HasForeignKey(d => d.McorporateActionDetailsPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.QuantityOfInstruments)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentAttributesPrimary)
                    .WithMany(p => p.QuantityOfInstruments)
                    .HasForeignKey(d => d.MfinancialInstrumentAttributesPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentPrimary)
                    .WithMany(p => p.QuantityOfInstruments)
                    .HasForeignKey(d => d.MfinancialInstrumentPrimaryId);

                entity.HasOne(d => d.MsecurityMovementPrimary)
                    .WithMany(p => p.QuantityOfInstruments)
                    .HasForeignKey(d => d.MsecurityMovementPrimaryId);
            });

            modelBuilder.Entity<QuantityOfInstrumentAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_QuantityOfInstrumentAudit_AuditId");

                entity.ToTable("QuantityOfInstrument_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.McorporateActionDetailsPrimaryId).HasColumnName("MCorporateActionDetailsPrimaryId");

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");

                entity.Property(e => e.MsecurityMovementPrimaryId).HasColumnName("MSecurityMovementPrimaryId");
            });

            modelBuilder.Entity<ReceivedCaEventDtl>(entity =>
            {
                entity.ToTable("Received_CA_Event_Dtl");

                entity.HasIndex(e => e.Cusip, "idx_ReceivedCAEventDtl_CUSIP");

                entity.HasIndex(e => e.EntryDtTime, "idx_ReceivedCAEventDtl_EntryDtTime");

                entity.HasIndex(e => e.ErrorId, "idx_ReceivedCAEventDtl_ErrorId");

                entity.HasIndex(e => e.FileImportMstId, "idx_ReceivedCAEventDtl_FileImportMstId");

                entity.HasIndex(e => e.Isin, "idx_ReceivedCAEventDtl_ISIN");

                entity.HasIndex(e => e.Sedol, "idx_ReceivedCAEventDtl_Sedol");

                entity.Property(e => e.ReceivedCaEventDtlId).HasColumnName("Received_CA_Event_Dtl_Id");

                entity.Property(e => e.AssetClassId).HasColumnName("Asset_Class_Id");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.CaEventForDate)
                    .HasColumnType("date")
                    .HasColumnName("CA_Event_For_Date");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.CaEventValidTill)
                    .HasColumnType("datetime")
                    .HasColumnName("CA_Event_Valid_Till");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorId).HasColumnName("Error_Id");

                entity.Property(e => e.ErrorMessageDetails).HasColumnName("Error_Message_Details");

                entity.Property(e => e.ExtractedMessage).HasColumnName("Extracted_Message");

                entity.Property(e => e.FileImportMstId).HasColumnName("File_Import_Mst_Id");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsProcessed).HasColumnName("Is_Processed");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.MessageId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Id");

                entity.Property(e => e.NormalizedMessage).HasColumnName("Normalized_Message");

                entity.Property(e => e.ParsedMessage).HasColumnName("Parsed_Message");

                entity.Property(e => e.SecurityId).HasColumnName("Security_Id");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<ReceivedCaEventDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedCAEventDtlAudit_AuditId");

                entity.ToTable("Received_CA_Event_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AssetClassId).HasColumnName("Asset_Class_Id");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.CaEventForDate)
                    .HasColumnType("date")
                    .HasColumnName("CA_Event_For_Date");

                entity.Property(e => e.CaEventTypeId).HasColumnName("CA_EventType_Id");

                entity.Property(e => e.CaEventValidTill)
                    .HasColumnType("datetime")
                    .HasColumnName("CA_Event_Valid_Till");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ErrorId).HasColumnName("Error_Id");

                entity.Property(e => e.ErrorMessageDetails).HasColumnName("Error_Message_Details");

                entity.Property(e => e.ExtractedMessage).HasColumnName("Extracted_Message");

                entity.Property(e => e.FileImportMstId).HasColumnName("File_Import_Mst_Id");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsProcessed).HasColumnName("Is_Processed");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.MessageId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Id");

                entity.Property(e => e.NormalizedMessage).HasColumnName("Normalized_Message");

                entity.Property(e => e.ParsedMessage).HasColumnName("Parsed_Message");

                entity.Property(e => e.ReceivedCaEventDtlId).HasColumnName("Received_CA_Event_Dtl_Id");

                entity.Property(e => e.SecurityId).HasColumnName("Security_Id");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<ReceivedMasterFileProcessingDtl>(entity =>
            {
                entity.ToTable("Received_Master_File_Processing_Dtl");

                entity.HasIndex(e => e.EntryDtTimeUtc, "idx_RcvdMstFileProcessingDtl_EntryDtTimeUTC");

                entity.HasIndex(e => e.FileImportMstId, "idx_RcvdMstFileProcessingDtl_FileImportMstId");

                entity.Property(e => e.ReceivedMasterFileProcessingDtlId).HasColumnName("Received_Master_File_Processing_Dtl_Id");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorMessageDetails).HasColumnName("Error_Message_Details");

                entity.Property(e => e.ExtractedMessage)
                    .IsRequired()
                    .HasColumnName("Extracted_Message");

                entity.Property(e => e.FileImportMstId).HasColumnName("File_Import_Mst_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsProcessed).HasColumnName("Is_Processed");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.MessageId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Id");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.TradingAccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReceivedMasterFileProcessingDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedMasterFileProcessingDtlAudit_AuditId");

                entity.ToTable("Received_Master_File_Processing_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.BloombergId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ErrorMessageDetails).HasColumnName("Error_Message_Details");

                entity.Property(e => e.ExtractedMessage).HasColumnName("Extracted_Message");

                entity.Property(e => e.FileImportMstId).HasColumnName("File_Import_Mst_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsProcessed).HasColumnName("Is_Processed");

                entity.Property(e => e.Isin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.MessageId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Message_Id");

                entity.Property(e => e.ReceivedMasterFileProcessingDtlId).HasColumnName("Received_Master_File_Processing_Dtl_Id");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.TradingAccountNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReceivedPaymentAccountHistory>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntAccountHistoryId)
                    .HasName("PK_ReceivedPaymentAccountHistory_RcvdPymnAccHistId");

                entity.ToTable("Received_Payment_Account_History");

                entity.Property(e => e.RcvdPymntAccountHistoryId).HasColumnName("Rcvd_Pymnt_Account_History_Id");

                entity.Property(e => e.AccountCd)
                    .HasMaxLength(5)
                    .HasColumnName("Account_Cd");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(8)
                    .HasColumnName("Account_Id");

                entity.Property(e => e.Action).HasMaxLength(1);

                entity.Property(e => e.ActivityChCd)
                    .HasMaxLength(2)
                    .HasColumnName("Activity_Ch_Cd");

                entity.Property(e => e.BatchCd)
                    .HasMaxLength(2)
                    .HasColumnName("Batch_Cd");

                entity.Property(e => e.BatchDcltnNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Batch_Dcltn_Nbr");

                entity.Property(e => e.Bbgid)
                    .HasMaxLength(100)
                    .HasColumnName("BBGID");

                entity.Property(e => e.BranchCd)
                    .HasMaxLength(3)
                    .HasColumnName("Branch_Cd");

                entity.Property(e => e.BusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Business_Date");

                entity.Property(e => e.ChkBrchAcctNbr)
                    .HasMaxLength(1)
                    .HasColumnName("Chk_Brch_Acct_Nbr");

                entity.Property(e => e.ClientNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Client_Nbr");

                entity.Property(e => e.CommAmt).HasColumnName("Comm_Amt");

                entity.Property(e => e.CreditGrossAmt).HasColumnName("Credit_Gross_Amt");

                entity.Property(e => e.CurrencyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Currency_Cd");

                entity.Property(e => e.Cusip).HasMaxLength(100);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryCd)
                    .HasMaxLength(3)
                    .HasColumnName("Entry_Cd");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.EntryIncomeCd)
                    .HasMaxLength(5)
                    .HasColumnName("Entry_Income_Cd");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isin).HasMaxLength(100);

                entity.Property(e => e.ItemDcltnNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Item_Dcltn_Nbr");

                entity.Property(e => e.LocationCd)
                    .HasMaxLength(3)
                    .HasColumnName("Location_Cd");

                entity.Property(e => e.OnlineAddInd)
                    .HasMaxLength(1)
                    .HasColumnName("Online_Add_Ind");

                entity.Property(e => e.PriceTrdAmtTxt)
                    .HasMaxLength(9)
                    .HasColumnName("Price_Trd_Amt_Txt");

                entity.Property(e => e.ProcessingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Processing_Dt");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RrCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rr_Cd");

                entity.Property(e => e.RrTransCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rr_Trans_Cd");

                entity.Property(e => e.SecmId).HasColumnName("Secm_Id");

                entity.Property(e => e.SecurityAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Security_Adp_Nbr");

                entity.Property(e => e.Sedol).HasMaxLength(100);

                entity.Property(e => e.SeqNbr).HasColumnName("Seq_Nbr");

                entity.Property(e => e.TagDcltnNbr)
                    .HasMaxLength(5)
                    .HasColumnName("Tag_Dcltn_Nbr");

                entity.Property(e => e.TaxWthldDvdAmt).HasColumnName("Tax_Wthld_Dvd_Amt");

                entity.Property(e => e.TradeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Trade_Dt");

                entity.Property(e => e.TradeSettleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Trade_Settle_Dt");

                entity.Property(e => e.TransactionAmt).HasColumnName("Transaction_Amt");

                entity.Property(e => e.TransactionDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction_Dt");

                entity.Property(e => e.TransactionQty).HasColumnName("Transaction_Qty");

                entity.Property(e => e.TypeAccountCd)
                    .HasMaxLength(1)
                    .HasColumnName("Type_Account_Cd");

                entity.Property(e => e.TypeDcltnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Type_Dcltn_Cd");

                entity.Property(e => e.TypeTranChCd)
                    .HasMaxLength(1)
                    .HasColumnName("Type_Tran_Ch_Cd");
            });

            modelBuilder.Entity<ReceivedPaymentAccountHistoryAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentAccountHistoryAudit_AuditId");

                entity.ToTable("Received_Payment_Account_History_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountCd)
                    .HasMaxLength(5)
                    .HasColumnName("Account_Cd");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(8)
                    .HasColumnName("Account_Id");

                entity.Property(e => e.Action).HasMaxLength(1);

                entity.Property(e => e.ActivityChCd)
                    .HasMaxLength(2)
                    .HasColumnName("Activity_Ch_Cd");

                entity.Property(e => e.BatchCd)
                    .HasMaxLength(2)
                    .HasColumnName("Batch_Cd");

                entity.Property(e => e.BatchDcltnNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Batch_Dcltn_Nbr");

                entity.Property(e => e.Bbgid)
                    .HasMaxLength(100)
                    .HasColumnName("BBGID");

                entity.Property(e => e.BranchCd)
                    .HasMaxLength(3)
                    .HasColumnName("Branch_Cd");

                entity.Property(e => e.BusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Business_Date");

                entity.Property(e => e.ChkBrchAcctNbr)
                    .HasMaxLength(1)
                    .HasColumnName("Chk_Brch_Acct_Nbr");

                entity.Property(e => e.ClientNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Client_Nbr");

                entity.Property(e => e.CommAmt).HasColumnName("Comm_Amt");

                entity.Property(e => e.CreditGrossAmt).HasColumnName("Credit_Gross_Amt");

                entity.Property(e => e.CurrencyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Currency_Cd");

                entity.Property(e => e.Cusip).HasMaxLength(100);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryCd)
                    .HasMaxLength(3)
                    .HasColumnName("Entry_Cd");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.EntryIncomeCd)
                    .HasMaxLength(5)
                    .HasColumnName("Entry_Income_Cd");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.Isin).HasMaxLength(100);

                entity.Property(e => e.ItemDcltnNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Item_Dcltn_Nbr");

                entity.Property(e => e.LocationCd)
                    .HasMaxLength(3)
                    .HasColumnName("Location_Cd");

                entity.Property(e => e.OnlineAddInd)
                    .HasMaxLength(1)
                    .HasColumnName("Online_Add_Ind");

                entity.Property(e => e.PriceTrdAmtTxt)
                    .HasMaxLength(9)
                    .HasColumnName("Price_Trd_Amt_Txt");

                entity.Property(e => e.ProcessingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Processing_Dt");

                entity.Property(e => e.RcvdPymntAccountHistoryId).HasColumnName("Rcvd_Pymnt_Account_History_Id");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RrCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rr_Cd");

                entity.Property(e => e.RrTransCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rr_Trans_Cd");

                entity.Property(e => e.SecmId).HasColumnName("Secm_Id");

                entity.Property(e => e.SecurityAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Security_Adp_Nbr");

                entity.Property(e => e.Sedol).HasMaxLength(100);

                entity.Property(e => e.SeqNbr).HasColumnName("Seq_Nbr");

                entity.Property(e => e.TagDcltnNbr)
                    .HasMaxLength(5)
                    .HasColumnName("Tag_Dcltn_Nbr");

                entity.Property(e => e.TaxWthldDvdAmt).HasColumnName("Tax_Wthld_Dvd_Amt");

                entity.Property(e => e.TradeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Trade_Dt");

                entity.Property(e => e.TradeSettleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Trade_Settle_Dt");

                entity.Property(e => e.TransactionAmt).HasColumnName("Transaction_Amt");

                entity.Property(e => e.TransactionDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction_Dt");

                entity.Property(e => e.TransactionQty).HasColumnName("Transaction_Qty");

                entity.Property(e => e.TypeAccountCd)
                    .HasMaxLength(1)
                    .HasColumnName("Type_Account_Cd");

                entity.Property(e => e.TypeDcltnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Type_Dcltn_Cd");

                entity.Property(e => e.TypeTranChCd)
                    .HasMaxLength(1)
                    .HasColumnName("Type_Tran_Ch_Cd");
            });

            modelBuilder.Entity<ReceivedPaymentFeedDtl>(entity =>
            {
                entity.HasKey(e => e.ReceivedPaymentFeedId)
                    .HasName("PK_ReceivedPaymentFeedDtl_ReceivedPaymentFeedId");

                entity.ToTable("Received_Payment_Feed_Dtl");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .HasColumnName("Account_Id");

                entity.Property(e => e.BatchCd)
                    .HasMaxLength(2)
                    .HasColumnName("Batch_Cd");

                entity.Property(e => e.BatchRequestId)
                    .HasMaxLength(200)
                    .HasColumnName("Batch_Request_Id");

                entity.Property(e => e.BusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Business_Date");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryCd)
                    .HasMaxLength(3)
                    .HasColumnName("Entry_Cd");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ErrorId).HasColumnName("Error_Id");

                entity.Property(e => e.ErrorMessageDetails).HasColumnName("Error_Message_Details");

                entity.Property(e => e.EventTypeId).HasColumnName("Event_Type_Id");

                entity.Property(e => e.FeedGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Feed_guid");

                entity.Property(e => e.FeedName)
                    .HasMaxLength(100)
                    .HasColumnName("Feed_Name");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsProcessed).HasColumnName("Is_Processed");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(200)
                    .HasColumnName("Request_Id");
            });

            modelBuilder.Entity<ReceivedPaymentFeedDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentFeedDtlAudit_AuditId");

                entity.ToTable("Received_Payment_Feed_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(20)
                    .HasColumnName("Account_Id");

                entity.Property(e => e.BatchCd)
                    .HasMaxLength(2)
                    .HasColumnName("Batch_Cd");

                entity.Property(e => e.BatchRequestId)
                    .HasMaxLength(200)
                    .HasColumnName("Batch_Request_Id");

                entity.Property(e => e.BusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Business_Date");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryCd)
                    .HasMaxLength(3)
                    .HasColumnName("Entry_Cd");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ErrorId).HasColumnName("Error_Id");

                entity.Property(e => e.ErrorMessageDetails).HasColumnName("Error_Message_Details");

                entity.Property(e => e.EventTypeId).HasColumnName("Event_Type_Id");

                entity.Property(e => e.FeedGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Feed_guid");

                entity.Property(e => e.FeedName)
                    .HasMaxLength(100)
                    .HasColumnName("Feed_Name");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsProcessed).HasColumnName("Is_Processed");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(200)
                    .HasColumnName("Request_Id");
            });

            modelBuilder.Entity<ReceivedPaymentFeedDtlExctractedMsg>(entity =>
            {
                entity.HasKey(e => e.ReceivedPaymentFeedMsgId)
                    .HasName("PK_ReceivedPaymentFeedDtlExtrctMsg_ReceivedPaymentFeedMsgId");

                entity.ToTable("Received_Payment_Feed_Dtl_Exctracted_Msg");

                entity.Property(e => e.ReceivedPaymentFeedMsgId).HasColumnName("Received_Payment_Feed_Msg_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExtractedMessage).HasColumnName("Extracted_Message");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");
            });

            modelBuilder.Entity<ReceivedPaymentFeedDtlExctractedMsgAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentFeedDtlExtrctMsgAudit_AuditId");

                entity.ToTable("Received_Payment_Feed_Dtl_Exctracted_Msg_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExtractedMessage).HasColumnName("Extracted_Message");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.ReceivedPaymentFeedMsgId).HasColumnName("Received_Payment_Feed_Msg_Id");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmt>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntReOrgAnnsmtId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmt_RcvdPymntReOrgAnnsmtId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.AllDatesChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("All_Dates_Chg_Ind");

                entity.Property(e => e.AnnsmtChgSrcTxt)
                    .HasMaxLength(4)
                    .HasColumnName("Annsmt_Chg_Src_Txt");

                entity.Property(e => e.AnnsmtCrtCd)
                    .HasMaxLength(1)
                    .HasColumnName("Annsmt_Crt_Cd");

                entity.Property(e => e.AnnsmtCrtSrcTxt)
                    .HasMaxLength(4)
                    .HasColumnName("Annsmt_Crt_Src_Txt");

                entity.Property(e => e.AnnsmtRcrdCd)
                    .HasMaxLength(1)
                    .HasColumnName("Annsmt_Rcrd_Cd");

                entity.Property(e => e.AnnsmtTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Annsmt_Type_Cd");

                entity.Property(e => e.AnnsmtUpdtCd)
                    .HasMaxLength(2)
                    .HasColumnName("Annsmt_Updt_Cd");

                entity.Property(e => e.AsOfPyblDt)
                    .HasColumnType("datetime")
                    .HasColumnName("As_Of_Pybl_Dt");

                entity.Property(e => e.BrAccessInd)
                    .HasMaxLength(1)
                    .HasColumnName("Br_Access_Ind");

                entity.Property(e => e.CallDenomNbr).HasColumnName("Call_Denom_Nbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Dt");

                entity.Property(e => e.ChangeTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Tm");

                entity.Property(e => e.ClientNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Client_Nbr");

                entity.Property(e => e.ConsentDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Consent_Dt");

                entity.Property(e => e.CorpActionId)
                    .HasMaxLength(16)
                    .HasColumnName("Corp_Action_Id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Dt");

                entity.Property(e => e.CreateTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Tm");

                entity.Property(e => e.CusipExtCd)
                    .HasMaxLength(3)
                    .HasColumnName("Cusip_Ext_Cd");

                entity.Property(e => e.CusipNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Cusip_Nbr");

                entity.Property(e => e.CvrsnExerPrcAmt).HasColumnName("Cvrsn_Exer_Prc_Amt");

                entity.Property(e => e.CvsnExerCrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Cvsn_Exer_Crncy_Cd");

                entity.Property(e => e.DatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Dated_Dt");

                entity.Property(e => e.DescSecLine1Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Desc_Sec_Line1_Txt");

                entity.Property(e => e.DescSecLine2Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Desc_Sec_Line2_Txt");

                entity.Property(e => e.DescSecLine3Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Desc_Sec_Line3_Txt");

                entity.Property(e => e.DtcElgblInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Elgbl_Ind");

                entity.Property(e => e.DtcQlfdInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Qlfd_Ind");

                entity.Property(e => e.EffectiveDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Effective_Dt");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExpTmZoneCd)
                    .HasMaxLength(3)
                    .HasColumnName("Exp_Tm_Zone_Cd");

                entity.Property(e => e.ExpirationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiration_Dt");

                entity.Property(e => e.ExpirationTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiration_Tm");

                entity.Property(e => e.ExpirationTmCd)
                    .HasMaxLength(1)
                    .HasColumnName("Expiration_Tm_Cd");

                entity.Property(e => e.FeeAmt).HasColumnName("Fee_Amt");

                entity.Property(e => e.FrstNtfctnDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Frst_Ntfctn_Dt");

                entity.Property(e => e.FrstntfDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Frstntf_Dt_Chg_Ind");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastNtfctnDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Ntfctn_Dt");

                entity.Property(e => e.LastntfDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Lastntf_Dt_Chg_Ind");

                entity.Property(e => e.NotificationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Notification_Dt");

                entity.Property(e => e.OffererNm)
                    .HasMaxLength(30)
                    .HasColumnName("Offerer_Nm");

                entity.Property(e => e.PayableDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Payable_Dt");

                entity.Property(e => e.ProrationFctrNbr).HasColumnName("Proration_Fctr_Nbr");

                entity.Property(e => e.ProrationInd)
                    .HasMaxLength(1)
                    .HasColumnName("Proration_Ind");

                entity.Property(e => e.PrortRndFctrNbr).HasColumnName("Prort_Rnd_Fctr_Nbr");

                entity.Property(e => e.PrtctInfoChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Prtct_Info_Chg_Ind");

                entity.Property(e => e.PrtctPeriodCd)
                    .HasMaxLength(1)
                    .HasColumnName("Prtct_Period_Cd");

                entity.Property(e => e.PrtctPeriodNbr).HasColumnName("Prtct_Period_Nbr");

                entity.Property(e => e.PublicationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Publication_Dt");

                entity.Property(e => e.PutDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Put_Dt");

                entity.Property(e => e.PutDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Put_Dt_Chg_Ind");

                entity.Property(e => e.QspExistInd)
                    .HasMaxLength(1)
                    .HasColumnName("Qsp_Exist_Ind");

                entity.Property(e => e.QspVrtnPct).HasColumnName("Qsp_Vrtn_Pct");

                entity.Property(e => e.RateOptNbr).HasColumnName("Rate_Opt_Nbr");

                entity.Property(e => e.RateTermNbr).HasColumnName("Rate_Term_Nbr");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Record_Dt");

                entity.Property(e => e.RecordDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Record_Dt_Chg_Ind");

                entity.Property(e => e.RedemptionDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Redemption_Dt");

                entity.Property(e => e.ReorgTrdOspCd)
                    .HasMaxLength(4)
                    .HasColumnName("Reorg_Trd_Osp_Cd");

                entity.Property(e => e.RspExistInd)
                    .HasMaxLength(1)
                    .HasColumnName("Rsp_Exist_Ind");

                entity.Property(e => e.SecurityAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Security_Adp_Nbr");

                entity.Property(e => e.SellPrcAmt).HasColumnName("Sell_Prc_Amt");

                entity.Property(e => e.StockRcrdInd)
                    .HasMaxLength(1)
                    .HasColumnName("Stock_Rcrd_Ind");

                entity.Property(e => e.SymbolTxt)
                    .HasMaxLength(8)
                    .HasColumnName("Symbol_Txt");

                entity.Property(e => e.UniqueNbr).HasColumnName("Unique_Nbr");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");

                entity.Property(e => e.VendorDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Vendor_Dt");

                entity.Property(e => e.WithdrawalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Withdrawal_Dt");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmtAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmtAudit_AuditId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.AllDatesChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("All_Dates_Chg_Ind");

                entity.Property(e => e.AnnsmtChgSrcTxt)
                    .HasMaxLength(4)
                    .HasColumnName("Annsmt_Chg_Src_Txt");

                entity.Property(e => e.AnnsmtCrtCd)
                    .HasMaxLength(1)
                    .HasColumnName("Annsmt_Crt_Cd");

                entity.Property(e => e.AnnsmtCrtSrcTxt)
                    .HasMaxLength(4)
                    .HasColumnName("Annsmt_Crt_Src_Txt");

                entity.Property(e => e.AnnsmtRcrdCd)
                    .HasMaxLength(1)
                    .HasColumnName("Annsmt_Rcrd_Cd");

                entity.Property(e => e.AnnsmtTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Annsmt_Type_Cd");

                entity.Property(e => e.AnnsmtUpdtCd)
                    .HasMaxLength(2)
                    .HasColumnName("Annsmt_Updt_Cd");

                entity.Property(e => e.AsOfPyblDt)
                    .HasColumnType("datetime")
                    .HasColumnName("As_Of_Pybl_Dt");

                entity.Property(e => e.BrAccessInd)
                    .HasMaxLength(1)
                    .HasColumnName("Br_Access_Ind");

                entity.Property(e => e.CallDenomNbr).HasColumnName("Call_Denom_Nbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Dt");

                entity.Property(e => e.ChangeTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Tm");

                entity.Property(e => e.ClientNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Client_Nbr");

                entity.Property(e => e.ConsentDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Consent_Dt");

                entity.Property(e => e.CorpActionId)
                    .HasMaxLength(16)
                    .HasColumnName("Corp_Action_Id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Dt");

                entity.Property(e => e.CreateTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Tm");

                entity.Property(e => e.CusipExtCd)
                    .HasMaxLength(3)
                    .HasColumnName("Cusip_Ext_Cd");

                entity.Property(e => e.CusipNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Cusip_Nbr");

                entity.Property(e => e.CvrsnExerPrcAmt).HasColumnName("Cvrsn_Exer_Prc_Amt");

                entity.Property(e => e.CvsnExerCrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Cvsn_Exer_Crncy_Cd");

                entity.Property(e => e.DatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Dated_Dt");

                entity.Property(e => e.DescSecLine1Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Desc_Sec_Line1_Txt");

                entity.Property(e => e.DescSecLine2Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Desc_Sec_Line2_Txt");

                entity.Property(e => e.DescSecLine3Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Desc_Sec_Line3_Txt");

                entity.Property(e => e.DtcElgblInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Elgbl_Ind");

                entity.Property(e => e.DtcQlfdInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Qlfd_Ind");

                entity.Property(e => e.EffectiveDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Effective_Dt");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExpTmZoneCd)
                    .HasMaxLength(3)
                    .HasColumnName("Exp_Tm_Zone_Cd");

                entity.Property(e => e.ExpirationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiration_Dt");

                entity.Property(e => e.ExpirationTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiration_Tm");

                entity.Property(e => e.ExpirationTmCd)
                    .HasMaxLength(1)
                    .HasColumnName("Expiration_Tm_Cd");

                entity.Property(e => e.FeeAmt).HasColumnName("Fee_Amt");

                entity.Property(e => e.FrstNtfctnDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Frst_Ntfctn_Dt");

                entity.Property(e => e.FrstntfDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Frstntf_Dt_Chg_Ind");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LastNtfctnDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Ntfctn_Dt");

                entity.Property(e => e.LastntfDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Lastntf_Dt_Chg_Ind");

                entity.Property(e => e.NotificationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Notification_Dt");

                entity.Property(e => e.OffererNm)
                    .HasMaxLength(30)
                    .HasColumnName("Offerer_Nm");

                entity.Property(e => e.PayableDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Payable_Dt");

                entity.Property(e => e.ProrationFctrNbr).HasColumnName("Proration_Fctr_Nbr");

                entity.Property(e => e.ProrationInd)
                    .HasMaxLength(1)
                    .HasColumnName("Proration_Ind");

                entity.Property(e => e.PrortRndFctrNbr).HasColumnName("Prort_Rnd_Fctr_Nbr");

                entity.Property(e => e.PrtctInfoChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Prtct_Info_Chg_Ind");

                entity.Property(e => e.PrtctPeriodCd)
                    .HasMaxLength(1)
                    .HasColumnName("Prtct_Period_Cd");

                entity.Property(e => e.PrtctPeriodNbr).HasColumnName("Prtct_Period_Nbr");

                entity.Property(e => e.PublicationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Publication_Dt");

                entity.Property(e => e.PutDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Put_Dt");

                entity.Property(e => e.PutDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Put_Dt_Chg_Ind");

                entity.Property(e => e.QspExistInd)
                    .HasMaxLength(1)
                    .HasColumnName("Qsp_Exist_Ind");

                entity.Property(e => e.QspVrtnPct).HasColumnName("Qsp_Vrtn_Pct");

                entity.Property(e => e.RateOptNbr).HasColumnName("Rate_Opt_Nbr");

                entity.Property(e => e.RateTermNbr).HasColumnName("Rate_Term_Nbr");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_Id");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Record_Dt");

                entity.Property(e => e.RecordDtChgInd)
                    .HasMaxLength(1)
                    .HasColumnName("Record_Dt_Chg_Ind");

                entity.Property(e => e.RedemptionDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Redemption_Dt");

                entity.Property(e => e.ReorgTrdOspCd)
                    .HasMaxLength(4)
                    .HasColumnName("Reorg_Trd_Osp_Cd");

                entity.Property(e => e.RspExistInd)
                    .HasMaxLength(1)
                    .HasColumnName("Rsp_Exist_Ind");

                entity.Property(e => e.SecurityAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Security_Adp_Nbr");

                entity.Property(e => e.SellPrcAmt).HasColumnName("Sell_Prc_Amt");

                entity.Property(e => e.StockRcrdInd)
                    .HasMaxLength(1)
                    .HasColumnName("Stock_Rcrd_Ind");

                entity.Property(e => e.SymbolTxt)
                    .HasMaxLength(8)
                    .HasColumnName("Symbol_Txt");

                entity.Property(e => e.UniqueNbr).HasColumnName("Unique_Nbr");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");

                entity.Property(e => e.VendorDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Vendor_Dt");

                entity.Property(e => e.WithdrawalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Withdrawal_Dt");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmtRate>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntReOrgAnnsmtRateId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmtRate_RcvdPymntReOrgAnnsmtRateId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt_Rate");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtRateId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_Rate_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.AltBondInd)
                    .HasMaxLength(1)
                    .HasColumnName("Alt_Bond_Ind");

                entity.Property(e => e.AltCusipCtryCd)
                    .HasMaxLength(2)
                    .HasColumnName("Alt_Cusip_Ctry_Cd");

                entity.Property(e => e.AltCusipExtCd)
                    .HasMaxLength(3)
                    .HasColumnName("Alt_Cusip_Ext_Cd");

                entity.Property(e => e.AltCusipNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Alt_Cusip_Nbr");

                entity.Property(e => e.AltDescLn1Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Alt_DescLn1_Txt");

                entity.Property(e => e.AltDescLn2Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Alt_DescLn2_Txt");

                entity.Property(e => e.AltDescLn3Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Alt_DescLn3_Txt");

                entity.Property(e => e.AltDvdndRecDt).HasColumnName("Alt_Dvdnd_Rec_Dt");

                entity.Property(e => e.AltScrtyAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Alt_Scrty_Adp_Nbr");

                entity.Property(e => e.AltSymbolTxt)
                    .HasMaxLength(8)
                    .HasColumnName("Alt_Symbol_Txt");

                entity.Property(e => e.AnnsmtOptionNbr).HasColumnName("Annsmt_Option_Nbr");

                entity.Property(e => e.BbDistRt).HasColumnName("Bb_Dist_Rt");

                entity.Property(e => e.CashCrrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Cash_Crrncy_Cd");

                entity.Property(e => e.CashInLieuRt).HasColumnName("Cash_In_Lieu_Rt");

                entity.Property(e => e.CashRt).HasColumnName("Cash_Rt");

                entity.Property(e => e.CcDescLn1Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Cc_Desc_Ln1_Txt");

                entity.Property(e => e.CcDescLn2Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Cc_Desc_Ln2_Txt");

                entity.Property(e => e.CcDescLn3Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Cc_Desc_Ln3_Txt");

                entity.Property(e => e.CcScrtyAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Cc_Scrty_Adp_Nbr");

                entity.Property(e => e.CilCrrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Cil_Crrncy_Cd");

                entity.Property(e => e.DivIntRt).HasColumnName("Div_Int_Rt");

                entity.Property(e => e.DtcCusipCntryCd)
                    .HasMaxLength(2)
                    .HasColumnName("Dtc_Cusip_Cntry_Cd");

                entity.Property(e => e.DtcCusipExtCd)
                    .HasMaxLength(3)
                    .HasColumnName("Dtc_Cusip_Ext_Cd");

                entity.Property(e => e.DtcCusipNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Dtc_Cusip_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FrctnRndFctrNbr).HasColumnName("Frctn_Rnd_Fctr_Nbr");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QspPct).HasColumnName("Qsp_Pct");

                entity.Property(e => e.RateTrlr1)
                    .HasMaxLength(30)
                    .HasColumnName("Rate_Trlr1");

                entity.Property(e => e.RateTrlr2)
                    .HasMaxLength(30)
                    .HasColumnName("Rate_Trlr2");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RspPct).HasColumnName("Rsp_Pct");

                entity.Property(e => e.UnitSizeNbr).HasColumnName("Unit_Size_Nbr");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmtRateAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmtRateAudit_AuditId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt_Rate_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.AltBondInd)
                    .HasMaxLength(1)
                    .HasColumnName("Alt_Bond_Ind");

                entity.Property(e => e.AltCusipCtryCd)
                    .HasMaxLength(2)
                    .HasColumnName("Alt_Cusip_Ctry_Cd");

                entity.Property(e => e.AltCusipExtCd)
                    .HasMaxLength(3)
                    .HasColumnName("Alt_Cusip_Ext_Cd");

                entity.Property(e => e.AltCusipNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Alt_Cusip_Nbr");

                entity.Property(e => e.AltDescLn1Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Alt_DescLn1_Txt");

                entity.Property(e => e.AltDescLn2Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Alt_DescLn2_Txt");

                entity.Property(e => e.AltDescLn3Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Alt_DescLn3_Txt");

                entity.Property(e => e.AltDvdndRecDt).HasColumnName("Alt_Dvdnd_Rec_Dt");

                entity.Property(e => e.AltScrtyAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Alt_Scrty_Adp_Nbr");

                entity.Property(e => e.AltSymbolTxt)
                    .HasMaxLength(8)
                    .HasColumnName("Alt_Symbol_Txt");

                entity.Property(e => e.AnnsmtOptionNbr).HasColumnName("Annsmt_Option_Nbr");

                entity.Property(e => e.BbDistRt).HasColumnName("Bb_Dist_Rt");

                entity.Property(e => e.CashCrrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Cash_Crrncy_Cd");

                entity.Property(e => e.CashInLieuRt).HasColumnName("Cash_In_Lieu_Rt");

                entity.Property(e => e.CashRt).HasColumnName("Cash_Rt");

                entity.Property(e => e.CcDescLn1Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Cc_Desc_Ln1_Txt");

                entity.Property(e => e.CcDescLn2Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Cc_Desc_Ln2_Txt");

                entity.Property(e => e.CcDescLn3Txt)
                    .HasMaxLength(30)
                    .HasColumnName("Cc_Desc_Ln3_Txt");

                entity.Property(e => e.CcScrtyAdpNbr)
                    .HasMaxLength(7)
                    .HasColumnName("Cc_Scrty_Adp_Nbr");

                entity.Property(e => e.CilCrrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Cil_Crrncy_Cd");

                entity.Property(e => e.DivIntRt).HasColumnName("Div_Int_Rt");

                entity.Property(e => e.DtcCusipCntryCd)
                    .HasMaxLength(2)
                    .HasColumnName("Dtc_Cusip_Cntry_Cd");

                entity.Property(e => e.DtcCusipExtCd)
                    .HasMaxLength(3)
                    .HasColumnName("Dtc_Cusip_Ext_Cd");

                entity.Property(e => e.DtcCusipNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Dtc_Cusip_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.FrctnRndFctrNbr).HasColumnName("Frctn_Rnd_Fctr_Nbr");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.QspPct).HasColumnName("Qsp_Pct");

                entity.Property(e => e.RateTrlr1)
                    .HasMaxLength(30)
                    .HasColumnName("Rate_Trlr1");

                entity.Property(e => e.RateTrlr2)
                    .HasMaxLength(30)
                    .HasColumnName("Rate_Trlr2");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtRateId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_Rate_Id");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RspPct).HasColumnName("Rsp_Pct");

                entity.Property(e => e.UnitSizeNbr).HasColumnName("Unit_Size_Nbr");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmtText>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntReOrgAnnsmtTxtId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmtText_RcvdPymntReOrgAnnsmtTxtId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt_Text");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtTxtId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_Txt_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Dt");

                entity.Property(e => e.ChangeTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Tm");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Dt");

                entity.Property(e => e.CreateTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Tm");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KeyTrlr)
                    .HasMaxLength(4)
                    .HasColumnName("Key_Trlr");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.RecTypeId)
                    .HasMaxLength(1)
                    .HasColumnName("Rec_Type_Id");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.TermId)
                    .HasMaxLength(4)
                    .HasColumnName("Term_Id");

                entity.Property(e => e.TextMsg)
                    .HasMaxLength(750)
                    .HasColumnName("Text_Msg");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("User_Id");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmtTextAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmtTextAudit_AuditId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt_Text_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Dt");

                entity.Property(e => e.ChangeTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_Tm");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Dt");

                entity.Property(e => e.CreateTm)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Tm");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.KeyTrlr)
                    .HasMaxLength(4)
                    .HasColumnName("Key_Trlr");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtTxtId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_Txt_Id");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.RecTypeId)
                    .HasMaxLength(1)
                    .HasColumnName("Rec_Type_Id");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.TermId)
                    .HasMaxLength(4)
                    .HasColumnName("Term_Id");

                entity.Property(e => e.TextMsg)
                    .HasMaxLength(750)
                    .HasColumnName("Text_Msg");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("User_Id");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmtUser>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntReOrgAnnsmtUserId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmtUser_RcvdPymntReOrgAnnsmtUserId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt_User");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtUserId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_User_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.AnnsCommentTxt)
                    .HasMaxLength(70)
                    .HasColumnName("Anns_Comment_Txt");

                entity.Property(e => e.AnnsFrstTrlrTxt)
                    .HasMaxLength(27)
                    .HasColumnName("Anns_Frst_Trlr_Txt");

                entity.Property(e => e.AnnsScndTrlrTxt)
                    .HasMaxLength(27)
                    .HasColumnName("Anns_Scnd_Trlr_Txt");

                entity.Property(e => e.BndsInLttryQty).HasColumnName("Bnds_In_Lttry_Qty");

                entity.Property(e => e.BondsCalledQty).HasColumnName("Bonds_Called_Qty");

                entity.Property(e => e.BrInstrTmCd)
                    .HasMaxLength(1)
                    .HasColumnName("Br_Instr_Tm_Cd");

                entity.Property(e => e.BrkrInstrctnDt).HasColumnName("Brkr_Instrctn_Dt");

                entity.Property(e => e.BrkrInstrctnTm).HasColumnName("Brkr_Instrctn_Tm");

                entity.Property(e => e.ClntRspnsRptDt).HasColumnName("Clnt_Rspns_Rpt_Dt");

                entity.Property(e => e.DropAnnsmtDt).HasColumnName("Drop_Annsmt_Dt");

                entity.Property(e => e.EarliestPyblDt).HasColumnName("Earliest_Pybl_Dt");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExprgReorgRptDt).HasColumnName("Exprg_Reorg_Rpt_Dt");

                entity.Property(e => e.IaBuyEndDt).HasColumnName("Ia_Buy_End_Dt");

                entity.Property(e => e.IaSellEndDt).HasColumnName("Ia_Sell_End_Dt");

                entity.Property(e => e.IaStartDt).HasColumnName("Ia_Start_Dt");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OsCusipNbr)
                    .HasMaxLength(12)
                    .HasColumnName("Os_Cusip_Nbr");

                entity.Property(e => e.OsPrPrtFctrNbr).HasColumnName("Os_Pr_Prt_Fctr_Nbr");

                entity.Property(e => e.OsPrimLmtQty).HasColumnName("Os_Prim_Lmt_Qty");

                entity.Property(e => e.OsPrimLmtRt).HasColumnName("Os_Prim_Lmt_Rt");

                entity.Property(e => e.OsRcrdDtInd)
                    .HasMaxLength(1)
                    .HasColumnName("Os_Rcrd_Dt_Ind");

                entity.Property(e => e.OsScPrtFctrNbr).HasColumnName("Os_Sc_Prt_Fctr_Nbr");

                entity.Property(e => e.OsScndryLmtQty).HasColumnName("Os_Scndry_Lmt_Qty");

                entity.Property(e => e.OsScndryLmtRt).HasColumnName("Os_Scndry_Lmt_Rt");

                entity.Property(e => e.PtActualDt).HasColumnName("Pt_Actual_Dt");

                entity.Property(e => e.PtSchdlDt).HasColumnName("Pt_Schdl_Dt");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.SubAcctCd)
                    .HasMaxLength(5)
                    .HasColumnName("Sub_Acct_Cd");

                entity.Property(e => e.SubAcctCdgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_Acct_Cdg_Cd");

                entity.Property(e => e.SubAcctTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_Acct_Type_Cd");

                entity.Property(e => e.SubBranchCd)
                    .HasMaxLength(3)
                    .HasColumnName("Sub_Branch_Cd");

                entity.Property(e => e.SubOvrdCrrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Sub_Ovrd_Crrncy_Cd");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentFeedReOrgAnnsmtUserAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentFeedReOrgAnnsmtUserAudit_AuditId");

                entity.ToTable("Received_Payment_Feed_ReOrg_Annsmt_User_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.AnnsCommentTxt)
                    .HasMaxLength(70)
                    .HasColumnName("Anns_Comment_Txt");

                entity.Property(e => e.AnnsFrstTrlrTxt)
                    .HasMaxLength(27)
                    .HasColumnName("Anns_Frst_Trlr_Txt");

                entity.Property(e => e.AnnsScndTrlrTxt)
                    .HasMaxLength(27)
                    .HasColumnName("Anns_Scnd_Trlr_Txt");

                entity.Property(e => e.BndsInLttryQty).HasColumnName("Bnds_In_Lttry_Qty");

                entity.Property(e => e.BondsCalledQty).HasColumnName("Bonds_Called_Qty");

                entity.Property(e => e.BrInstrTmCd)
                    .HasMaxLength(1)
                    .HasColumnName("Br_Instr_Tm_Cd");

                entity.Property(e => e.BrkrInstrctnDt).HasColumnName("Brkr_Instrctn_Dt");

                entity.Property(e => e.BrkrInstrctnTm).HasColumnName("Brkr_Instrctn_Tm");

                entity.Property(e => e.ClntRspnsRptDt).HasColumnName("Clnt_Rspns_Rpt_Dt");

                entity.Property(e => e.DropAnnsmtDt).HasColumnName("Drop_Annsmt_Dt");

                entity.Property(e => e.EarliestPyblDt).HasColumnName("Earliest_Pybl_Dt");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExprgReorgRptDt).HasColumnName("Exprg_Reorg_Rpt_Dt");

                entity.Property(e => e.IaBuyEndDt).HasColumnName("Ia_Buy_End_Dt");

                entity.Property(e => e.IaSellEndDt).HasColumnName("Ia_Sell_End_Dt");

                entity.Property(e => e.IaStartDt).HasColumnName("Ia_Start_Dt");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.OsCusipNbr)
                    .HasMaxLength(12)
                    .HasColumnName("Os_Cusip_Nbr");

                entity.Property(e => e.OsPrPrtFctrNbr).HasColumnName("Os_Pr_Prt_Fctr_Nbr");

                entity.Property(e => e.OsPrimLmtQty).HasColumnName("Os_Prim_Lmt_Qty");

                entity.Property(e => e.OsPrimLmtRt).HasColumnName("Os_Prim_Lmt_Rt");

                entity.Property(e => e.OsRcrdDtInd)
                    .HasMaxLength(1)
                    .HasColumnName("Os_Rcrd_Dt_Ind");

                entity.Property(e => e.OsScPrtFctrNbr).HasColumnName("Os_Sc_Prt_Fctr_Nbr");

                entity.Property(e => e.OsScndryLmtQty).HasColumnName("Os_Scndry_Lmt_Qty");

                entity.Property(e => e.OsScndryLmtRt).HasColumnName("Os_Scndry_Lmt_Rt");

                entity.Property(e => e.PtActualDt).HasColumnName("Pt_Actual_Dt");

                entity.Property(e => e.PtSchdlDt).HasColumnName("Pt_Schdl_Dt");

                entity.Property(e => e.RcvdPymntReOrgAnnsmtUserId).HasColumnName("Rcvd_Pymnt_ReOrg_Annsmt_User_Id");

                entity.Property(e => e.RecTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Rec_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.SubAcctCd)
                    .HasMaxLength(5)
                    .HasColumnName("Sub_Acct_Cd");

                entity.Property(e => e.SubAcctCdgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_Acct_Cdg_Cd");

                entity.Property(e => e.SubAcctTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_Acct_Type_Cd");

                entity.Property(e => e.SubBranchCd)
                    .HasMaxLength(3)
                    .HasColumnName("Sub_Branch_Cd");

                entity.Property(e => e.SubOvrdCrrncyCd)
                    .HasMaxLength(2)
                    .HasColumnName("Sub_Ovrd_Crrncy_Cd");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentVendorAncmt>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntVendorAncmtId)
                    .HasName("PK_ReceivedPaymentVendorAncmt_RcvdPymnVndrAncAmtId");

                entity.ToTable("Received_Payment_Vendor_Ancmt");

                entity.Property(e => e.RcvdPymntVendorAncmtId).HasColumnName("Rcvd_Pymnt_Vendor_Ancmt_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.BkgDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Bkg_Dt_Nbr");

                entity.Property(e => e.CdgCusipCd)
                    .HasMaxLength(1)
                    .HasColumnName("Cdg_Cusip_Cd");

                entity.Property(e => e.ClntRvsnCd)
                    .HasMaxLength(1)
                    .HasColumnName("Clnt_Rvsn_Cd");

                entity.Property(e => e.CntntCd)
                    .HasMaxLength(3)
                    .HasColumnName("Cntnt_Cd");

                entity.Property(e => e.CrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Crncy_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.CusipExtendNbr)
                    .HasMaxLength(3)
                    .HasColumnName("Cusip_Extend_Nbr");

                entity.Property(e => e.CusipIntrlExNbr)
                    .HasMaxLength(3)
                    .HasColumnName("Cusip_Intrl_Ex_Nbr");

                entity.Property(e => e.CusipNbr)
                    .HasMaxLength(8)
                    .HasColumnName("Cusip_Nbr");

                entity.Property(e => e.DbllOffDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dbll_Off_Dt_Nbr");

                entity.Property(e => e.DbllOnDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dbll_On_Dt_Nbr");

                entity.Property(e => e.DbllRdmptDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dbll_Rdmpt_Dt_Nbr");

                entity.Property(e => e.DclrnDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dclrn_Dt_Nbr");

                entity.Property(e => e.DivpMstrCd)
                    .HasMaxLength(1)
                    .HasColumnName("Divp_Mstr_Cd");

                entity.Property(e => e.DtcAssetClass)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Asset_Class");

                entity.Property(e => e.DtcCaId)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Ca_Id");

                entity.Property(e => e.DtcElgblInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Elgbl_Ind");

                entity.Property(e => e.DtcEventType)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Event_Type");

                entity.Property(e => e.DtcFnctnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Dtc_Fnctn_Cd");

                entity.Property(e => e.DtcInterimInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Interim_Ind");

                entity.Property(e => e.DtcOptnNbr)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Optn_Nbr");

                entity.Property(e => e.DtcSeqNbr)
                    .HasMaxLength(3)
                    .HasColumnName("Dtc_Seq_Nbr");

                entity.Property(e => e.DtcTermId)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Term_Id");

                entity.Property(e => e.DvdndTypeCd)
                    .HasMaxLength(2)
                    .HasColumnName("Dvdnd_Type_Cd");

                entity.Property(e => e.EntrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Entr_Cd");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Ex_Dt_Nbr");

                entity.Property(e => e.FtntCd)
                    .HasMaxLength(2)
                    .HasColumnName("Ftnt_Cd");

                entity.Property(e => e.IdsiRt)
                    .HasMaxLength(13)
                    .HasColumnName("Idsi_Rt");

                entity.Property(e => e.InitPymntCd)
                    .HasMaxLength(2)
                    .HasColumnName("Init_Pymnt_Cd");

                entity.Property(e => e.InterimOffDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Interim_Off_Dt_Nbr");

                entity.Property(e => e.InterimOnDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Interim_On_Dt_Nbr");

                entity.Property(e => e.InvalidCd)
                    .HasMaxLength(1)
                    .HasColumnName("Invalid_Cd");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IssTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Iss_Type_Cd");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.LngShrtCd)
                    .HasMaxLength(2)
                    .HasColumnName("Lng_Shrt_Cd");

                entity.Property(e => e.LstRvsnSrceNm)
                    .HasMaxLength(8)
                    .HasColumnName("Lst_Rvsn_Srce_Nm");

                entity.Property(e => e.LstRvsnTmNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Lst_Rvsn_Tm_Nbr");

                entity.Property(e => e.MailCd)
                    .HasMaxLength(1)
                    .HasColumnName("Mail_Cd");

                entity.Property(e => e.MsdPymntDtNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Msd_Pymnt_Dt_Nbr");

                entity.Property(e => e.MssgDtNbr)
                    .HasMaxLength(6)
                    .HasColumnName("Mssg_Dt_Nbr");

                entity.Property(e => e.MssgNbr)
                    .HasMaxLength(2)
                    .HasColumnName("Mssg_Nbr");

                entity.Property(e => e.NycRcrdDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Nyc_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.PayDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Pay_Dt_Nbr");

                entity.Property(e => e.PrvncCd)
                    .HasMaxLength(2)
                    .HasColumnName("Prvnc_Cd");

                entity.Property(e => e.PymntAplctCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Aplct_Cd");

                entity.Property(e => e.PymntClassCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Class_Cd");

                entity.Property(e => e.PymntDescCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Desc_Cd");

                entity.Property(e => e.PymntOptnlInd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Optnl_Ind");

                entity.Property(e => e.PymntOrdrOrgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Ordr_Org_Cd");

                entity.Property(e => e.PymntSeqNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Pymnt_Seq_Nbr");

                entity.Property(e => e.PymntTypeCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Type_Cd");

                entity.Property(e => e.PymntTypeOrgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Type_Org_Cd");

                entity.Property(e => e.RcrdDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Rcrd_Dt_Nbr");

                entity.Property(e => e.RdpIssueTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Rdp_Issue_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RgnznCd)
                    .HasMaxLength(2)
                    .HasColumnName("Rgnzn_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.RsnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Rsn_Cd");

                entity.Property(e => e.RtTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Rt_Type_Cd");

                entity.Property(e => e.SecDfltInd)
                    .HasMaxLength(1)
                    .HasColumnName("Sec_Dflt_Ind");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.StkRcrdCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Rcrd_Cd");

                entity.Property(e => e.TakeoffSwtchCd)
                    .HasMaxLength(1)
                    .HasColumnName("Takeoff_Swtch_Cd");

                entity.Property(e => e.TaxBaseOrgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Tax_Base_Org_Cd");

                entity.Property(e => e.TaxDescCd)
                    .HasMaxLength(2)
                    .HasColumnName("Tax_Desc_Cd");

                entity.Property(e => e.UniqueCd)
                    .HasMaxLength(1)
                    .HasColumnName("Unique_Cd");

                entity.Property(e => e.UnqVndrId)
                    .HasMaxLength(16)
                    .HasColumnName("Unq_Vndr_Id");

                entity.Property(e => e.UpdtDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Updt_Dt_Nbr");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");

                entity.Property(e => e.ValorRcrdId)
                    .HasMaxLength(8)
                    .HasColumnName("Valor_Rcrd_Id");

                entity.Property(e => e.VndrLstRvsnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Vndr_Lst_Rvsn_Cd");

                entity.Property(e => e.VndrRvsn1Cd)
                    .HasMaxLength(1)
                    .HasColumnName("Vndr_Rvsn1_Cd");

                entity.Property(e => e.VndrRvsn4Cd)
                    .HasMaxLength(1)
                    .HasColumnName("Vndr_Rvsn4_Cd");

                entity.Property(e => e.XrefKeyId)
                    .HasMaxLength(9)
                    .HasColumnName("Xref_Key_Id");
            });

            modelBuilder.Entity<ReceivedPaymentVendorAncmtAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentVendorAncmtAudit_AuditId");

                entity.ToTable("Received_Payment_Vendor_Ancmt_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.BkgDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Bkg_Dt_Nbr");

                entity.Property(e => e.CdgCusipCd)
                    .HasMaxLength(1)
                    .HasColumnName("Cdg_Cusip_Cd");

                entity.Property(e => e.ClntRvsnCd)
                    .HasMaxLength(1)
                    .HasColumnName("Clnt_Rvsn_Cd");

                entity.Property(e => e.CntntCd)
                    .HasMaxLength(3)
                    .HasColumnName("Cntnt_Cd");

                entity.Property(e => e.CrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Crncy_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.CusipExtendNbr)
                    .HasMaxLength(3)
                    .HasColumnName("Cusip_Extend_Nbr");

                entity.Property(e => e.CusipIntrlExNbr)
                    .HasMaxLength(3)
                    .HasColumnName("Cusip_Intrl_Ex_Nbr");

                entity.Property(e => e.CusipNbr)
                    .HasMaxLength(8)
                    .HasColumnName("Cusip_Nbr");

                entity.Property(e => e.DbllOffDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dbll_Off_Dt_Nbr");

                entity.Property(e => e.DbllOnDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dbll_On_Dt_Nbr");

                entity.Property(e => e.DbllRdmptDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dbll_Rdmpt_Dt_Nbr");

                entity.Property(e => e.DclrnDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Dclrn_Dt_Nbr");

                entity.Property(e => e.DivpMstrCd)
                    .HasMaxLength(1)
                    .HasColumnName("Divp_Mstr_Cd");

                entity.Property(e => e.DtcAssetClass)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Asset_Class");

                entity.Property(e => e.DtcCaId)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Ca_Id");

                entity.Property(e => e.DtcElgblInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Elgbl_Ind");

                entity.Property(e => e.DtcEventType)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Event_Type");

                entity.Property(e => e.DtcFnctnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Dtc_Fnctn_Cd");

                entity.Property(e => e.DtcInterimInd)
                    .HasMaxLength(1)
                    .HasColumnName("Dtc_Interim_Ind");

                entity.Property(e => e.DtcOptnNbr)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Optn_Nbr");

                entity.Property(e => e.DtcSeqNbr)
                    .HasMaxLength(3)
                    .HasColumnName("Dtc_Seq_Nbr");

                entity.Property(e => e.DtcTermId)
                    .HasMaxLength(100)
                    .HasColumnName("Dtc_Term_Id");

                entity.Property(e => e.DvdndTypeCd)
                    .HasMaxLength(2)
                    .HasColumnName("Dvdnd_Type_Cd");

                entity.Property(e => e.EntrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Entr_Cd");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.ExDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Ex_Dt_Nbr");

                entity.Property(e => e.FtntCd)
                    .HasMaxLength(2)
                    .HasColumnName("Ftnt_Cd");

                entity.Property(e => e.IdsiRt)
                    .HasMaxLength(13)
                    .HasColumnName("Idsi_Rt");

                entity.Property(e => e.InitPymntCd)
                    .HasMaxLength(2)
                    .HasColumnName("Init_Pymnt_Cd");

                entity.Property(e => e.InterimOffDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Interim_Off_Dt_Nbr");

                entity.Property(e => e.InterimOnDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Interim_On_Dt_Nbr");

                entity.Property(e => e.InvalidCd)
                    .HasMaxLength(1)
                    .HasColumnName("Invalid_Cd");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IssTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Iss_Type_Cd");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.LngShrtCd)
                    .HasMaxLength(2)
                    .HasColumnName("Lng_Shrt_Cd");

                entity.Property(e => e.LstRvsnSrceNm)
                    .HasMaxLength(8)
                    .HasColumnName("Lst_Rvsn_Srce_Nm");

                entity.Property(e => e.LstRvsnTmNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Lst_Rvsn_Tm_Nbr");

                entity.Property(e => e.MailCd)
                    .HasMaxLength(1)
                    .HasColumnName("Mail_Cd");

                entity.Property(e => e.MsdPymntDtNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Msd_Pymnt_Dt_Nbr");

                entity.Property(e => e.MssgDtNbr)
                    .HasMaxLength(6)
                    .HasColumnName("Mssg_Dt_Nbr");

                entity.Property(e => e.MssgNbr)
                    .HasMaxLength(2)
                    .HasColumnName("Mssg_Nbr");

                entity.Property(e => e.NycRcrdDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Nyc_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.PayDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Pay_Dt_Nbr");

                entity.Property(e => e.PrvncCd)
                    .HasMaxLength(2)
                    .HasColumnName("Prvnc_Cd");

                entity.Property(e => e.PymntAplctCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Aplct_Cd");

                entity.Property(e => e.PymntClassCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Class_Cd");

                entity.Property(e => e.PymntDescCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Desc_Cd");

                entity.Property(e => e.PymntOptnlInd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Optnl_Ind");

                entity.Property(e => e.PymntOrdrOrgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Ordr_Org_Cd");

                entity.Property(e => e.PymntSeqNbr)
                    .HasMaxLength(4)
                    .HasColumnName("Pymnt_Seq_Nbr");

                entity.Property(e => e.PymntTypeCd)
                    .HasMaxLength(2)
                    .HasColumnName("Pymnt_Type_Cd");

                entity.Property(e => e.PymntTypeOrgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Type_Org_Cd");

                entity.Property(e => e.RcrdDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Rcrd_Dt_Nbr");

                entity.Property(e => e.RcvdPymntVendorAncmtId).HasColumnName("Rcvd_Pymnt_Vendor_Ancmt_Id");

                entity.Property(e => e.RdpIssueTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Rdp_Issue_Type_Cd");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RgnznCd)
                    .HasMaxLength(2)
                    .HasColumnName("Rgnzn_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.RsnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Rsn_Cd");

                entity.Property(e => e.RtTypeCd)
                    .HasMaxLength(1)
                    .HasColumnName("Rt_Type_Cd");

                entity.Property(e => e.SecDfltInd)
                    .HasMaxLength(1)
                    .HasColumnName("Sec_Dflt_Ind");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.StkRcrdCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Rcrd_Cd");

                entity.Property(e => e.TakeoffSwtchCd)
                    .HasMaxLength(1)
                    .HasColumnName("Takeoff_Swtch_Cd");

                entity.Property(e => e.TaxBaseOrgCd)
                    .HasMaxLength(1)
                    .HasColumnName("Tax_Base_Org_Cd");

                entity.Property(e => e.TaxDescCd)
                    .HasMaxLength(2)
                    .HasColumnName("Tax_Desc_Cd");

                entity.Property(e => e.UniqueCd)
                    .HasMaxLength(1)
                    .HasColumnName("Unique_Cd");

                entity.Property(e => e.UnqVndrId)
                    .HasMaxLength(16)
                    .HasColumnName("Unq_Vndr_Id");

                entity.Property(e => e.UpdtDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Updt_Dt_Nbr");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");

                entity.Property(e => e.ValorRcrdId)
                    .HasMaxLength(8)
                    .HasColumnName("Valor_Rcrd_Id");

                entity.Property(e => e.VndrLstRvsnCd)
                    .HasMaxLength(2)
                    .HasColumnName("Vndr_Lst_Rvsn_Cd");

                entity.Property(e => e.VndrRvsn1Cd)
                    .HasMaxLength(1)
                    .HasColumnName("Vndr_Rvsn1_Cd");

                entity.Property(e => e.VndrRvsn4Cd)
                    .HasMaxLength(1)
                    .HasColumnName("Vndr_Rvsn4_Cd");

                entity.Property(e => e.XrefKeyId)
                    .HasMaxLength(9)
                    .HasColumnName("Xref_Key_Id");
            });

            modelBuilder.Entity<ReceivedPaymentVendorCashDiv>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntVendorCashDivId)
                    .HasName("PK_ReceivedPaymentVendorCashDiv_RcvdPymnVndrCashDivId");

                entity.ToTable("Received_Payment_Vendor_Cash_Div");

                entity.Property(e => e.RcvdPymntVendorCashDivId).HasColumnName("Rcvd_Pymnt_Vendor_Cash_Div_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.CshCrncySymCd)
                    .HasMaxLength(2)
                    .HasColumnName("Csh_Crncy_Sym_Cd");

                entity.Property(e => e.CshDvdndCd)
                    .HasMaxLength(1)
                    .HasColumnName("Csh_Dvdnd_Cd");

                entity.Property(e => e.CshDvdndCrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Csh_Dvdnd_Crncy_Cd");

                entity.Property(e => e.CshDvdndVndrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Csh_Dvdnd_Vndr_Cd");

                entity.Property(e => e.CshFrgnWthldRt)
                    .HasMaxLength(9)
                    .HasColumnName("Csh_Frgn_Wthld_Rt");

                entity.Property(e => e.DvdndIntMsdRt)
                    .HasMaxLength(17)
                    .HasColumnName("Dvdnd_Int_Msd_Rt");

                entity.Property(e => e.DvdndShrAmt)
                    .HasMaxLength(17)
                    .HasColumnName("Dvdnd_Shr_Amt");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.PrncpCptlLqdnRt)
                    .HasMaxLength(17)
                    .HasColumnName("Prncp_Cptl_Lqdn_Rt");

                entity.Property(e => e.PymntTypeMsdCd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Type_Msd_Cd");

                entity.Property(e => e.QlfdNqlfdInd)
                    .HasMaxLength(1)
                    .HasColumnName("Qlfd_Nqlfd_Ind");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentVendorCashDivAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentVendorCashDivAudit_AuditId");

                entity.ToTable("Received_Payment_Vendor_Cash_Div_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.CshCrncySymCd)
                    .HasMaxLength(2)
                    .HasColumnName("Csh_Crncy_Sym_Cd");

                entity.Property(e => e.CshDvdndCd)
                    .HasMaxLength(1)
                    .HasColumnName("Csh_Dvdnd_Cd");

                entity.Property(e => e.CshDvdndCrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Csh_Dvdnd_Crncy_Cd");

                entity.Property(e => e.CshDvdndVndrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Csh_Dvdnd_Vndr_Cd");

                entity.Property(e => e.CshFrgnWthldRt)
                    .HasMaxLength(9)
                    .HasColumnName("Csh_Frgn_Wthld_Rt");

                entity.Property(e => e.DvdndIntMsdRt)
                    .HasMaxLength(17)
                    .HasColumnName("Dvdnd_Int_Msd_Rt");

                entity.Property(e => e.DvdndShrAmt)
                    .HasMaxLength(17)
                    .HasColumnName("Dvdnd_Shr_Amt");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.PrncpCptlLqdnRt)
                    .HasMaxLength(17)
                    .HasColumnName("Prncp_Cptl_Lqdn_Rt");

                entity.Property(e => e.PymntTypeMsdCd)
                    .HasMaxLength(1)
                    .HasColumnName("Pymnt_Type_Msd_Cd");

                entity.Property(e => e.QlfdNqlfdInd)
                    .HasMaxLength(1)
                    .HasColumnName("Qlfd_Nqlfd_Ind");

                entity.Property(e => e.RcvdPymntVendorCashDivId).HasColumnName("Rcvd_Pymnt_Vendor_Cash_Div_Id");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentVendorIntPymnt>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntVendorIntPymntId)
                    .HasName("PK_ReceivedPaymentVendorIntPymnt_RcvdPymnVndrIntPymntId");

                entity.ToTable("Received_Payment_Vendor_Int_Pymnt");

                entity.Property(e => e.RcvdPymntVendorIntPymntId).HasColumnName("Rcvd_Pymnt_Vendor_Int_Pymnt_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.CrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Crncy_Cd");

                entity.Property(e => e.CrncySymCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Sym_Cd");

                entity.Property(e => e.CrncyVndrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Vndr_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IntExtdDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Int_Extd_Dt_Nbr");

                entity.Property(e => e.IntFrgnWthldRt)
                    .HasMaxLength(9)
                    .HasColumnName("Int_Frgn_Wthld_Rt");

                entity.Property(e => e.IntMuniBndInd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Muni_Bnd_Ind");

                entity.Property(e => e.IntPymntCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Pymnt_Cd");

                entity.Property(e => e.IntPymntFreqCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Pymnt_Freq_Cd");

                entity.Property(e => e.IntRtAncmtPct)
                    .HasMaxLength(17)
                    .HasColumnName("Int_Rt_Ancmt_Pct");

                entity.Property(e => e.IntRtPymntPct)
                    .HasMaxLength(17)
                    .HasColumnName("Int_Rt_Pymnt_Pct");

                entity.Property(e => e.IntTaxCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Tax_Cd");

                entity.Property(e => e.IntVrblRt)
                    .HasMaxLength(19)
                    .HasColumnName("Int_Vrbl_Rt");

                entity.Property(e => e.IntWhiCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Whi_Cd");

                entity.Property(e => e.IntYrBaseCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Yr_Base_Cd");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentVendorIntPymntAudit>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntVendorIntPymntId)
                    .HasName("PK_ReceivedPaymentVendorIntPymntAudit_AuditId");

                entity.ToTable("Received_Payment_Vendor_Int_Pymnt_Audit");

                entity.Property(e => e.RcvdPymntVendorIntPymntId)
                    .ValueGeneratedNever()
                    .HasColumnName("Rcvd_Pymnt_Vendor_Int_Pymnt_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.AuditId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Audit_Id");

                entity.Property(e => e.CrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Crncy_Cd");

                entity.Property(e => e.CrncySymCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Sym_Cd");

                entity.Property(e => e.CrncyVndrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Vndr_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IntExtdDtNbr)
                    .HasMaxLength(10)
                    .HasColumnName("Int_Extd_Dt_Nbr");

                entity.Property(e => e.IntFrgnWthldRt)
                    .HasMaxLength(9)
                    .HasColumnName("Int_Frgn_Wthld_Rt");

                entity.Property(e => e.IntMuniBndInd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Muni_Bnd_Ind");

                entity.Property(e => e.IntPymntCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Pymnt_Cd");

                entity.Property(e => e.IntPymntFreqCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Pymnt_Freq_Cd");

                entity.Property(e => e.IntRtAncmtPct)
                    .HasMaxLength(17)
                    .HasColumnName("Int_Rt_Ancmt_Pct");

                entity.Property(e => e.IntRtPymntPct)
                    .HasMaxLength(17)
                    .HasColumnName("Int_Rt_Pymnt_Pct");

                entity.Property(e => e.IntTaxCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Tax_Cd");

                entity.Property(e => e.IntVrblRt)
                    .HasMaxLength(19)
                    .HasColumnName("Int_Vrbl_Rt");

                entity.Property(e => e.IntWhiCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Whi_Cd");

                entity.Property(e => e.IntYrBaseCd)
                    .HasMaxLength(1)
                    .HasColumnName("Int_Yr_Base_Cd");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentVendorPrncpPydn>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntVendorPrncpPydnId)
                    .HasName("PK_ReceivedPaymentVendorPrncpPydn_RcvdPymnVndrPrncpPydnId");

                entity.ToTable("Received_Payment_Vendor_Prncp_Pydn");

                entity.Property(e => e.RcvdPymntVendorPrncpPydnId).HasColumnName("Rcvd_Pymnt_Vendor_Prncp_Pydn_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.CrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Crncy_Cd");

                entity.Property(e => e.CrncySymCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Sym_Cd");

                entity.Property(e => e.CrncyVndrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Vndr_Cd");

                entity.Property(e => e.CrntFctrRt)
                    .HasMaxLength(17)
                    .HasColumnName("Crnt_Fctr_Rt");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.PrevFctrRt)
                    .HasMaxLength(17)
                    .HasColumnName("Prev_Fctr_Rt");

                entity.Property(e => e.PrncpBndRt)
                    .HasMaxLength(17)
                    .HasColumnName("Prncp_Bnd_Rt");

                entity.Property(e => e.PrncpCrnOtstAmt)
                    .HasMaxLength(12)
                    .HasColumnName("Prncp_Crn_Otst_Amt");

                entity.Property(e => e.PrncpExpltCd)
                    .HasMaxLength(2)
                    .HasColumnName("Prncp_Explt_Cd");

                entity.Property(e => e.PrncpIniOtstAmt)
                    .HasMaxLength(12)
                    .HasColumnName("Prncp_Ini_Otst_Amt");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentVendorPrncpPydnAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentVendorPrncpPydnAudit_AuditId");

                entity.ToTable("Received_Payment_Vendor_Prncp_Pydn_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.CrncyCd)
                    .HasMaxLength(3)
                    .HasColumnName("Crncy_Cd");

                entity.Property(e => e.CrncySymCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Sym_Cd");

                entity.Property(e => e.CrncyVndrCd)
                    .HasMaxLength(2)
                    .HasColumnName("Crncy_Vndr_Cd");

                entity.Property(e => e.CrntFctrRt)
                    .HasMaxLength(17)
                    .HasColumnName("Crnt_Fctr_Rt");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.PrevFctrRt)
                    .HasMaxLength(17)
                    .HasColumnName("Prev_Fctr_Rt");

                entity.Property(e => e.PrncpBndRt)
                    .HasMaxLength(17)
                    .HasColumnName("Prncp_Bnd_Rt");

                entity.Property(e => e.PrncpCrnOtstAmt)
                    .HasMaxLength(12)
                    .HasColumnName("Prncp_Crn_Otst_Amt");

                entity.Property(e => e.PrncpExpltCd)
                    .HasMaxLength(2)
                    .HasColumnName("Prncp_Explt_Cd");

                entity.Property(e => e.PrncpIniOtstAmt)
                    .HasMaxLength(12)
                    .HasColumnName("Prncp_Ini_Otst_Amt");

                entity.Property(e => e.RcvdPymntVendorPrncpPydnId).HasColumnName("Rcvd_Pymnt_Vendor_Prncp_Pydn_Id");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.UpdtLastTmstp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updt_Last_Tmstp");
            });

            modelBuilder.Entity<ReceivedPaymentVendorStkDiv>(entity =>
            {
                entity.HasKey(e => e.RcvdPymntVendorStkDivId)
                    .HasName("PK_ReceivedPaymentVendorStkDiv_RcvdPymnVndrStkDivId");

                entity.ToTable("Received_Payment_Vendor_Stk_Div");

                entity.Property(e => e.RcvdPymntVendorStkDivId).HasColumnName("Rcvd_Pymnt_Vendor_Stk_Div_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.CusipPaidOutNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Cusip_Paid_Out_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.StkDvdndCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Cd");

                entity.Property(e => e.StkDvdndDnmtrRt)
                    .HasMaxLength(6)
                    .HasColumnName("Stk_Dvdnd_Dnmtr_Rt");

                entity.Property(e => e.StkDvdndFmtCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Fmt_Cd");

                entity.Property(e => e.StkDvdndFrctnCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Frctn_Cd");

                entity.Property(e => e.StkDvdndNmrtrRt)
                    .HasMaxLength(6)
                    .HasColumnName("Stk_Dvdnd_Nmrtr_Rt");

                entity.Property(e => e.StkDvdndPymntCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Pymnt_Cd");

                entity.Property(e => e.StkDvdndRt)
                    .HasMaxLength(17)
                    .HasColumnName("Stk_Dvdnd_Rt");

                entity.Property(e => e.StkDvdndShrAmt)
                    .HasMaxLength(18)
                    .HasColumnName("Stk_Dvdnd_Shr_Amt");
            });

            modelBuilder.Entity<ReceivedPaymentVendorStkDivAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_ReceivedPaymentVendorStkDivAudit_AuditId");

                entity.ToTable("Received_Payment_Vendor_Stk_Div_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActionCd)
                    .HasMaxLength(1)
                    .HasColumnName("Action_Cd");

                entity.Property(e => e.CrtnDtNbr).HasColumnName("Crtn_Dt_Nbr");

                entity.Property(e => e.CusipPaidOutNbr)
                    .HasMaxLength(9)
                    .HasColumnName("Cusip_Paid_Out_Nbr");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IssueWhenInd)
                    .HasMaxLength(1)
                    .HasColumnName("Issue_When_Ind");

                entity.Property(e => e.KeyRcrdDtNbr).HasColumnName("Key_Rcrd_Dt_Nbr");

                entity.Property(e => e.OccursNbr).HasColumnName("Occurs_Nbr");

                entity.Property(e => e.RcvdPymntVendorStkDivId).HasColumnName("Rcvd_Pymnt_Vendor_Stk_Div_Id");

                entity.Property(e => e.ReceivedPaymentFeedId).HasColumnName("Received_Payment_Feed_Id");

                entity.Property(e => e.RecordTypeCd)
                    .HasMaxLength(3)
                    .HasColumnName("Record_Type_Cd");

                entity.Property(e => e.RltvRcrdNbr).HasColumnName("Rltv_Rcrd_Nbr");

                entity.Property(e => e.SrceId)
                    .HasMaxLength(2)
                    .HasColumnName("Srce_Id");

                entity.Property(e => e.StkDvdndCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Cd");

                entity.Property(e => e.StkDvdndDnmtrRt)
                    .HasMaxLength(6)
                    .HasColumnName("Stk_Dvdnd_Dnmtr_Rt");

                entity.Property(e => e.StkDvdndFmtCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Fmt_Cd");

                entity.Property(e => e.StkDvdndFrctnCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Frctn_Cd");

                entity.Property(e => e.StkDvdndNmrtrRt)
                    .HasMaxLength(6)
                    .HasColumnName("Stk_Dvdnd_Nmrtr_Rt");

                entity.Property(e => e.StkDvdndPymntCd)
                    .HasMaxLength(1)
                    .HasColumnName("Stk_Dvdnd_Pymnt_Cd");

                entity.Property(e => e.StkDvdndRt)
                    .HasMaxLength(17)
                    .HasColumnName("Stk_Dvdnd_Rt");

                entity.Property(e => e.StkDvdndShrAmt)
                    .HasMaxLength(18)
                    .HasColumnName("Stk_Dvdnd_Shr_Amt");
            });

            modelBuilder.Entity<RoleApplicationPermissionMapping>(entity =>
            {
                entity.HasKey(e => e.RoleAppPermissionId)
                    .HasName("PK_RoleApplicationPermissionMapping_RoleAppPermissionId");

                entity.ToTable("Role_Application_Permission_Mapping");

                entity.Property(e => e.RoleAppPermissionId).HasColumnName("Role_App_Permission_Id");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            });

            modelBuilder.Entity<RoleApplicationPermissionMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_RoleApplicationPermissionMappingAudit_AuditID");

                entity.ToTable("Role_Application_Permission_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.RoleAppPermissionId).HasColumnName("Role_App_Permission_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            });

            modelBuilder.Entity<RoleMst>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_RoleMst_RoleId");

                entity.ToTable("Role_Mst");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<RoleMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_RoleMstAudit_AuditId");

                entity.ToTable("Role_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<SafekeepingAccount>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("SafekeepingAccount");

                entity.Property(e => e.AccountCode).HasColumnName("accountCode");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");
            });

            modelBuilder.Entity<SafekeepingAccountAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_SafekeepingAccountAudit_AuditId");

                entity.ToTable("SafekeepingAccount_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AccountCode).HasColumnName("accountCode");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");
            });

            modelBuilder.Entity<SecurityMovement>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("SecurityMovement");

                entity.HasIndex(e => e.IndicatorPrimaryId, "IX_SecurityMovement_IndicatorPrimaryId");

                entity.HasIndex(e => e.McorporateActionOptionPrimaryId, "IX_SecurityMovement_MCorporateActionOptionPrimaryId");

                entity.HasIndex(e => e.CurrencyPrimaryId, "IX_SecurityMovement_currencyPrimaryId");

                entity.HasIndex(e => e.FinancialInstrumentAttributePrimaryId, "IX_SecurityMovement_financialInstrumentAttributePrimaryId");

                entity.HasIndex(e => e.FinancialInstrumentPrimaryId, "IX_SecurityMovement_financialInstrumentPrimaryId");

                entity.HasIndex(e => e.PeriodPrimaryId, "IX_SecurityMovement_periodPrimaryId");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyPrimaryId).HasColumnName("currencyPrimaryId");

                entity.Property(e => e.FinancialInstrumentAttributePrimaryId).HasColumnName("financialInstrumentAttributePrimaryId");

                entity.Property(e => e.FinancialInstrumentPrimaryId).HasColumnName("financialInstrumentPrimaryId");

                entity.Property(e => e.MatchStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.NumberId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodPrimaryId).HasColumnName("periodPrimaryId");

                entity.HasOne(d => d.CurrencyPrimary)
                    .WithMany(p => p.SecurityMovements)
                    .HasForeignKey(d => d.CurrencyPrimaryId);

                entity.HasOne(d => d.FinancialInstrumentAttributePrimary)
                    .WithMany(p => p.SecurityMovements)
                    .HasForeignKey(d => d.FinancialInstrumentAttributePrimaryId);

                entity.HasOne(d => d.FinancialInstrumentPrimary)
                    .WithMany(p => p.SecurityMovements)
                    .HasForeignKey(d => d.FinancialInstrumentPrimaryId)
                    .HasConstraintName("FK_SecurityMovement_FinancialInstruments_FinancialInstrumentPrimaryId");

                entity.HasOne(d => d.IndicatorPrimary)
                    .WithMany(p => p.SecurityMovements)
                    .HasForeignKey(d => d.IndicatorPrimaryId);

                entity.HasOne(d => d.McorporateActionOptionPrimary)
                    .WithMany(p => p.SecurityMovements)
                    .HasForeignKey(d => d.McorporateActionOptionPrimaryId);

                entity.HasOne(d => d.PeriodPrimary)
                    .WithMany(p => p.SecurityMovements)
                    .HasForeignKey(d => d.PeriodPrimaryId)
                    .HasConstraintName("FK_SecurityMovement_Period_PeriodPrimaryId");
            });

            modelBuilder.Entity<SecurityMovementAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_SecurityMovementAudit_AuditId");

                entity.ToTable("SecurityMovement_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyPrimaryId).HasColumnName("currencyPrimaryId");

                entity.Property(e => e.FinancialInstrumentAttributePrimaryId).HasColumnName("financialInstrumentAttributePrimaryId");

                entity.Property(e => e.FinancialInstrumentPrimaryId).HasColumnName("financialInstrumentPrimaryId");

                entity.Property(e => e.MatchStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.McorporateActionOptionPrimaryId).HasColumnName("MCorporateActionOptionPrimaryId");

                entity.Property(e => e.NumberId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodPrimaryId).HasColumnName("periodPrimaryId");
            });

            modelBuilder.Entity<SenderEntityBicDtl>(entity =>
            {
                entity.ToTable("Sender_Entity_BIC_Dtl");

                entity.Property(e => e.SenderEntityBicDtlId).HasColumnName("Sender_Entity_BIC_Dtl_Id");

                entity.Property(e => e.BpsEntityCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BPS_Entity_Code");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.EntityDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Entity_Description");

                entity.Property(e => e.EntityRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Entity_Region");

                entity.Property(e => e.EntityShortCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Entity_Short_Code");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReplyToEmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Reply_To_Email_Address");

                entity.Property(e => e.SenderBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Sender_BIC");

                entity.Property(e => e.SenderEnvironment)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Sender_Environment");
            });

            modelBuilder.Entity<SenderEntityBicDtlAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_SenderEntityBICDtlAudit_AuditId");

                entity.ToTable("Sender_Entity_BIC_Dtl_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.BpsEntityCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BPS_Entity_Code");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.EntityDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Entity_Description");

                entity.Property(e => e.EntityRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Entity_Region");

                entity.Property(e => e.EntityShortCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Entity_Short_Code");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.ReplyToEmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Reply_To_Email_Address");

                entity.Property(e => e.SenderBic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Sender_BIC");

                entity.Property(e => e.SenderEntityBicDtlId).HasColumnName("Sender_Entity_BIC_Dtl_Id");

                entity.Property(e => e.SenderEnvironment)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Sender_Environment");
            });

            modelBuilder.Entity<SourceConfig>(entity =>
            {
                entity.ToTable("Source_Config");

                entity.Property(e => e.SourceConfigId).HasColumnName("Source_Config_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OffsetHours).HasColumnName("Offset_Hours");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.TimeZone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Time_Zone");

                entity.Property(e => e.LOB)                    
                    .HasMaxLength(400)
                    .HasColumnName("LOB");

                entity.Property(e => e.OffsetConfig)                    
                    .HasMaxLength(400)
                    .HasColumnName("Offset_Config");

                entity.Property(e => e.DerivedOffsetConfig)
                    .HasMaxLength(400)
                    .HasColumnName("Derived_Offset_Config");
            });

            modelBuilder.Entity<SourceConfigAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_SourceConfigAudit_AuditId");

                entity.ToTable("Source_Config_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.OffsetHours).HasColumnName("Offset_Hours");

                entity.Property(e => e.SourceConfigId).HasColumnName("Source_Config_Id");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(400)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(100)
                    .HasColumnName("Time_Zone");

                entity.Property(e => e.LOB)
                    .HasMaxLength(400)
                    .HasColumnName("LOB");

                entity.Property(e => e.OffsetConfig)
                    .HasMaxLength(400)
                    .HasColumnName("Offset_Config");

                entity.Property(e => e.DerivedOffsetConfig)
                    .HasMaxLength(400)
                    .HasColumnName("Derived_Offset_Config");
            });

            modelBuilder.Entity<SystemConfigSearchParameter>(entity =>
            {
                entity.HasKey(e => e.SystemConfigSearchParametersId)
                    .HasName("PK_SystemConfigSearchParameters_SystemConfigSearchParametersId");

                entity.ToTable("System_Config_Search_Parameters");

                entity.Property(e => e.SystemConfigSearchParametersId).HasColumnName("System_Config_Search_Parameters_id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Display_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FieldType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Field_Type");

                entity.Property(e => e.FieldValue)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Field_Value");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsInAdvancedSeach).HasColumnName("Is_In_Advanced_Seach");

                entity.Property(e => e.IsInBasicSearch).HasColumnName("Is_In_Basic_Search");

                entity.Property(e => e.IsInWorkQueue).HasColumnName("Is_In_Work_Queue");
            });

            modelBuilder.Entity<SystemConfigSearchParametersAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_SystemConfigSearchParametersAudit_AuditId");

                entity.ToTable("System_Config_Search_Parameters_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Display_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.FieldType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Field_Type");

                entity.Property(e => e.FieldValue)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Field_Value");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsInAdvancedSeach).HasColumnName("Is_In_Advanced_Seach");

                entity.Property(e => e.IsInBasicSearch).HasColumnName("Is_In_Basic_Search");

                entity.Property(e => e.IsInWorkQueue).HasColumnName("Is_In_Work_Queue");

                entity.Property(e => e.SystemConfigSearchParametersId).HasColumnName("System_Config_Search_Parameters_id");
            });

            modelBuilder.Entity<TypeOfInstrument>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.ToTable("TypeOfInstrument");

                entity.HasIndex(e => e.MfinancialInstrumentAttributesPrimaryId, "IX_TypeOfInstrument_MFinancialInstrumentAttributesPrimaryId");

                entity.HasIndex(e => e.MfinancialInstrumentPrimaryId, "IX_TypeOfInstrument_MFinancialInstrumentPrimaryId");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");

                entity.HasOne(d => d.MfinancialInstrumentAttributesPrimary)
                    .WithMany(p => p.TypeOfInstruments)
                    .HasForeignKey(d => d.MfinancialInstrumentAttributesPrimaryId);

                entity.HasOne(d => d.MfinancialInstrumentPrimary)
                    .WithMany(p => p.TypeOfInstruments)
                    .HasForeignKey(d => d.MfinancialInstrumentPrimaryId);
            });

            modelBuilder.Entity<TypeOfInstrumentAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_TypeOfInstrumentAudit_AuditId");

                entity.ToTable("TypeOfInstrument_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.MfinancialInstrumentAttributesPrimaryId).HasColumnName("MFinancialInstrumentAttributesPrimaryId");

                entity.Property(e => e.MfinancialInstrumentPrimaryId).HasColumnName("MFinancialInstrumentPrimaryId");
            });

            modelBuilder.Entity<UnderlyingSecuritiesAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_UnderlyingSecuritiesAudit_AuditId");

                entity.ToTable("UnderlyingSecurities_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");
            });

            modelBuilder.Entity<UnderlyingSecurity>(entity =>
            {
                entity.HasKey(e => e.PrimaryId);

                entity.HasIndex(e => e.FinancialInstrumentAttributesPrimaryId, "IX_UnderlyingSecurities_FinancialInstrumentAttributesPrimaryId");

                entity.HasIndex(e => e.FinancialInstrumentPrimaryId, "IX_UnderlyingSecurities_FinancialInstrumentPrimaryId");

                entity.HasOne(d => d.FinancialInstrumentAttributesPrimary)
                    .WithMany(p => p.UnderlyingSecurities)
                    .HasForeignKey(d => d.FinancialInstrumentAttributesPrimaryId);

                entity.HasOne(d => d.FinancialInstrumentPrimary)
                    .WithMany(p => p.UnderlyingSecurities)
                    .HasForeignKey(d => d.FinancialInstrumentPrimaryId);
            });

            modelBuilder.Entity<UserLoginSourceMst>(entity =>
            {
                entity.HasKey(e => e.UserLoginSourceId)
                    .HasName("PK_UserLoginSourceMst_UserLoginSourceId");

                entity.ToTable("User_Login_Source_Mst");

                entity.Property(e => e.UserLoginSourceId).HasColumnName("User_Login_Source_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");
            });

            modelBuilder.Entity<UserLoginSourceMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_UserLoginSourceMstAudit_AuditId");

                entity.ToTable("User_Login_Source_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.UserLoginSourceId).HasColumnName("User_Login_Source_Id");
            });

            modelBuilder.Entity<UserMst>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserMst");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First_Name");

                entity.Property(e => e.ForceLogout)
                    .HasColumnName("Force_Logout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("Full_Name");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.LoginStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Login_Status");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(1000)
                    .HasColumnName("User_Password");
            });

            modelBuilder.Entity<UserMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_UserMstAudit_AuditID");

                entity.ToTable("UserMst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First_Name");

                entity.Property(e => e.ForceLogout).HasColumnName("Force_Logout");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("Full_Name");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.LoginStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Login_Status");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(1000)
                    .HasColumnName("User_Password");
            });

            modelBuilder.Entity<UserRoleMapping>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("User_Role_Mapping");

                entity.Property(e => e.UserRoleId).HasColumnName("User_Role_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserRoleMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_UserRoleMapping_AuditID");

                entity.ToTable("User_Role_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRoleId).HasColumnName("User_Role_Id");
            });

            modelBuilder.Entity<UserSourceMapping>(entity =>
            {
                entity.ToTable("User_Source_Mapping");

                entity.HasIndex(e => e.UserSourceMappingId, "IX_User_Source_Mapping")
                    .IsUnique();

                entity.Property(e => e.UserSourceMappingId).HasColumnName("User_Source_Mapping_Id");

                entity.Property(e => e.AdDomain)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ad_Domain");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginSourceUniqueId).HasColumnName("LoginSource_UniqueId");

                entity.Property(e => e.SourceLoginId)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Source_LoginID");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserSourceMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_UserSourceMappingAudit_AuditID");

                entity.ToTable("User_Source_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AdDomain)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ad_Domain");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LoginSourceUniqueId).HasColumnName("LoginSource_UniqueId");

                entity.Property(e => e.SourceLoginId)
                    .HasMaxLength(1000)
                    .HasColumnName("Source_LoginID");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(100)
                    .HasColumnName("Source_Name");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserSourceMappingId).HasColumnName("User_Source_Mapping_Id");
            });

            modelBuilder.Entity<VwGoldenRecordFilteredData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_GoldenRecord_Filtered_Data");

                entity.Property(e => e.AssetClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Class");

                entity.Property(e => e.AssetSubClass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Asset_Sub_Class");

                entity.Property(e => e.BloombergId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BloombergID");

                entity.Property(e => e.CibcEntity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CIBC_ENTITY");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Country_Of_Issue");

                entity.Property(e => e.EarlyResponseDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.EarlyResponseDeadlineDateDateCode).HasColumnName("EarlyResponseDeadlineDate_DateCode");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDateDatecode).HasColumnName("EffectiveDate_Datecode");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.EventMvc)
                    .HasMaxLength(5)
                    .HasColumnName("Event_MVC");

                entity.Property(e => e.EventName)
                    .HasMaxLength(10)
                    .HasColumnName("Event_Name");

                entity.Property(e => e.ExDividendOrDistributionDate).HasColumnType("datetime");

                entity.Property(e => e.ExDividendOrDistributionDateDateCode).HasColumnName("ExDividendOrDistributionDate_DateCode");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateDateCode).HasColumnName("ExpiryDate_DateCode");

                entity.Property(e => e.GoldenRecordCreateDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Golden_Record_Create_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.GoldenRecordMatchDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Golden_Record_Match_Dt_Time_UTC");

                entity.Property(e => e.GoldenRecordPriority).HasColumnName("Golden_Record_Priority");

                entity.Property(e => e.GoldenRecordStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Golden_Record_Status");

                entity.Property(e => e.HasEventPosition).HasColumnName("Has_Event_Position");

                entity.Property(e => e.HasTotalPendingCancellationQty).HasColumnName("Has_Total_Pending_Cancellation_Qty");

                entity.Property(e => e.HasTotalPendingInstructionsQty).HasColumnName("Has_Total_Pending_Instructions_Qty");

                entity.Property(e => e.HasTotalUnelectedQty).HasColumnName("Has_Total_Unelected_Qty");

                entity.Property(e => e.InternalSecurityId).HasColumnName("Internal_Security_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsAdditionalTextUpdated).HasColumnName("Is_Additional_Text_Updated");

                entity.Property(e => e.IsAutoStp).HasColumnName("Is_Auto_STP");

                entity.Property(e => e.IsInformationConditionsUpdated).HasColumnName("Is_Information_Conditions_Updated");

                entity.Property(e => e.IsInformationToComplyUpdated).HasColumnName("Is_Information_To_Comply_Updated");

                entity.Property(e => e.IsNarrativeVersionUpdated).HasColumnName("Is_Narrative_Version_Updated");

                entity.Property(e => e.IsPositionCaptured).HasColumnName("Is_Position_Captured");

                entity.Property(e => e.IsTaxationConditionsUpdated).HasColumnName("Is_Taxation_Conditions_Updated");

                entity.Property(e => e.IsTouched).HasColumnName("Is_Touched");

                entity.Property(e => e.IsoChangeType)
                    .HasMaxLength(1000)
                    .HasColumnName("ISO_Change_Type");

                entity.Property(e => e.IsoOfferor)
                    .HasMaxLength(1000)
                    .HasColumnName("ISO_Offeror");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Issuer_Name");

                entity.Property(e => e.LegalEntityName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Name");

                entity.Property(e => e.LongName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Long_Name");

                entity.Property(e => e.MarketDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.MarketDeadlineDateDateCode).HasColumnName("MarketDeadlineDate_DateCode");

                entity.Property(e => e.MatchStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Match_status");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDateDateCode).HasColumnName("PaymentDate_DateCode");

                entity.Property(e => e.PositionFixDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Position_Fix_Date");

                entity.Property(e => e.ProtectDate).HasColumnType("datetime");

                entity.Property(e => e.ProtectDateDateCode).HasColumnName("ProtectDate_DateCode");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDateDateCode).HasColumnName("RecordDate_DateCode");

                entity.Property(e => e.ResponseDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseDeadlineDateDateCode).HasColumnName("ResponseDeadlineDate_DateCode");

                entity.Property(e => e.ReviewByDate)
                    .HasColumnType("date")
                    .HasColumnName("Review_By_Date");

                entity.Property(e => e.SecurityDescription).HasColumnName("Security_Description");

                entity.Property(e => e.SecurityIdType)
                    .HasMaxLength(100)
                    .HasColumnName("SecurityID_Type");

                entity.Property(e => e.SecurityIdValue)
                    .HasMaxLength(100)
                    .HasColumnName("SecurityID_Value");

                entity.Property(e => e.SecurityType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Security_Type");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Short_Name");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");

                entity.Property(e => e.ValidityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Validity_Date");
            });

            modelBuilder.Entity<VwGoldenRecordMdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_GoldenRecord_MDates");

                entity.Property(e => e.EarlyResponseDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.EarlyResponseDeadlineDateDateCode).HasColumnName("EarlyResponseDeadlineDate_DateCode");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDateDatecode).HasColumnName("EffectiveDate_Datecode");

                entity.Property(e => e.ExDividendOrDistributionDate).HasColumnType("datetime");

                entity.Property(e => e.ExDividendOrDistributionDateDateCode).HasColumnName("ExDividendOrDistributionDate_DateCode");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDateDateCode).HasColumnName("ExpiryDate_DateCode");

                entity.Property(e => e.GoldenRecordId).HasColumnName("GoldenRecordID");

                entity.Property(e => e.MarketDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.MarketDeadlineDateDateCode).HasColumnName("MarketDeadlineDate_DateCode");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDateDateCode).HasColumnName("PaymentDate_DateCode");

                entity.Property(e => e.ProtectDate).HasColumnType("datetime");

                entity.Property(e => e.ProtectDateDateCode).HasColumnName("ProtectDate_DateCode");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDateDateCode).HasColumnName("RecordDate_DateCode");

                entity.Property(e => e.ResponseDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseDeadlineDateDateCode).HasColumnName("ResponseDeadlineDate_DateCode");
            });

            modelBuilder.Entity<VwGoldenRecordTradingAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_GoldenRecord_TradingAccounts");

                entity.Property(e => e.CibcEntity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CIBC_ENTITY");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.LegalEntityName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("Legal_Entity_Name");

                entity.Property(e => e.TradingAccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Trading_Account_Number");
            });

            modelBuilder.Entity<VwPaymentFilterSearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Payment_Filter_Search");

                entity.Property(e => e.CaoptionId).HasColumnName("CAOptionID");

                entity.Property(e => e.OptionSecurityValue).HasColumnName("Option_Security_Value");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("Payment_Date");

                entity.Property(e => e.PaymentSecurityValue).HasColumnName("Payment_Security_Value");

                entity.Property(e => e.ResultPublicationDate)
                    .HasColumnType("date")
                    .HasColumnName("Result_Publication_Date");
            });

            modelBuilder.Entity<WorkQueueMst>(entity =>
            {
                entity.HasKey(e => e.WorkQueueId)
                    .HasName("PK_WorkQueueMst_WorkQueueId");

                entity.ToTable("Work_Queue_Mst");

                entity.Property(e => e.WorkQueueId).HasColumnName("Work_Queue_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkQueueDescription)
                    .IsUnicode(false)
                    .HasColumnName("Work_Queue_Description");

                entity.Property(e => e.WorkQueueName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Work_Queue_Name");

                entity.Property(e => e.WorkQueueObject)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("Work_Queue_Object");
            });

            modelBuilder.Entity<WorkQueueMstAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_WorkQueueMstAudit_AuditId");

                entity.ToTable("Work_Queue_Mst_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.WorkQueueDescription)
                    .IsUnicode(false)
                    .HasColumnName("Work_Queue_Description");

                entity.Property(e => e.WorkQueueId).HasColumnName("Work_Queue_Id");

                entity.Property(e => e.WorkQueueName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Work_Queue_Name");

                entity.Property(e => e.WorkQueueObject)
                    .IsUnicode(false)
                    .HasColumnName("Work_Queue_Object");
            });

            modelBuilder.Entity<WorkQueueUserMapping>(entity =>
            {
                entity.ToTable("Work_Queue_User_Mapping");

                entity.Property(e => e.WorkQueueUserMappingId).HasColumnName("Work_Queue_User_Mapping_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkQueueId).HasColumnName("Work_Queue_Id");
            });

            modelBuilder.Entity<WorkQueueUserMappingAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_WorkQueueUserMappingAudit_AuditId");

                entity.ToTable("Work_Queue_User_Mapping_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkQueueId).HasColumnName("Work_Queue_Id");

                entity.Property(e => e.WorkQueueUserMappingId).HasColumnName("Work_Queue_User_Mapping_Id");
            });

            modelBuilder.Entity<AMHAcknowledgement>(entity =>
            {
                entity.HasKey(e => e.AHMAckId)
                    .HasName("PK_AMHAcknowledgements_AMHAckId");

                entity.ToTable("AMH_Acknowledgements");

                entity.Property(e => e.AHMAckId).HasColumnName("AMH_Ack_Id");

                entity.Property(e => e.SemeRef).HasColumnName("SEME_Ref");

                entity.Property(e => e.AckStatus).HasColumnName("Ack_Status");

                entity.Property(e => e.AckMessage).HasColumnName("Ack_Message");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AMHAcknowledgementAudit>(entity =>
            {
                entity.HasKey(e => e.AHMAckId)
                    .HasName("PK_AMHAcknowledgementsAudit_AuditId");

                entity.ToTable("AMH_Acknowledgements_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.AHMAckId).HasColumnName("AMH_Ack_Id");

                entity.Property(e => e.SemeRef).HasColumnName("SEME_Ref");

                entity.Property(e => e.AckStatus).HasColumnName("Ack_Status");

                entity.Property(e => e.AckMessage).HasColumnName("Ack_Message");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GoldenRecordSecurityDetail>(entity =>
            {
                entity.HasKey(e => e.GoldenRecordSecurityDtlId)
                    .HasName("PK_GoldenRecordSecurityDetails_GoldenRecordSecDtlId");

                entity.ToTable("Golden_Record_Security_Details");

                entity.HasIndex(e => new { e.GoldenRecordId, e.OptionNumber, e.MovementId }, "Unq_GoldenRecordSecDtl_GoldenRecordIdOptionNumberMovementId")
                    .IsUnique();

                entity.Property(e => e.GoldenRecordSecurityDtlId).HasColumnName("Golden_Record_Security_Dtl_Id");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.OptionNumber).HasColumnName("Option_Number");

                entity.Property(e => e.MovementId).HasColumnName("Movement_Id");

                entity.Property(e => e.CUSIP).HasColumnName("CUSIP");

                entity.Property(e => e.ISIN).HasColumnName("ISIN");

                entity.Property(e => e.Sedol).HasColumnName("Sedol");

                entity.Property(e => e.BloombergId).HasColumnName("Bloomberg_Id");

                entity.Property(e => e.ShortName).HasColumnName("Short_Name");

                entity.Property(e => e.LongName).HasColumnName("Long_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GoldenRecordSecurityDetailAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_GoldenRecordSecurityDetailsAudit_AuditId");

                entity.ToTable("Golden_Record_Security_Details_Audit");

                entity.Property(e => e.AuditId).HasColumnName("Audit_Id");

                entity.Property(e => e.GoldenRecordSecurityDtlId).HasColumnName("Golden_Record_Security_Dtl_Id");

                entity.Property(e => e.GoldenRecordId).HasColumnName("Golden_Record_Id");

                entity.Property(e => e.OptionNumber).HasColumnName("Option_Number");

                entity.Property(e => e.MovementId).HasColumnName("Movement_Id");

                entity.Property(e => e.CUSIP).HasColumnName("CUSIP");

                entity.Property(e => e.ISIN).HasColumnName("ISIN");

                entity.Property(e => e.Sedol).HasColumnName("Sedol");

                entity.Property(e => e.BloombergId).HasColumnName("Bloomberg_Id");

                entity.Property(e => e.ShortName).HasColumnName("Short_Name");

                entity.Property(e => e.LongName).HasColumnName("Long_Name");

                entity.Property(e => e.EntryBy).HasColumnName("Entry_By");

                entity.Property(e => e.EntryDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntryDtTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry_Dt_Time_UTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Trading_Account_Groups>(entity =>
            {
                //entity.HasKey(o => new { o.LEGAL_ENTITY_CDR_ID, o.TRADING_ACCOUNT_NUMBER });

                entity.HasKey(e => e.Trading_Account_Group_Id).HasName("PK_TradingAccountGroups_TradingAccountGroupsId");

                entity.ToTable("Trading_Account_Groups");

                entity.HasIndex(e => e.Trading_Account_Group_Id, "PK_TradingAccountGroups_TradingAccountGroupsId");


                entity.Property(e => e.Request_DateTime)
                    .HasColumnType("datetime")
                    .IsRequired();


                entity.Property(e => e.Group_Id)
                    .IsRequired();


                entity.Property(e => e.Group_Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .IsRequired();


                entity.Property(e => e.Email_Address_List)
                    .IsUnicode(false);


                entity.Property(e => e.Feed_Is_Active)
                    .HasMaxLength(10)
                    .IsUnicode(false);


                entity.Property(e => e.Trading_Account_List)
                    .IsUnicode(false);


                entity.Property(e => e.Parent_Company_Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);


                entity.Property(e => e.Feed_File_Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);


                entity.Property(e => e.Is_Active)
                    .IsRequired();


                entity.Property(e => e.Entry_By)
                    .IsRequired();


                entity.Property(e => e.Entry_Dt_Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .IsRequired();

                entity.Property(e => e.Entry_Dt_Time_Utc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())")
                    .IsRequired();


            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
