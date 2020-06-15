using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    public class USCensusdao
    {
        public double TotalArea;
        public string State;
        public double Population;
        public double DensityPerSqKm;
        
        /// <summary>
        /// maping us census csv
        /// </summary>
        /// <param name="uSCensusCSV"></param>
        public USCensusdao(USCensusCSV uSCensusCSV)
        {

            this.State = uSCensusCSV.State;
            this.Population = uSCensusCSV.Population;
            this.DensityPerSqKm = uSCensusCSV.PopulationDensity;
            this.TotalArea = uSCensusCSV.TotalArea;
        }
    }
}
