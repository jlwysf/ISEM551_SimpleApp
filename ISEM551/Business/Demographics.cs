using System.Collections.Generic;
using System;
using DataAccess;
using Models;
using System.Data;
using System.Linq;

namespace Business
{
    public class Demographics
    {
        public static List<DemographicInformation> GetIndividulDemographicData()
        {
            DemographicInformation IndivDemo = new DemographicInformation();
            var IndivDemoList = new List<DemographicInformation>();

            DataSet dsGetDemographicsReport = new DataSet();
            dsGetDemographicsReport = DADemographicsInformation.GetDemographicsUsingDBWithConfig();

            if (dsGetDemographicsReport.Tables.Count > 0) {
                IndivDemoList = dsGetDemographicsReport.Tables[0].AsEnumerable().Select(m => new DemographicInformation
                {
                    FirstName = Convert.ToString(m["FirstName"]),
                    LastName = Convert.ToString(m["LastName"]),
                    Sex = Convert.ToString(m["Sex"]),
                    Address = Convert.ToString(m["Address"]),
                }).ToList();
            }

            return IndivDemoList;

        }
    

    }
}
