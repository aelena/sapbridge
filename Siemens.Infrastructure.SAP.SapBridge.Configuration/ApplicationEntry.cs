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

        public ApplicationEntry()
        { }

        public ApplicationEntry( string name)
        {
            this.Name = name;
        }

    }
}
