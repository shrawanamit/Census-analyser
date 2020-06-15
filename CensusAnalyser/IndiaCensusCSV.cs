using CsvHelper.Configuration.Attributes;
using System;

namespace CensusAnalyser
{
    public class IndiaCensusCSV
    {
        [Name("State")]
        public string State { get; set; }
        [Name("Population")]
        public double Population { get; set; }
        [Name("AreaInSqKm")]
        public double AreaInSqKm { get; set; }
        [Name("DensityPerSqKm")]
        public double DensityPerSqKm { get; set; }

    }
}
