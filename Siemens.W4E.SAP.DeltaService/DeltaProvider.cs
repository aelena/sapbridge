using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ploeh.Albedo;

namespace Siemens.W4E.SAP.DeltaService
{
    public class DeltaProvider
    {

        public IEnumerable<DeltaItem> FindDelta<T> ( T original,
                                     T newer,
                                     bool deltaOnlyForValueOrStringFields = true,
                                     bool doRecursiveInspect = false,
                                     BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic )
        {
            // would not make much sense in either case...
            if ( original == null || newer == null )
                return null;

            var _origFP = original.GetType ().GetPropertiesAndFields ( bindingFlags );
            var _newFP = newer.GetType ().GetPropertiesAndFields ( bindingFlags );

            var actual_1 = _origFP.Accept ( new ValueAndNameCollectingVisitor ( original ) ).Value.Cast<Tuple<string, object>> ().ToArray ();
            var actual_2 = _newFP.Accept ( new ValueAndNameCollectingVisitor ( newer ) ).Value.Cast<Tuple<string, object>> ().ToArray ();

            if ( deltaOnlyForValueOrStringFields && !doRecursiveInspect )
            {
                // this only works for strings or primitive types but not for recursive type inspection
                // so we still have got some way to go here... 
                var delta = actual_1.Zip ( actual_2, ( a1, a2 ) => ( a1.Item2.ToString() != a2.Item2.ToString() ) ? new DeltaItem ( a1.Item1, a1.Item2, a2.Item2 ) : null );
                return delta.Where ( x => x != null );
            }

            return null;
        }


    }


}
