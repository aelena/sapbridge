using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests.Internal_API_tests
{
    public class TestsWithDummyTypes
    {

        Foo foo;

        public TestsWithDummyTypes ()
        {
            // build the entire dummy object graph
            this.foo = new Foo ();
        }

        // ---------------------------------------------------------------------------------------------


        [Fact]
        public void ShouldMapEntireDummyObjectGraphCorrectly()
        {
            var sp = new ServiceProvider ();
            sp.MapObject ( "1234", "Q", "/SIE/SWE_MM_GRTO3", this.foo );
        }

        // ---------------------------------------------------------------------------------------------

    }
}
