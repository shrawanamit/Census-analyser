using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    class IndiaStateCodeCSV
    {
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public int TIN { get; set; }
        

        public IndiaStateCodeCSV(String stateName, String stateCode, int tin)
        {
            this.StateName = stateName;
            this.StateCode = stateCode;
            this.TIN = tin;
            
        }

        public override string ToString()
        {
            return "IndiaStateCodeCSV{" +
                    "stateName='" + StateName + '\'' +
                    ", stateCode='" + StateCode + '\'' +
                    ", tin='" + TIN + '\'' +
                    '}';
        }
       
    }
}
