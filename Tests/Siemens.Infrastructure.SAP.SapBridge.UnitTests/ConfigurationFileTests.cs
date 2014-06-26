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

        [Fact]
        public void ShouldGetConfigurationSection ()
        {
            _config.Should ().NotBeNull ();
        }


        [Fact]
        public void ShouldGetTwoApplications ()
        {
            _config.Entries.Should ().HaveCount ( 2 );
        }

        [Fact]
        public void ShouldGetTwoCompanyCodesConfiguredPerApplication ()
        {
            _config.Entries.First ().SapConfigurationEntries.Should ().HaveCount ( 2 );
        }

        [Fact]
        public void ShouldHaveCorrectCompanyCodesForEachConfigurationEntry ()
        {
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "1234" ).Count ().Should ().Be ( 1 );
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Company == "5290" ).Count ().Should ().Be ( 1 );
            _config.Entries.First ().SapConfigurationEntries.FindAll ( x => x.Environment == "Q" ).Count ().Should ().Be ( 2 );
        }

    }
}
