﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Siemens.Infrastructure.SAP.SapBridge.Configuration.Constants;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;
using System.Configuration;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests.Internal_API_tests
{
    public class CardinalityTests
    {

        SapConfigurationSection _config = null;
        public CardinalityTests ()
        {
            _config = ( SapConfigurationSection ) ConfigurationManager.GetSection ( "SapConfigurationSection" );
        }

        // ---------------------------------------------------------------------------------------------


        [Fact]
        public void ShouldValidateCorrectCardinality ()
        {
            CardinalityConstants.ExactlyOne.Should ().BeEquivalentTo ( "1" );
            CardinalityConstants.OneOrN.Should ().BeEquivalentTo ( "1-n" );
            CardinalityConstants.ZeroOrN.Should ().BeEquivalentTo ( "0-n" );
            CardinalityConstants.ZeroOrOne.Should ().BeEquivalentTo ( "0-1" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldReturnListWithFourElements ()
        {
            CardinalityConstants.AsList ().Should ().HaveCount ( 4 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldContainStringInAsListReturn ()
        {
            CardinalityConstants.AsList ().Should ().Contain ( "1" );
            CardinalityConstants.AsList ().Should ().Contain ( "0-1" );
            CardinalityConstants.AsList ().Should ().Contain ( "0-n" );
            CardinalityConstants.AsList ().Should ().Contain ( "1-n" );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void ShouldNotContainStringInAsListReturn ()
        {
            CardinalityConstants.AsList ().Should ().NotContain ( "0" );
            CardinalityConstants.AsList ().Should ().NotContain ( "n" );
        }

        // ---------------------------------------------------------------------------------------------

    }
}
