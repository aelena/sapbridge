using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    public class MappingData
    {

        /// <summary>
        /// Gets or sets a value that represents the technical
        /// name of the table in SAP.
        /// </summary>
        [XmlAttribute ( AttributeName = "tableName" )]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets a a value that indicates the managed
        /// type that will contain the values that will be passed
        /// to the SAP fields defined in the mappings.
        /// </summary>
        [XmlAttribute ( AttributeName = "typeName" )]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets a a value that indicates the cardinality
        /// of the mapping. 
        /// There can be several cardinalities expressed by
        /// the values
        ///
        /// 0-1 - zero or one element max, meaning an optional mapping
        /// 1   - mandatory and exactly only one instance
        /// 0-n - zero or 1 or several instances
        /// 1-n - at least one instance of the mapping to be sent to SAP
        /// 
        /// </summary>
        [XmlAttribute ( AttributeName = "cardinality" )]
        public string Cardinality { get; set; }

        /// <summary>
        /// Represents the mapping type ( object or table )
        /// </summary>
        [XmlAttribute ( AttributeName = "mappingType" )]
        public string MappingType { get; set; }

        [XmlElement ( ElementName = "mappingType" )]
        public List<Mapping> Mappings = new List<Mapping> ();

    }
}
