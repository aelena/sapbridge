using Siemens.Infrastructure.SAP.SapBridge.Configuration;
using Siemens.Infrastructure.SAP.SapBridge.Configuration.Tools;
using Xunit;
using FluentAssertions;
using System.Xml.Linq;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests
{
    public class CustomConfigurationTests
    {

        [Fact]
        public void ShouldGetRootElementRight ()
        {

            var root = new SapConfigurationSection ();
            root.Entries.Add ( new SapConfigurationEntry () { Company = "1234", Environment = "Q" } );

            var _xml = XmlSerializerSectionHandler.SerializeObject ( root );

            var xDoc = XDocument.Parse ( _xml );
            xDoc.Root.Name.Should ().Equals ( "SapConfigurationSection" );


        }


    }

}
