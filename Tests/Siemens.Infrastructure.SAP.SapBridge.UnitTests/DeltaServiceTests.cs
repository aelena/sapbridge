using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies;
using FluentAssertions;
using Xunit.Extensions;
using System.Collections;
using Siemens.Infrastructure.SAP.SapBridge.UnitTests._dummy_classes;

namespace Siemens.W4E.SAP.DeltaService.UnitTests
{
    public class DeltaServiceTests
    {
        [Fact]
        public void DeltaService_ShouldFindSimplestDelta ()
        {
            // create two simples objects in the arrange phase
            var fooOriginal = new SimpleFoo ();
            var fooNew = new SimpleFoo { Message = "I am a newer instance", Age = 2828 };
            // instantiate the service that returns the delta
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDelta<SimpleFoo> ( fooOriginal, fooNew );
            delta.Should ().HaveCount ( 2 );
        }

        [Fact]
        public void DeltaService_ShouldNotCrashOnNullField ()
        {
            // create two simples objects in the arrange phase
            var fooOriginal = new SimpleFoo ();
            var fooNew = new SimpleFoo { Message = null, Age = 2828 };
            // instantiate the service that returns the delta
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDelta<SimpleFoo> ( fooOriginal, fooNew );
            delta.Should ().HaveCount ( 2 );
        }

        [Fact]
        public void DeltaService_ShouldNotCrashOnNullInstance_1 ()
        {
            var fooOriginal = new SimpleFoo ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDelta<SimpleFoo> ( fooOriginal, null );
            delta.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_ShouldNotCrashOnNullInstance_2 ()
        {
            var fooOriginal = new SimpleFoo ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDelta<SimpleFoo> ( null, fooOriginal );
            delta.Should ().BeNull ();
        }


        // -------------------------------------------------------------------------------------------------------------------


        [Fact]
        public void DeltaService_ShouldFindCommonFieldsSimpleTypes ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDelta<SimpleFoo, SimpleFoo2> ( sf1, sf2 );
            delta.Should ().NotBeNull ();
        }


        // -------------------------------------------------------------------------------------------------------------------


        #region " --- GetMemberInfo tests --- "

        [Fact]
        public void DeltaService_ShouldGetMemberInfo ()
        {
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var memberInfo = deltaProvider.GetMemberInfo ( sf2, "DebtIssue", System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic );
            memberInfo.FieldName.Should ().BeEquivalentTo ( "DebtIssue" );
        }

