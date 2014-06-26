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
            root.Entries.Add ( new ApplicationEntry ( "MDM" )
            {
                SapConfigurationEntries = new System.Collections.Generic.List<SapConfigurationEntry> () { 
                    new SapConfigurationEntry() { Company="1234", Environment="Q"}}
            } );

            var _xml = XmlSerializerSectionHandler.SerializeObject ( root );

            var xDoc = XDocument.Parse ( _xml );
            var appNode = from applications in xDoc.Descendants ( XName.Get ( "Application" ) )
                          select applications;

            appNode.First ().FirstAttribute.Value.Should ().BeEquivalentTo ( "MDM" );

        }


        [Fact]
        public void ShouldContainCorrectSapConfigurationEntryNode ()
        {

            var root = new SapConfigurationSection ();
            root.Entries.Add ( new ApplicationEntry ( "MDM" )
            {
                SapConfigurationEntries = new System.Collections.Generic.List<SapConfigurationEntry> () { 
                    new SapConfigurationEntry() { Company="1234", Environment="Q"}}
            } );

            var _xml = XmlSerializerSectionHandler.SerializeObject ( root );

            var xDoc = XDocument.Parse ( _xml );
            var appNode = from applications in xDoc.Descendants ( XName.Get ( "SapConfigurationEntry" ) )
                          select applications;

            appNode.First ().FirstAttribute.Value.Should ().BeEquivalentTo ( "1234" );
            appNode.First ().LastAttribute.Value.Should ().BeEquivalentTo ( "Q" );


        }


    }

}
