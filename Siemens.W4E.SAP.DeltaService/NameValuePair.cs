using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.W4E.SAP.DeltaService
{
    public class NameValuePair
    {

        private readonly string _fieldName;
        private readonly object _fieldValue;

        /// <summary>
        /// Gets the name of the instance field that is different from one instance to the other.
        /// </summary>
        public string FieldName
        {
            get { return this._fieldName; }
        }

        /// <summary>
        /// Gets the value of the field in the first instance
        /// </summary>
        public object FieldValue
        {
            get { return this._fieldValue; }
        }

         /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="fieldValue"></param>
        public NameValuePair ( string fieldName, object fieldValue )
        {
            this._fieldName = fieldName;
            this._fieldValue = fieldValue;
        }


        /// <summary>
        /// Overriding ToString() to return a more readable representation
        /// of the object.
        /// </summary>
        /// <returns></returns>
        public override string ToString ()
        {
            return string.Format ( "{0} : {1}", this.FieldName, this.FieldValue.ToString() );
        }

    }
}
