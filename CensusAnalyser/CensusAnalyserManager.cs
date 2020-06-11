using NPOI.SS.Formula.Functions;
using System.Collections.Generic;

namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {
        //loading India census data
        public static int LoadIndiaCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> csvDataTable = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            return csvDataTable.Count;
        }
        
        /// <summary>
        /// load india state census data
        /// </summary>
        /// <param name="indianStateCensusCSVFilePath"></param>
        /// <returns></returns>
        public static int LoadIndiaStateCode(string indianStateCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaStateCodeCSV> csvDataTable = csvBuilder.LoadStateCSVData(indianStateCensusCSVFilePath);
            return csvDataTable.Count;
        }
        public string GetStateWiseSortedCensusData(string csvFilePath) 
        {

            return null;
        }
    }
}
