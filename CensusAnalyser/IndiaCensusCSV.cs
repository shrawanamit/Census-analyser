using System;

namespace CensusAnalyser
{
    class IndiaCensusCSV
    {
        public string State { get; set; }
        public int Population { get; set; }
        public int AreaInSqKm { get; set; }
        public int DensityPerSqKm { get; set; }

        public IndiaCensusCSV(String state, int population, int areaInSqKm, int densityPerSqKm)
        {
                    this.State = state;
                    this.Population = population;
                    this.AreaInSqKm = areaInSqKm;
                    this.DensityPerSqKm = densityPerSqKm;
        }

        public override string ToString()
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
