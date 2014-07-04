using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;
using System.Reflection;
using System.Collections;

namespace Siemens.Infrastructure.SAP.SapBridge
{
    public class BaseProvider
    {

        private readonly SapConfigurationSection _configuration;
        public SapConfigurationSection Configuration
        {
            get
            {
                return this._configuration == null ? this.ReadConfiguration () : this._configuration;
            }
            private set { }
        }

        // ---------------------------------------------------------------------------------------------

        public BaseProvider ()
        {
            this._configuration = this.ReadConfiguration ();
        }

        // ---------------------------------------------------------------------------------------------

        internal SapConfigurationSection ReadConfiguration ( string configurationSectionName = "SapConfigurationSection" )
        {
            if ( this._configuration == null )
                return ( SapConfigurationSection ) ConfigurationManager.GetSection ( configurationSectionName );
            return this._configuration;
        }

        // ---------------------------------------------------------------------------------------------

        protected internal RfcConfigParameters MapConnectionDataToRfcConfigParameters ( IEnumerable<SapConfigurationEntry> configurationInstance )
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


        protected internal IEnumerable<SapConfigurationEntry> ReadSpecificConnectionDataEntry (
            string applicationCode,
            string environment,
            string companyCode, SapConfigurationSection configuration )
        {
            if ( configuration == null )
                configuration = this.ReadConfiguration ();
            var configurationInstance = configuration.Entries.Where ( x => x.Name == applicationCode.Trim ().ToUpperInvariant () )
                 .First ().SapConfigurationEntries.Where ( x => x.Environment == environment.Trim ().ToUpperInvariant () &&
                 x.Company == companyCode.Trim ().ToUpperInvariant () );
            return configurationInstance;
        }

        // ---------------------------------------------------------------------------------------------


        protected internal Type FindTypeInObjectGraph ( string typeName, object rootObject )
        {
            
            if ( rootObject == null )
                return null;

            if ( String.IsNullOrWhiteSpace ( typeName ) )
                throw new ArgumentException ( "The Type name indicated by parameter 'typeName' cannot be null" );


            // simplest case first
            if ( rootObject.GetType ().FullName.Equals ( typeName ) )
                return rootObject.GetType ();

            foreach ( var f in rootObject.GetType ().GetFields ( BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic ) )
            {

                // there has to be a better way, IList? other namespaces are to be checked too (non generic)
                // why did I put GenericTypeArguments.First()
                if ( f.FieldType.Namespace.Equals ( "System.Collections.Generic" ) )
                {
                    if ( f.FieldType.GenericTypeArguments.First ().FullName.Equals ( typeName ) )
                        return f.FieldType.GenericTypeArguments.First ();
                }
                else if ( f.FieldType.IsArray )
                {

                }
                else
                    if ( f.FieldType.FullName.Equals ( typeName ) )
                        return f.FieldType;

                // step inside if this field is a class and it is not a string 
                if ( f.FieldType.IsClass && f.FieldType != typeof ( string ) )
                {
                    var _sub = this.FindTypeInObjectGraph ( typeName, f.GetValue ( rootObject ) );
                    if ( _sub != null )
                        return _sub;
                }

            }

            foreach ( var f in rootObject.GetType ().GetProperties ( BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic ) )
                if ( f.PropertyType.FullName.Equals ( typeName ) )
                    if ( f.PropertyType is IList )
                        return null;
                    else
                        return f.PropertyType;

            return null;

            //(f.FieldType).IsClass

        }


        // ---------------------------------------------------------------------------------------------

        protected internal string FindBAPIForOperation ( string companyCode, string environment, string operationName )
        {
            var _x = this.GetConfigurationForCompanyAndEnvironment ( companyCode, environment );
            var opName = _x.First ().GetBAPIsAndOperations ().Where ( x => x.Item2 == operationName );
            return ( opName != null && opName.Count () > 0 ) ? opName.First ().Item1 : null;
        }

        // ---------------------------------------------------------------------------------------------

        protected internal List<SapConfigurationEntry> GetConfigurationForCompanyAndEnvironment ( string companyCode, string environment )
        {
            var _x = this.Configuration.Entries.First ().SapConfigurationEntries.FindAll (
                x => x.Company == companyCode && x.Environment == environment );
            return _x;
        }

        // ---------------------------------------------------------------------------------------------

        protected internal RfcConfigParameters GetConnectionParameters ( string applicationCode,
                                                                string environment,
                                                                string operation,
                                                                string companyCode,
                                                                SapConfigurationSection configuration = null )
        {

            var configurationInstance = this.ReadSpecificConnectionDataEntry ( applicationCode, environment, companyCode, configuration );
            return this.MapConnectionDataToRfcConfigParameters ( configurationInstance );

        }

        // ---------------------------------------------------------------------------------------------


    }
}
