using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;

namespace Siemens.Infrastructure.SAP.SapBridge
{
    class SearchProvider
    {

        private SapConfigurationSection _config;

        internal IQueryable<R> Search<T, R> ( object searchDataCriteria,
                                              string applicationCode,
                                              string environment,
                                              string bapiName,
                                              string companyCode )
        {

            // get connection values needed to connect to SAP via sap .net connector
            var configurationParameters = this.GetConnectionParameters ( applicationCode, environment, bapiName, companyCode );

           

            return null;
        }


        // ---------------------------------------------------------------------------------------------


        internal RfcConfigParameters GetConnectionParameters ( string applicationCode,
                                                                string environment,
                                                                string operation,
                                                                string companyCode,
                                                                SapConfigurationSection configuration = null )
        {

            var configurationInstance = this.ReadSpecificConnectionDataEntry ( applicationCode, environment, companyCode, configuration );
            return this.MapConnectionDataToRfcConfigParameters ( configurationInstance );

        }

        // ---------------------------------------------------------------------------------------------

        internal SapConfigurationSection ReadConfiguration ( string configurationSectionName = "SapConfigurationSection" )
        {
            return ( SapConfigurationSection ) ConfigurationManager.GetSection ( configurationSectionName );
        }

        // ---------------------------------------------------------------------------------------------


        #region " --- private methods --- "

        private RfcConfigParameters MapConnectionDataToRfcConfigParameters ( IEnumerable<SapConfigurationEntry> configurationInstance )
        {
            if ( configurationInstance != null )
            {

                var _tempConnectionData = configurationInstance.First ().ConnectionData;
                var _rfcConfigParams = new RfcConfigParameters ();

                _rfcConfigParams.Add ( RfcConfigParameters.AppServerHost, _tempConnectionData.SapHostName );
                _rfcConfigParams.Add ( RfcConfigParameters.SystemNumber, _tempConnectionData.SapSystemNumber );
                _rfcConfigParams.Add ( RfcConfigParameters.User, _tempConnectionData.SapUserName );
                _rfcConfigParams.Add ( RfcConfigParameters.Password, _tempConnectionData.SapUserPassword );
                _rfcConfigParams.Add ( RfcConfigParameters.Client, _tempConnectionData.SapClientSystem );
                _rfcConfigParams.Add ( RfcConfigParameters.Language, _tempConnectionData.Language );
                _rfcConfigParams.Add ( RfcConfigParameters.PoolSize, _tempConnectionData.PoolSize );
                _rfcConfigParams.Add ( RfcConfigParameters.MaxPoolSize, _tempConnectionData.MaxPoolSize );
                _rfcConfigParams.Add ( RfcConfigParameters.IdleTimeout, _tempConnectionData.IdleTimeout );

                return _rfcConfigParams;
            }

            return null;
        }

        // ---------------------------------------------------------------------------------------------


        private IEnumerable<SapConfigurationEntry> ReadSpecificConnectionDataEntry ( string applicationCode, string environment, string companyCode, SapConfigurationSection configuration )
        {
            if ( configuration == null )
                configuration = this.ReadConfiguration ();
            var configurationInstance = configuration.Entries.Where ( x => x.Name == applicationCode.Trim ().ToUpperInvariant () )
                 .First ().SapConfigurationEntries.Where ( x => x.Environment == environment.Trim ().ToUpperInvariant () &&
                 x.Company == companyCode.Trim ().ToUpperInvariant () );
            return configurationInstance;
        }

        // ---------------------------------------------------------------------------------------------

        #endregion


        // ---------------------------------------------------------------------------------------------



    }
}
