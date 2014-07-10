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


        private BindingFlags _bindingFlags;

        public void SetDefaultBindingFlags ( BindingFlags bindingFlags )
        {
            this._bindingFlags = bindingFlags;
        }

        public BindingFlags GetCurrentBindingFlags ()
        {
            return this._bindingFlags;
        }


        // -------------------------------------------------------------------------------------------------------------------


        #region " --- constructors --- "

        /// <summary>
        /// Default constructor. Initializes instance with current bindingFlags
        /// set to this scope:
        /// BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
        /// </summary>
        public DeltaProvider ()
        {
            this._bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        }


        // -------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Parameterized constructor, allows the caller to set specific
        /// bindingFlags.
        /// </summary>
        /// <param name="bindingFlags"></param>
        public DeltaProvider ( BindingFlags bindingFlags )
        {
            this._bindingFlags = bindingFlags;
        }


        #endregion 


        // -------------------------------------------------------------------------------------------------------------------


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
                        ? new DeltaItem ( a1.FieldName, a1.FieldValue, a2.FieldValue )
                        : null );

                // return only non-null instances
                return delta.Where ( x => x != null );
            }
            else
            {
                // if we need to dive deep down...
                var _origValues = this.GetValuesAndNames ( original, bindingFlags );
                var _newValues = this.GetValuesAndNames ( newer, bindingFlags );
                for ( int i = 0; i < _origValues.Count (); i++ )
                {
                }

            }

            return null;
        }


        // -------------------------------------------------------------------------------------------------------------------


        public IEnumerable<DeltaItem> FindDelta<T, U> ( T original,
                                U newer,
                                bool deltaOnlyForValueOrStringFields = true,
                                BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic )
        {
            // if one of the instances is null, just return null
            // or should we throw an exception to inform the caller?
            if ( original == null || newer == null )
                return null;

            var _sourceVN = this.GetValuesAndNames ( original, bindingFlags );
            var _targetVN = this.GetValuesAndNames ( newer, bindingFlags );
            // obtain the common set of fields
            var _commonSet = _sourceVN.Select ( x => x.FieldName ).Intersect ( _targetVN.Select ( y => y.FieldName ) );
            
            IList<DeltaItem> deltas = new List<DeltaItem>();
            foreach ( var _c in _commonSet )
            {
                var delta = this.FindDeltaForSingleField<T, U> ( original, newer, _c );
                if ( delta != null )
                    deltas.Add ( delta );
            }

            return deltas;
        }


        // -------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Gets a minimum of reflection information for a single 
        /// field or property of the specified name.
        /// </summary>
        /// <param name="target">Object to inspect.</param>
        /// <param name="fieldName">Name of the field or property to find.</param>
        /// <param name="bindingFlags">Reflection flags for discovery scope.</param>
        /// <returns>An instance of MemberBasicInfo or null.</returns>
        internal MemberBasicInfo GetMemberInfo ( object target, string fieldName, BindingFlags bindingFlags )
        {
            return ( target == null ) ? null :
                    target.GetType ()
                   .GetProperties ( bindingFlags )
                   .Select ( p => new MemberBasicInfo ( p.Name, p.GetValue ( target, null ) ) ).Where ( p => p.FieldName == fieldName )
                   .Concat ( target
                   .GetType ()
                   .GetFields ( bindingFlags )
                   .Select ( f => new MemberBasicInfo ( f.Name, f.GetValue ( target ) ) ).Where ( p => p.FieldName == fieldName ) ).FirstOrDefault ();
        }


        // -------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="bindingFlags"></param>
        /// <returns></returns>
        private IEnumerable<MemberBasicInfo> GetValuesAndNames ( object target, BindingFlags bindingFlags )
        {
            return ( target == null ) ? null :
                    target.GetType ()
                   .GetProperties ( bindingFlags )
                   .Select ( p => new MemberBasicInfo ( p.Name, p.GetValue ( target, null ) ) )
                   .Concat ( target
                   .GetType ()
                   .GetFields ( bindingFlags )
                   .Select ( f => new MemberBasicInfo ( f.Name, f.GetValue ( target ) ) ) );
        }


        // -------------------------------------------------------------------------------------------------------------------


        private IEnumerable<MemberBasicInfo> GetValuesAndNames<T, U> ( T source, U target, BindingFlags bindingFlags )
        {

            var _sourceVN = this.GetValuesAndNames ( source, bindingFlags );
            var _targetVN = this.GetValuesAndNames ( target, bindingFlags );

            // obtain the common set of fields
            var _commonSet = _sourceVN.Select ( x => x ).Intersect ( _targetVN.Select ( y => y ) );

            // TODO: decide what to do with the other fields that do not coincide
            // most likely use the same set of fields for both objects

            var _commonSetVN = this.GetValuesAndNames ( _commonSet, bindingFlags );

            return null;
        }


        // -------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// For a specific field that is to exist in two objecs
        /// of a different type, it searches for the field name
        /// and if found in both instances, it returns the delta
        /// item if the values are different.
        /// </summary>
        /// <typeparam name="T">Type of the first object to be inspected.</typeparam>
        /// <typeparam name="U">Type of the second object to be inspected.</typeparam>
        /// <param name="source">First object to be inspected.</param>
        /// <param name="target">Second object to be inspected.</param>
        /// <param name="fieldName">Name of the field that must be found.</param>
        /// <returns>Returns an instsance of DeltaItem if the field exists in both (non-null)
        /// instances and it has different values in each of the instances.
        /// Otherwise null is returned.</returns>
        internal DeltaItem FindDeltaForSingleField<T, U> ( T source, U target, string fieldName )
        {
            var memberInfoInSource = this.GetMemberInfo ( source, fieldName, this._bindingFlags );
            var memberInfoInTarget = this.GetMemberInfo ( target, fieldName, this._bindingFlags );
            if ( memberInfoInSource != null && memberInfoInTarget != null )
            {
                if (memberInfoInSource.FieldValue.ToStringSafe() != memberInfoInTarget.FieldValue.ToStringSafe())
                {
                    return new DeltaItem ( fieldName, memberInfoInSource.FieldValue,
                        memberInfoInTarget.FieldValue );
                }
            }
            return null;
        }


        // -------------------------------------------------------------------------------------------------------------------

    }


}
