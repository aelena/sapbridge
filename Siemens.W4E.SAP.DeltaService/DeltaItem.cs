using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siemens.W4E.SAP.DeltaService
{
    /// <summary>
    /// Represents the simplest information snippet about 
    /// what changed between two instances of a type.
    /// It has only three fields
    /// 
    /// - FieldName : name of the instance field that is different from one instance to the other
    /// - FieldValueInFirstInstance : value of the field in the first instance
    /// - FieldValueInSecondInstance : value of the field in the second instance
    /// </summary>
    public class DeltaItem
    {

        private readonly string _fieldName;
        private readonly object _firstInstanceValue;
        private readonly object _secondInstanceValue;

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
        public object FieldValueInFirstInstance
        {
            get { return this._firstInstanceValue; }
        }

        /// <summary>
        /// Gets the  value of the field in the second instance
        /// </summary>
        public object FieldValueInSecondInstance
        {
            get { return this._secondInstanceValue; }
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="firstInstanceValue"></param>
        /// <param name="secondInstanceValue"></param>
        public DeltaItem (string fieldName, object firstInstanceValue, object secondInstanceValue)
        {
            this._fieldName = fieldName;
            this._firstInstanceValue = firstInstanceValue;
            this._secondInstanceValue = secondInstanceValue;
        }


        /// <summary>
        /// Overriding ToString() to return a more readable representation
        /// of the object.
        /// </summary>
        /// <returns></returns>
        public override string ToString ()
        {
            return string.Format ( "Field '{0}' : in origin {0}, in second instance {1}", this.FieldName,
                this.FieldValueInFirstInstance.ToString(), this.FieldValueInSecondInstance.ToString() );
        }

    }
}
