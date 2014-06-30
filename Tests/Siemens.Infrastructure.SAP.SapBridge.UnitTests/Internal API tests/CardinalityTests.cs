using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Siemens.Infrastructure.SAP.SapBridge.Configuration.Constants;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests.Internal_API_tests
{
    public class CardinalityTests
    {

        [Fact]
        public void ShouldValidateCorrectCardinality()
        {
            CardinalityConstants.ExactlyOne.Should ().BeEquivalentTo ( "1" );
            CardinalityConstants.OneOrN.Should ().BeEquivalentTo ( "1-n" );
            CardinalityConstants.ZeroOrN.Should ().BeEquivalentTo ( "0-n" );
            CardinalityConstants.ZeroOrOne.Should ().BeEquivalentTo ( "0-1" );
        }

    }
}
