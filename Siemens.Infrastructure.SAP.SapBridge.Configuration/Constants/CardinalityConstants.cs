using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.Infrastructure.SAP.SapBridge.Configuration.Constants
{

    /// <summary>
    /// This class holds a constants indicating different
    /// values for instance cardinalities.
    /// There can be several cardinalities expressed by
    /// the values
    ///
    /// 0-1 - zero or one element max, meaning an optional mapping
    /// 1   - mandatory and exactly only one instance
    /// 0-n - zero or 1 or several instances
    /// 1-n - at least one instance of the mapping to be sent to SAP
    /// 
    /// </summary>
    public sealed class CardinalityConstants
    {
        /// <summary>
        /// 0-1 - zero or one element max, meaning an optional element
        /// </summary>
        public const string ZeroOrOne = "0-1";
        /// <summary>
        /// 1   - mandatory and exactly only one instance
        /// </summary>
        public const string ExactlyOne = "1";
        /// <summary>
        /// 0-n - zero or 1 or several instances
        /// </summary>
        public const string ZeroOrN = "0-n";
        /// <summary>
        /// 1-n - at least one instance of the mapping to be sent to SAP
        /// </summary>
        public const string OneOrN = "1-n";
    }
}
