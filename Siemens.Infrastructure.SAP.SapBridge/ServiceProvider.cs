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

        private readonly RfcDestination RfcDestination;

        // ----------------------------------------------------------------------------------------------------------------

        public RfcDestination GetDestinationConfiguration ( string applicationCode, string companyCode, string environment )
        {
            RfcDestination _rfcDest01 = RfcDestinationManager.GetDestination ( this.MapConnectionDataToRfcConfigParameters (
                this.ReadSpecificConnectionDataEntry ( applicationCode, environment, companyCode, null ) ) );
            return _rfcDest01;
        }


        // ----------------------------------------------------------------------------------------------------------------


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


        public IRfcTable MapDataTableToIRfcTable ( string applicationCode, string companyCode, string environment, string operationName, DataTable dataTable )
        {

            // get configuration for request companyCode, environment and operation
            var _config = this.GetConfigurationForCompanyAndEnvironment ( companyCode, environment ).First ().BapiConfigurations.BapiConfigurations.Where ( x => x.Operation == operationName );
            var _mapping = _config.First ().Mapping.First ();
            if ( this.RfcDestination == null )
                this.GetDestinationConfiguration ( applicationCode, companyCode, environment );
            var repo01 = RfcDestination.Repository;
            // get the bapi reference
            IRfcFunction saveBAPI = repo01.CreateFunction ( _config.First ().BapiName );
            IRfcTable inputTable = saveBAPI.GetTable ( _mapping.TableName );
            inputTable.Append ( dataTable.Rows.Count );
            for ( int i = 0; i < dataTable.Rows.Count; i++ )
            {
                foreach ( var m in _mapping.Mappings )
                    if ( !m.IsReturnField )
                        inputTable [ i ].SetValue ( m.SapName, Convert.ToString ( dataTable.Rows [ i ] [ m.FieldName ] ) );
            }

            //return inputTable;
            return null;
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
                    Type t = this.FindTypeInObjectGraph ( mapping.TypeName, rootObject );
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
