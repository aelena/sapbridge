using Siemens.Infrastructure.SAP.SapBridge.Configuration;
using Siemens.Infrastructure.SAP.SapBridge.Configuration.Tools;
using Xunit;
using FluentAssertions;
using System.Xml.Linq;
using System.Linq;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests
{
    public class CustomConfigurationTests
    {

        [Fact]
        public void ShouldContainCorrectRootElement ()
        {

            var root = new SapConfigurationSection ();
            root.Entries.Add ( new ApplicationEntry ( "MDM" ) );

            var _xml = XmlSerializerSectionHandler.SerializeObject ( root );

            var xDoc = XDocument.Parse ( _xml );
            xDoc.Root.Name.Should ().Equals ( "SapConfigurationSection" );

        }


        [Fact]
        public void ShouldContainCorrectApplicationNode ()
        {

            var root = new SapConfigurationSection ();
            root.Entries.Add ( new ApplicationEntry ( "MDM" ) );

            var _xml = XmlSerializerSectionHandler.SerializeObject ( root );

            var xDoc = XDocument.Parse ( _xml );
            var appNode = from applications in xDoc.Descendants(XName.Get("Application"))
                          select applications;

            appNode.First ().FirstAttribute.Value.Should ().Equals ( "MDM" );


        }


    }

}
