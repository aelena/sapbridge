using System.Xml.Serialization;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration
{
    public class ConnectionData
    {
        [XmlAttribute ( "sapUserName" )]
        public string SapUserName { get; set; }

        [XmlAttribute ( "sapUserPassword" )]
        public string SapUserPassword { get; set; }

        [XmlAttribute ( "sapHostName" )]
        public string SapHostName { get; set; }

        [XmlAttribute ( "sapSystemNumber" )]
        public string SapSystemNumber { get; set; }

        [XmlAttribute ( "sapClientSystem" )]
        public string SapClientSystem { get; set; }

        [XmlAttribute ( "language" )]
        public string Language { get; set; }

        [XmlAttribute ( "poolSize" )]
        public string PoolSize { get; set; }

        [XmlAttribute ( "maxPoolSize" )]
        public string MaxPoolSize { get; set; }

        [XmlAttribute ( "idleTimeout" )]
        public string IdleTimeout { get; set; }
    }
}
