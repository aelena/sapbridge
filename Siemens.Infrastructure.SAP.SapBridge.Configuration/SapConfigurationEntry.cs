using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;

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

        [XmlAttribute ( "environment" )]
        public string Environment { get; set; }

        [XmlElement ( ElementName = "ConnectionData" )]
        public ConnectionData ConnectionData { get; set; }

        [XmlElement ( ElementName = "BapiConfigurationBlock" )]
        public BapiConfigurationBlock BapiConfigurations = new BapiConfigurationBlock ();

        public IEnumerable<MappingData> GetMappingsForBAPI ( string bapiName )
        {
            var _bapiConfig = this.BapiConfigurations.BapiConfigurations.Where ( x => x.BapiName == bapiName );
            if ( _bapiConfig != null && _bapiConfig.Count() > 0)
                return _bapiConfig.First ().Mapping;
            return null;


        }

    }








}
