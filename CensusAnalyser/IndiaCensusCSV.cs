using CsvHelper.Configuration.Attributes;
using System;

namespace CensusAnalyser
{
    class IndiaCensusCSV
    {
        [Name("State")]
        public string State { get; set; }
        [Name("Population")]
        public int Population { get; set; }
        [Name("AreaInSqKm")]
        public int AreaInSqKm { get; set; }
        [Name("DensityPerSqKm")]
        public int DensityPerSqKm { get; set; }

    }
}
