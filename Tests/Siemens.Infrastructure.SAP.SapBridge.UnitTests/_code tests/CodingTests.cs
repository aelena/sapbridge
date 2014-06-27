using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests._code_tests
{
    public class CodingTests
    {

        [Fact]
        public void CodeTest_CheckingDynamicObject ()
        {

            dynamic d = new
            {
                MyFirstField = "First",
                MySecondField = "Second",
                MyThirdField = 3
            };
            var props = ( ( object ) d ).GetType ().GetProperties ();
            props.Should ().HaveCount ( 3 );
            var hash = from p in props
                       select new
                       {
                           Key = p.Name,
                           Value = p.GetValue ( d )
                       };

            hash.Should ().HaveCount ( 3 );
            hash.First ().Value.Equals ( "First" );
            hash.ElementAt ( 2 ).Value.Equals ( "Second" );
            hash.Last ().Value.Equals ( 3 );

        }

    }
}
