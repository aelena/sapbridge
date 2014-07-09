using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.W4E.SAP.DeltaService
{
    public class MemberBasicInfo
    {

        private readonly string _fieldName;
        private readonly object _fieldValue;
        private readonly Type _type;
        private readonly bool _isActualClass;

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
        /// Returns the real type of the value 
        /// of the field.
        /// </summary>
        public Type UnderlyingType
        {
            get { return this._type; }
        }

        /// <summary>
        /// Returns a boolean that indicates whether
        /// the field value is actually a class
        /// ( for the time being this excludes strings
        /// and although they are classes, we consider them
        /// primitives here, as this indicator is used to
        /// know if we need to explore types recursively )
        /// </summary>
        public bool IsActualClass
        {
            get { return this._isActualClass; }
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="fieldValue"></param>
        public MemberBasicInfo ( string fieldName, object fieldValue )
        {
            this._fieldName = fieldName;
            this._fieldValue = fieldValue;
            if ( fieldValue != null )
            {
                this._type = fieldValue.GetType ().UnderlyingSystemType;
                if ( this._type.IsClass && this._type != typeof ( string ) )
                    this._isActualClass = true;
            }
        }


        /// <summary>
        /// Overriding ToString() to return a more readable representation
        /// of the object.
        /// </summary>
        /// <returns></returns>
        public override string ToString ()
        {
            return string.Format ( "{0} : {1} (is of type {2})", 
                this.FieldName, 
                this.FieldValue.ToString (),
                this.UnderlyingType.FullName );
        }

    }
}
