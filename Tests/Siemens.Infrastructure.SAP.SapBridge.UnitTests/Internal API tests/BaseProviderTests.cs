﻿using System;
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
        public void ShouldFindTypeInObjectGraph_Foo ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Foo", foo );
            t.Should ().NotBeNull ();
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Foo" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_Bar ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Bar", foo );
            t.Should ().NotBeNull ();
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Bar" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_Baz ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Baz", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Baz" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_Qux ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Qux", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Qux" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_Corge ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Corge", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Corge" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_Pippo ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Pippo", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Pippo" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_Snork ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Snork", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Snork" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindTypeInObjectGraph_Wombat ()
        {
            var foo = new Foo ();
            var sp = new ServiceProvider ();
            var t = sp.FindInstanceInObjectGraph ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Wombat", foo );
            t.FullName.Should ().BeEquivalentTo ( "Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies.Wombat" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldFindBAPINameForOperationName ()
        {
            var bp = new BaseProvider ();
            var bapiName = bp.FindBAPIForOperation ( "1234", "Q", "SEARCH" );
            bapiName.Should ().BeEquivalentTo ( "/SIE/SWE_MM_GRTO1" );

        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldReturnNullForWrongOperationName ()
        {
            var bp = new BaseProvider ();
            var bapiName = bp.FindBAPIForOperation ( "1234", "Q", "SEARCH___" );
            bapiName.Should ().BeNull ();

        }

        // ---------------------------------------------------------------------------------------------


    }
}
