using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.Infrastructure.SAP.SapBridge.UnitTests.Dummies
{

    public class SimpleFoo
    {
        internal string FooField = "I am Foo instance!";
        internal string Message = "My message to the world is...";
        internal int Age = 23139;
        internal double Cash = 2399393.29;
    }

    public class SimpleFoo2
    {
        internal string FooField = "I am Foo instance!";
        internal string Message = "My message to the world is...";
        internal int MyAge = 23139;
        internal double Cash = 2399393.29;
        internal double DebtIssue = 3343.02;
    }

    internal sealed class Foo : SimpleFoo
    {

        internal Bar Bar;
        internal List<Baz> BazList = new List<Baz> ();
        internal Qux Quux;

        internal Foo ()
        {
            this.Bar = new Bar ( "FooBar Bar" );
            this.Quux = new Qux ();
            BazList.Add ( new Baz
            {
                BazFieldA = "Yuck!",
                BazFieldB = 2839
            } );
            BazList.Add ( new Baz () );
        }
    }

    // ---------------------------------------------------------------------------------------------

    internal sealed class Bar
    {
        internal string BarName { get; private set; }
        internal Bar ( string barName )
        {
            this.BarName = BarName;
        }
    }

    // ---------------------------------------------------------------------------------------------

    internal sealed class Baz
    {
        internal string BazFieldA = "baz field A";
        internal int BazFieldB = 42;
    }

    // ---------------------------------------------------------------------------------------------

    internal sealed class Qux
    {
        internal string QuxField = "I am Qux instance!";    

        internal Corge Corge;
        internal Qux ()
        {
            this.Corge = new Corge ();
        }
    }

    // ---------------------------------------------------------------------------------------------

    internal sealed class Corge
    {
        internal string Hello = "I am a true Corge!";
        internal Pippo PippoInstance = new Pippo ();

    }

    // ---------------------------------------------------------------------------------------------

    internal class Pippo
    {
        internal Snork Snorkah = new Snork () { MySnorkyName = "Snork!" };
    }

    public class Snork
    {
        public string MySnorkyName { get;set;}
        internal Wombat WombatInstance = new Wombat ();

    }

    public class Wombat
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
    }
}
