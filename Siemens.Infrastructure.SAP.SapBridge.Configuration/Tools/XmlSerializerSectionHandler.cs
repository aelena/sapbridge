using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration.Tools
{
    public class XmlSerializerSectionHandler : IConfigurationSectionHandler
    {

        public object Create ( object parent, object configContext, System.Xml.XmlNode section )
        {
            // get the name of the type from the type= attribute on the root node
            var xpn = section.CreateNavigator ();
            string TypeName = ( string ) xpn.Evaluate ( "string(@type)" );
            if ( TypeName == "" )
            {
                throw new ConfigurationErrorsException (
                    "The type attribute is not present on the root node of the <" +
                    section.Name + "> configuration section ", section );
            }

            // make sure this string evaluates to a valid type
            Type t = Type.GetType ( TypeName );
            if ( t == null )
            {
                throw new ConfigurationErrorsException (
                    "The type attribute \'" + TypeName + "\' specified in the root node of the " +
                    "the <" + section.Name + "> configuration section is not a valid type.",
                    section );
            }
            var xs = new XmlSerializer ( t );

            // attempt to deserialize an object of this type from the provided XML section
            var xnr = new XmlNodeReader ( section );
            try
            {
                return xs.Deserialize ( xnr );
            }
            catch ( Exception ex )
            {
                string s = ex.Message;
                Exception iex = ex.InnerException;
                while ( iex != null )
                {
                    s += "; " + iex.Message;
                    iex = iex.InnerException;
                }
                throw new ConfigurationErrorsException (
                    "Unable to deserialize an object of type \'" + TypeName +
                    "\' from  the <" + section.Name + "> configuration section: " +
                    s, ex, section );
            }
        }


        // ----------------------------------------------------------------------------------------------------


        public static string SerializeObject ( dynamic o )
        {
            StringBuilder sb = new StringBuilder ();

            try
            {
                using ( var sw = new StringWriter ( sb ) )
                {
                    using ( var xtw = new XmlTextWriter ( sw ) )
                    {
                        xtw.Formatting = Formatting.Indented;
                        XmlSerializerNamespaces xsn = new XmlSerializerNamespaces ();
                        xsn.Add ( "", "" );
                        XmlSerializer xs = new XmlSerializer ( o.GetType () );
                        xs.Serialize ( xtw, o, xsn );
                        string s = sb.ToString ();
                        return Regex.Replace ( s, "(<" + o.GetType ().Name + ")(>)", "$1 type=\"" + o.GetType ().FullName + "\"$2" );
                    }
                }
            }
            catch ( Exception ex )
            {
                throw new Exception ( "Error on creating serialized representation of object.", ex );
            }

        }


        // ----------------------------------------------------------------------------------------------------


    }
}
