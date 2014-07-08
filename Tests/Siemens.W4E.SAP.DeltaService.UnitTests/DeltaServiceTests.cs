using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies;
using FluentAssertions;
    
namespace Siemens.W4E.SAP.DeltaService.UnitTests
{
    public class DeltaServiceTests
    {
        [Fact]
        public void ShouldFindSimplestDelta()
        {
            // create two simples objects in the arrange phase
            var fooOriginal = new SimpleFoo ();
            var fooNew = new SimpleFoo { Message = "I am a newer instance", Age = 2828 };
            // instantiate the service that returns the delta
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDelta<SimpleFoo> ( fooOriginal, fooNew );
            delta.Should ().HaveCount ( 2 );
             
        }
    }
}
