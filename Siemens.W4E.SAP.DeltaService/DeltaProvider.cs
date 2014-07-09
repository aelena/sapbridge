using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ploeh.Albedo;
using Siemens.Infrastructure.SAP.SapBridge.Utils;

namespace Siemens.W4E.SAP.DeltaService
{
    public class DeltaProvider
    {

        public IEnumerable<DeltaItem> FindDelta<T> ( T original,
                                     T newer,
                                     bool deltaOnlyForValueOrStringFields = true,
                                     BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic )
        {
            // would not make much sense in either case...
            if ( original == null || newer == null )
                return null;

            //var _origFP = original.GetType ().GetPropertiesAndFields ( bindingFlags );
            //var _newFP = newer.GetType ().GetPropertiesAndFields ( bindingFlags );
            //var actual_1 = _origFP.Accept ( new ValueAndNameCollectingVisitor ( original ) ).Value.Cast<Tuple<string, object>> ().ToArray ();
            //var actual_2 = _newFP.Accept ( new ValueAndNameCollectingVisitor ( newer ) ).Value.Cast<Tuple<string, object>> ().ToArray ();

            if ( deltaOnlyForValueOrStringFields )
            {
                // this only works for strings or primitive types but not for recursive type inspection
                // so we still have got some way to go here... 
                var delta = this.GetValuesAndNames ( original, bindingFlags )
                    .Zip ( this.GetValuesAndNames ( newer, bindingFlags ),
                    ( a1, a2 ) => ( a1.FieldValue.ToStringSafe () != a2.FieldValue.ToStringSafe () ) 
                        ? new DeltaItem ( a1.FieldName, a1.FieldValue, a2.FieldValue) 
                        : null );

                // return only non-null instances
                return delta.Where ( x => x != null );
            }


            return null;
        }



        private IEnumerable<NameValuePair> GetValuesAndNames ( object target, BindingFlags bindingFlags )
        {
            return ( target == null ) ? null :
                    target.GetType ()
                   .GetProperties ( bindingFlags )
                   .Select ( p => new NameValuePair ( p.Name, p.GetValue ( target, null ) ) )
                   .Concat ( target
                   .GetType ()
                   .GetFields ( bindingFlags )
                   .Select ( f => new NameValuePair ( f.Name, f.GetValue ( target ) ) ) );
        }


    }


}
