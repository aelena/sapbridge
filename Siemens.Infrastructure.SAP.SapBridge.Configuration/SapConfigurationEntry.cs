using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{


    public class SapConfigurationEntry
    {
        /// <summary>
        /// Gets or sets the name of the Application that
        /// identifies the configuration block.
        /// </summary>
        [XmlAttribute ( "company" )]
        public string Company { get; set; }

        // ---------------------------------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the environment indicator for which
        /// this configuration applies.
        /// </summary>
        [XmlAttribute ( "environment" )]
        public string Environment { get; set; }

        // ---------------------------------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the instance of ConnectionData
        /// that specifies all the parameters needed 
        /// to connect to the SAP environment.
        /// </summary>
        [XmlElement ( ElementName = "ConnectionData" )]
        public ConnectionData ConnectionData { get; set; }

        // ---------------------------------------------------------------------------------------------

        [XmlElement ( ElementName = "BapiConfigurationBlock" )]
        public BapiConfigurationBlock BapiConfigurations = new BapiConfigurationBlock ();

        // ---------------------------------------------------------------------------------------------

        public IEnumerable<MappingData> GetMappingsForBAPI ( string bapiName )
        {
            var _bapiConfig = this.BapiConfigurations.BapiConfigurations.Where ( x => x.BapiName == bapiName );
            if ( _bapiConfig != null && _bapiConfig.Count () > 0 )
                return _bapiConfig.First ().Mapping;
            return null;
        }

        // ---------------------------------------------------------------------------------------------

        /// <summary>
        /// Gets all the operations listed in this particular section of
        /// the configuration.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tuple<string,string>> GetBAPIsAndOperations ()
        {
            return this.BapiConfigurations.BapiConfigurations.Select ( x => new Tuple<string, string> ( x.BapiName, x.Operation ) );
        }

        // ---------------------------------------------------------------------------------------------

    }








}
