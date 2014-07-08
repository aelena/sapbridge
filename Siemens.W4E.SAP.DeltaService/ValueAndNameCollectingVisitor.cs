using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.Albedo;

namespace Siemens.W4E.SAP.DeltaService
{
    class ValueAndNameCollectingVisitor: ReflectionVisitor<IEnumerable>
    {
        private readonly object target;
        private readonly Tuple<string, object> [] values;

        public ValueAndNameCollectingVisitor ( object target, params Tuple<string, object> [] values )
        {
            this.target = target;
            this.values = values;
        }

        public override IEnumerable Value
        {
            get { return this.values; }
        }

        public override IReflectionVisitor<IEnumerable> Visit (
            FieldInfoElement fieldInfoElement )
        {
            var value = fieldInfoElement.FieldInfo.GetValue ( this.target );
            var fieldName = fieldInfoElement.FieldInfo.Name;
            return new ValueAndNameCollectingVisitor (
                this.target,
                this.values.Concat ( new [] { new Tuple<string, object> ( fieldName, value ) } ).ToArray () );
        }

        public override IReflectionVisitor<IEnumerable> Visit (
            PropertyInfoElement propertyInfoElement )
        {
            var value =
                propertyInfoElement.PropertyInfo.GetValue ( this.target, null );
            var propName = propertyInfoElement.PropertyInfo.Name;

            return new ValueAndNameCollectingVisitor (
                this.target,
                this.values.Concat ( new [] { new Tuple<string, object> ( propName, value ) } ).ToArray () );
        }
    }
}
