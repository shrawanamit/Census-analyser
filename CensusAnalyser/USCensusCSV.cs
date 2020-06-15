using CsvHelper.Configuration.Attributes;
using LanguageExt;

namespace CensusAnalyser
{
    public class USCensusCSV
    {

        [Name("State")]
        public string State { get; set; }
        [Name("StateId")]
        public string StateId { get; set; }
        [Name("Population")]
        public double Population{ get; set; }
        [Name("PopulationDensity")]
        public double PopulationDensity{ get; set; }
        [Name("TotalArea")]
        public double TotalArea { get; set; }
    }
}
