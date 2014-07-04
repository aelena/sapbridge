using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using SAP.Middleware.Connector;
using Siemens.Infrastructure.SAP.SapBridge.Configuration;

namespace Siemens.Infrastructure.SAP.SapBridge
{
    class SearchProvider : BaseProvider
    {

        private SapConfigurationSection _config;

        internal IQueryable<R> Search<T, R> ( object searchDataCriteria,
                                              string applicationCode,
                                              string environment,
                                              string bapiName,
                                              string companyCode )
        {

            // get connection values needed to connect to SAP via sap .net connector
            var configurationParameters = this.GetConnectionParameters ( applicationCode, environment, bapiName, companyCode );

           

            return null;
        }


        // ---------------------------------------------------------------------------------------------


        


    }
}
