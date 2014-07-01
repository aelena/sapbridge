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
            var _sasha = sp.GetMappingsForCompanyEnvironmentAndBAPIName ( "1234", "Q", "/SIE/SWE_MM_GRTO3" );
            _sasha.Should ().HaveCount ( 5 );

            _sasha.ElementAt ( 0 ).TableName.Should ().BeEquivalentTo ( "TABL1" );
            _sasha.ElementAt ( 0 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Foo" );
            _sasha.ElementAt ( 0 ).Mappings.Should ().HaveCount ( 2 );
            CardinalityConstants.AsList ().Should ().Contain ( _sasha.ElementAt ( 0 ).Cardinality );

            _sasha.ElementAt ( 1 ).TableName.Should ().BeEquivalentTo ( "TABL2" );
            _sasha.ElementAt ( 1 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Bar" );
            _sasha.ElementAt ( 1 ).Mappings.Should ().HaveCount ( 2 );
            CardinalityConstants.AsList ().Should ().Contain ( _sasha.ElementAt ( 1 ).Cardinality );

            _sasha.ElementAt ( 2 ).TableName.Should ().BeEquivalentTo ( "TABL3" );
            _sasha.ElementAt ( 2 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Baz" );
            _sasha.ElementAt ( 2 ).Mappings.Should ().HaveCount ( 2 );
            CardinalityConstants.AsList ().Should ().Contain ( _sasha.ElementAt ( 2 ).Cardinality );

            _sasha.ElementAt ( 3 ).TableName.Should ().BeEquivalentTo ( "TABL4" );
            _sasha.ElementAt ( 3 ).TypeName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Qux" );
            _sasha.ElementAt ( 3 ).Mappings.Should ().HaveCount ( 1 );
            CardinalityConstants.AsList ().Should ().Contain ( _sasha.ElementAt ( 3 ).Cardinality );

            _sasha.ElementAt ( 4 ).TableName.Should ().BeEquivalentTo ( "TABL5" );
            _sasha.ElementAt ( 4 ).TypeName.Should ().BeEquivalentTo ( "System.Data.DataTable" );
            _sasha.ElementAt ( 4 ).Mappings.Should ().HaveCount ( 4 );
            CardinalityConstants.AsList ().Should ().Contain ( _sasha.ElementAt ( 4 ).Cardinality );

        }

        // ---------------------------------------------------------------------------------------------

        //[Fact]
        //public void ShouldMapSimpleObjectToDataTable()
        //{
        //    var sp = new ServiceProvider ();
        //    sp.MapDataTable ( "1234", "Q", "", null );
        //}

        // ---------------------------------------------------------------------------------------------

    }
}
