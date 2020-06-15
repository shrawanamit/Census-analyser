using CsvHelper.Configuration.Attributes;

namespace CensusAnalyser
{
    public class IndiaStateCodeCSV
    {

        [Name("StateName")]
        public string StateName { get; set; }
        [Name("StateCode")]
        public string StateCode { get; set; }
        
    }
}
