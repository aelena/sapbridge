using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;
using System.Configuration;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests.Internal_API_tests
{
    public class BaseProviderTests
    {

        SapConfigurationSection _config = null;
        public BaseProviderTests ()
        {
            _config = ( SapConfigurationSection ) ConfigurationManager.GetSection ( "SapConfigurationSection" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_1 ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Foo", foo );
            t.Should ().NotBeNull ();
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Foo" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_2 ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Bar", foo );
            t.Should ().NotBeNull ();
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Bar" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_3 ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Baz", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Baz" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_4 ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Qux", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Qux" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_5 ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Curge", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Curge" );
        }

        // ---------------------------------------------------------------------------------------------





    }
}
