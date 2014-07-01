using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    public class Mapping
    {
        [XmlAttribute ( AttributeName = "sapName" )]
        public string SapName { get; set; }

        [XmlAttribute ( AttributeName = "fieldName" )]
        public string FieldName { get; set; }

        //[XmlAttribute ( AttributeName = "returnType" )]
        //public bool IsReturnType { get; set; }

        public Mapping () { }

        public Mapping ( string sapName, string fieldName)
        {
            this.SapName = sapName;
            this.FieldName = fieldName;
        }
    }
}
