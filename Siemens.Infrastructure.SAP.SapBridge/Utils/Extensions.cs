using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.Infrastructure.SAP.SapBridge.Utils
{
    public static class Extensions
    {

        /// <summary>
        /// This is an extension method that provides a safe version of ToString
        /// so that if the object is null an empty string is returned 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToStringSafe ( this Object obj )
        {
            return ToStringSafe ( obj, String.Empty );
        }


        // -------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// This is an extension method that provides a safe version of ToString
        /// and allows the caller to specify a default return value so that if the
        /// string is null the return value will be used.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string ToStringSafe ( this object obj, string defaultValue )
        {
            return ( null == obj ) ? ( ( null == defaultValue ) ? String.Empty : defaultValue ) : Convert.ToString ( obj );

        }


        // -------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// This is an extension method that provides a safe version of to string
        /// and allows the caller to specify a default return value so that if the
        /// string is null the return value will be used.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string ToStringSafe ( this String str, string defaultValue )
        {
            return ( String.IsNullOrEmpty ( str ) ) ? ( ( null == defaultValue ) ? String.Empty : defaultValue ) : str;
        }


        // -------------------------------------------------------------------------------------------------------------------------


        public static string SubstringSafe ( this String str, int startIndex, int length )
        {
            if ( !String.IsNullOrEmpty ( str ) && startIndex >= 0 && str.Length >= startIndex + length )
            {
                return str.Substring ( startIndex, length );
            }
            return String.Empty;
        }


        // -------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Generics-based method that extends a String by enabling it 
        /// to return a different string representation corresponding 
        /// to type T specified.
        /// <example>
        /// <![CDATA[ 
        /// String decimalString = "1277,4848";
        /// var returnValue = decimalString.ParseToStringSafe<Decimal> ( "N2" );
        /// returnValue is now "1.277,48"
        /// ]]>
        /// </example>
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ParseToStringSafe<T> ( this String s, string format = "", string defaultValue = "" ) where T : IConvertible
        {

            try
            {

                if ( !String.IsNullOrEmpty ( s ) )
                {
                    if ( String.IsNullOrEmpty ( format ) )
                        return ( ( T ) Convert.ChangeType ( s, typeof ( T ) ) ).ToString ();
                    else
                    {
                        var _t = ( T ) Convert.ChangeType ( s, typeof ( T ) );
                        if ( _t is Decimal )
                            return _t.ToDecimal ( null ).ToString ( format );
                        if ( _t is Int16 )
                            return _t.ToInt16 ( null ).ToString ( format );
                        if ( _t is UInt16 )
                            return _t.ToUInt16 ( null ).ToString ( format );
                        if ( _t is Int32 )
                            return _t.ToInt32 ( null ).ToString ( format );
                        if ( _t is UInt32 )
                            return _t.ToUInt32 ( null ).ToString ( format );
                        if ( _t is Int64 )
                            return _t.ToInt64 ( null ).ToString ( format );
                        if ( _t is UInt64 )
                            return _t.ToUInt64 ( null ).ToString ( format );
                        if ( _t is Double )
                            return _t.ToDouble ( null ).ToString ( format );
                        if ( _t is Single )
                            return _t.ToSingle ( null ).ToString ( format );
                        if ( _t is DateTime )
                            return _t.ToDateTime ( null ).ToString ( format );
                    }
                }
            }
            catch ( Exception ex )
            {
                // if conversion fails, return "", basically because we want this 
                // to not break caller's code
                return s;
            }

            if ( !String.IsNullOrEmpty ( defaultValue ) )
                return defaultValue;
            return "";

        }


        // -------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Tries to parse a string containing a decimal value to another string
        /// with a different format as specified by the second argument.
        /// It's a decimal parsing of strings of sorts.
        /// The value in the string has to be a right decimal value, however.
        /// </summary>
        /// <param name="decValue">String containing the decimal value.</param>
        /// <param name="formatString">Optional parameter containing a format string.</param>
        /// <returns>The successfully parsed string or an empty if the value 
        /// was not a valid decimal value.</returns>
        public static string TryParseAsDecimal ( this string decValue, string formatString = "" )
        {
            var _tempDec = new Decimal ();
            if ( Decimal.TryParse ( decValue, out _tempDec ) )
            {
                if ( !String.IsNullOrWhiteSpace ( formatString ) )
                    return _tempDec.ToString ( formatString );

                return _tempDec.ToString ();
            }
            else
                return string.Empty;
        }


        // -------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Provides a more convenient workaround for converting strings to 
        /// Decimal, without having to do the TryParse every time.
        /// Has an optional parameter to allow the caller to indicate a default value
        /// in case conversion fails. If this value is not indicated, 0.00 is assumed.
        /// </summary>
        /// <param name="decValue">String containing the representation of the value to convert to Decimal.</param>
        /// <param name="defaultValueIfConversionFails">Optional parameter to allow the caller to indicate 
        /// a default value in case conversion fails</param>
        /// <returns></returns>
        public static Decimal ToDecimalSafe ( this string decValue, Decimal defaultValueIfConversionFails = 0.00m )
        {
            var _tempDec = new Decimal ();
            if ( Decimal.TryParse ( decValue, out _tempDec ) )
                return _tempDec;
            else
                return defaultValueIfConversionFails;
        }


        // -------------------------------------------------------------------------------------------------------------------------

    }
}
