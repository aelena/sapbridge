using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDMC_EntityLayer.Model;
using System.Data;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests._dummy_classes
{
    interface IMDMC_Requests
    {
        string ADRNR { get; set; }
        string BLK_BillingBlockAtSalesArea { get; set; }
        string BLK_CentralBillingBlock { get; set; }
        bool BLK_CentralDeletionBlockMasterRecord { get; set; }
        bool BLK_CentralDeletionFlagMasterRecord { get; set; }
        string BLK_CentralDeliveriesBlock { get; set; }
        bool BLK_CentralPostingBlock { get; set; }
        string BLK_CentralSalesOrderBlock { get; set; }
        bool BLK_CentralSalesSupportBlock { get; set; }
        bool BLK_CentralSalesSupportBlockAtSalesArea { get; set; }
        bool BLK_DeletionBlockMasterRecordCC { get; set; }
        bool BLK_DeletionFlagMasterRecordCC { get; set; }
        bool BLK_DeletionFlagMasterRecordSA { get; set; }
        string BLK_DeliveriesBlockAtSalesArea { get; set; }
        string BLK_OrdersBlockAtSalesArea { get; set; }
        bool BLK_PostingBlockForCC { get; set; }
        DateTime? BlockedTime { get; set; }
        string CL_RCO_UserAccount { get; set; }
        string CLERK_UserAccount { get; set; }
        string ClusterCompanyCode { get; set; }
        string ClusterCountryCode { get; set; }
        string ClusterDistributionChannel { get; set; }
        string ClusterDivision { get; set; }
        string ClusterPOCode { get; set; }
        string CostCenter { get; set; }
        string CustomerNumber { get; set; }
        string DDLDCComment { get; set; }
        string Email_DetailedActivity { get; set; }
        string Email_ExtraField1 { get; set; }
        string Email_ExtraField2 { get; set; }
        string Email_ExtraField3 { get; set; }
        string Email_ExtraField4 { get; set; }
        string Email_ExtraField5 { get; set; }
        string Email_StepChangeLog { get; set; }
        string GD_Adr_City { get; set; }
        string GD_Adr_City2 { get; set; }
        string GD_Adr_Country { get; set; }
        string GD_Adr_Name { get; set; }
        string GD_Adr_Name2 { get; set; }
        string GD_Adr_Name3 { get; set; }
        string GD_Adr_Name4 { get; set; }
        string GD_Adr_POBox { get; set; }
        string GD_Adr_POBoxLoc { get; set; }
        string GD_Adr_POBoxPostalCode { get; set; }
        string GD_Adr_PostalCode { get; set; }
        string GD_Adr_Region { get; set; }
        string GD_Adr_Search { get; set; }
        string GD_Adr_Street { get; set; }
        string GD_Adr_Street2 { get; set; }
        string GD_Adr_Street3 { get; set; }
        string GD_Adr_Street4 { get; set; }
        string GD_Adr_Street5 { get; set; }
        string GD_Com_Comment { get; set; }
        string GD_Com_DataLine { get; set; }
        string GD_Com_EmailAddress { get; set; }
        string GD_Com_FaxNumber { get; set; }
        string GD_Com_LanguageCode { get; set; }
        string GD_Com_Telebox { get; set; }
        string GD_Com_Telephone { get; set; }
        string GD_Com_TransportZone { get; set; }
        string GD_Com_URL { get; set; }
        string GD_Ctr_AccountGroup { get; set; }
        string GD_Ctr_ActualQMSystem { get; set; }
        string GD_Ctr_CF { get; set; }
        string GD_Ctr_CreditInfoNo { get; set; }
        string GD_Ctr_CustomerClassification { get; set; }
        string GD_Ctr_CustomerNumber { get; set; }
        string GD_Ctr_GFORM { get; set; }
        string GD_Ctr_IFANumber { get; set; }
        string GD_Ctr_IFANumber1 { get; set; }
        string GD_Ctr_Industry { get; set; }
        bool GD_Ctr_IsNaturalPerson { get; set; }
        string GD_Ctr_LastExtReview { get; set; }
        string GD_Ctr_NIF { get; set; }
        string GD_Ctr_PIVA { get; set; }
        string GD_Ctr_QMSystemTo { get; set; }
        string GD_Ctr_RepresentiveName { get; set; }
        string GD_Ctr_RiskClassification { get; set; }
        bool GD_Ctr_SalesPurTax { get; set; }
        string GD_Ctr_TaxCode1 { get; set; }
        bool GD_Ctr_TaxCode1_Gov { get; set; }
        bool GD_Ctr_TaxCode1_HighRisk { get; set; }
        bool GD_Ctr_TaxCode1_NP { get; set; }
        string GD_Ctr_TaxCode2 { get; set; }
        string GD_Ctr_TaxNumber { get; set; }
        string GD_Ctr_UnsubscribeCMD { get; set; }
        string GD_Ctr_VATRegistrationNumber { get; set; }
        string GD_Ctr_VendorNumber { get; set; }
        bool GD_Damex { get; set; }
        bool? GD_Embassy { get; set; }
        bool? GD_FreeZone { get; set; }
        bool? GD_MainlyCivilian { get; set; }
        bool? GD_MainlyMilitary { get; set; }
        DateTime? GD_NatP_DateOfBirth { get; set; }
        string GD_NatP_PlaceOfBirth { get; set; }
        string GD_NatP_Profession { get; set; }
        string GD_NatP_Sex { get; set; }
        string GD_NatP_Title { get; set; }
        bool? GD_Nuclear { get; set; }
        string GD_SAPNumber { get; set; }
        bool? Is_Both_Channel { get; set; }
        bool Locked { get; set; }
        MDMC_Request_CompanyCode MDMC_Request_CompanyCode { get; set; }
        System.Data.Objects.DataClasses.EntityReference<MDMC_Request_CompanyCode> MDMC_Request_CompanyCodeReference { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_ContactPersons> MDMC_Request_ContactPersons { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerBankDetails> MDMC_Request_CustomerBankDetails { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerEmailDetails> MDMC_Request_CustomerEmailDetails { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerFaxDetails> MDMC_Request_CustomerFaxDetails { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerPartnerFunction> MDMC_Request_CustomerPartnerFunction { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerPhoneDetails> MDMC_Request_CustomerPhoneDetails { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerVAT> MDMC_Request_CustomerVAT { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_SalesOrganization> MDMC_Request_SalesOrganization { get; set; }
        string OperationType { get; set; }
        string RCO_UserAccount { get; set; }
        string RequestID { get; set; }
        string RequestType { get; set; }
        string SAP_Message { get; set; }
        string SR_Comments { get; set; }
        string SUS_UserAccount { get; set; }
        bool TS_IsUrgentRequest { get; set; }
        string UserWithLock { get; set; }
    }

    // -------------------------------------------------------------------------------------------------------------------


    interface IMDMC_RequestsSAP
    {
        string ADRNR { get; set; }
        string BLK_BillingBlockAtSalesArea { get; set; }
        string BLK_CentralBillingBlock { get; set; }
        bool BLK_CentralDeletionBlockMasterRecord { get; set; }
        bool BLK_CentralDeletionFlagMasterRecord { get; set; }
        string BLK_CentralDeliveriesBlock { get; set; }
        bool BLK_CentralPostingBlock { get; set; }
        string BLK_CentralSalesOrderBlock { get; set; }
        bool BLK_CentralSalesSupportBlock { get; set; }
        bool BLK_CentralSalesSupportBlockAtSalesArea { get; set; }
        bool BLK_DeletionBlockMasterRecordCC { get; set; }
        bool BLK_DeletionFlagMasterRecordCC { get; set; }
        bool BLK_DeletionFlagMasterRecordSA { get; set; }
        string BLK_DeliveriesBlockAtSalesArea { get; set; }
        string BLK_OrdersBlockAtSalesArea { get; set; }
        bool BLK_PostingBlockForCC { get; set; }
        string CL_RCO_UserAccount { get; set; }
        string CLERK_UserAccount { get; set; }
        string ClusterCompanyCode { get; set; }
        string ClusterCountryCode { get; set; }
        string ClusterDistributionChannel { get; set; }
        string ClusterDivision { get; set; }
        string ClusterPOCode { get; set; }
        string CustomerNumber { get; set; }
        string GD_Adr_City { get; set; }
        string GD_Adr_City2 { get; set; }
        string GD_Adr_Country { get; set; }
        string GD_Adr_Name { get; set; }
        string GD_Adr_Name2 { get; set; }
        string GD_Adr_Name3 { get; set; }
        string GD_Adr_Name4 { get; set; }
        string GD_Adr_POBox { get; set; }
        string GD_Adr_POBoxLoc { get; set; }
        string GD_Adr_POBoxPostalCode { get; set; }
        string GD_Adr_PostalCode { get; set; }
        string GD_Adr_Region { get; set; }
        string GD_Adr_Search { get; set; }
        string GD_Adr_Street { get; set; }
        string GD_Adr_Street2 { get; set; }
        string GD_Adr_Street3 { get; set; }
        string GD_Adr_Street4 { get; set; }
        string GD_Adr_Street5 { get; set; }
        string GD_Com_Comment { get; set; }
        string GD_Com_DataLine { get; set; }
        string GD_Com_EmailAddress { get; set; }
        string GD_Com_FaxNumber { get; set; }
        string GD_Com_LanguageCode { get; set; }
        string GD_Com_Telebox { get; set; }
        string GD_Com_Telephone { get; set; }
        string GD_Com_TransportZone { get; set; }
        string GD_Com_URL { get; set; }
        string GD_Ctr_AccountGroup { get; set; }
        string GD_Ctr_ActualQMSystem { get; set; }
        string GD_Ctr_CreditInfoNo { get; set; }
        string GD_Ctr_CustomerClassification { get; set; }
        string GD_Ctr_CustomerNumber { get; set; }
        string GD_Ctr_GFORM { get; set; }
        string GD_Ctr_IFANumber { get; set; }
        string GD_Ctr_Industry { get; set; }
        bool GD_Ctr_IsNaturalPerson { get; set; }
        string GD_Ctr_LastExtReview { get; set; }
        string GD_Ctr_QMSystemTo { get; set; }
        string GD_Ctr_RepresentiveName { get; set; }
        string GD_Ctr_RiskClassification { get; set; }
        bool GD_Ctr_SalesPurTax { get; set; }
        string GD_Ctr_TaxCode_IT_CF { get; set; }
        string GD_Ctr_TaxCode_IT_PIva { get; set; }
        string GD_Ctr_TaxCode_PT_NIF { get; set; }
        string GD_Ctr_TaxCode1 { get; set; }
        bool GD_Ctr_TaxCode1_Gov { get; set; }
        bool GD_Ctr_TaxCode1_HighRisk { get; set; }
        bool GD_Ctr_TaxCode1_NP { get; set; }
        string GD_Ctr_TaxCode2 { get; set; }
        string GD_Ctr_TaxNumber { get; set; }
        string GD_Ctr_UnsubscribeCMD { get; set; }
        string GD_Ctr_VATRegistrationNumber { get; set; }
        string GD_Ctr_VendorNumber { get; set; }
        bool? GD_Embassy { get; set; }
        bool? GD_FreeZone { get; set; }
        bool? GD_MainlyCivilian { get; set; }
        bool? GD_MainlyMilitary { get; set; }
        DateTime? GD_NatP_DateOfBirth { get; set; }
        string GD_NatP_PlaceOfBirth { get; set; }
        string GD_NatP_Profession { get; set; }
        string GD_NatP_Sex { get; set; }
        string GD_NatP_Title { get; set; }
        bool? GD_Nuclear { get; set; }
        string GD_SAPNumber { get; set; }
        MDMC_Request_CompanyCodeSAP MDMC_Request_CompanyCodeSAP { get; set; }
        System.Data.Objects.DataClasses.EntityReference<MDMC_Request_CompanyCodeSAP> MDMC_Request_CompanyCodeSAPReference { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_ContactPersonsSAP> MDMC_Request_ContactPersonsSAP { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerBankDetailsSAP> MDMC_Request_CustomerBankDetailsSAP { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerEmailDetailsSAP> MDMC_Request_CustomerEmailDetailsSAP { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerFaxDetailsSAP> MDMC_Request_CustomerFaxDetailsSAP { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerPartnerFunctionSAP> MDMC_Request_CustomerPartnerFunctionSAP { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerPhoneDetailsSAP> MDMC_Request_CustomerPhoneDetailsSAP { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_CustomerVATSAP> MDMC_Request_CustomerVATSAP { get; set; }
        System.Data.Objects.DataClasses.EntityCollection<MDMC_Request_SalesOrganizationSAP> MDMC_Request_SalesOrganizationSAP { get; set; }
        string OperationType { get; set; }
        string RCO_UserAccount { get; set; }
        string RequestID { get; set; }
        string RequestType { get; set; }
        string SAP_Message { get; set; }
        string SUS_UserAccount { get; set; }
        bool TS_IsUrgentRequest { get; set; }
    }


    // -------------------------------------------------------------------------------------------------------------------

}
