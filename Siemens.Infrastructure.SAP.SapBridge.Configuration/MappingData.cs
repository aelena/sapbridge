using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    public class MappingData
    {

        [XmlAttribute ( AttributeName = "tableName" )]
        public string TableName { get; set; } 

        [XmlElement ( ElementName = "Mapping" )]
        public List<Mapping> Mappings = new List<Mapping> ();

    }
}
