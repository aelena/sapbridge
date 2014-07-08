using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siemens.W4E.SAP.DeltaService
{
    public sealed class DeltaItem
    {

        private readonly string _fieldName;
        private readonly object _firstInstanceValue;
        private readonly object _secondInstanceValue;

        public string FieldName
        {
            get { return this._fieldName; }
        }

        public object FieldValueInFirstInstance
        {
            get { return this._firstInstanceValue; }
        }

        public object FieldValueInSecondInstance
        {
            get { return this._secondInstanceValue; }
        }

        public DeltaItem (string fieldName, object firstInstanceValue, object secondInstanceValue)
        {
            this._fieldName = fieldName;
            this._firstInstanceValue = firstInstanceValue;
            this._secondInstanceValue = secondInstanceValue;
        }

    }
}
