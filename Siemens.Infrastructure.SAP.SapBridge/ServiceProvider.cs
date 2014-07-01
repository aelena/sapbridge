using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;

namespace Siemens.Infrastructure.SAP.SapBridge
{
    public class ServiceProvider : BaseProvider
    {

        /// <summary>
        /// Clients will call this method when they want to perform searches against SAP.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <param name="applicationCode">THe short letter code that identifies an application, such as 
        /// MDM, MDMC, GRT, TTT, etc.</param>
        /// <param name="environment"></param>
        /// <param name="operation">A literal that indicates the operation to perform</param>
        /// <param name="companyCode">An optional company code parameter to find specific operations
        /// defined for specific company codes in the .config file.</param>
        /// <param name="searchDataCriteria">Represents any object (a DTO basically) that contains
        /// at least the minimum fields needed to perform the search against SAP. Since the number
        /// of fields to be used in search will vary from application to application - or even to
        /// perform different searches within one single application - we need to keep this 
        /// flexible.</param>
        /// <returns></returns>
        public IQueryable<R> PerformSearch<T, R> ( object searchDataCriteria,
                                                  string applicationCode,
                                                  string environment,
                                                  string operation,
                                                  string companyCode = "*" )
        {

            var sp = new SearchProvider ();
            return sp.Search<T, R> ( searchDataCriteria, applicationCode, environment, operation, companyCode );

        }


        // ---------------------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------------------


        public void MapDataTable ( string companyCode, string environment, string operationName, DataTable dataTable )
        {

            //var repo01 = RfcDestination.Repository;
            //// get the bapi reference
            //IRfcFunction saveBAPI = repo01.CreateFunction ( ConfigurationManager.AppSettings [ "saveBAPI" ] );
            //IRfcTable inputTable = saveBAPI.GetTable ( "PUSH" );
            //inputTable.Append ( dataTable.Rows.Count );
            //for ( int i = 0; i < dataTable.Rows.Count; i++ )
            //{
            //    inputTable [ i ].SetValue ( "EBELN", Convert.ToString ( dataTable.Rows [ i ] [ "EBELN" ] ) );
            //    inputTable [ i ].SetValue ( "EBELP", Convert.ToString ( dataTable.Rows [ i ] [ "EBELP" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_TICK", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_TICK" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_SEC", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_SEC" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_DIVI", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_DIVI" ] ) );
            //    inputTable [ i ].SetValue ( "BLDAT", Convert.ToDateTime ( dataTable.Rows [ i ] [ "BLDAT" ] ).ToString ( "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture ) );
            //    inputTable [ i ].SetValue ( "BWART", Convert.ToString ( dataTable.Rows [ i ] [ "BWART" ] ) );
            //    inputTable [ i ].SetValue ( "ERFMG", Convert.ToDouble ( dataTable.Rows [ i ] [ "ERFMG" ] ) );
            //    inputTable [ i ].SetValue ( "LFSNR", Convert.ToString ( dataTable.Rows [ i ] [ "LFSNR" ] ) );
            //    inputTable [ i ].SetValue ( "REQUSR", Convert.ToString ( dataTable.Rows [ i ] [ "REQUSR" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_ORGD", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_ORGDESC" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_NTAC", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_NTAC" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_NAME", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_NAME" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_STAT", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_STAT" ] ) );
            //    inputTable [ i ].SetValue ( "/SIE/SWE_MM_COMT", Convert.ToString ( dataTable.Rows [ i ] [ "SWE_MM_COMT" ] ) );
            //    inputTable [ i ].SetValue ( "BUKRS", Convert.ToString ( dataTable.Rows [ i ] [ "BUKRS" ] ) );
            //    inputTable [ i ].SetValue ( "LAND1", Convert.ToString ( dataTable.Rows [ i ] [ "LAND1" ] ) );
            //    inputTable [ i ].SetValue ( "EKORG", Convert.ToString ( dataTable.Rows [ i ] [ "EKORG" ] ) );
            //    inputTable [ i ].SetValue ( "MATNR", Convert.ToString ( dataTable.Rows [ i ] [ "MATNR" ] ) );
            //    inputTable [ i ].SetValue ( "TXZ01", Convert.ToString ( dataTable.Rows [ i ] [ "TXZ01" ] ) );
            //    inputTable [ i ].SetValue ( "MENGE", Convert.ToDouble ( dataTable.Rows [ i ] [ "MENGE" ] ) );
            //    inputTable [ i ].SetValue ( "MAXQTY", Convert.ToDouble ( dataTable.Rows [ i ] [ "MAXQTY" ] ) );
            //    inputTable [ i ].SetValue ( "LIFNR", Convert.ToString ( dataTable.Rows [ i ] [ "LIFNR" ] ) );
            //    inputTable [ i ].SetValue ( "NAME1", Convert.ToString ( dataTable.Rows [ i ] [ "NAME1" ] ) );

            //}

        }


        // ---------------------------------------------------------------------------------------------


        public void MapObject ( string companyCode, string environment, string bapiName, object rootObject )
        {
            // obtains the mappings for these 3 criteria, companyCode, environment, bapiName
            var mappings = this.GetMappingsForCompanyEnvironmentAndBAPIName ( companyCode, environment, bapiName );
            var _allTypes = from map in mappings
                            select new
                            {
                                map.TypeName
                            };
            if ( mappings != null )
            {
                foreach ( var mapping in mappings )
                {
                    Type t = this.FindInstanceInObjectGraph ( mapping.TypeName, rootObject );
                }
            }
        }

        // ---------------------------------------------------------------------------------------------

        public void MapObject_2 ( string companyCode,
                                string environment,
                                string bapiName,
                                IEnumerable<dynamic> objects )
        {
            // obtains the mappings for these 3 criteria, companyCode, environment, bapiName
            var mappings = this.GetMappingsForCompanyEnvironmentAndBAPIName ( companyCode, environment, bapiName );
            //if ( mappings != null )
            //{
            //    foreach ( var mapping in mappings)
            //    objects.All ( x => mapping.GetTypeList ().Contains ( x.GetType ().FullName ) );
            //}
        }

        // ---------------------------------------------------------------------------------------------


        internal IEnumerable<MappingData> GetMappingsForCompanyEnvironmentAndBAPIName ( string companyCode,
                                                                    string environment,
                                                                        string bapiName )
        {

            var _x = this.Configuration.Entries.First ().SapConfigurationEntries.FindAll (
                x => x.Company == companyCode && x.Environment == environment );
            if ( _x != null && _x.Count () > 0 )
                return _x.First ().GetMappingsForBAPI ( bapiName );
            return null;
        }


        // ---------------------------------------------------------------------------------------------

    }
}
