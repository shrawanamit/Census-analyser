using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    public class IndiaStateCodeCSV
    {
        [Name("StateName")]
        public string StateName { get; set; }
        [Name("StateCode")] 
        public string StateCode { get; set; }
        [Name("TIN")]
        public int Tin { get; set; }
        
    }
}
