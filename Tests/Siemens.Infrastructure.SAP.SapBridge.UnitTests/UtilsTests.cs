using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests
{
    public class UtilsTests
    {
        [Fact]
        public void SimpleDataTableCreationShouldReturnNullOnNullList()
        {
            var u = new SapUtilities ();
            u.CreateSimpleTable ( null ).Should ().BeNull ();
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void SimpleDataTableCreationShouldReturnEmptyTableOnEmptyList ()
        {
            var u = new SapUtilities ();
            u.CreateSimpleTable ( new List<string>() ).Columns.Should ().HaveCount ( 0 );
        }

        // ---------------------------------------------------------------------------------------------

        [Fact]
        public void SimpleDataTableCreationShouldCreateCorrectly ()
        {
            var u = new SapUtilities ();
            u.CreateSimpleTable ( new List<String> { "COL_A", "COL_B", "COL_C" } ).Columns.Should ().HaveCount ( 3 );
        }

        // ---------------------------------------------------------------------------------------------

    }
}
