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


        SapConfigurationSection root;
        string serializedXml;
        XDocument xDocument;

        /// <summary>
        /// Use the constructor as test fixture setup
        /// </summary>
        public CustomConfigurationTests ()
        {
            root = new SapConfigurationSection ();
            root.Entries.Add ( new ApplicationEntry ( "MDM" )
            {
                SapConfigurationEntries = new System.Collections.Generic.List<SapConfigurationEntry> () { 
                    new SapConfigurationEntry() { 
                        Company="1234", 
                        Environment="Q",
                         ConnectionData = new ConnectionData()
                         {
                            IdleTimeout="600",
                            Language="EN",
                            PoolSize="10",
                            MaxPoolSize="100",
                            SapClientSystem="",
                            SapHostName ="",
                            SapSystemNumber = "",
                            SapUserName ="",
                            SapUserPassword =""
                         }
                     }
                }
            } );
            this.serializedXml = XmlSerializerSectionHandler.SerializeObject ( root );
            this.xDocument = XDocument.Parse ( this.serializedXml );


        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldContainCorrectRootElement ()
        {
            xDocument.Root.Name.Should ().Equals ( "SapConfigurationSection" );
        }


        // ---------------------------------------------------------------------------------------------


        [Fact]
        public void ShouldContainCorrectApplicationNode ()
        {
            var appNode = from applications in xDocument.Descendants ( XName.Get ( "Application" ) )
                          select applications;

            appNode.First ().FirstAttribute.Value.Should ().BeEquivalentTo ( "MDM" );

        }

        // ---------------------------------------------------------------------------------------------


        [Fact]
        public void ShouldContainCorrectSapConfigurationEntryNode ()
        {
            var appNode = from applications in xDocument.Descendants ( XName.Get ( "SapConfigurationEntry" ) )
                          select applications;
            appNode.First ().FirstAttribute.Value.Should ().BeEquivalentTo ( "1234" );
            appNode.First ().LastAttribute.Value.Should ().BeEquivalentTo ( "Q" );

        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldContainConnectionData()
        {
            var appNode = from applications in xDocument.Descendants ( XName.Get ( "ConnectionData" ) )
                          select applications;
            appNode.Should ().HaveCount ( 1 );
            appNode.First ().Attribute ( XName.Get ( "language" ) ).Value.Should().BeEquivalentTo ( "EN" );
        }

        // ---------------------------------------------------------------------------------------------


    }

}
