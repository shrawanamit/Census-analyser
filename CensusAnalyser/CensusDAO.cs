namespace CensusAnalyser
{

    public class CensusDAO
    {
        public string State;
        public double Population;
        public double AreaInSqKm;
        public double DensityPerSqKm;
      

        /// <summary>
        /// maping india census csv data
        /// </summary>
        /// <param name="indiaCensusCSV"></param>
        public CensusDAO(IndiaCensusCSV indiaCensusCSV)
        {
            this.State = indiaCensusCSV.State;
            this.AreaInSqKm = indiaCensusCSV.AreaInSqKm;
            this.DensityPerSqKm = indiaCensusCSV.DensityPerSqKm;
            this.Population = indiaCensusCSV.Population;
        }
    }
}
