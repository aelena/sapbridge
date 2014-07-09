using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.Infrastructure.SAP.SapBridge
{
    public sealed class SapUtilities
    {

        /// <summary>
        /// Creates a simple instance of a DataTable
        /// where all the fields are string by default.
        /// Only a list of names for the columns has to be passed.
        /// </summary>
        /// <param name="columnNames"></param>
        /// <returns></returns>
        public DataTable CreateSimpleTable ( IEnumerable<string> columnNames )
        {
            if ( columnNames == null )
                return null;

            var dt = new DataTable();
            foreach ( var colName in columnNames )
                dt.Columns.Add ( new DataColumn ( colName, typeof ( String ) ) );
            return dt;
        }

        // ---------------------------------------------------------------------------------------------


    }
}
