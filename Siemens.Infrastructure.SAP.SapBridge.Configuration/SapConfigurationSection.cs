using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml.Serialization;
using System.Data.SqlClient;


namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    [XmlRoot ( 
        //Namespace = "Siemens.Infrastructure.SAP.SapBridge.Configuration", 
        IsNullable = false, 
        ElementName = "SapConfigurationSection" )]
    public class SapConfigurationSection
    {

        [XmlElement ( ElementName = "Application" )]
        public List<SapConfigurationEntry> Entries = new List<SapConfigurationEntry> ();

    }
}
