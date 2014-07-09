using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data;
using MDMC_EntityLayer.Model;


namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests._dummy_classes
{
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute ( NamespaceName = "MDMC_DataModel", Name = "MDMC_Requests" )]
    [Serializable ()]
    [DataContractAttribute ( IsReference = true )]
    public partial class MDMC_Requests : EntityObject, IMDMC_Requests
    {
        #region Factory Method

        /// <summary>
        /// Create a new MDMC_Requests object.
        /// </summary>
        /// <param name="requestID">Initial value of the RequestID property.</param>
        /// <param name="tS_IsUrgentRequest">Initial value of the TS_IsUrgentRequest property.</param>
        /// <param name="gD_Ctr_IsNaturalPerson">Initial value of the GD_Ctr_IsNaturalPerson property.</param>
        /// <param name="gD_Ctr_TaxCode1_HighRisk">Initial value of the GD_Ctr_TaxCode1_HighRisk property.</param>
        /// <param name="gD_Ctr_TaxCode1_Gov">Initial value of the GD_Ctr_TaxCode1_Gov property.</param>
        /// <param name="gD_Ctr_TaxCode1_NP">Initial value of the GD_Ctr_TaxCode1_NP property.</param>
        /// <param name="gD_Ctr_SalesPurTax">Initial value of the GD_Ctr_SalesPurTax property.</param>
        /// <param name="bLK_CentralPostingBlock">Initial value of the BLK_CentralPostingBlock property.</param>
        /// <param name="bLK_PostingBlockForCC">Initial value of the BLK_PostingBlockForCC property.</param>
        /// <param name="bLK_CentralSalesSupportBlock">Initial value of the BLK_CentralSalesSupportBlock property.</param>
        /// <param name="bLK_CentralSalesSupportBlockAtSalesArea">Initial value of the BLK_CentralSalesSupportBlockAtSalesArea property.</param>
        /// <param name="bLK_CentralDeletionFlagMasterRecord">Initial value of the BLK_CentralDeletionFlagMasterRecord property.</param>
        /// <param name="bLK_DeletionFlagMasterRecordCC">Initial value of the BLK_DeletionFlagMasterRecordCC property.</param>
        /// <param name="bLK_DeletionFlagMasterRecordSA">Initial value of the BLK_DeletionFlagMasterRecordSA property.</param>
        /// <param name="bLK_CentralDeletionBlockMasterRecord">Initial value of the BLK_CentralDeletionBlockMasterRecord property.</param>
        /// <param name="bLK_DeletionBlockMasterRecordCC">Initial value of the BLK_DeletionBlockMasterRecordCC property.</param>
        /// <param name="locked">Initial value of the Locked property.</param>
        /// <param name="gD_Damex">Initial value of the GD_Damex property.</param>
        public static MDMC_Requests CreateMDMC_Requests ( global::System.String requestID, global::System.Boolean tS_IsUrgentRequest, global::System.Boolean gD_Ctr_IsNaturalPerson, global::System.Boolean gD_Ctr_TaxCode1_HighRisk, global::System.Boolean gD_Ctr_TaxCode1_Gov, global::System.Boolean gD_Ctr_TaxCode1_NP, global::System.Boolean gD_Ctr_SalesPurTax, global::System.Boolean bLK_CentralPostingBlock, global::System.Boolean bLK_PostingBlockForCC, global::System.Boolean bLK_CentralSalesSupportBlock, global::System.Boolean bLK_CentralSalesSupportBlockAtSalesArea, global::System.Boolean bLK_CentralDeletionFlagMasterRecord, global::System.Boolean bLK_DeletionFlagMasterRecordCC, global::System.Boolean bLK_DeletionFlagMasterRecordSA, global::System.Boolean bLK_CentralDeletionBlockMasterRecord, global::System.Boolean bLK_DeletionBlockMasterRecordCC, global::System.Boolean locked, global::System.Boolean gD_Damex )
        {
            MDMC_Requests mDMC_Requests = new MDMC_Requests ();
            mDMC_Requests.RequestID = requestID;
            mDMC_Requests.TS_IsUrgentRequest = tS_IsUrgentRequest;
            mDMC_Requests.GD_Ctr_IsNaturalPerson = gD_Ctr_IsNaturalPerson;
            mDMC_Requests.GD_Ctr_TaxCode1_HighRisk = gD_Ctr_TaxCode1_HighRisk;
            mDMC_Requests.GD_Ctr_TaxCode1_Gov = gD_Ctr_TaxCode1_Gov;
            mDMC_Requests.GD_Ctr_TaxCode1_NP = gD_Ctr_TaxCode1_NP;
            mDMC_Requests.GD_Ctr_SalesPurTax = gD_Ctr_SalesPurTax;
            mDMC_Requests.BLK_CentralPostingBlock = bLK_CentralPostingBlock;
            mDMC_Requests.BLK_PostingBlockForCC = bLK_PostingBlockForCC;
            mDMC_Requests.BLK_CentralSalesSupportBlock = bLK_CentralSalesSupportBlock;
            mDMC_Requests.BLK_CentralSalesSupportBlockAtSalesArea = bLK_CentralSalesSupportBlockAtSalesArea;
            mDMC_Requests.BLK_CentralDeletionFlagMasterRecord = bLK_CentralDeletionFlagMasterRecord;
            mDMC_Requests.BLK_DeletionFlagMasterRecordCC = bLK_DeletionFlagMasterRecordCC;
            mDMC_Requests.BLK_DeletionFlagMasterRecordSA = bLK_DeletionFlagMasterRecordSA;
            mDMC_Requests.BLK_CentralDeletionBlockMasterRecord = bLK_CentralDeletionBlockMasterRecord;
            mDMC_Requests.BLK_DeletionBlockMasterRecordCC = bLK_DeletionBlockMasterRecordCC;
            mDMC_Requests.Locked = locked;
            mDMC_Requests.GD_Damex = gD_Damex;
            return mDMC_Requests;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = true, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.String RequestID
        {
            get
            {
                return _RequestID;
            }
            set
            {
                if ( _RequestID != value )
                {
                    OnRequestIDChanging ( value );
                    ReportPropertyChanging ( "RequestID" );
                    _RequestID = StructuralObject.SetValidValue ( value, false );
                    ReportPropertyChanged ( "RequestID" );
                    OnRequestIDChanged ();
                }
            }
        }
        private global::System.String _RequestID;
        partial void OnRequestIDChanging ( global::System.String value );
        partial void OnRequestIDChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean TS_IsUrgentRequest
        {
            get
            {
                return _TS_IsUrgentRequest;
            }
            set
            {
                OnTS_IsUrgentRequestChanging ( value );
                ReportPropertyChanging ( "TS_IsUrgentRequest" );
                _TS_IsUrgentRequest = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "TS_IsUrgentRequest" );
                OnTS_IsUrgentRequestChanged ();
            }
        }
        private global::System.Boolean _TS_IsUrgentRequest;
        partial void OnTS_IsUrgentRequestChanging ( global::System.Boolean value );
        partial void OnTS_IsUrgentRequestChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String OperationType
        {
            get
            {
                return _OperationType;
            }
            set
            {
                OnOperationTypeChanging ( value );
                ReportPropertyChanging ( "OperationType" );
                _OperationType = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "OperationType" );
                OnOperationTypeChanged ();
            }
        }
        private global::System.String _OperationType;
        partial void OnOperationTypeChanging ( global::System.String value );
        partial void OnOperationTypeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String CustomerNumber
        {
            get
            {
                return _CustomerNumber;
            }
            set
            {
                OnCustomerNumberChanging ( value );
                ReportPropertyChanging ( "CustomerNumber" );
                _CustomerNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "CustomerNumber" );
                OnCustomerNumberChanged ();
            }
        }
        private global::System.String _CustomerNumber;
        partial void OnCustomerNumberChanging ( global::System.String value );
        partial void OnCustomerNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterCountryCode
        {
            get
            {
                return _ClusterCountryCode;
            }
            set
            {
                OnClusterCountryCodeChanging ( value );
                ReportPropertyChanging ( "ClusterCountryCode" );
                _ClusterCountryCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterCountryCode" );
                OnClusterCountryCodeChanged ();
            }
        }
        private global::System.String _ClusterCountryCode;
        partial void OnClusterCountryCodeChanging ( global::System.String value );
        partial void OnClusterCountryCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterCompanyCode
        {
            get
            {
                return _ClusterCompanyCode;
            }
            set
            {
                OnClusterCompanyCodeChanging ( value );
                ReportPropertyChanging ( "ClusterCompanyCode" );
                _ClusterCompanyCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterCompanyCode" );
                OnClusterCompanyCodeChanged ();
            }
        }
        private global::System.String _ClusterCompanyCode;
        partial void OnClusterCompanyCodeChanging ( global::System.String value );
        partial void OnClusterCompanyCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterPOCode
        {
            get
            {
                return _ClusterPOCode;
            }
            set
            {
                OnClusterPOCodeChanging ( value );
                ReportPropertyChanging ( "ClusterPOCode" );
                _ClusterPOCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterPOCode" );
                OnClusterPOCodeChanged ();
            }
        }
        private global::System.String _ClusterPOCode;
        partial void OnClusterPOCodeChanging ( global::System.String value );
        partial void OnClusterPOCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_RiskClassification
        {
            get
            {
                return _GD_Ctr_RiskClassification;
            }
            set
            {
                OnGD_Ctr_RiskClassificationChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_RiskClassification" );
                _GD_Ctr_RiskClassification = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_RiskClassification" );
                OnGD_Ctr_RiskClassificationChanged ();
            }
        }
        private global::System.String _GD_Ctr_RiskClassification;
        partial void OnGD_Ctr_RiskClassificationChanging ( global::System.String value );
        partial void OnGD_Ctr_RiskClassificationChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_CustomerClassification
        {
            get
            {
                return _GD_Ctr_CustomerClassification;
            }
            set
            {
                OnGD_Ctr_CustomerClassificationChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_CustomerClassification" );
                _GD_Ctr_CustomerClassification = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_CustomerClassification" );
                OnGD_Ctr_CustomerClassificationChanged ();
            }
        }
        private global::System.String _GD_Ctr_CustomerClassification;
        partial void OnGD_Ctr_CustomerClassificationChanging ( global::System.String value );
        partial void OnGD_Ctr_CustomerClassificationChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_IsNaturalPerson
        {
            get
            {
                return _GD_Ctr_IsNaturalPerson;
            }
            set
            {
                OnGD_Ctr_IsNaturalPersonChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_IsNaturalPerson" );
                _GD_Ctr_IsNaturalPerson = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_IsNaturalPerson" );
                OnGD_Ctr_IsNaturalPersonChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_IsNaturalPerson;
        partial void OnGD_Ctr_IsNaturalPersonChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_IsNaturalPersonChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name
        {
            get
            {
                return _GD_Adr_Name;
            }
            set
            {
                OnGD_Adr_NameChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Name" );
                _GD_Adr_Name = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name" );
                OnGD_Adr_NameChanged ();
            }
        }
        private global::System.String _GD_Adr_Name;
        partial void OnGD_Adr_NameChanging ( global::System.String value );
        partial void OnGD_Adr_NameChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name2
        {
            get
            {
                return _GD_Adr_Name2;
            }
            set
            {
                OnGD_Adr_Name2Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Name2" );
                _GD_Adr_Name2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name2" );
                OnGD_Adr_Name2Changed ();
            }
        }
        private global::System.String _GD_Adr_Name2;
        partial void OnGD_Adr_Name2Changing ( global::System.String value );
        partial void OnGD_Adr_Name2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name3
        {
            get
            {
                return _GD_Adr_Name3;
            }
            set
            {
                OnGD_Adr_Name3Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Name3" );
                _GD_Adr_Name3 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name3" );
                OnGD_Adr_Name3Changed ();
            }
        }
        private global::System.String _GD_Adr_Name3;
        partial void OnGD_Adr_Name3Changing ( global::System.String value );
        partial void OnGD_Adr_Name3Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name4
        {
            get
            {
                return _GD_Adr_Name4;
            }
            set
            {
                OnGD_Adr_Name4Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Name4" );
                _GD_Adr_Name4 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name4" );
                OnGD_Adr_Name4Changed ();
            }
        }
        private global::System.String _GD_Adr_Name4;
        partial void OnGD_Adr_Name4Changing ( global::System.String value );
        partial void OnGD_Adr_Name4Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Search
        {
            get
            {
                return _GD_Adr_Search;
            }
            set
            {
                OnGD_Adr_SearchChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Search" );
                _GD_Adr_Search = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Search" );
                OnGD_Adr_SearchChanged ();
            }
        }
        private global::System.String _GD_Adr_Search;
        partial void OnGD_Adr_SearchChanging ( global::System.String value );
        partial void OnGD_Adr_SearchChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street
        {
            get
            {
                return _GD_Adr_Street;
            }
            set
            {
                OnGD_Adr_StreetChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Street" );
                _GD_Adr_Street = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street" );
                OnGD_Adr_StreetChanged ();
            }
        }
        private global::System.String _GD_Adr_Street;
        partial void OnGD_Adr_StreetChanging ( global::System.String value );
        partial void OnGD_Adr_StreetChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street2
        {
            get
            {
                return _GD_Adr_Street2;
            }
            set
            {
                OnGD_Adr_Street2Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street2" );
                _GD_Adr_Street2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street2" );
                OnGD_Adr_Street2Changed ();
            }
        }
        private global::System.String _GD_Adr_Street2;
        partial void OnGD_Adr_Street2Changing ( global::System.String value );
        partial void OnGD_Adr_Street2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street3
        {
            get
            {
                return _GD_Adr_Street3;
            }
            set
            {
                OnGD_Adr_Street3Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street3" );
                _GD_Adr_Street3 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street3" );
                OnGD_Adr_Street3Changed ();
            }
        }
        private global::System.String _GD_Adr_Street3;
        partial void OnGD_Adr_Street3Changing ( global::System.String value );
        partial void OnGD_Adr_Street3Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street4
        {
            get
            {
                return _GD_Adr_Street4;
            }
            set
            {
                OnGD_Adr_Street4Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street4" );
                _GD_Adr_Street4 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street4" );
                OnGD_Adr_Street4Changed ();
            }
        }
        private global::System.String _GD_Adr_Street4;
        partial void OnGD_Adr_Street4Changing ( global::System.String value );
        partial void OnGD_Adr_Street4Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street5
        {
            get
            {
                return _GD_Adr_Street5;
            }
            set
            {
                OnGD_Adr_Street5Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street5" );
                _GD_Adr_Street5 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street5" );
                OnGD_Adr_Street5Changed ();
            }
        }
        private global::System.String _GD_Adr_Street5;
        partial void OnGD_Adr_Street5Changing ( global::System.String value );
        partial void OnGD_Adr_Street5Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_PostalCode
        {
            get
            {
                return _GD_Adr_PostalCode;
            }
            set
            {
                OnGD_Adr_PostalCodeChanging ( value );
                ReportPropertyChanging ( "GD_Adr_PostalCode" );
                _GD_Adr_PostalCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_PostalCode" );
                OnGD_Adr_PostalCodeChanged ();
            }
        }
        private global::System.String _GD_Adr_PostalCode;
        partial void OnGD_Adr_PostalCodeChanging ( global::System.String value );
        partial void OnGD_Adr_PostalCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_City
        {
            get
            {
                return _GD_Adr_City;
            }
            set
            {
                OnGD_Adr_CityChanging ( value );
                ReportPropertyChanging ( "GD_Adr_City" );
                _GD_Adr_City = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_City" );
                OnGD_Adr_CityChanged ();
            }
        }
        private global::System.String _GD_Adr_City;
        partial void OnGD_Adr_CityChanging ( global::System.String value );
        partial void OnGD_Adr_CityChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Country
        {
            get
            {
                return _GD_Adr_Country;
            }
            set
            {
                OnGD_Adr_CountryChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Country" );
                _GD_Adr_Country = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Country" );
                OnGD_Adr_CountryChanged ();
            }
        }
        private global::System.String _GD_Adr_Country;
        partial void OnGD_Adr_CountryChanging ( global::System.String value );
        partial void OnGD_Adr_CountryChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Region
        {
            get
            {
                return _GD_Adr_Region;
            }
            set
            {
                OnGD_Adr_RegionChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Region" );
                _GD_Adr_Region = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Region" );
                OnGD_Adr_RegionChanged ();
            }
        }
        private global::System.String _GD_Adr_Region;
        partial void OnGD_Adr_RegionChanging ( global::System.String value );
        partial void OnGD_Adr_RegionChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_POBox
        {
            get
            {
                return _GD_Adr_POBox;
            }
            set
            {
                OnGD_Adr_POBoxChanging ( value );
                ReportPropertyChanging ( "GD_Adr_POBox" );
                _GD_Adr_POBox = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_POBox" );
                OnGD_Adr_POBoxChanged ();
            }
        }
        private global::System.String _GD_Adr_POBox;
        partial void OnGD_Adr_POBoxChanging ( global::System.String value );
        partial void OnGD_Adr_POBoxChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_POBoxPostalCode
        {
            get
            {
                return _GD_Adr_POBoxPostalCode;
            }
            set
            {
                OnGD_Adr_POBoxPostalCodeChanging ( value );
                ReportPropertyChanging ( "GD_Adr_POBoxPostalCode" );
                _GD_Adr_POBoxPostalCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_POBoxPostalCode" );
                OnGD_Adr_POBoxPostalCodeChanged ();
            }
        }
        private global::System.String _GD_Adr_POBoxPostalCode;
        partial void OnGD_Adr_POBoxPostalCodeChanging ( global::System.String value );
        partial void OnGD_Adr_POBoxPostalCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_LanguageCode
        {
            get
            {
                return _GD_Com_LanguageCode;
            }
            set
            {
                OnGD_Com_LanguageCodeChanging ( value );
                ReportPropertyChanging ( "GD_Com_LanguageCode" );
                _GD_Com_LanguageCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_LanguageCode" );
                OnGD_Com_LanguageCodeChanged ();
            }
        }
        private global::System.String _GD_Com_LanguageCode;
        partial void OnGD_Com_LanguageCodeChanging ( global::System.String value );
        partial void OnGD_Com_LanguageCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_Telephone
        {
            get
            {
                return _GD_Com_Telephone;
            }
            set
            {
                OnGD_Com_TelephoneChanging ( value );
                ReportPropertyChanging ( "GD_Com_Telephone" );
                _GD_Com_Telephone = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_Telephone" );
                OnGD_Com_TelephoneChanged ();
            }
        }
        private global::System.String _GD_Com_Telephone;
        partial void OnGD_Com_TelephoneChanging ( global::System.String value );
        partial void OnGD_Com_TelephoneChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_FaxNumber
        {
            get
            {
                return _GD_Com_FaxNumber;
            }
            set
            {
                OnGD_Com_FaxNumberChanging ( value );
                ReportPropertyChanging ( "GD_Com_FaxNumber" );
                _GD_Com_FaxNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_FaxNumber" );
                OnGD_Com_FaxNumberChanged ();
            }
        }
        private global::System.String _GD_Com_FaxNumber;
        partial void OnGD_Com_FaxNumberChanging ( global::System.String value );
        partial void OnGD_Com_FaxNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_EmailAddress
        {
            get
            {
                return _GD_Com_EmailAddress;
            }
            set
            {
                OnGD_Com_EmailAddressChanging ( value );
                ReportPropertyChanging ( "GD_Com_EmailAddress" );
                _GD_Com_EmailAddress = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_EmailAddress" );
                OnGD_Com_EmailAddressChanged ();
            }
        }
        private global::System.String _GD_Com_EmailAddress;
        partial void OnGD_Com_EmailAddressChanging ( global::System.String value );
        partial void OnGD_Com_EmailAddressChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_Telebox
        {
            get
            {
                return _GD_Com_Telebox;
            }
            set
            {
                OnGD_Com_TeleboxChanging ( value );
                ReportPropertyChanging ( "GD_Com_Telebox" );
                _GD_Com_Telebox = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_Telebox" );
                OnGD_Com_TeleboxChanged ();
            }
        }
        private global::System.String _GD_Com_Telebox;
        partial void OnGD_Com_TeleboxChanging ( global::System.String value );
        partial void OnGD_Com_TeleboxChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_URL
        {
            get
            {
                return _GD_Com_URL;
            }
            set
            {
                OnGD_Com_URLChanging ( value );
                ReportPropertyChanging ( "GD_Com_URL" );
                _GD_Com_URL = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_URL" );
                OnGD_Com_URLChanged ();
            }
        }
        private global::System.String _GD_Com_URL;
        partial void OnGD_Com_URLChanging ( global::System.String value );
        partial void OnGD_Com_URLChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_DataLine
        {
            get
            {
                return _GD_Com_DataLine;
            }
            set
            {
                OnGD_Com_DataLineChanging ( value );
                ReportPropertyChanging ( "GD_Com_DataLine" );
                _GD_Com_DataLine = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_DataLine" );
                OnGD_Com_DataLineChanged ();
            }
        }
        private global::System.String _GD_Com_DataLine;
        partial void OnGD_Com_DataLineChanging ( global::System.String value );
        partial void OnGD_Com_DataLineChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_Comment
        {
            get
            {
                return _GD_Com_Comment;
            }
            set
            {
                OnGD_Com_CommentChanging ( value );
                ReportPropertyChanging ( "GD_Com_Comment" );
                _GD_Com_Comment = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_Comment" );
                OnGD_Com_CommentChanged ();
            }
        }
        private global::System.String _GD_Com_Comment;
        partial void OnGD_Com_CommentChanging ( global::System.String value );
        partial void OnGD_Com_CommentChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_Title
        {
            get
            {
                return _GD_NatP_Title;
            }
            set
            {
                OnGD_NatP_TitleChanging ( value );
                ReportPropertyChanging ( "GD_NatP_Title" );
                _GD_NatP_Title = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_Title" );
                OnGD_NatP_TitleChanged ();
            }
        }
        private global::System.String _GD_NatP_Title;
        partial void OnGD_NatP_TitleChanging ( global::System.String value );
        partial void OnGD_NatP_TitleChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.DateTime> GD_NatP_DateOfBirth
        {
            get
            {
                return _GD_NatP_DateOfBirth;
            }
            set
            {
                OnGD_NatP_DateOfBirthChanging ( value );
                ReportPropertyChanging ( "GD_NatP_DateOfBirth" );
                _GD_NatP_DateOfBirth = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_NatP_DateOfBirth" );
                OnGD_NatP_DateOfBirthChanged ();
            }
        }
        private Nullable<global::System.DateTime> _GD_NatP_DateOfBirth;
        partial void OnGD_NatP_DateOfBirthChanging ( Nullable<global::System.DateTime> value );
        partial void OnGD_NatP_DateOfBirthChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_PlaceOfBirth
        {
            get
            {
                return _GD_NatP_PlaceOfBirth;
            }
            set
            {
                OnGD_NatP_PlaceOfBirthChanging ( value );
                ReportPropertyChanging ( "GD_NatP_PlaceOfBirth" );
                _GD_NatP_PlaceOfBirth = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_PlaceOfBirth" );
                OnGD_NatP_PlaceOfBirthChanged ();
            }
        }
        private global::System.String _GD_NatP_PlaceOfBirth;
        partial void OnGD_NatP_PlaceOfBirthChanging ( global::System.String value );
        partial void OnGD_NatP_PlaceOfBirthChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_Profession
        {
            get
            {
                return _GD_NatP_Profession;
            }
            set
            {
                OnGD_NatP_ProfessionChanging ( value );
                ReportPropertyChanging ( "GD_NatP_Profession" );
                _GD_NatP_Profession = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_Profession" );
                OnGD_NatP_ProfessionChanged ();
            }
        }
        private global::System.String _GD_NatP_Profession;
        partial void OnGD_NatP_ProfessionChanging ( global::System.String value );
        partial void OnGD_NatP_ProfessionChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_Sex
        {
            get
            {
                return _GD_NatP_Sex;
            }
            set
            {
                OnGD_NatP_SexChanging ( value );
                ReportPropertyChanging ( "GD_NatP_Sex" );
                _GD_NatP_Sex = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_Sex" );
                OnGD_NatP_SexChanged ();
            }
        }
        private global::System.String _GD_NatP_Sex;
        partial void OnGD_NatP_SexChanging ( global::System.String value );
        partial void OnGD_NatP_SexChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_CustomerNumber
        {
            get
            {
                return _GD_Ctr_CustomerNumber;
            }
            set
            {
                OnGD_Ctr_CustomerNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_CustomerNumber" );
                _GD_Ctr_CustomerNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_CustomerNumber" );
                OnGD_Ctr_CustomerNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_CustomerNumber;
        partial void OnGD_Ctr_CustomerNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_CustomerNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_Industry
        {
            get
            {
                return _GD_Ctr_Industry;
            }
            set
            {
                OnGD_Ctr_IndustryChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_Industry" );
                _GD_Ctr_Industry = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_Industry" );
                OnGD_Ctr_IndustryChanged ();
            }
        }
        private global::System.String _GD_Ctr_Industry;
        partial void OnGD_Ctr_IndustryChanging ( global::System.String value );
        partial void OnGD_Ctr_IndustryChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_CF
        {
            get
            {
                return _GD_Ctr_CF;
            }
            set
            {
                OnGD_Ctr_CFChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_CF" );
                _GD_Ctr_CF = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_CF" );
                OnGD_Ctr_CFChanged ();
            }
        }
        private global::System.String _GD_Ctr_CF;
        partial void OnGD_Ctr_CFChanging ( global::System.String value );
        partial void OnGD_Ctr_CFChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_PIVA
        {
            get
            {
                return _GD_Ctr_PIVA;
            }
            set
            {
                OnGD_Ctr_PIVAChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_PIVA" );
                _GD_Ctr_PIVA = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_PIVA" );
                OnGD_Ctr_PIVAChanged ();
            }
        }
        private global::System.String _GD_Ctr_PIVA;
        partial void OnGD_Ctr_PIVAChanging ( global::System.String value );
        partial void OnGD_Ctr_PIVAChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_NIF
        {
            get
            {
                return _GD_Ctr_NIF;
            }
            set
            {
                OnGD_Ctr_NIFChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_NIF" );
                _GD_Ctr_NIF = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_NIF" );
                OnGD_Ctr_NIFChanged ();
            }
        }
        private global::System.String _GD_Ctr_NIF;
        partial void OnGD_Ctr_NIFChanging ( global::System.String value );
        partial void OnGD_Ctr_NIFChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxCode1
        {
            get
            {
                return _GD_Ctr_TaxCode1;
            }
            set
            {
                OnGD_Ctr_TaxCode1Changing ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1" );
                _GD_Ctr_TaxCode1 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1" );
                OnGD_Ctr_TaxCode1Changed ();
            }
        }
        private global::System.String _GD_Ctr_TaxCode1;
        partial void OnGD_Ctr_TaxCode1Changing ( global::System.String value );
        partial void OnGD_Ctr_TaxCode1Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_TaxCode1_HighRisk
        {
            get
            {
                return _GD_Ctr_TaxCode1_HighRisk;
            }
            set
            {
                OnGD_Ctr_TaxCode1_HighRiskChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1_HighRisk" );
                _GD_Ctr_TaxCode1_HighRisk = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1_HighRisk" );
                OnGD_Ctr_TaxCode1_HighRiskChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_TaxCode1_HighRisk;
        partial void OnGD_Ctr_TaxCode1_HighRiskChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_TaxCode1_HighRiskChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_TaxCode1_Gov
        {
            get
            {
                return _GD_Ctr_TaxCode1_Gov;
            }
            set
            {
                OnGD_Ctr_TaxCode1_GovChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1_Gov" );
                _GD_Ctr_TaxCode1_Gov = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1_Gov" );
                OnGD_Ctr_TaxCode1_GovChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_TaxCode1_Gov;
        partial void OnGD_Ctr_TaxCode1_GovChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_TaxCode1_GovChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_TaxCode1_NP
        {
            get
            {
                return _GD_Ctr_TaxCode1_NP;
            }
            set
            {
                OnGD_Ctr_TaxCode1_NPChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1_NP" );
                _GD_Ctr_TaxCode1_NP = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1_NP" );
                OnGD_Ctr_TaxCode1_NPChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_TaxCode1_NP;
        partial void OnGD_Ctr_TaxCode1_NPChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_TaxCode1_NPChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxCode2
        {
            get
            {
                return _GD_Ctr_TaxCode2;
            }
            set
            {
                OnGD_Ctr_TaxCode2Changing ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode2" );
                _GD_Ctr_TaxCode2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxCode2" );
                OnGD_Ctr_TaxCode2Changed ();
            }
        }
        private global::System.String _GD_Ctr_TaxCode2;
        partial void OnGD_Ctr_TaxCode2Changing ( global::System.String value );
        partial void OnGD_Ctr_TaxCode2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_VATRegistrationNumber
        {
            get
            {
                return _GD_Ctr_VATRegistrationNumber;
            }
            set
            {
                OnGD_Ctr_VATRegistrationNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_VATRegistrationNumber" );
                _GD_Ctr_VATRegistrationNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_VATRegistrationNumber" );
                OnGD_Ctr_VATRegistrationNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_VATRegistrationNumber;
        partial void OnGD_Ctr_VATRegistrationNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_VATRegistrationNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_SalesPurTax
        {
            get
            {
                return _GD_Ctr_SalesPurTax;
            }
            set
            {
                OnGD_Ctr_SalesPurTaxChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_SalesPurTax" );
                _GD_Ctr_SalesPurTax = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_SalesPurTax" );
                OnGD_Ctr_SalesPurTaxChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_SalesPurTax;
        partial void OnGD_Ctr_SalesPurTaxChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_SalesPurTaxChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_RepresentiveName
        {
            get
            {
                return _GD_Ctr_RepresentiveName;
            }
            set
            {
                OnGD_Ctr_RepresentiveNameChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_RepresentiveName" );
                _GD_Ctr_RepresentiveName = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_RepresentiveName" );
                OnGD_Ctr_RepresentiveNameChanged ();
            }
        }
        private global::System.String _GD_Ctr_RepresentiveName;
        partial void OnGD_Ctr_RepresentiveNameChanging ( global::System.String value );
        partial void OnGD_Ctr_RepresentiveNameChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxNumber
        {
            get
            {
                return _GD_Ctr_TaxNumber;
            }
            set
            {
                OnGD_Ctr_TaxNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxNumber" );
                _GD_Ctr_TaxNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxNumber" );
                OnGD_Ctr_TaxNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_TaxNumber;
        partial void OnGD_Ctr_TaxNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_TaxNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_CreditInfoNo
        {
            get
            {
                return _GD_Ctr_CreditInfoNo;
            }
            set
            {
                OnGD_Ctr_CreditInfoNoChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_CreditInfoNo" );
                _GD_Ctr_CreditInfoNo = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_CreditInfoNo" );
                OnGD_Ctr_CreditInfoNoChanged ();
            }
        }
        private global::System.String _GD_Ctr_CreditInfoNo;
        partial void OnGD_Ctr_CreditInfoNoChanging ( global::System.String value );
        partial void OnGD_Ctr_CreditInfoNoChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_ActualQMSystem
        {
            get
            {
                return _GD_Ctr_ActualQMSystem;
            }
            set
            {
                OnGD_Ctr_ActualQMSystemChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_ActualQMSystem" );
                _GD_Ctr_ActualQMSystem = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_ActualQMSystem" );
                OnGD_Ctr_ActualQMSystemChanged ();
            }
        }
        private global::System.String _GD_Ctr_ActualQMSystem;
        partial void OnGD_Ctr_ActualQMSystemChanging ( global::System.String value );
        partial void OnGD_Ctr_ActualQMSystemChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_LastExtReview
        {
            get
            {
                return _GD_Ctr_LastExtReview;
            }
            set
            {
                OnGD_Ctr_LastExtReviewChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_LastExtReview" );
                _GD_Ctr_LastExtReview = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_LastExtReview" );
                OnGD_Ctr_LastExtReviewChanged ();
            }
        }
        private global::System.String _GD_Ctr_LastExtReview;
        partial void OnGD_Ctr_LastExtReviewChanging ( global::System.String value );
        partial void OnGD_Ctr_LastExtReviewChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_QMSystemTo
        {
            get
            {
                return _GD_Ctr_QMSystemTo;
            }
            set
            {
                OnGD_Ctr_QMSystemToChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_QMSystemTo" );
                _GD_Ctr_QMSystemTo = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_QMSystemTo" );
                OnGD_Ctr_QMSystemToChanged ();
            }
        }
        private global::System.String _GD_Ctr_QMSystemTo;
        partial void OnGD_Ctr_QMSystemToChanging ( global::System.String value );
        partial void OnGD_Ctr_QMSystemToChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_AccountGroup
        {
            get
            {
                return _GD_Ctr_AccountGroup;
            }
            set
            {
                OnGD_Ctr_AccountGroupChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_AccountGroup" );
                _GD_Ctr_AccountGroup = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_AccountGroup" );
                OnGD_Ctr_AccountGroupChanged ();
            }
        }
        private global::System.String _GD_Ctr_AccountGroup;
        partial void OnGD_Ctr_AccountGroupChanging ( global::System.String value );
        partial void OnGD_Ctr_AccountGroupChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_IFANumber
        {
            get
            {
                return _GD_Ctr_IFANumber;
            }
            set
            {
                OnGD_Ctr_IFANumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_IFANumber" );
                _GD_Ctr_IFANumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_IFANumber" );
                OnGD_Ctr_IFANumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_IFANumber;
        partial void OnGD_Ctr_IFANumberChanging ( global::System.String value );
        partial void OnGD_Ctr_IFANumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String SUS_UserAccount
        {
            get
            {
                return _SUS_UserAccount;
            }
            set
            {
                OnSUS_UserAccountChanging ( value );
                ReportPropertyChanging ( "SUS_UserAccount" );
                _SUS_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "SUS_UserAccount" );
                OnSUS_UserAccountChanged ();
            }
        }
        private global::System.String _SUS_UserAccount;
        partial void OnSUS_UserAccountChanging ( global::System.String value );
        partial void OnSUS_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String RCO_UserAccount
        {
            get
            {
                return _RCO_UserAccount;
            }
            set
            {
                OnRCO_UserAccountChanging ( value );
                ReportPropertyChanging ( "RCO_UserAccount" );
                _RCO_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "RCO_UserAccount" );
                OnRCO_UserAccountChanged ();
            }
        }
        private global::System.String _RCO_UserAccount;
        partial void OnRCO_UserAccountChanging ( global::System.String value );
        partial void OnRCO_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String CLERK_UserAccount
        {
            get
            {
                return _CLERK_UserAccount;
            }
            set
            {
                OnCLERK_UserAccountChanging ( value );
                ReportPropertyChanging ( "CLERK_UserAccount" );
                _CLERK_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "CLERK_UserAccount" );
                OnCLERK_UserAccountChanged ();
            }
        }
        private global::System.String _CLERK_UserAccount;
        partial void OnCLERK_UserAccountChanging ( global::System.String value );
        partial void OnCLERK_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String RequestType
        {
            get
            {
                return _RequestType;
            }
            set
            {
                OnRequestTypeChanging ( value );
                ReportPropertyChanging ( "RequestType" );
                _RequestType = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "RequestType" );
                OnRequestTypeChanged ();
            }
        }
        private global::System.String _RequestType;
        partial void OnRequestTypeChanging ( global::System.String value );
        partial void OnRequestTypeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ADRNR
        {
            get
            {
                return _ADRNR;
            }
            set
            {
                OnADRNRChanging ( value );
                ReportPropertyChanging ( "ADRNR" );
                _ADRNR = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ADRNR" );
                OnADRNRChanged ();
            }
        }
        private global::System.String _ADRNR;
        partial void OnADRNRChanging ( global::System.String value );
        partial void OnADRNRChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String SAP_Message
        {
            get
            {
                return _SAP_Message;
            }
            set
            {
                OnSAP_MessageChanging ( value );
                ReportPropertyChanging ( "SAP_Message" );
                _SAP_Message = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "SAP_Message" );
                OnSAP_MessageChanged ();
            }
        }
        private global::System.String _SAP_Message;
        partial void OnSAP_MessageChanging ( global::System.String value );
        partial void OnSAP_MessageChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String CostCenter
        {
            get
            {
                return _CostCenter;
            }
            set
            {
                OnCostCenterChanging ( value );
                ReportPropertyChanging ( "CostCenter" );
                _CostCenter = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "CostCenter" );
                OnCostCenterChanged ();
            }
        }
        private global::System.String _CostCenter;
        partial void OnCostCenterChanging ( global::System.String value );
        partial void OnCostCenterChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String DDLDCComment
        {
            get
            {
                return _DDLDCComment;
            }
            set
            {
                OnDDLDCCommentChanging ( value );
                ReportPropertyChanging ( "DDLDCComment" );
                _DDLDCComment = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "DDLDCComment" );
                OnDDLDCCommentChanged ();
            }
        }
        private global::System.String _DDLDCComment;
        partial void OnDDLDCCommentChanging ( global::System.String value );
        partial void OnDDLDCCommentChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String SR_Comments
        {
            get
            {
                return _SR_Comments;
            }
            set
            {
                OnSR_CommentsChanging ( value );
                ReportPropertyChanging ( "SR_Comments" );
                _SR_Comments = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "SR_Comments" );
                OnSR_CommentsChanged ();
            }
        }
        private global::System.String _SR_Comments;
        partial void OnSR_CommentsChanging ( global::System.String value );
        partial void OnSR_CommentsChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralPostingBlock
        {
            get
            {
                return _BLK_CentralPostingBlock;
            }
            set
            {
                OnBLK_CentralPostingBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralPostingBlock" );
                _BLK_CentralPostingBlock = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralPostingBlock" );
                OnBLK_CentralPostingBlockChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralPostingBlock;
        partial void OnBLK_CentralPostingBlockChanging ( global::System.Boolean value );
        partial void OnBLK_CentralPostingBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_PostingBlockForCC
        {
            get
            {
                return _BLK_PostingBlockForCC;
            }
            set
            {
                OnBLK_PostingBlockForCCChanging ( value );
                ReportPropertyChanging ( "BLK_PostingBlockForCC" );
                _BLK_PostingBlockForCC = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_PostingBlockForCC" );
                OnBLK_PostingBlockForCCChanged ();
            }
        }
        private global::System.Boolean _BLK_PostingBlockForCC;
        partial void OnBLK_PostingBlockForCCChanging ( global::System.Boolean value );
        partial void OnBLK_PostingBlockForCCChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_CentralSalesOrderBlock
        {
            get
            {
                return _BLK_CentralSalesOrderBlock;
            }
            set
            {
                OnBLK_CentralSalesOrderBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralSalesOrderBlock" );
                _BLK_CentralSalesOrderBlock = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_CentralSalesOrderBlock" );
                OnBLK_CentralSalesOrderBlockChanged ();
            }
        }
        private global::System.String _BLK_CentralSalesOrderBlock;
        partial void OnBLK_CentralSalesOrderBlockChanging ( global::System.String value );
        partial void OnBLK_CentralSalesOrderBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_OrdersBlockAtSalesArea
        {
            get
            {
                return _BLK_OrdersBlockAtSalesArea;
            }
            set
            {
                OnBLK_OrdersBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_OrdersBlockAtSalesArea" );
                _BLK_OrdersBlockAtSalesArea = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_OrdersBlockAtSalesArea" );
                OnBLK_OrdersBlockAtSalesAreaChanged ();
            }
        }
        private global::System.String _BLK_OrdersBlockAtSalesArea;
        partial void OnBLK_OrdersBlockAtSalesAreaChanging ( global::System.String value );
        partial void OnBLK_OrdersBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_CentralDeliveriesBlock
        {
            get
            {
                return _BLK_CentralDeliveriesBlock;
            }
            set
            {
                OnBLK_CentralDeliveriesBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralDeliveriesBlock" );
                _BLK_CentralDeliveriesBlock = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_CentralDeliveriesBlock" );
                OnBLK_CentralDeliveriesBlockChanged ();
            }
        }
        private global::System.String _BLK_CentralDeliveriesBlock;
        partial void OnBLK_CentralDeliveriesBlockChanging ( global::System.String value );
        partial void OnBLK_CentralDeliveriesBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_DeliveriesBlockAtSalesArea
        {
            get
            {
                return _BLK_DeliveriesBlockAtSalesArea;
            }
            set
            {
                OnBLK_DeliveriesBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_DeliveriesBlockAtSalesArea" );
                _BLK_DeliveriesBlockAtSalesArea = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_DeliveriesBlockAtSalesArea" );
                OnBLK_DeliveriesBlockAtSalesAreaChanged ();
            }
        }
        private global::System.String _BLK_DeliveriesBlockAtSalesArea;
        partial void OnBLK_DeliveriesBlockAtSalesAreaChanging ( global::System.String value );
        partial void OnBLK_DeliveriesBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_CentralBillingBlock
        {
            get
            {
                return _BLK_CentralBillingBlock;
            }
            set
            {
                OnBLK_CentralBillingBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralBillingBlock" );
                _BLK_CentralBillingBlock = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_CentralBillingBlock" );
                OnBLK_CentralBillingBlockChanged ();
            }
        }
        private global::System.String _BLK_CentralBillingBlock;
        partial void OnBLK_CentralBillingBlockChanging ( global::System.String value );
        partial void OnBLK_CentralBillingBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_BillingBlockAtSalesArea
        {
            get
            {
                return _BLK_BillingBlockAtSalesArea;
            }
            set
            {
                OnBLK_BillingBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_BillingBlockAtSalesArea" );
                _BLK_BillingBlockAtSalesArea = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_BillingBlockAtSalesArea" );
                OnBLK_BillingBlockAtSalesAreaChanged ();
            }
        }
        private global::System.String _BLK_BillingBlockAtSalesArea;
        partial void OnBLK_BillingBlockAtSalesAreaChanging ( global::System.String value );
        partial void OnBLK_BillingBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralSalesSupportBlock
        {
            get
            {
                return _BLK_CentralSalesSupportBlock;
            }
            set
            {
                OnBLK_CentralSalesSupportBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralSalesSupportBlock" );
                _BLK_CentralSalesSupportBlock = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralSalesSupportBlock" );
                OnBLK_CentralSalesSupportBlockChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralSalesSupportBlock;
        partial void OnBLK_CentralSalesSupportBlockChanging ( global::System.Boolean value );
        partial void OnBLK_CentralSalesSupportBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralSalesSupportBlockAtSalesArea
        {
            get
            {
                return _BLK_CentralSalesSupportBlockAtSalesArea;
            }
            set
            {
                OnBLK_CentralSalesSupportBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_CentralSalesSupportBlockAtSalesArea" );
                _BLK_CentralSalesSupportBlockAtSalesArea = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralSalesSupportBlockAtSalesArea" );
                OnBLK_CentralSalesSupportBlockAtSalesAreaChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralSalesSupportBlockAtSalesArea;
        partial void OnBLK_CentralSalesSupportBlockAtSalesAreaChanging ( global::System.Boolean value );
        partial void OnBLK_CentralSalesSupportBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralDeletionFlagMasterRecord
        {
            get
            {
                return _BLK_CentralDeletionFlagMasterRecord;
            }
            set
            {
                OnBLK_CentralDeletionFlagMasterRecordChanging ( value );
                ReportPropertyChanging ( "BLK_CentralDeletionFlagMasterRecord" );
                _BLK_CentralDeletionFlagMasterRecord = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralDeletionFlagMasterRecord" );
                OnBLK_CentralDeletionFlagMasterRecordChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralDeletionFlagMasterRecord;
        partial void OnBLK_CentralDeletionFlagMasterRecordChanging ( global::System.Boolean value );
        partial void OnBLK_CentralDeletionFlagMasterRecordChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_DeletionFlagMasterRecordCC
        {
            get
            {
                return _BLK_DeletionFlagMasterRecordCC;
            }
            set
            {
                OnBLK_DeletionFlagMasterRecordCCChanging ( value );
                ReportPropertyChanging ( "BLK_DeletionFlagMasterRecordCC" );
                _BLK_DeletionFlagMasterRecordCC = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_DeletionFlagMasterRecordCC" );
                OnBLK_DeletionFlagMasterRecordCCChanged ();
            }
        }
        private global::System.Boolean _BLK_DeletionFlagMasterRecordCC;
        partial void OnBLK_DeletionFlagMasterRecordCCChanging ( global::System.Boolean value );
        partial void OnBLK_DeletionFlagMasterRecordCCChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_DeletionFlagMasterRecordSA
        {
            get
            {
                return _BLK_DeletionFlagMasterRecordSA;
            }
            set
            {
                OnBLK_DeletionFlagMasterRecordSAChanging ( value );
                ReportPropertyChanging ( "BLK_DeletionFlagMasterRecordSA" );
                _BLK_DeletionFlagMasterRecordSA = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_DeletionFlagMasterRecordSA" );
                OnBLK_DeletionFlagMasterRecordSAChanged ();
            }
        }
        private global::System.Boolean _BLK_DeletionFlagMasterRecordSA;
        partial void OnBLK_DeletionFlagMasterRecordSAChanging ( global::System.Boolean value );
        partial void OnBLK_DeletionFlagMasterRecordSAChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralDeletionBlockMasterRecord
        {
            get
            {
                return _BLK_CentralDeletionBlockMasterRecord;
            }
            set
            {
                OnBLK_CentralDeletionBlockMasterRecordChanging ( value );
                ReportPropertyChanging ( "BLK_CentralDeletionBlockMasterRecord" );
                _BLK_CentralDeletionBlockMasterRecord = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralDeletionBlockMasterRecord" );
                OnBLK_CentralDeletionBlockMasterRecordChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralDeletionBlockMasterRecord;
        partial void OnBLK_CentralDeletionBlockMasterRecordChanging ( global::System.Boolean value );
        partial void OnBLK_CentralDeletionBlockMasterRecordChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_DeletionBlockMasterRecordCC
        {
            get
            {
                return _BLK_DeletionBlockMasterRecordCC;
            }
            set
            {
                OnBLK_DeletionBlockMasterRecordCCChanging ( value );
                ReportPropertyChanging ( "BLK_DeletionBlockMasterRecordCC" );
                _BLK_DeletionBlockMasterRecordCC = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_DeletionBlockMasterRecordCC" );
                OnBLK_DeletionBlockMasterRecordCCChanged ();
            }
        }
        private global::System.Boolean _BLK_DeletionBlockMasterRecordCC;
        partial void OnBLK_DeletionBlockMasterRecordCCChanging ( global::System.Boolean value );
        partial void OnBLK_DeletionBlockMasterRecordCCChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterDivision
        {
            get
            {
                return _ClusterDivision;
            }
            set
            {
                OnClusterDivisionChanging ( value );
                ReportPropertyChanging ( "ClusterDivision" );
                _ClusterDivision = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterDivision" );
                OnClusterDivisionChanged ();
            }
        }
        private global::System.String _ClusterDivision;
        partial void OnClusterDivisionChanging ( global::System.String value );
        partial void OnClusterDivisionChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterDistributionChannel
        {
            get
            {
                return _ClusterDistributionChannel;
            }
            set
            {
                OnClusterDistributionChannelChanging ( value );
                ReportPropertyChanging ( "ClusterDistributionChannel" );
                _ClusterDistributionChannel = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterDistributionChannel" );
                OnClusterDistributionChannelChanged ();
            }
        }
        private global::System.String _ClusterDistributionChannel;
        partial void OnClusterDistributionChannelChanging ( global::System.String value );
        partial void OnClusterDistributionChannelChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_VendorNumber
        {
            get
            {
                return _GD_Ctr_VendorNumber;
            }
            set
            {
                OnGD_Ctr_VendorNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_VendorNumber" );
                _GD_Ctr_VendorNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_VendorNumber" );
                OnGD_Ctr_VendorNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_VendorNumber;
        partial void OnGD_Ctr_VendorNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_VendorNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String Email_DetailedActivity
        {
            get
            {
                return _Email_DetailedActivity;
            }
            set
            {
                OnEmail_DetailedActivityChanging ( value );
                ReportPropertyChanging ( "Email_DetailedActivity" );
                _Email_DetailedActivity = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "Email_DetailedActivity" );
                OnEmail_DetailedActivityChanged ();
            }
        }
        private global::System.String _Email_DetailedActivity;
        partial void OnEmail_DetailedActivityChanging ( global::System.String value );
        partial void OnEmail_DetailedActivityChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String Email_StepChangeLog
        {
            get
            {
                return _Email_StepChangeLog;
            }
            set
            {
                OnEmail_StepChangeLogChanging ( value );
                ReportPropertyChanging ( "Email_StepChangeLog" );
                _Email_StepChangeLog = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "Email_StepChangeLog" );
                OnEmail_StepChangeLogChanged ();
            }
        }
        private global::System.String _Email_StepChangeLog;
        partial void OnEmail_StepChangeLogChanging ( global::System.String value );
        partial void OnEmail_StepChangeLogChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_TransportZone
        {
            get
            {
                return _GD_Com_TransportZone;
            }
            set
            {
                OnGD_Com_TransportZoneChanging ( value );
                ReportPropertyChanging ( "GD_Com_TransportZone" );
                _GD_Com_TransportZone = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_TransportZone" );
                OnGD_Com_TransportZoneChanged ();
            }
        }
        private global::System.String _GD_Com_TransportZone;
        partial void OnGD_Com_TransportZoneChanging ( global::System.String value );
        partial void OnGD_Com_TransportZoneChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean Locked
        {
            get
            {
                return _Locked;
            }
            set
            {
                OnLockedChanging ( value );
                ReportPropertyChanging ( "Locked" );
                _Locked = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "Locked" );
                OnLockedChanged ();
            }
        }
        private global::System.Boolean _Locked;
        partial void OnLockedChanging ( global::System.Boolean value );
        partial void OnLockedChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String UserWithLock
        {
            get
            {
                return _UserWithLock;
            }
            set
            {
                OnUserWithLockChanging ( value );
                ReportPropertyChanging ( "UserWithLock" );
                _UserWithLock = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "UserWithLock" );
                OnUserWithLockChanged ();
            }
        }
        private global::System.String _UserWithLock;
        partial void OnUserWithLockChanging ( global::System.String value );
        partial void OnUserWithLockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.DateTime> BlockedTime
        {
            get
            {
                return _BlockedTime;
            }
            set
            {
                OnBlockedTimeChanging ( value );
                ReportPropertyChanging ( "BlockedTime" );
                _BlockedTime = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BlockedTime" );
                OnBlockedTimeChanged ();
            }
        }
        private Nullable<global::System.DateTime> _BlockedTime;
        partial void OnBlockedTimeChanging ( Nullable<global::System.DateTime> value );
        partial void OnBlockedTimeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_IFANumber1
        {
            get
            {
                return _GD_Ctr_IFANumber1;
            }
            set
            {
                OnGD_Ctr_IFANumber1Changing ( value );
                ReportPropertyChanging ( "GD_Ctr_IFANumber1" );
                _GD_Ctr_IFANumber1 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_IFANumber1" );
                OnGD_Ctr_IFANumber1Changed ();
            }
        }
        private global::System.String _GD_Ctr_IFANumber1;
        partial void OnGD_Ctr_IFANumber1Changing ( global::System.String value );
        partial void OnGD_Ctr_IFANumber1Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_SAPNumber
        {
            get
            {
                return _GD_SAPNumber;
            }
            set
            {
                OnGD_SAPNumberChanging ( value );
                ReportPropertyChanging ( "GD_SAPNumber" );
                _GD_SAPNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_SAPNumber" );
                OnGD_SAPNumberChanged ();
            }
        }
        private global::System.String _GD_SAPNumber;
        partial void OnGD_SAPNumberChanging ( global::System.String value );
        partial void OnGD_SAPNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_UnsubscribeCMD
        {
            get
            {
                return _GD_Ctr_UnsubscribeCMD;
            }
            set
            {
                OnGD_Ctr_UnsubscribeCMDChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_UnsubscribeCMD" );
                _GD_Ctr_UnsubscribeCMD = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_UnsubscribeCMD" );
                OnGD_Ctr_UnsubscribeCMDChanged ();
            }
        }
        private global::System.String _GD_Ctr_UnsubscribeCMD;
        partial void OnGD_Ctr_UnsubscribeCMDChanging ( global::System.String value );
        partial void OnGD_Ctr_UnsubscribeCMDChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String Email_ExtraField1
        {
            get
            {
                return _Email_ExtraField1;
            }
            set
            {
                OnEmail_ExtraField1Changing ( value );
                ReportPropertyChanging ( "Email_ExtraField1" );
                _Email_ExtraField1 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "Email_ExtraField1" );
                OnEmail_ExtraField1Changed ();
            }
        }
        private global::System.String _Email_ExtraField1;
        partial void OnEmail_ExtraField1Changing ( global::System.String value );
        partial void OnEmail_ExtraField1Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String Email_ExtraField2
        {
            get
            {
                return _Email_ExtraField2;
            }
            set
            {
                OnEmail_ExtraField2Changing ( value );
                ReportPropertyChanging ( "Email_ExtraField2" );
                _Email_ExtraField2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "Email_ExtraField2" );
                OnEmail_ExtraField2Changed ();
            }
        }
        private global::System.String _Email_ExtraField2;
        partial void OnEmail_ExtraField2Changing ( global::System.String value );
        partial void OnEmail_ExtraField2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String Email_ExtraField3
        {
            get
            {
                return _Email_ExtraField3;
            }
            set
            {
                OnEmail_ExtraField3Changing ( value );
                ReportPropertyChanging ( "Email_ExtraField3" );
                _Email_ExtraField3 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "Email_ExtraField3" );
                OnEmail_ExtraField3Changed ();
            }
        }
        private global::System.String _Email_ExtraField3;
        partial void OnEmail_ExtraField3Changing ( global::System.String value );
        partial void OnEmail_ExtraField3Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String Email_ExtraField4
        {
            get
            {
                return _Email_ExtraField4;
            }
            set
            {
                OnEmail_ExtraField4Changing ( value );
                ReportPropertyChanging ( "Email_ExtraField4" );
                _Email_ExtraField4 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "Email_ExtraField4" );
                OnEmail_ExtraField4Changed ();
            }
        }
        private global::System.String _Email_ExtraField4;
        partial void OnEmail_ExtraField4Changing ( global::System.String value );
        partial void OnEmail_ExtraField4Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String Email_ExtraField5
        {
            get
            {
                return _Email_ExtraField5;
            }
            set
            {
                OnEmail_ExtraField5Changing ( value );
                ReportPropertyChanging ( "Email_ExtraField5" );
                _Email_ExtraField5 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "Email_ExtraField5" );
                OnEmail_ExtraField5Changed ();
            }
        }
        private global::System.String _Email_ExtraField5;
        partial void OnEmail_ExtraField5Changing ( global::System.String value );
        partial void OnEmail_ExtraField5Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_City2
        {
            get
            {
                return _GD_Adr_City2;
            }
            set
            {
                OnGD_Adr_City2Changing ( value );
                ReportPropertyChanging ( "GD_Adr_City2" );
                _GD_Adr_City2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_City2" );
                OnGD_Adr_City2Changed ();
            }
        }
        private global::System.String _GD_Adr_City2;
        partial void OnGD_Adr_City2Changing ( global::System.String value );
        partial void OnGD_Adr_City2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_GFORM
        {
            get
            {
                return _GD_Ctr_GFORM;
            }
            set
            {
                OnGD_Ctr_GFORMChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_GFORM" );
                _GD_Ctr_GFORM = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_GFORM" );
                OnGD_Ctr_GFORMChanged ();
            }
        }
        private global::System.String _GD_Ctr_GFORM;
        partial void OnGD_Ctr_GFORMChanging ( global::System.String value );
        partial void OnGD_Ctr_GFORMChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_POBoxLoc
        {
            get
            {
                return _GD_Adr_POBoxLoc;
            }
            set
            {
                OnGD_Adr_POBoxLocChanging ( value );
                ReportPropertyChanging ( "GD_Adr_POBoxLoc" );
                _GD_Adr_POBoxLoc = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_POBoxLoc" );
                OnGD_Adr_POBoxLocChanged ();
            }
        }
        private global::System.String _GD_Adr_POBoxLoc;
        partial void OnGD_Adr_POBoxLocChanging ( global::System.String value );
        partial void OnGD_Adr_POBoxLocChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> Is_Both_Channel
        {
            get
            {
                return _Is_Both_Channel;
            }
            set
            {
                OnIs_Both_ChannelChanging ( value );
                ReportPropertyChanging ( "Is_Both_Channel" );
                _Is_Both_Channel = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "Is_Both_Channel" );
                OnIs_Both_ChannelChanged ();
            }
        }
        private Nullable<global::System.Boolean> _Is_Both_Channel;
        partial void OnIs_Both_ChannelChanging ( Nullable<global::System.Boolean> value );
        partial void OnIs_Both_ChannelChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String CL_RCO_UserAccount
        {
            get
            {
                return _CL_RCO_UserAccount;
            }
            set
            {
                OnCL_RCO_UserAccountChanging ( value );
                ReportPropertyChanging ( "CL_RCO_UserAccount" );
                _CL_RCO_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "CL_RCO_UserAccount" );
                OnCL_RCO_UserAccountChanged ();
            }
        }
        private global::System.String _CL_RCO_UserAccount;
        partial void OnCL_RCO_UserAccountChanging ( global::System.String value );
        partial void OnCL_RCO_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Damex
        {
            get
            {
                return _GD_Damex;
            }
            set
            {
                OnGD_DamexChanging ( value );
                ReportPropertyChanging ( "GD_Damex" );
                _GD_Damex = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Damex" );
                OnGD_DamexChanged ();
            }
        }
        private global::System.Boolean _GD_Damex;
        partial void OnGD_DamexChanging ( global::System.Boolean value );
        partial void OnGD_DamexChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_MainlyMilitary
        {
            get
            {
                return _GD_MainlyMilitary;
            }
            set
            {
                OnGD_MainlyMilitaryChanging ( value );
                ReportPropertyChanging ( "GD_MainlyMilitary" );
                _GD_MainlyMilitary = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_MainlyMilitary" );
                OnGD_MainlyMilitaryChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_MainlyMilitary;
        partial void OnGD_MainlyMilitaryChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_MainlyMilitaryChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_MainlyCivilian
        {
            get
            {
                return _GD_MainlyCivilian;
            }
            set
            {
                OnGD_MainlyCivilianChanging ( value );
                ReportPropertyChanging ( "GD_MainlyCivilian" );
                _GD_MainlyCivilian = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_MainlyCivilian" );
                OnGD_MainlyCivilianChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_MainlyCivilian;
        partial void OnGD_MainlyCivilianChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_MainlyCivilianChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_Nuclear
        {
            get
            {
                return _GD_Nuclear;
            }
            set
            {
                OnGD_NuclearChanging ( value );
                ReportPropertyChanging ( "GD_Nuclear" );
                _GD_Nuclear = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Nuclear" );
                OnGD_NuclearChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_Nuclear;
        partial void OnGD_NuclearChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_NuclearChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_FreeZone
        {
            get
            {
                return _GD_FreeZone;
            }
            set
            {
                OnGD_FreeZoneChanging ( value );
                ReportPropertyChanging ( "GD_FreeZone" );
                _GD_FreeZone = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_FreeZone" );
                OnGD_FreeZoneChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_FreeZone;
        partial void OnGD_FreeZoneChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_FreeZoneChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_Embassy
        {
            get
            {
                return _GD_Embassy;
            }
            set
            {
                OnGD_EmbassyChanging ( value );
                ReportPropertyChanging ( "GD_Embassy" );
                _GD_Embassy = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Embassy" );
                OnGD_EmbassyChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_Embassy;
        partial void OnGD_EmbassyChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_EmbassyChanged ();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_CompanyCode_MDMC_Requests", "MDMC_Request_CompanyCode" )]
        public MDMC_Request_CompanyCode MDMC_Request_CompanyCode
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedReference<MDMC_Request_CompanyCode> ( "MDMC_DataModel.FK_MDMC_CompanyCode_MDMC_Requests", "MDMC_Request_CompanyCode" ).Value;
            }
            set
            {
                ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedReference<MDMC_Request_CompanyCode> ( "MDMC_DataModel.FK_MDMC_CompanyCode_MDMC_Requests", "MDMC_Request_CompanyCode" ).Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute ( false )]
        [DataMemberAttribute ()]
        public EntityReference<MDMC_Request_CompanyCode> MDMC_Request_CompanyCodeReference
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedReference<MDMC_Request_CompanyCode> ( "MDMC_DataModel.FK_MDMC_CompanyCode_MDMC_Requests", "MDMC_Request_CompanyCode" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedReference<MDMC_Request_CompanyCode> ( "MDMC_DataModel.FK_MDMC_CompanyCode_MDMC_Requests", "MDMC_Request_CompanyCode", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_Request_ContactPersons_MDMC_Requests", "MDMC_Request_ContactPersons" )]
        public EntityCollection<MDMC_Request_ContactPersons> MDMC_Request_ContactPersons
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_ContactPersons> ( "MDMC_DataModel.FK_MDMC_Request_ContactPersons_MDMC_Requests", "MDMC_Request_ContactPersons" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_ContactPersons> ( "MDMC_DataModel.FK_MDMC_Request_ContactPersons_MDMC_Requests", "MDMC_Request_ContactPersons", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerBankDetails_MDMC_Requests", "MDMC_Request_CustomerBankDetails" )]
        public EntityCollection<MDMC_Request_CustomerBankDetails> MDMC_Request_CustomerBankDetails
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerBankDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerBankDetails_MDMC_Requests", "MDMC_Request_CustomerBankDetails" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerBankDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerBankDetails_MDMC_Requests", "MDMC_Request_CustomerBankDetails", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerEmailDetails_MDMC_Requests", "MDMC_Request_CustomerEmailDetails" )]
        public EntityCollection<MDMC_Request_CustomerEmailDetails> MDMC_Request_CustomerEmailDetails
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerEmailDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerEmailDetails_MDMC_Requests", "MDMC_Request_CustomerEmailDetails" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerEmailDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerEmailDetails_MDMC_Requests", "MDMC_Request_CustomerEmailDetails", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerFaxDetails_MDMC_Requests", "MDMC_Request_CustomerFaxDetails" )]
        public EntityCollection<MDMC_Request_CustomerFaxDetails> MDMC_Request_CustomerFaxDetails
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerFaxDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerFaxDetails_MDMC_Requests", "MDMC_Request_CustomerFaxDetails" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerFaxDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerFaxDetails_MDMC_Requests", "MDMC_Request_CustomerFaxDetails", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerPhoneDetails_MDMC_Requests", "MDMC_Request_CustomerPhoneDetails" )]
        public EntityCollection<MDMC_Request_CustomerPhoneDetails> MDMC_Request_CustomerPhoneDetails
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerPhoneDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPhoneDetails_MDMC_Requests", "MDMC_Request_CustomerPhoneDetails" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerPhoneDetails> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPhoneDetails_MDMC_Requests", "MDMC_Request_CustomerPhoneDetails", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerVAT_MDMC_Requests", "MDMC_Request_CustomerVAT" )]
        public EntityCollection<MDMC_Request_CustomerVAT> MDMC_Request_CustomerVAT
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerVAT> ( "MDMC_DataModel.FK_MDMC_RequestCustomerVAT_MDMC_Requests", "MDMC_Request_CustomerVAT" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerVAT> ( "MDMC_DataModel.FK_MDMC_RequestCustomerVAT_MDMC_Requests", "MDMC_Request_CustomerVAT", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_SalesOrganization_MDMC_Requests", "MDMC_Request_SalesOrganization" )]
        public EntityCollection<MDMC_Request_SalesOrganization> MDMC_Request_SalesOrganization
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_SalesOrganization> ( "MDMC_DataModel.FK_MDMC_SalesOrganization_MDMC_Requests", "MDMC_Request_SalesOrganization" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_SalesOrganization> ( "MDMC_DataModel.FK_MDMC_SalesOrganization_MDMC_Requests", "MDMC_Request_SalesOrganization", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerPartnerFunction_MDMC_Requests", "MDMC_Request_CustomerPartnerFunction" )]
        public EntityCollection<MDMC_Request_CustomerPartnerFunction> MDMC_Request_CustomerPartnerFunction
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerPartnerFunction> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPartnerFunction_MDMC_Requests", "MDMC_Request_CustomerPartnerFunction" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerPartnerFunction> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPartnerFunction_MDMC_Requests", "MDMC_Request_CustomerPartnerFunction", value );
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute ( NamespaceName = "MDMC_DataModel", Name = "MDMC_RequestsSAP" )]
    [Serializable ()]
    [DataContractAttribute ( IsReference = true )]
    public partial class MDMC_RequestsSAP : EntityObject, IMDMC_RequestsSAP
    {
        #region Factory Method

        /// <summary>
        /// Create a new MDMC_RequestsSAP object.
        /// </summary>
        /// <param name="requestID">Initial value of the RequestID property.</param>
        /// <param name="tS_IsUrgentRequest">Initial value of the TS_IsUrgentRequest property.</param>
        /// <param name="gD_Ctr_IsNaturalPerson">Initial value of the GD_Ctr_IsNaturalPerson property.</param>
        /// <param name="gD_Ctr_TaxCode1_HighRisk">Initial value of the GD_Ctr_TaxCode1_HighRisk property.</param>
        /// <param name="gD_Ctr_TaxCode1_Gov">Initial value of the GD_Ctr_TaxCode1_Gov property.</param>
        /// <param name="gD_Ctr_TaxCode1_NP">Initial value of the GD_Ctr_TaxCode1_NP property.</param>
        /// <param name="gD_Ctr_SalesPurTax">Initial value of the GD_Ctr_SalesPurTax property.</param>
        /// <param name="bLK_CentralPostingBlock">Initial value of the BLK_CentralPostingBlock property.</param>
        /// <param name="bLK_PostingBlockForCC">Initial value of the BLK_PostingBlockForCC property.</param>
        /// <param name="bLK_CentralSalesSupportBlock">Initial value of the BLK_CentralSalesSupportBlock property.</param>
        /// <param name="bLK_CentralSalesSupportBlockAtSalesArea">Initial value of the BLK_CentralSalesSupportBlockAtSalesArea property.</param>
        /// <param name="bLK_CentralDeletionFlagMasterRecord">Initial value of the BLK_CentralDeletionFlagMasterRecord property.</param>
        /// <param name="bLK_DeletionFlagMasterRecordCC">Initial value of the BLK_DeletionFlagMasterRecordCC property.</param>
        /// <param name="bLK_DeletionFlagMasterRecordSA">Initial value of the BLK_DeletionFlagMasterRecordSA property.</param>
        /// <param name="bLK_CentralDeletionBlockMasterRecord">Initial value of the BLK_CentralDeletionBlockMasterRecord property.</param>
        /// <param name="bLK_DeletionBlockMasterRecordCC">Initial value of the BLK_DeletionBlockMasterRecordCC property.</param>
        public static MDMC_RequestsSAP CreateMDMC_RequestsSAP ( global::System.String requestID, global::System.Boolean tS_IsUrgentRequest, global::System.Boolean gD_Ctr_IsNaturalPerson, global::System.Boolean gD_Ctr_TaxCode1_HighRisk, global::System.Boolean gD_Ctr_TaxCode1_Gov, global::System.Boolean gD_Ctr_TaxCode1_NP, global::System.Boolean gD_Ctr_SalesPurTax, global::System.Boolean bLK_CentralPostingBlock, global::System.Boolean bLK_PostingBlockForCC, global::System.Boolean bLK_CentralSalesSupportBlock, global::System.Boolean bLK_CentralSalesSupportBlockAtSalesArea, global::System.Boolean bLK_CentralDeletionFlagMasterRecord, global::System.Boolean bLK_DeletionFlagMasterRecordCC, global::System.Boolean bLK_DeletionFlagMasterRecordSA, global::System.Boolean bLK_CentralDeletionBlockMasterRecord, global::System.Boolean bLK_DeletionBlockMasterRecordCC )
        {
            MDMC_RequestsSAP mDMC_RequestsSAP = new MDMC_RequestsSAP ();
            mDMC_RequestsSAP.RequestID = requestID;
            mDMC_RequestsSAP.TS_IsUrgentRequest = tS_IsUrgentRequest;
            mDMC_RequestsSAP.GD_Ctr_IsNaturalPerson = gD_Ctr_IsNaturalPerson;
            mDMC_RequestsSAP.GD_Ctr_TaxCode1_HighRisk = gD_Ctr_TaxCode1_HighRisk;
            mDMC_RequestsSAP.GD_Ctr_TaxCode1_Gov = gD_Ctr_TaxCode1_Gov;
            mDMC_RequestsSAP.GD_Ctr_TaxCode1_NP = gD_Ctr_TaxCode1_NP;
            mDMC_RequestsSAP.GD_Ctr_SalesPurTax = gD_Ctr_SalesPurTax;
            mDMC_RequestsSAP.BLK_CentralPostingBlock = bLK_CentralPostingBlock;
            mDMC_RequestsSAP.BLK_PostingBlockForCC = bLK_PostingBlockForCC;
            mDMC_RequestsSAP.BLK_CentralSalesSupportBlock = bLK_CentralSalesSupportBlock;
            mDMC_RequestsSAP.BLK_CentralSalesSupportBlockAtSalesArea = bLK_CentralSalesSupportBlockAtSalesArea;
            mDMC_RequestsSAP.BLK_CentralDeletionFlagMasterRecord = bLK_CentralDeletionFlagMasterRecord;
            mDMC_RequestsSAP.BLK_DeletionFlagMasterRecordCC = bLK_DeletionFlagMasterRecordCC;
            mDMC_RequestsSAP.BLK_DeletionFlagMasterRecordSA = bLK_DeletionFlagMasterRecordSA;
            mDMC_RequestsSAP.BLK_CentralDeletionBlockMasterRecord = bLK_CentralDeletionBlockMasterRecord;
            mDMC_RequestsSAP.BLK_DeletionBlockMasterRecordCC = bLK_DeletionBlockMasterRecordCC;
            return mDMC_RequestsSAP;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = true, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.String RequestID
        {
            get
            {
                return _RequestID;
            }
            set
            {
                if ( _RequestID != value )
                {
                    OnRequestIDChanging ( value );
                    ReportPropertyChanging ( "RequestID" );
                    _RequestID = StructuralObject.SetValidValue ( value, false );
                    ReportPropertyChanged ( "RequestID" );
                    OnRequestIDChanged ();
                }
            }
        }
        private global::System.String _RequestID;
        partial void OnRequestIDChanging ( global::System.String value );
        partial void OnRequestIDChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean TS_IsUrgentRequest
        {
            get
            {
                return _TS_IsUrgentRequest;
            }
            set
            {
                OnTS_IsUrgentRequestChanging ( value );
                ReportPropertyChanging ( "TS_IsUrgentRequest" );
                _TS_IsUrgentRequest = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "TS_IsUrgentRequest" );
                OnTS_IsUrgentRequestChanged ();
            }
        }
        private global::System.Boolean _TS_IsUrgentRequest;
        partial void OnTS_IsUrgentRequestChanging ( global::System.Boolean value );
        partial void OnTS_IsUrgentRequestChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String OperationType
        {
            get
            {
                return _OperationType;
            }
            set
            {
                OnOperationTypeChanging ( value );
                ReportPropertyChanging ( "OperationType" );
                _OperationType = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "OperationType" );
                OnOperationTypeChanged ();
            }
        }
        private global::System.String _OperationType;
        partial void OnOperationTypeChanging ( global::System.String value );
        partial void OnOperationTypeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterCountryCode
        {
            get
            {
                return _ClusterCountryCode;
            }
            set
            {
                OnClusterCountryCodeChanging ( value );
                ReportPropertyChanging ( "ClusterCountryCode" );
                _ClusterCountryCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterCountryCode" );
                OnClusterCountryCodeChanged ();
            }
        }
        private global::System.String _ClusterCountryCode;
        partial void OnClusterCountryCodeChanging ( global::System.String value );
        partial void OnClusterCountryCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterCompanyCode
        {
            get
            {
                return _ClusterCompanyCode;
            }
            set
            {
                OnClusterCompanyCodeChanging ( value );
                ReportPropertyChanging ( "ClusterCompanyCode" );
                _ClusterCompanyCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterCompanyCode" );
                OnClusterCompanyCodeChanged ();
            }
        }
        private global::System.String _ClusterCompanyCode;
        partial void OnClusterCompanyCodeChanging ( global::System.String value );
        partial void OnClusterCompanyCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterPOCode
        {
            get
            {
                return _ClusterPOCode;
            }
            set
            {
                OnClusterPOCodeChanging ( value );
                ReportPropertyChanging ( "ClusterPOCode" );
                _ClusterPOCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterPOCode" );
                OnClusterPOCodeChanged ();
            }
        }
        private global::System.String _ClusterPOCode;
        partial void OnClusterPOCodeChanging ( global::System.String value );
        partial void OnClusterPOCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_RiskClassification
        {
            get
            {
                return _GD_Ctr_RiskClassification;
            }
            set
            {
                OnGD_Ctr_RiskClassificationChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_RiskClassification" );
                _GD_Ctr_RiskClassification = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_RiskClassification" );
                OnGD_Ctr_RiskClassificationChanged ();
            }
        }
        private global::System.String _GD_Ctr_RiskClassification;
        partial void OnGD_Ctr_RiskClassificationChanging ( global::System.String value );
        partial void OnGD_Ctr_RiskClassificationChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_IsNaturalPerson
        {
            get
            {
                return _GD_Ctr_IsNaturalPerson;
            }
            set
            {
                OnGD_Ctr_IsNaturalPersonChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_IsNaturalPerson" );
                _GD_Ctr_IsNaturalPerson = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_IsNaturalPerson" );
                OnGD_Ctr_IsNaturalPersonChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_IsNaturalPerson;
        partial void OnGD_Ctr_IsNaturalPersonChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_IsNaturalPersonChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name
        {
            get
            {
                return _GD_Adr_Name;
            }
            set
            {
                OnGD_Adr_NameChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Name" );
                _GD_Adr_Name = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name" );
                OnGD_Adr_NameChanged ();
            }
        }
        private global::System.String _GD_Adr_Name;
        partial void OnGD_Adr_NameChanging ( global::System.String value );
        partial void OnGD_Adr_NameChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name2
        {
            get
            {
                return _GD_Adr_Name2;
            }
            set
            {
                OnGD_Adr_Name2Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Name2" );
                _GD_Adr_Name2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name2" );
                OnGD_Adr_Name2Changed ();
            }
        }
        private global::System.String _GD_Adr_Name2;
        partial void OnGD_Adr_Name2Changing ( global::System.String value );
        partial void OnGD_Adr_Name2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name3
        {
            get
            {
                return _GD_Adr_Name3;
            }
            set
            {
                OnGD_Adr_Name3Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Name3" );
                _GD_Adr_Name3 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name3" );
                OnGD_Adr_Name3Changed ();
            }
        }
        private global::System.String _GD_Adr_Name3;
        partial void OnGD_Adr_Name3Changing ( global::System.String value );
        partial void OnGD_Adr_Name3Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Name4
        {
            get
            {
                return _GD_Adr_Name4;
            }
            set
            {
                OnGD_Adr_Name4Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Name4" );
                _GD_Adr_Name4 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Name4" );
                OnGD_Adr_Name4Changed ();
            }
        }
        private global::System.String _GD_Adr_Name4;
        partial void OnGD_Adr_Name4Changing ( global::System.String value );
        partial void OnGD_Adr_Name4Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Search
        {
            get
            {
                return _GD_Adr_Search;
            }
            set
            {
                OnGD_Adr_SearchChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Search" );
                _GD_Adr_Search = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Search" );
                OnGD_Adr_SearchChanged ();
            }
        }
        private global::System.String _GD_Adr_Search;
        partial void OnGD_Adr_SearchChanging ( global::System.String value );
        partial void OnGD_Adr_SearchChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street
        {
            get
            {
                return _GD_Adr_Street;
            }
            set
            {
                OnGD_Adr_StreetChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Street" );
                _GD_Adr_Street = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street" );
                OnGD_Adr_StreetChanged ();
            }
        }
        private global::System.String _GD_Adr_Street;
        partial void OnGD_Adr_StreetChanging ( global::System.String value );
        partial void OnGD_Adr_StreetChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street2
        {
            get
            {
                return _GD_Adr_Street2;
            }
            set
            {
                OnGD_Adr_Street2Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street2" );
                _GD_Adr_Street2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street2" );
                OnGD_Adr_Street2Changed ();
            }
        }
        private global::System.String _GD_Adr_Street2;
        partial void OnGD_Adr_Street2Changing ( global::System.String value );
        partial void OnGD_Adr_Street2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street3
        {
            get
            {
                return _GD_Adr_Street3;
            }
            set
            {
                OnGD_Adr_Street3Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street3" );
                _GD_Adr_Street3 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street3" );
                OnGD_Adr_Street3Changed ();
            }
        }
        private global::System.String _GD_Adr_Street3;
        partial void OnGD_Adr_Street3Changing ( global::System.String value );
        partial void OnGD_Adr_Street3Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street4
        {
            get
            {
                return _GD_Adr_Street4;
            }
            set
            {
                OnGD_Adr_Street4Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street4" );
                _GD_Adr_Street4 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street4" );
                OnGD_Adr_Street4Changed ();
            }
        }
        private global::System.String _GD_Adr_Street4;
        partial void OnGD_Adr_Street4Changing ( global::System.String value );
        partial void OnGD_Adr_Street4Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Street5
        {
            get
            {
                return _GD_Adr_Street5;
            }
            set
            {
                OnGD_Adr_Street5Changing ( value );
                ReportPropertyChanging ( "GD_Adr_Street5" );
                _GD_Adr_Street5 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Street5" );
                OnGD_Adr_Street5Changed ();
            }
        }
        private global::System.String _GD_Adr_Street5;
        partial void OnGD_Adr_Street5Changing ( global::System.String value );
        partial void OnGD_Adr_Street5Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_PostalCode
        {
            get
            {
                return _GD_Adr_PostalCode;
            }
            set
            {
                OnGD_Adr_PostalCodeChanging ( value );
                ReportPropertyChanging ( "GD_Adr_PostalCode" );
                _GD_Adr_PostalCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_PostalCode" );
                OnGD_Adr_PostalCodeChanged ();
            }
        }
        private global::System.String _GD_Adr_PostalCode;
        partial void OnGD_Adr_PostalCodeChanging ( global::System.String value );
        partial void OnGD_Adr_PostalCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_City
        {
            get
            {
                return _GD_Adr_City;
            }
            set
            {
                OnGD_Adr_CityChanging ( value );
                ReportPropertyChanging ( "GD_Adr_City" );
                _GD_Adr_City = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_City" );
                OnGD_Adr_CityChanged ();
            }
        }
        private global::System.String _GD_Adr_City;
        partial void OnGD_Adr_CityChanging ( global::System.String value );
        partial void OnGD_Adr_CityChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Country
        {
            get
            {
                return _GD_Adr_Country;
            }
            set
            {
                OnGD_Adr_CountryChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Country" );
                _GD_Adr_Country = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Country" );
                OnGD_Adr_CountryChanged ();
            }
        }
        private global::System.String _GD_Adr_Country;
        partial void OnGD_Adr_CountryChanging ( global::System.String value );
        partial void OnGD_Adr_CountryChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_Region
        {
            get
            {
                return _GD_Adr_Region;
            }
            set
            {
                OnGD_Adr_RegionChanging ( value );
                ReportPropertyChanging ( "GD_Adr_Region" );
                _GD_Adr_Region = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_Region" );
                OnGD_Adr_RegionChanged ();
            }
        }
        private global::System.String _GD_Adr_Region;
        partial void OnGD_Adr_RegionChanging ( global::System.String value );
        partial void OnGD_Adr_RegionChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_POBox
        {
            get
            {
                return _GD_Adr_POBox;
            }
            set
            {
                OnGD_Adr_POBoxChanging ( value );
                ReportPropertyChanging ( "GD_Adr_POBox" );
                _GD_Adr_POBox = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_POBox" );
                OnGD_Adr_POBoxChanged ();
            }
        }
        private global::System.String _GD_Adr_POBox;
        partial void OnGD_Adr_POBoxChanging ( global::System.String value );
        partial void OnGD_Adr_POBoxChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_POBoxPostalCode
        {
            get
            {
                return _GD_Adr_POBoxPostalCode;
            }
            set
            {
                OnGD_Adr_POBoxPostalCodeChanging ( value );
                ReportPropertyChanging ( "GD_Adr_POBoxPostalCode" );
                _GD_Adr_POBoxPostalCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_POBoxPostalCode" );
                OnGD_Adr_POBoxPostalCodeChanged ();
            }
        }
        private global::System.String _GD_Adr_POBoxPostalCode;
        partial void OnGD_Adr_POBoxPostalCodeChanging ( global::System.String value );
        partial void OnGD_Adr_POBoxPostalCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_LanguageCode
        {
            get
            {
                return _GD_Com_LanguageCode;
            }
            set
            {
                OnGD_Com_LanguageCodeChanging ( value );
                ReportPropertyChanging ( "GD_Com_LanguageCode" );
                _GD_Com_LanguageCode = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_LanguageCode" );
                OnGD_Com_LanguageCodeChanged ();
            }
        }
        private global::System.String _GD_Com_LanguageCode;
        partial void OnGD_Com_LanguageCodeChanging ( global::System.String value );
        partial void OnGD_Com_LanguageCodeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_Telephone
        {
            get
            {
                return _GD_Com_Telephone;
            }
            set
            {
                OnGD_Com_TelephoneChanging ( value );
                ReportPropertyChanging ( "GD_Com_Telephone" );
                _GD_Com_Telephone = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_Telephone" );
                OnGD_Com_TelephoneChanged ();
            }
        }
        private global::System.String _GD_Com_Telephone;
        partial void OnGD_Com_TelephoneChanging ( global::System.String value );
        partial void OnGD_Com_TelephoneChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_FaxNumber
        {
            get
            {
                return _GD_Com_FaxNumber;
            }
            set
            {
                OnGD_Com_FaxNumberChanging ( value );
                ReportPropertyChanging ( "GD_Com_FaxNumber" );
                _GD_Com_FaxNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_FaxNumber" );
                OnGD_Com_FaxNumberChanged ();
            }
        }
        private global::System.String _GD_Com_FaxNumber;
        partial void OnGD_Com_FaxNumberChanging ( global::System.String value );
        partial void OnGD_Com_FaxNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_EmailAddress
        {
            get
            {
                return _GD_Com_EmailAddress;
            }
            set
            {
                OnGD_Com_EmailAddressChanging ( value );
                ReportPropertyChanging ( "GD_Com_EmailAddress" );
                _GD_Com_EmailAddress = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_EmailAddress" );
                OnGD_Com_EmailAddressChanged ();
            }
        }
        private global::System.String _GD_Com_EmailAddress;
        partial void OnGD_Com_EmailAddressChanging ( global::System.String value );
        partial void OnGD_Com_EmailAddressChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_Telebox
        {
            get
            {
                return _GD_Com_Telebox;
            }
            set
            {
                OnGD_Com_TeleboxChanging ( value );
                ReportPropertyChanging ( "GD_Com_Telebox" );
                _GD_Com_Telebox = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_Telebox" );
                OnGD_Com_TeleboxChanged ();
            }
        }
        private global::System.String _GD_Com_Telebox;
        partial void OnGD_Com_TeleboxChanging ( global::System.String value );
        partial void OnGD_Com_TeleboxChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_URL
        {
            get
            {
                return _GD_Com_URL;
            }
            set
            {
                OnGD_Com_URLChanging ( value );
                ReportPropertyChanging ( "GD_Com_URL" );
                _GD_Com_URL = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_URL" );
                OnGD_Com_URLChanged ();
            }
        }
        private global::System.String _GD_Com_URL;
        partial void OnGD_Com_URLChanging ( global::System.String value );
        partial void OnGD_Com_URLChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_DataLine
        {
            get
            {
                return _GD_Com_DataLine;
            }
            set
            {
                OnGD_Com_DataLineChanging ( value );
                ReportPropertyChanging ( "GD_Com_DataLine" );
                _GD_Com_DataLine = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_DataLine" );
                OnGD_Com_DataLineChanged ();
            }
        }
        private global::System.String _GD_Com_DataLine;
        partial void OnGD_Com_DataLineChanging ( global::System.String value );
        partial void OnGD_Com_DataLineChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_Comment
        {
            get
            {
                return _GD_Com_Comment;
            }
            set
            {
                OnGD_Com_CommentChanging ( value );
                ReportPropertyChanging ( "GD_Com_Comment" );
                _GD_Com_Comment = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_Comment" );
                OnGD_Com_CommentChanged ();
            }
        }
        private global::System.String _GD_Com_Comment;
        partial void OnGD_Com_CommentChanging ( global::System.String value );
        partial void OnGD_Com_CommentChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_Title
        {
            get
            {
                return _GD_NatP_Title;
            }
            set
            {
                OnGD_NatP_TitleChanging ( value );
                ReportPropertyChanging ( "GD_NatP_Title" );
                _GD_NatP_Title = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_Title" );
                OnGD_NatP_TitleChanged ();
            }
        }
        private global::System.String _GD_NatP_Title;
        partial void OnGD_NatP_TitleChanging ( global::System.String value );
        partial void OnGD_NatP_TitleChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.DateTime> GD_NatP_DateOfBirth
        {
            get
            {
                return _GD_NatP_DateOfBirth;
            }
            set
            {
                OnGD_NatP_DateOfBirthChanging ( value );
                ReportPropertyChanging ( "GD_NatP_DateOfBirth" );
                _GD_NatP_DateOfBirth = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_NatP_DateOfBirth" );
                OnGD_NatP_DateOfBirthChanged ();
            }
        }
        private Nullable<global::System.DateTime> _GD_NatP_DateOfBirth;
        partial void OnGD_NatP_DateOfBirthChanging ( Nullable<global::System.DateTime> value );
        partial void OnGD_NatP_DateOfBirthChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_PlaceOfBirth
        {
            get
            {
                return _GD_NatP_PlaceOfBirth;
            }
            set
            {
                OnGD_NatP_PlaceOfBirthChanging ( value );
                ReportPropertyChanging ( "GD_NatP_PlaceOfBirth" );
                _GD_NatP_PlaceOfBirth = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_PlaceOfBirth" );
                OnGD_NatP_PlaceOfBirthChanged ();
            }
        }
        private global::System.String _GD_NatP_PlaceOfBirth;
        partial void OnGD_NatP_PlaceOfBirthChanging ( global::System.String value );
        partial void OnGD_NatP_PlaceOfBirthChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_Profession
        {
            get
            {
                return _GD_NatP_Profession;
            }
            set
            {
                OnGD_NatP_ProfessionChanging ( value );
                ReportPropertyChanging ( "GD_NatP_Profession" );
                _GD_NatP_Profession = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_Profession" );
                OnGD_NatP_ProfessionChanged ();
            }
        }
        private global::System.String _GD_NatP_Profession;
        partial void OnGD_NatP_ProfessionChanging ( global::System.String value );
        partial void OnGD_NatP_ProfessionChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_NatP_Sex
        {
            get
            {
                return _GD_NatP_Sex;
            }
            set
            {
                OnGD_NatP_SexChanging ( value );
                ReportPropertyChanging ( "GD_NatP_Sex" );
                _GD_NatP_Sex = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_NatP_Sex" );
                OnGD_NatP_SexChanged ();
            }
        }
        private global::System.String _GD_NatP_Sex;
        partial void OnGD_NatP_SexChanging ( global::System.String value );
        partial void OnGD_NatP_SexChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_CustomerNumber
        {
            get
            {
                return _GD_Ctr_CustomerNumber;
            }
            set
            {
                OnGD_Ctr_CustomerNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_CustomerNumber" );
                _GD_Ctr_CustomerNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_CustomerNumber" );
                OnGD_Ctr_CustomerNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_CustomerNumber;
        partial void OnGD_Ctr_CustomerNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_CustomerNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_Industry
        {
            get
            {
                return _GD_Ctr_Industry;
            }
            set
            {
                OnGD_Ctr_IndustryChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_Industry" );
                _GD_Ctr_Industry = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_Industry" );
                OnGD_Ctr_IndustryChanged ();
            }
        }
        private global::System.String _GD_Ctr_Industry;
        partial void OnGD_Ctr_IndustryChanging ( global::System.String value );
        partial void OnGD_Ctr_IndustryChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxCode_IT_CF
        {
            get
            {
                return _GD_Ctr_TaxCode_IT_CF;
            }
            set
            {
                OnGD_Ctr_TaxCode_IT_CFChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode_IT_CF" );
                _GD_Ctr_TaxCode_IT_CF = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxCode_IT_CF" );
                OnGD_Ctr_TaxCode_IT_CFChanged ();
            }
        }
        private global::System.String _GD_Ctr_TaxCode_IT_CF;
        partial void OnGD_Ctr_TaxCode_IT_CFChanging ( global::System.String value );
        partial void OnGD_Ctr_TaxCode_IT_CFChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxCode_IT_PIva
        {
            get
            {
                return _GD_Ctr_TaxCode_IT_PIva;
            }
            set
            {
                OnGD_Ctr_TaxCode_IT_PIvaChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode_IT_PIva" );
                _GD_Ctr_TaxCode_IT_PIva = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxCode_IT_PIva" );
                OnGD_Ctr_TaxCode_IT_PIvaChanged ();
            }
        }
        private global::System.String _GD_Ctr_TaxCode_IT_PIva;
        partial void OnGD_Ctr_TaxCode_IT_PIvaChanging ( global::System.String value );
        partial void OnGD_Ctr_TaxCode_IT_PIvaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxCode_PT_NIF
        {
            get
            {
                return _GD_Ctr_TaxCode_PT_NIF;
            }
            set
            {
                OnGD_Ctr_TaxCode_PT_NIFChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode_PT_NIF" );
                _GD_Ctr_TaxCode_PT_NIF = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxCode_PT_NIF" );
                OnGD_Ctr_TaxCode_PT_NIFChanged ();
            }
        }
        private global::System.String _GD_Ctr_TaxCode_PT_NIF;
        partial void OnGD_Ctr_TaxCode_PT_NIFChanging ( global::System.String value );
        partial void OnGD_Ctr_TaxCode_PT_NIFChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxCode1
        {
            get
            {
                return _GD_Ctr_TaxCode1;
            }
            set
            {
                OnGD_Ctr_TaxCode1Changing ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1" );
                _GD_Ctr_TaxCode1 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1" );
                OnGD_Ctr_TaxCode1Changed ();
            }
        }
        private global::System.String _GD_Ctr_TaxCode1;
        partial void OnGD_Ctr_TaxCode1Changing ( global::System.String value );
        partial void OnGD_Ctr_TaxCode1Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_TaxCode1_HighRisk
        {
            get
            {
                return _GD_Ctr_TaxCode1_HighRisk;
            }
            set
            {
                OnGD_Ctr_TaxCode1_HighRiskChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1_HighRisk" );
                _GD_Ctr_TaxCode1_HighRisk = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1_HighRisk" );
                OnGD_Ctr_TaxCode1_HighRiskChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_TaxCode1_HighRisk;
        partial void OnGD_Ctr_TaxCode1_HighRiskChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_TaxCode1_HighRiskChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_TaxCode1_Gov
        {
            get
            {
                return _GD_Ctr_TaxCode1_Gov;
            }
            set
            {
                OnGD_Ctr_TaxCode1_GovChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1_Gov" );
                _GD_Ctr_TaxCode1_Gov = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1_Gov" );
                OnGD_Ctr_TaxCode1_GovChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_TaxCode1_Gov;
        partial void OnGD_Ctr_TaxCode1_GovChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_TaxCode1_GovChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_TaxCode1_NP
        {
            get
            {
                return _GD_Ctr_TaxCode1_NP;
            }
            set
            {
                OnGD_Ctr_TaxCode1_NPChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode1_NP" );
                _GD_Ctr_TaxCode1_NP = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_TaxCode1_NP" );
                OnGD_Ctr_TaxCode1_NPChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_TaxCode1_NP;
        partial void OnGD_Ctr_TaxCode1_NPChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_TaxCode1_NPChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxCode2
        {
            get
            {
                return _GD_Ctr_TaxCode2;
            }
            set
            {
                OnGD_Ctr_TaxCode2Changing ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxCode2" );
                _GD_Ctr_TaxCode2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxCode2" );
                OnGD_Ctr_TaxCode2Changed ();
            }
        }
        private global::System.String _GD_Ctr_TaxCode2;
        partial void OnGD_Ctr_TaxCode2Changing ( global::System.String value );
        partial void OnGD_Ctr_TaxCode2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_VATRegistrationNumber
        {
            get
            {
                return _GD_Ctr_VATRegistrationNumber;
            }
            set
            {
                OnGD_Ctr_VATRegistrationNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_VATRegistrationNumber" );
                _GD_Ctr_VATRegistrationNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_VATRegistrationNumber" );
                OnGD_Ctr_VATRegistrationNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_VATRegistrationNumber;
        partial void OnGD_Ctr_VATRegistrationNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_VATRegistrationNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean GD_Ctr_SalesPurTax
        {
            get
            {
                return _GD_Ctr_SalesPurTax;
            }
            set
            {
                OnGD_Ctr_SalesPurTaxChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_SalesPurTax" );
                _GD_Ctr_SalesPurTax = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Ctr_SalesPurTax" );
                OnGD_Ctr_SalesPurTaxChanged ();
            }
        }
        private global::System.Boolean _GD_Ctr_SalesPurTax;
        partial void OnGD_Ctr_SalesPurTaxChanging ( global::System.Boolean value );
        partial void OnGD_Ctr_SalesPurTaxChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_RepresentiveName
        {
            get
            {
                return _GD_Ctr_RepresentiveName;
            }
            set
            {
                OnGD_Ctr_RepresentiveNameChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_RepresentiveName" );
                _GD_Ctr_RepresentiveName = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_RepresentiveName" );
                OnGD_Ctr_RepresentiveNameChanged ();
            }
        }
        private global::System.String _GD_Ctr_RepresentiveName;
        partial void OnGD_Ctr_RepresentiveNameChanging ( global::System.String value );
        partial void OnGD_Ctr_RepresentiveNameChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_TaxNumber
        {
            get
            {
                return _GD_Ctr_TaxNumber;
            }
            set
            {
                OnGD_Ctr_TaxNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_TaxNumber" );
                _GD_Ctr_TaxNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_TaxNumber" );
                OnGD_Ctr_TaxNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_TaxNumber;
        partial void OnGD_Ctr_TaxNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_TaxNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_CreditInfoNo
        {
            get
            {
                return _GD_Ctr_CreditInfoNo;
            }
            set
            {
                OnGD_Ctr_CreditInfoNoChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_CreditInfoNo" );
                _GD_Ctr_CreditInfoNo = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_CreditInfoNo" );
                OnGD_Ctr_CreditInfoNoChanged ();
            }
        }
        private global::System.String _GD_Ctr_CreditInfoNo;
        partial void OnGD_Ctr_CreditInfoNoChanging ( global::System.String value );
        partial void OnGD_Ctr_CreditInfoNoChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_ActualQMSystem
        {
            get
            {
                return _GD_Ctr_ActualQMSystem;
            }
            set
            {
                OnGD_Ctr_ActualQMSystemChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_ActualQMSystem" );
                _GD_Ctr_ActualQMSystem = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_ActualQMSystem" );
                OnGD_Ctr_ActualQMSystemChanged ();
            }
        }
        private global::System.String _GD_Ctr_ActualQMSystem;
        partial void OnGD_Ctr_ActualQMSystemChanging ( global::System.String value );
        partial void OnGD_Ctr_ActualQMSystemChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_LastExtReview
        {
            get
            {
                return _GD_Ctr_LastExtReview;
            }
            set
            {
                OnGD_Ctr_LastExtReviewChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_LastExtReview" );
                _GD_Ctr_LastExtReview = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_LastExtReview" );
                OnGD_Ctr_LastExtReviewChanged ();
            }
        }
        private global::System.String _GD_Ctr_LastExtReview;
        partial void OnGD_Ctr_LastExtReviewChanging ( global::System.String value );
        partial void OnGD_Ctr_LastExtReviewChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_QMSystemTo
        {
            get
            {
                return _GD_Ctr_QMSystemTo;
            }
            set
            {
                OnGD_Ctr_QMSystemToChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_QMSystemTo" );
                _GD_Ctr_QMSystemTo = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_QMSystemTo" );
                OnGD_Ctr_QMSystemToChanged ();
            }
        }
        private global::System.String _GD_Ctr_QMSystemTo;
        partial void OnGD_Ctr_QMSystemToChanging ( global::System.String value );
        partial void OnGD_Ctr_QMSystemToChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_AccountGroup
        {
            get
            {
                return _GD_Ctr_AccountGroup;
            }
            set
            {
                OnGD_Ctr_AccountGroupChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_AccountGroup" );
                _GD_Ctr_AccountGroup = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_AccountGroup" );
                OnGD_Ctr_AccountGroupChanged ();
            }
        }
        private global::System.String _GD_Ctr_AccountGroup;
        partial void OnGD_Ctr_AccountGroupChanging ( global::System.String value );
        partial void OnGD_Ctr_AccountGroupChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_IFANumber
        {
            get
            {
                return _GD_Ctr_IFANumber;
            }
            set
            {
                OnGD_Ctr_IFANumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_IFANumber" );
                _GD_Ctr_IFANumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_IFANumber" );
                OnGD_Ctr_IFANumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_IFANumber;
        partial void OnGD_Ctr_IFANumberChanging ( global::System.String value );
        partial void OnGD_Ctr_IFANumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String SUS_UserAccount
        {
            get
            {
                return _SUS_UserAccount;
            }
            set
            {
                OnSUS_UserAccountChanging ( value );
                ReportPropertyChanging ( "SUS_UserAccount" );
                _SUS_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "SUS_UserAccount" );
                OnSUS_UserAccountChanged ();
            }
        }
        private global::System.String _SUS_UserAccount;
        partial void OnSUS_UserAccountChanging ( global::System.String value );
        partial void OnSUS_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String RCO_UserAccount
        {
            get
            {
                return _RCO_UserAccount;
            }
            set
            {
                OnRCO_UserAccountChanging ( value );
                ReportPropertyChanging ( "RCO_UserAccount" );
                _RCO_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "RCO_UserAccount" );
                OnRCO_UserAccountChanged ();
            }
        }
        private global::System.String _RCO_UserAccount;
        partial void OnRCO_UserAccountChanging ( global::System.String value );
        partial void OnRCO_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String CLERK_UserAccount
        {
            get
            {
                return _CLERK_UserAccount;
            }
            set
            {
                OnCLERK_UserAccountChanging ( value );
                ReportPropertyChanging ( "CLERK_UserAccount" );
                _CLERK_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "CLERK_UserAccount" );
                OnCLERK_UserAccountChanged ();
            }
        }
        private global::System.String _CLERK_UserAccount;
        partial void OnCLERK_UserAccountChanging ( global::System.String value );
        partial void OnCLERK_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String RequestType
        {
            get
            {
                return _RequestType;
            }
            set
            {
                OnRequestTypeChanging ( value );
                ReportPropertyChanging ( "RequestType" );
                _RequestType = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "RequestType" );
                OnRequestTypeChanged ();
            }
        }
        private global::System.String _RequestType;
        partial void OnRequestTypeChanging ( global::System.String value );
        partial void OnRequestTypeChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ADRNR
        {
            get
            {
                return _ADRNR;
            }
            set
            {
                OnADRNRChanging ( value );
                ReportPropertyChanging ( "ADRNR" );
                _ADRNR = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ADRNR" );
                OnADRNRChanged ();
            }
        }
        private global::System.String _ADRNR;
        partial void OnADRNRChanging ( global::System.String value );
        partial void OnADRNRChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String SAP_Message
        {
            get
            {
                return _SAP_Message;
            }
            set
            {
                OnSAP_MessageChanging ( value );
                ReportPropertyChanging ( "SAP_Message" );
                _SAP_Message = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "SAP_Message" );
                OnSAP_MessageChanged ();
            }
        }
        private global::System.String _SAP_Message;
        partial void OnSAP_MessageChanging ( global::System.String value );
        partial void OnSAP_MessageChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralPostingBlock
        {
            get
            {
                return _BLK_CentralPostingBlock;
            }
            set
            {
                OnBLK_CentralPostingBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralPostingBlock" );
                _BLK_CentralPostingBlock = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralPostingBlock" );
                OnBLK_CentralPostingBlockChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralPostingBlock;
        partial void OnBLK_CentralPostingBlockChanging ( global::System.Boolean value );
        partial void OnBLK_CentralPostingBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_PostingBlockForCC
        {
            get
            {
                return _BLK_PostingBlockForCC;
            }
            set
            {
                OnBLK_PostingBlockForCCChanging ( value );
                ReportPropertyChanging ( "BLK_PostingBlockForCC" );
                _BLK_PostingBlockForCC = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_PostingBlockForCC" );
                OnBLK_PostingBlockForCCChanged ();
            }
        }
        private global::System.Boolean _BLK_PostingBlockForCC;
        partial void OnBLK_PostingBlockForCCChanging ( global::System.Boolean value );
        partial void OnBLK_PostingBlockForCCChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_CentralSalesOrderBlock
        {
            get
            {
                return _BLK_CentralSalesOrderBlock;
            }
            set
            {
                OnBLK_CentralSalesOrderBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralSalesOrderBlock" );
                _BLK_CentralSalesOrderBlock = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_CentralSalesOrderBlock" );
                OnBLK_CentralSalesOrderBlockChanged ();
            }
        }
        private global::System.String _BLK_CentralSalesOrderBlock;
        partial void OnBLK_CentralSalesOrderBlockChanging ( global::System.String value );
        partial void OnBLK_CentralSalesOrderBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_OrdersBlockAtSalesArea
        {
            get
            {
                return _BLK_OrdersBlockAtSalesArea;
            }
            set
            {
                OnBLK_OrdersBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_OrdersBlockAtSalesArea" );
                _BLK_OrdersBlockAtSalesArea = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_OrdersBlockAtSalesArea" );
                OnBLK_OrdersBlockAtSalesAreaChanged ();
            }
        }
        private global::System.String _BLK_OrdersBlockAtSalesArea;
        partial void OnBLK_OrdersBlockAtSalesAreaChanging ( global::System.String value );
        partial void OnBLK_OrdersBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_CentralDeliveriesBlock
        {
            get
            {
                return _BLK_CentralDeliveriesBlock;
            }
            set
            {
                OnBLK_CentralDeliveriesBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralDeliveriesBlock" );
                _BLK_CentralDeliveriesBlock = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_CentralDeliveriesBlock" );
                OnBLK_CentralDeliveriesBlockChanged ();
            }
        }
        private global::System.String _BLK_CentralDeliveriesBlock;
        partial void OnBLK_CentralDeliveriesBlockChanging ( global::System.String value );
        partial void OnBLK_CentralDeliveriesBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_DeliveriesBlockAtSalesArea
        {
            get
            {
                return _BLK_DeliveriesBlockAtSalesArea;
            }
            set
            {
                OnBLK_DeliveriesBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_DeliveriesBlockAtSalesArea" );
                _BLK_DeliveriesBlockAtSalesArea = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_DeliveriesBlockAtSalesArea" );
                OnBLK_DeliveriesBlockAtSalesAreaChanged ();
            }
        }
        private global::System.String _BLK_DeliveriesBlockAtSalesArea;
        partial void OnBLK_DeliveriesBlockAtSalesAreaChanging ( global::System.String value );
        partial void OnBLK_DeliveriesBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_CentralBillingBlock
        {
            get
            {
                return _BLK_CentralBillingBlock;
            }
            set
            {
                OnBLK_CentralBillingBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralBillingBlock" );
                _BLK_CentralBillingBlock = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_CentralBillingBlock" );
                OnBLK_CentralBillingBlockChanged ();
            }
        }
        private global::System.String _BLK_CentralBillingBlock;
        partial void OnBLK_CentralBillingBlockChanging ( global::System.String value );
        partial void OnBLK_CentralBillingBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String BLK_BillingBlockAtSalesArea
        {
            get
            {
                return _BLK_BillingBlockAtSalesArea;
            }
            set
            {
                OnBLK_BillingBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_BillingBlockAtSalesArea" );
                _BLK_BillingBlockAtSalesArea = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "BLK_BillingBlockAtSalesArea" );
                OnBLK_BillingBlockAtSalesAreaChanged ();
            }
        }
        private global::System.String _BLK_BillingBlockAtSalesArea;
        partial void OnBLK_BillingBlockAtSalesAreaChanging ( global::System.String value );
        partial void OnBLK_BillingBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralSalesSupportBlock
        {
            get
            {
                return _BLK_CentralSalesSupportBlock;
            }
            set
            {
                OnBLK_CentralSalesSupportBlockChanging ( value );
                ReportPropertyChanging ( "BLK_CentralSalesSupportBlock" );
                _BLK_CentralSalesSupportBlock = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralSalesSupportBlock" );
                OnBLK_CentralSalesSupportBlockChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralSalesSupportBlock;
        partial void OnBLK_CentralSalesSupportBlockChanging ( global::System.Boolean value );
        partial void OnBLK_CentralSalesSupportBlockChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralSalesSupportBlockAtSalesArea
        {
            get
            {
                return _BLK_CentralSalesSupportBlockAtSalesArea;
            }
            set
            {
                OnBLK_CentralSalesSupportBlockAtSalesAreaChanging ( value );
                ReportPropertyChanging ( "BLK_CentralSalesSupportBlockAtSalesArea" );
                _BLK_CentralSalesSupportBlockAtSalesArea = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralSalesSupportBlockAtSalesArea" );
                OnBLK_CentralSalesSupportBlockAtSalesAreaChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralSalesSupportBlockAtSalesArea;
        partial void OnBLK_CentralSalesSupportBlockAtSalesAreaChanging ( global::System.Boolean value );
        partial void OnBLK_CentralSalesSupportBlockAtSalesAreaChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralDeletionFlagMasterRecord
        {
            get
            {
                return _BLK_CentralDeletionFlagMasterRecord;
            }
            set
            {
                OnBLK_CentralDeletionFlagMasterRecordChanging ( value );
                ReportPropertyChanging ( "BLK_CentralDeletionFlagMasterRecord" );
                _BLK_CentralDeletionFlagMasterRecord = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralDeletionFlagMasterRecord" );
                OnBLK_CentralDeletionFlagMasterRecordChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralDeletionFlagMasterRecord;
        partial void OnBLK_CentralDeletionFlagMasterRecordChanging ( global::System.Boolean value );
        partial void OnBLK_CentralDeletionFlagMasterRecordChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_DeletionFlagMasterRecordCC
        {
            get
            {
                return _BLK_DeletionFlagMasterRecordCC;
            }
            set
            {
                OnBLK_DeletionFlagMasterRecordCCChanging ( value );
                ReportPropertyChanging ( "BLK_DeletionFlagMasterRecordCC" );
                _BLK_DeletionFlagMasterRecordCC = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_DeletionFlagMasterRecordCC" );
                OnBLK_DeletionFlagMasterRecordCCChanged ();
            }
        }
        private global::System.Boolean _BLK_DeletionFlagMasterRecordCC;
        partial void OnBLK_DeletionFlagMasterRecordCCChanging ( global::System.Boolean value );
        partial void OnBLK_DeletionFlagMasterRecordCCChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_DeletionFlagMasterRecordSA
        {
            get
            {
                return _BLK_DeletionFlagMasterRecordSA;
            }
            set
            {
                OnBLK_DeletionFlagMasterRecordSAChanging ( value );
                ReportPropertyChanging ( "BLK_DeletionFlagMasterRecordSA" );
                _BLK_DeletionFlagMasterRecordSA = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_DeletionFlagMasterRecordSA" );
                OnBLK_DeletionFlagMasterRecordSAChanged ();
            }
        }
        private global::System.Boolean _BLK_DeletionFlagMasterRecordSA;
        partial void OnBLK_DeletionFlagMasterRecordSAChanging ( global::System.Boolean value );
        partial void OnBLK_DeletionFlagMasterRecordSAChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_CentralDeletionBlockMasterRecord
        {
            get
            {
                return _BLK_CentralDeletionBlockMasterRecord;
            }
            set
            {
                OnBLK_CentralDeletionBlockMasterRecordChanging ( value );
                ReportPropertyChanging ( "BLK_CentralDeletionBlockMasterRecord" );
                _BLK_CentralDeletionBlockMasterRecord = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_CentralDeletionBlockMasterRecord" );
                OnBLK_CentralDeletionBlockMasterRecordChanged ();
            }
        }
        private global::System.Boolean _BLK_CentralDeletionBlockMasterRecord;
        partial void OnBLK_CentralDeletionBlockMasterRecordChanging ( global::System.Boolean value );
        partial void OnBLK_CentralDeletionBlockMasterRecordChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = false )]
        [DataMemberAttribute ()]
        public global::System.Boolean BLK_DeletionBlockMasterRecordCC
        {
            get
            {
                return _BLK_DeletionBlockMasterRecordCC;
            }
            set
            {
                OnBLK_DeletionBlockMasterRecordCCChanging ( value );
                ReportPropertyChanging ( "BLK_DeletionBlockMasterRecordCC" );
                _BLK_DeletionBlockMasterRecordCC = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "BLK_DeletionBlockMasterRecordCC" );
                OnBLK_DeletionBlockMasterRecordCCChanged ();
            }
        }
        private global::System.Boolean _BLK_DeletionBlockMasterRecordCC;
        partial void OnBLK_DeletionBlockMasterRecordCCChanging ( global::System.Boolean value );
        partial void OnBLK_DeletionBlockMasterRecordCCChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterDivision
        {
            get
            {
                return _ClusterDivision;
            }
            set
            {
                OnClusterDivisionChanging ( value );
                ReportPropertyChanging ( "ClusterDivision" );
                _ClusterDivision = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterDivision" );
                OnClusterDivisionChanged ();
            }
        }
        private global::System.String _ClusterDivision;
        partial void OnClusterDivisionChanging ( global::System.String value );
        partial void OnClusterDivisionChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String ClusterDistributionChannel
        {
            get
            {
                return _ClusterDistributionChannel;
            }
            set
            {
                OnClusterDistributionChannelChanging ( value );
                ReportPropertyChanging ( "ClusterDistributionChannel" );
                _ClusterDistributionChannel = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "ClusterDistributionChannel" );
                OnClusterDistributionChannelChanged ();
            }
        }
        private global::System.String _ClusterDistributionChannel;
        partial void OnClusterDistributionChannelChanging ( global::System.String value );
        partial void OnClusterDistributionChannelChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_CustomerClassification
        {
            get
            {
                return _GD_Ctr_CustomerClassification;
            }
            set
            {
                OnGD_Ctr_CustomerClassificationChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_CustomerClassification" );
                _GD_Ctr_CustomerClassification = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_CustomerClassification" );
                OnGD_Ctr_CustomerClassificationChanged ();
            }
        }
        private global::System.String _GD_Ctr_CustomerClassification;
        partial void OnGD_Ctr_CustomerClassificationChanging ( global::System.String value );
        partial void OnGD_Ctr_CustomerClassificationChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String CustomerNumber
        {
            get
            {
                return _CustomerNumber;
            }
            set
            {
                OnCustomerNumberChanging ( value );
                ReportPropertyChanging ( "CustomerNumber" );
                _CustomerNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "CustomerNumber" );
                OnCustomerNumberChanged ();
            }
        }
        private global::System.String _CustomerNumber;
        partial void OnCustomerNumberChanging ( global::System.String value );
        partial void OnCustomerNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_VendorNumber
        {
            get
            {
                return _GD_Ctr_VendorNumber;
            }
            set
            {
                OnGD_Ctr_VendorNumberChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_VendorNumber" );
                _GD_Ctr_VendorNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_VendorNumber" );
                OnGD_Ctr_VendorNumberChanged ();
            }
        }
        private global::System.String _GD_Ctr_VendorNumber;
        partial void OnGD_Ctr_VendorNumberChanging ( global::System.String value );
        partial void OnGD_Ctr_VendorNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Com_TransportZone
        {
            get
            {
                return _GD_Com_TransportZone;
            }
            set
            {
                OnGD_Com_TransportZoneChanging ( value );
                ReportPropertyChanging ( "GD_Com_TransportZone" );
                _GD_Com_TransportZone = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Com_TransportZone" );
                OnGD_Com_TransportZoneChanged ();
            }
        }
        private global::System.String _GD_Com_TransportZone;
        partial void OnGD_Com_TransportZoneChanging ( global::System.String value );
        partial void OnGD_Com_TransportZoneChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_SAPNumber
        {
            get
            {
                return _GD_SAPNumber;
            }
            set
            {
                OnGD_SAPNumberChanging ( value );
                ReportPropertyChanging ( "GD_SAPNumber" );
                _GD_SAPNumber = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_SAPNumber" );
                OnGD_SAPNumberChanged ();
            }
        }
        private global::System.String _GD_SAPNumber;
        partial void OnGD_SAPNumberChanging ( global::System.String value );
        partial void OnGD_SAPNumberChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_UnsubscribeCMD
        {
            get
            {
                return _GD_Ctr_UnsubscribeCMD;
            }
            set
            {
                OnGD_Ctr_UnsubscribeCMDChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_UnsubscribeCMD" );
                _GD_Ctr_UnsubscribeCMD = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_UnsubscribeCMD" );
                OnGD_Ctr_UnsubscribeCMDChanged ();
            }
        }
        private global::System.String _GD_Ctr_UnsubscribeCMD;
        partial void OnGD_Ctr_UnsubscribeCMDChanging ( global::System.String value );
        partial void OnGD_Ctr_UnsubscribeCMDChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_City2
        {
            get
            {
                return _GD_Adr_City2;
            }
            set
            {
                OnGD_Adr_City2Changing ( value );
                ReportPropertyChanging ( "GD_Adr_City2" );
                _GD_Adr_City2 = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_City2" );
                OnGD_Adr_City2Changed ();
            }
        }
        private global::System.String _GD_Adr_City2;
        partial void OnGD_Adr_City2Changing ( global::System.String value );
        partial void OnGD_Adr_City2Changed ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Ctr_GFORM
        {
            get
            {
                return _GD_Ctr_GFORM;
            }
            set
            {
                OnGD_Ctr_GFORMChanging ( value );
                ReportPropertyChanging ( "GD_Ctr_GFORM" );
                _GD_Ctr_GFORM = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Ctr_GFORM" );
                OnGD_Ctr_GFORMChanged ();
            }
        }
        private global::System.String _GD_Ctr_GFORM;
        partial void OnGD_Ctr_GFORMChanging ( global::System.String value );
        partial void OnGD_Ctr_GFORMChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String GD_Adr_POBoxLoc
        {
            get
            {
                return _GD_Adr_POBoxLoc;
            }
            set
            {
                OnGD_Adr_POBoxLocChanging ( value );
                ReportPropertyChanging ( "GD_Adr_POBoxLoc" );
                _GD_Adr_POBoxLoc = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "GD_Adr_POBoxLoc" );
                OnGD_Adr_POBoxLocChanged ();
            }
        }
        private global::System.String _GD_Adr_POBoxLoc;
        partial void OnGD_Adr_POBoxLocChanging ( global::System.String value );
        partial void OnGD_Adr_POBoxLocChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public global::System.String CL_RCO_UserAccount
        {
            get
            {
                return _CL_RCO_UserAccount;
            }
            set
            {
                OnCL_RCO_UserAccountChanging ( value );
                ReportPropertyChanging ( "CL_RCO_UserAccount" );
                _CL_RCO_UserAccount = StructuralObject.SetValidValue ( value, true );
                ReportPropertyChanged ( "CL_RCO_UserAccount" );
                OnCL_RCO_UserAccountChanged ();
            }
        }
        private global::System.String _CL_RCO_UserAccount;
        partial void OnCL_RCO_UserAccountChanging ( global::System.String value );
        partial void OnCL_RCO_UserAccountChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_MainlyMilitary
        {
            get
            {
                return _GD_MainlyMilitary;
            }
            set
            {
                OnGD_MainlyMilitaryChanging ( value );
                ReportPropertyChanging ( "GD_MainlyMilitary" );
                _GD_MainlyMilitary = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_MainlyMilitary" );
                OnGD_MainlyMilitaryChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_MainlyMilitary;
        partial void OnGD_MainlyMilitaryChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_MainlyMilitaryChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_MainlyCivilian
        {
            get
            {
                return _GD_MainlyCivilian;
            }
            set
            {
                OnGD_MainlyCivilianChanging ( value );
                ReportPropertyChanging ( "GD_MainlyCivilian" );
                _GD_MainlyCivilian = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_MainlyCivilian" );
                OnGD_MainlyCivilianChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_MainlyCivilian;
        partial void OnGD_MainlyCivilianChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_MainlyCivilianChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_Nuclear
        {
            get
            {
                return _GD_Nuclear;
            }
            set
            {
                OnGD_NuclearChanging ( value );
                ReportPropertyChanging ( "GD_Nuclear" );
                _GD_Nuclear = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Nuclear" );
                OnGD_NuclearChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_Nuclear;
        partial void OnGD_NuclearChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_NuclearChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_FreeZone
        {
            get
            {
                return _GD_FreeZone;
            }
            set
            {
                OnGD_FreeZoneChanging ( value );
                ReportPropertyChanging ( "GD_FreeZone" );
                _GD_FreeZone = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_FreeZone" );
                OnGD_FreeZoneChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_FreeZone;
        partial void OnGD_FreeZoneChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_FreeZoneChanged ();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute ( EntityKeyProperty = false, IsNullable = true )]
        [DataMemberAttribute ()]
        public Nullable<global::System.Boolean> GD_Embassy
        {
            get
            {
                return _GD_Embassy;
            }
            set
            {
                OnGD_EmbassyChanging ( value );
                ReportPropertyChanging ( "GD_Embassy" );
                _GD_Embassy = StructuralObject.SetValidValue ( value );
                ReportPropertyChanged ( "GD_Embassy" );
                OnGD_EmbassyChanged ();
            }
        }
        private Nullable<global::System.Boolean> _GD_Embassy;
        partial void OnGD_EmbassyChanging ( Nullable<global::System.Boolean> value );
        partial void OnGD_EmbassyChanged ();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_CompanyCodeSAP_MDMC_Requests", "MDMC_Request_CompanyCodeSAP" )]
        public MDMC_Request_CompanyCodeSAP MDMC_Request_CompanyCodeSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedReference<MDMC_Request_CompanyCodeSAP> ( "MDMC_DataModel.FK_MDMC_CompanyCodeSAP_MDMC_Requests", "MDMC_Request_CompanyCodeSAP" ).Value;
            }
            set
            {
                ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedReference<MDMC_Request_CompanyCodeSAP> ( "MDMC_DataModel.FK_MDMC_CompanyCodeSAP_MDMC_Requests", "MDMC_Request_CompanyCodeSAP" ).Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute ( false )]
        [DataMemberAttribute ()]
        public EntityReference<MDMC_Request_CompanyCodeSAP> MDMC_Request_CompanyCodeSAPReference
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedReference<MDMC_Request_CompanyCodeSAP> ( "MDMC_DataModel.FK_MDMC_CompanyCodeSAP_MDMC_Requests", "MDMC_Request_CompanyCodeSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedReference<MDMC_Request_CompanyCodeSAP> ( "MDMC_DataModel.FK_MDMC_CompanyCodeSAP_MDMC_Requests", "MDMC_Request_CompanyCodeSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_Request_ContactPersonsSAP_MDMC_RequestsSAP", "MDMC_Request_ContactPersonsSAP" )]
        public EntityCollection<MDMC_Request_ContactPersonsSAP> MDMC_Request_ContactPersonsSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_ContactPersonsSAP> ( "MDMC_DataModel.FK_MDMC_Request_ContactPersonsSAP_MDMC_RequestsSAP", "MDMC_Request_ContactPersonsSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_ContactPersonsSAP> ( "MDMC_DataModel.FK_MDMC_Request_ContactPersonsSAP_MDMC_RequestsSAP", "MDMC_Request_ContactPersonsSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_Request_CustomerBankDetailsSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerBankDetailsSAP" )]
        public EntityCollection<MDMC_Request_CustomerBankDetailsSAP> MDMC_Request_CustomerBankDetailsSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerBankDetailsSAP> ( "MDMC_DataModel.FK_MDMC_Request_CustomerBankDetailsSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerBankDetailsSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerBankDetailsSAP> ( "MDMC_DataModel.FK_MDMC_Request_CustomerBankDetailsSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerBankDetailsSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerEmailDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerEmailDetailsSAP" )]
        public EntityCollection<MDMC_Request_CustomerEmailDetailsSAP> MDMC_Request_CustomerEmailDetailsSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerEmailDetailsSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerEmailDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerEmailDetailsSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerEmailDetailsSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerEmailDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerEmailDetailsSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerFaxDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerFaxDetailsSAP" )]
        public EntityCollection<MDMC_Request_CustomerFaxDetailsSAP> MDMC_Request_CustomerFaxDetailsSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerFaxDetailsSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerFaxDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerFaxDetailsSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerFaxDetailsSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerFaxDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerFaxDetailsSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerPhoneDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerPhoneDetailsSAP" )]
        public EntityCollection<MDMC_Request_CustomerPhoneDetailsSAP> MDMC_Request_CustomerPhoneDetailsSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerPhoneDetailsSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPhoneDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerPhoneDetailsSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerPhoneDetailsSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPhoneDetailsSAP_MDMC_Requests", "MDMC_Request_CustomerPhoneDetailsSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerVATSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerVATSAP" )]
        public EntityCollection<MDMC_Request_CustomerVATSAP> MDMC_Request_CustomerVATSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerVATSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerVATSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerVATSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerVATSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerVATSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerVATSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_RequestCustomerPartnerFunctionSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerPartnerFunctionSAP" )]
        public EntityCollection<MDMC_Request_CustomerPartnerFunctionSAP> MDMC_Request_CustomerPartnerFunctionSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_CustomerPartnerFunctionSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPartnerFunctionSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerPartnerFunctionSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_CustomerPartnerFunctionSAP> ( "MDMC_DataModel.FK_MDMC_RequestCustomerPartnerFunctionSAP_MDMC_RequestsSAP", "MDMC_Request_CustomerPartnerFunctionSAP", value );
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute ()]
        [SoapIgnoreAttribute ()]
        [DataMemberAttribute ()]
        [EdmRelationshipNavigationPropertyAttribute ( "MDMC_DataModel", "FK_MDMC_SalesOrganizationSAP_MDMC_Requests", "MDMC_Request_SalesOrganizationSAP" )]
        public EntityCollection<MDMC_Request_SalesOrganizationSAP> MDMC_Request_SalesOrganizationSAP
        {
            get
            {
                return ( ( IEntityWithRelationships ) this ).RelationshipManager.GetRelatedCollection<MDMC_Request_SalesOrganizationSAP> ( "MDMC_DataModel.FK_MDMC_SalesOrganizationSAP_MDMC_Requests", "MDMC_Request_SalesOrganizationSAP" );
            }
            set
            {
                if ( ( value != null ) )
                {
                    ( ( IEntityWithRelationships ) this ).RelationshipManager.InitializeRelatedCollection<MDMC_Request_SalesOrganizationSAP> ( "MDMC_DataModel.FK_MDMC_SalesOrganizationSAP_MDMC_Requests", "MDMC_Request_SalesOrganizationSAP", value );
                }
            }
        }

        #endregion

    }
}
