using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests
{
    public class ConfigurationFileTests
    {
        SapConfigurationSection _config = null;
        public ConfigurationFileTests ()
        {
            _config = ( SapConfigurationSection ) ConfigurationManager.GetSection ( "SapConfigurationSection" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldGetConfigurationSection ()
        {
            _config.Should ().NotBeNull ();
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldGetTwoApplications ()
        {
            _config.Entries.Should ().HaveCount ( 2 );
            _config.Entries.First ().Name.Should ().BeEquivalentTo ( "MDM" );
            _config.Entries.Last ().Name.Should ().BeEquivalentTo ( "MDMC" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldGetTwoCompanyCodesConfiguredPerApplication ()
        {
            _config.Entries.First ().SapConfigurationEntries.Should ().HaveCount ( 2 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldHaveCorrectCompanyCodesForEachConfigurationEntry ()
        {
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "1234" ).Count ().Should ().Be ( 1 );
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "5290" ).Count ().Should ().Be ( 1 );
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Environment == "Q" ).Count ().Should ().Be ( 2 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldHaveTwoBapiConfiguration ()
        {
            _config.Entries.First ().SapConfigurationEntries.First ().BapiConfigurations.BapiConfigurations.Should ().HaveCount ( 2 );
            _config.Entries.First ().SapConfigurationEntries.Last ().BapiConfigurations.BapiConfigurations.Should ().HaveCount ( 2 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldHaveCorrectBapiConfiguration2 ()
        {
            _config.Entries.First ().SapConfigurationEntries.First ().BapiConfigurations.BapiConfigurations.First ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_GRTO1" );
            _config.Entries.First ().SapConfigurationEntries.First ().BapiConfigurations.BapiConfigurations.Last ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_GRTO2" );
            _config.Entries.Last ().SapConfigurationEntries.Last ().BapiConfigurations.BapiConfigurations.First ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_XAXA1" );
            _config.Entries.Last ().SapConfigurationEntries.Last ().BapiConfigurations.BapiConfigurations.Last ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_XAXA2" );
        }

        // ---------------------------------------------------------------------------------------------

    }
}
