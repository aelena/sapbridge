using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;
using System.Configuration;
using Siemens.Infrastructure.SAP.SapBridge.Configuration.Constants;
using System.Data;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests.External_API_tests
{
    public class ServiceProviderTests
    {

        SapConfigurationSection _config = null;
        public ServiceProviderTests ()
        {
            _config = ( SapConfigurationSection ) ConfigurationManager.GetSection ( "SapConfigurationSection" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldGetMappingsForCompanyEnvironmentAndBAPIName ()
        {

            var sp = new ServiceProvider ();
            var elements = sp.GetMappingsForCompanyEnvironmentAndBAPIName ( "1234", "Q", "/SIE/SWE_MM_GRTO3" );
            elements.Should ().HaveCount ( 4 );

            elements.ElementAt ( 0 ).TableName.Should ().BeEquivalentTo ( "TABL1" );
            elements.ElementAt ( 0 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Foo" );
            elements.ElementAt ( 0 ).Mappings.Should ().HaveCount ( 2 );
            CardinalityConstants.AsList ().Should ().Contain ( elements.ElementAt ( 0 ).Cardinality );

            elements.ElementAt ( 1 ).TableName.Should ().BeEquivalentTo ( "TABL2" );
            elements.ElementAt ( 1 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Bar" );
            elements.ElementAt ( 1 ).Mappings.Should ().HaveCount ( 2 );
            CardinalityConstants.AsList ().Should ().Contain ( elements.ElementAt ( 1 ).Cardinality );

            elements.ElementAt ( 2 ).TableName.Should ().BeEquivalentTo ( "TABL3" );
            elements.ElementAt ( 2 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Baz" );
            elements.ElementAt ( 2 ).Mappings.Should ().HaveCount ( 2 );
            CardinalityConstants.AsList ().Should ().Contain ( elements.ElementAt ( 2 ).Cardinality );

            elements.ElementAt ( 3 ).TableName.Should ().BeEquivalentTo ( "TABL4" );
            elements.ElementAt ( 3 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Qux" );
            elements.ElementAt ( 3 ).Mappings.Should ().HaveCount ( 1 );
            CardinalityConstants.AsList ().Should ().Contain ( elements.ElementAt ( 3 ).Cardinality );

           
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldMapSimpleObjectToDataTable ()
        {
            var sp = new ServiceProvider ();
            var u = new SapUtilities ();
            var dt = u.CreateSimpleTable ( new List<string> { "EBELP", "EBELN", "SWE_MM_TICK" } );
            var mappedTable = sp.MapDataTableToIRfcTable ( "MDM", "1234", "Q", "WRITEGRTDATA", dt );
            mappedTable.Should ().NotBeNull ();
        }

        // ---------------------------------------------------------------------------------------------

    }
}
