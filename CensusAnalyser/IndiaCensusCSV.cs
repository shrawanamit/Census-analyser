using CsvHelper.Configuration.Attributes;
using System;

namespace CensusAnalyser
{
    public class IndiaCensusCSV
    {
        [Name("State")]
        public string State { get; set; }
        [Name("Population")]
        public int Population { get; set; }
        [Name("AreaInSqKm")]
        public int AreaInSqKm { get; set; }
        [Name("DensityPerSqKm")]
        public int DensityPerSqKm { get; set; }

       public
        override string ToString()
        {
            return "IndiaCensusCSV{" +
                    "State='" + State + '\'' +
                    ", Population='" + Population + '\'' +
                    ", AreaInSqKm='" + AreaInSqKm + '\'' +
                    ", DensityPerSqKm='" + DensityPerSqKm + '\'' +
                    '}';
        }

    }
}
