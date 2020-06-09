namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {
        //loading India census data
        public static int LoadIndiaCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            int csvDataTable = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            return csvDataTable;
        }
        //load india state census data
        public static int LoadIndiaStateCode(string indianStateCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            int csvDataTable = csvBuilder.LoadStateCSVData(indianStateCensusCSVFilePath);
            return csvDataTable;
        }
    }
}