        [Fact]
        public void DeltaService_ShouldNotGetMemberInfoOnWrongFieldName ()
        {
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var memberInfo = deltaProvider.GetMemberInfo ( sf2, "DebtxxxxxIssue", System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic );
            memberInfo.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_GetMemberInfoShouldNotCrash ()
        {
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var memberInfo = deltaProvider.GetMemberInfo ( sf2, null, System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic );
            memberInfo.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_GetMemberInfoShouldNotCrashOnNullTarget ()
        {
            var deltaProvider = new DeltaProvider ();
            var memberInfo = deltaProvider.GetMemberInfo ( null, "DebtIssue", System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic );
            memberInfo.Should ().BeNull ();
        }

        #endregion


        // -------------------------------------------------------------------------------------------------------------------


        #region " --- FindDeltaForSingleField tests --- "

        [Fact]
        public void DeltaService_FindDeltaForSingleField ()
        {
            var sf1 = new SimpleFoo () { Cash = 1 };
            var sf2 = new SimpleFoo2 () { Cash = 2 };
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField ( sf1, sf2, "Cash" );
            delta.FieldValueInFirstInstance.Should ().Be ( 1.0 );
            delta.FieldValueInSecondInstance.Should ().Be ( 2.0 );
            delta.FieldName.Should ().BeEquivalentTo ( "Cash" );
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleField_2 ()
        {
            var sf1 = new SimpleFoo () { Message = "Hello" };
            var sf2 = new SimpleFoo2 () { Message = "World" };
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField ( sf1, sf2, "Message" );
            delta.FieldValueInFirstInstance.Should ().Be ( "Hello" );
            delta.FieldValueInSecondInstance.Should ().Be ( "World" );
            delta.FieldName.Should ().BeEquivalentTo ( "Message" );
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleFieldShouldReturnNullForFieldWithSameValueInBothInstances ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField ( sf1, sf2, "Message" );
            delta.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleFieldShouldReturnNullForNonSharedField ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField ( sf1, sf2, "MyAge" );
            delta.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleFieldShouldNotCrashOnNullFieldName ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField ( sf1, sf2, null );
            delta.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleFieldShouldNotCrashOnNullInstance_1 ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField<SimpleFoo, SimpleFoo2> ( null, sf2, "Cash" );
            delta.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleFieldShouldNotCrashOnNullInstance_2 ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField<SimpleFoo, SimpleFoo2> ( sf1, null, "Cash" );
            delta.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleFieldShouldNotCrashOnNullInstance_3 ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField<SimpleFoo, SimpleFoo2> ( null, null, "Cash" );
            delta.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltaForSingleFieldShouldNotCrashOnNullInstance_4 ()
        {
            var sf1 = new SimpleFoo ();
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var delta = deltaProvider.FindDeltaForSingleField<SimpleFoo, SimpleFoo2> ( null, null, null );
            delta.Should ().BeNull ();
        }

        #endregion


        // -------------------------------------------------------------------------------------------------------------------


        #region " --- FindDelta<T,U> tests --- "

        public class Shitdata : IEnumerable<object []>
        {
            private readonly List<object []> _data = new List<object []>
            {
                new object[] { new SimpleFoo (), new SimpleFoo2(), 0},
                new object[] { new SimpleFoo (){ Cash = 1 }, new SimpleFoo2(){ Cash = 2 }, 1}
            };

            public IEnumerator<object []> GetEnumerator ()
            { return _data.GetEnumerator (); }

            IEnumerator IEnumerable.GetEnumerator ()
            { return GetEnumerator (); }
        }

        #region " --- with simple types --- "

        [Theory,
            ClassData ( typeof ( Shitdata ) )]
        public void DeltaService_FindDeltasForInstancesOfDifferentType_1 ( SimpleFoo o1, SimpleFoo2 o2, int deltaCount )
        {
            var deltaProvider = new DeltaProvider ();
            var deltas = deltaProvider.FindDelta<SimpleFoo, SimpleFoo2> ( o1, o2 );
            deltas.Should ().HaveCount ( deltaCount );
        }

        [Fact]
        public void DeltaService_FindDeltasForInstancesOfDifferentType_2 ()
        {
            var sf1 = new SimpleFoo () { Cash = 1 };
            var sf2 = new SimpleFoo2 () { Cash = 2 };
            var deltaProvider = new DeltaProvider ();
            var deltas = deltaProvider.FindDelta<SimpleFoo, SimpleFoo2> ( sf1, sf2 );
            deltas.Should ().HaveCount ( 1 );
            deltas.First ().FieldValueInFirstInstance.Should ().Be ( 1.0 );
            deltas.First ().FieldValueInSecondInstance.Should ().Be ( 2.0 );
        }

        [Fact]
        public void DeltaService_FindDeltasForInstancesOfDifferentType_ShouldNotCrashOnNullInstance_1 ()
        {
            var sf1 = new SimpleFoo () { Cash = 1 };
            var deltaProvider = new DeltaProvider ();
            var deltas = deltaProvider.FindDelta<SimpleFoo, SimpleFoo2> ( sf1, null );
            deltas.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltasForInstancesOfDifferentType_ShouldNotCrashOnNullInstance_2 ()
        {
            var sf2 = new SimpleFoo2 ();
            var deltaProvider = new DeltaProvider ();
            var deltas = deltaProvider.FindDelta<SimpleFoo, SimpleFoo2> ( null, sf2 );
            deltas.Should ().BeNull ();
        }

        [Fact]
        public void DeltaService_FindDeltasForInstancesWithNoSharedFields_ShouldBeZero ()
        {
            var sf1 = new SimpleFoo () { Cash = 1 };
            var q = new Qux () { QuxField = "hi" };
            var deltaProvider = new DeltaProvider ();
            var deltas = deltaProvider.FindDelta<SimpleFoo, Qux> ( sf1, q );
            deltas.Should ().HaveCount ( 0 );
        }

        #endregion

        #region " --- with bigger types --- "
        
        // TODO: this has to be done with the real live application objects...

        //[Fact]
        //public void DeltaService_FindDeltasForDefaultMDMCInstances()
        //{
        //    var req1 = new MDMC_Requests ();
        //    var req2 = new MDMC_RequestsSAP ();
        //    var deltaProvider = new DeltaProvider ();
        //    var deltas = deltaProvider.FindDelta ( req1, req2 );
        //    deltas.Should ().HaveCount ( 0 );
        //}

        #endregion

        #endregion


        // -------------------------------------------------------------------------------------------------------------------

    }
}
