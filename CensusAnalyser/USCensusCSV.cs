using CsvHelper.Configuration.Attributes;

namespace CensusAnalyser
{
    public class USCensusCSV
    {
        [Name("State")]
        public string State { get; set; }
        [Name("StateId")]
        public string StateId { get; set; }
        [Name("Population")]
        public int Population { get; set; }
        [Name("PopulationDensity")]
        public float PopulationDensity { get; set; }
        [Name("TotalArea")]
        public float totalArea { get; set; }
    }
}
