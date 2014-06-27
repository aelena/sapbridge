using System.Collections.Generic;
using System.Xml.Serialization;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    public class BapiConfiguration
    {
        [XmlAttribute ( AttributeName = "bapiName" )]
        public string BapiName { get; set; }

        [XmlAttribute ( AttributeName = "operation" )]
        public string Operation { get; set; }

        [XmlElement ( ElementName = "Mappings" )]
        public MappingData Mapping = new MappingData ();
    }
}
