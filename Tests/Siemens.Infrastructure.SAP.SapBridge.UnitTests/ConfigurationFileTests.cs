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
        public void ShouldFindACorrectApplicationCode ()
        {
            _config.Entries.Where ( x => x.Name.Equals ( "MDMC" ) ).Should ().HaveCount ( 1 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldGetTwoCompanyCodesConfiguredPerApplication ()
        {
            _config.Entries.First ().SapConfigurationEntries.Should ().HaveCount ( 3 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldHaveCorrectCompanyCodesForEachConfigurationEntry ()
        {
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "1234" ).Count ().Should ().Be ( 1 );
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "5290" ).Count ().Should ().Be ( 1 );
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "*" ).Count ().Should ().Be ( 1 );
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Environment == "Q" ).Count ().Should ().Be ( 3 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldHaveTwoBapiConfiguration ()
        {
            _config.Entries.First ().SapConfigurationEntries.First ().BapiConfigurations.BapiConfigurations.Should ().HaveCount ( 4 );
            _config.Entries.First ().SapConfigurationEntries.ElementAt(1).BapiConfigurations.BapiConfigurations.Should ().HaveCount ( 2 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldHaveCorrectBapiConfiguration ()
        {
            _config.Entries.First ().SapConfigurationEntries.First ().BapiConfigurations.BapiConfigurations.First ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_GRTO1" );
            _config.Entries.First ().SapConfigurationEntries.ElementAt (2).BapiConfigurations.BapiConfigurations.Last ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_GRTO2" );
            _config.Entries.Last ().SapConfigurationEntries.Last ().BapiConfigurations.BapiConfigurations.First ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_XAXA1" );
            _config.Entries.Last ().SapConfigurationEntries.Last ().BapiConfigurations.BapiConfigurations.Last ().BapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_XAXA2" );
            _config.Entries.First ().SapConfigurationEntries.First ().BapiConfigurations.BapiConfigurations.First ().Operation.Should ().BeEquivalentTo ( "SEARCH" );
            _config.Entries.First ().SapConfigurationEntries.First ().BapiConfigurations.BapiConfigurations.ElementAt ( 1 ).Operation.Should ().BeEquivalentTo ( "WRITE" );
            _config.Entries.Last ().SapConfigurationEntries.Last ().BapiConfigurations.BapiConfigurations.First ().Operation.Should ().BeEquivalentTo ( "SEARCH" );
            _config.Entries.Last ().SapConfigurationEntries.Last ().BapiConfigurations.BapiConfigurations.Last().Operation.Should ().BeEquivalentTo ( "WRITE" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldObtainAllMappingsForAGivenCompanyEnvironmentAndBAPIName ()
        {
            var _x = _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "1234" && x.Environment == "Q" );
            _x.Should ().HaveCount ( 1 );
            var _mappings = _x.First ().GetMappingsForBAPI ( @"/SIE/SWE_MM_GRTO1" );
            _mappings.Should ().HaveCount ( 3 );
        }

        // ---------------------------------------------------------------------------------------------

    }
}
