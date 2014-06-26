using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }



  




}
