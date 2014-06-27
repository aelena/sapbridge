using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;
using Xunit;
using SAP.Middleware.Connector;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests.Internal_API_tests
{
    public class SearchProviderTests
    {

        SapConfigurationSection _config = null;
        public SearchProviderTests ()
        {
            _config = ( SapConfigurationSection ) ConfigurationManager.GetSection ( "SapConfigurationSection" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldGetCorrectConfigurationData ()
        {

        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldMapConnectionDataToRFC ()
        {
            var sp = new SearchProvider ();
            var results = sp.GetConnectionParameters ( "MDM", "Q", "SEARCH", "5290" );
            // check some data to make sure the configuration read is the right one
            results [ "ASHOST" ].Should ().BeEquivalentTo ( "unknown" );
            results [ "USER" ].Should ().BeEquivalentTo ( "user1" );
            results [ "CLIENT" ].Should ().BeEquivalentTo ( "74" );

        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldMapConnectionDataToRFCUsingExistingConfiguration ()
        {

            var sp = new SearchProvider ();
            var results = sp.GetConnectionParameters ( "MDM", "Q", "SEARCH", "5290", 
                ( SapConfigurationSection ) ConfigurationManager.GetSection ( "SapConfigurationSection" ) );
            // check some data to make sure the configuration read is the right one
            results [ "ASHOST" ].Should ().BeEquivalentTo ( "unknown" );
            results [ "USER" ].Should ().BeEquivalentTo ( "user1" );
            results [ "CLIENT" ].Should ().BeEquivalentTo ( "74" );

        }

        // ---------------------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------------------


        // ---------------------------------------------------------------------------------------------

    }
}
