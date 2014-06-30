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
        /// <param name="environment"></param>
        /// <param name="operation">A literal that indicates the operation to perform</param>
        /// <param name="companyCode">An optional company code parameter to find specific operations
        /// defined for specific company codes in the .config file.</param>
        /// <param name="searchDataCriteria">Represents any object (a DTO basically) that contains
        /// at least the minimum fields needed to perform the search against SAP. Since the number
        /// of fields to be used in search will vary from application to application - or even to
        /// perform different searches within one single application - we need to keep this 
        /// flexible.</param>
        /// <returns></returns>
        public IQueryable<R> PerformSearch<T,R> ( object searchDataCriteria,
                                                  string applicationCode, 
                                                  string environment,
                                                  string operation, 
                                                  string companyCode = "*" )
        {

            var sp = new SearchProvider ();
            return sp.Search<T, R> ( searchDataCriteria, applicationCode, environment, operation, companyCode );

        }

    }
}
