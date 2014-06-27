using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.Infrastructure.SAP.SapBridge
{
    public class ServiceProvider
    {

        /// <summary>
        /// Clients will call this method when they want to perform searches against SAP.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <param name="applicationCode">THe short letter code that identifies an application, such as 
        /// MDM, MDMC, GRT, TTT, etc.</param>
        /// <param name="operation">A literal that indicates the operation to perform</param>
        /// <param name="companyCode">An optional company code parameter to find specific operations
        /// defined for specific company codes in the .config file.</param>
        /// <returns></returns>
        public IQueryable<R> PerformSearch<T,R> ( string applicationCode, 
                                                  string environment,
                                                  string operation, 
                                                  string companyCode = "*" )
        {

            var sp = new SearchProvider ();
            return sp.Search<T,R> ( applicationCode, environment, operation, companyCode );

        }

    }
}
