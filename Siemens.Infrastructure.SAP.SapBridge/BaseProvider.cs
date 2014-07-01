﻿using System;
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

        SapConfigurationSection _configuration;
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
            this.ReadConfiguration ();
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


        protected internal IEnumerable<SapConfigurationEntry> ReadSpecificConnectionDataEntry ( string applicationCode, string environment, string companyCode, SapConfigurationSection configuration )
        {
            if ( configuration == null )
                configuration = this.ReadConfiguration ();
            var configurationInstance = configuration.Entries.Where ( x => x.Name == applicationCode.Trim ().ToUpperInvariant () )
                 .First ().SapConfigurationEntries.Where ( x => x.Environment == environment.Trim ().ToUpperInvariant () &&
                 x.Company == companyCode.Trim ().ToUpperInvariant () );
            return configurationInstance;
        }

        // ---------------------------------------------------------------------------------------------


        protected internal Type FindInstanceInObjectGraph ( string typeName, object rootObject )
        {
            if ( rootObject == null )
                throw new ArgumentNullException ( "rootObject" );

            if ( String.IsNullOrWhiteSpace ( typeName ) )
                throw new ArgumentException ( "The Type name indicated by parameter 'typeName' cannot be null" );


            // simplest case first
            if ( rootObject.GetType ().FullName.Equals ( typeName ) )
                return rootObject.GetType ();

            foreach ( var f in rootObject.GetType ().GetFields ( BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic ) )
            {
                if ( f.FieldType.Namespace.Equals ( "System.Collections.Generic" ) )    // there has to be a better way, IList? other namespaces are to be checked too (non generic)
                {
                    if ( f.FieldType.GenericTypeArguments.First ().FullName.Equals ( typeName ) )
                        return f.FieldType.GenericTypeArguments.First ();
                }
                else
                    if ( f.FieldType.FullName.Equals ( typeName ) )
                        return f.FieldType;
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

    }
}