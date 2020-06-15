using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    public class IndiaStateDao
    {
        public string StateName;
        public string StateCode;
        /// <summary>
        /// maping india state code csv
        /// </summary>
        /// <param name="indiaStateCodeCSV"></param>
        public IndiaStateDao(IndiaStateCodeCSV indiaStateCodeCSV)
        {
            this.StateName = indiaStateCodeCSV.StateName;
            this.StateCode = indiaStateCodeCSV.StateCode;

        }
    }
}
