using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    public class ApplicationEntry
    {

        [XmlAttribute ( AttributeName = "name" )]
        public string Name { get; set; }

        public List<SapConfigurationEntry> SapConfigurationEntries { get; set; }

        public ApplicationEntry()
        {
            this.SapConfigurationEntries = new List<SapConfigurationEntry> ();
        }

        public ApplicationEntry( string name)
        {
            this.SapConfigurationEntries = new List<SapConfigurationEntry> ();
            this.Name = name;
        }


    }
}
