using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    public class BapiConfigurationBlock
    {
        [XmlElement ( ElementName = "BapiConfiguration" )]
        public List<BapiConfiguration> BapiConfigurations = new List<BapiConfiguration> ();
    }
}
