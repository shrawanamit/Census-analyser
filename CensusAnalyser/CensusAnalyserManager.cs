using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System.Collections.Generic;
using System.Linq;

namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {
        //loading India census data
        public static int LoadIndiaCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            return indianCensusData.Count;
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
        /// <summary>
        /// short Indian census Data state wise convert into json
        /// </summary>
        /// <param name="indianCensusCSVFilePath"></param>
        /// <returns>json string</returns>
        public static string GetStateWiseSortedCensusData(string indianCensusCSVFilePath) 
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            List<IndiaCensusCSV> sorted = indianCensusData
                                          .OrderBy(x => x.State)
                                          .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }
        /// <summary>
        /// short Indian census Data stateCode wise convert into json
        /// </summary>
        /// <param name="indianStateCensusCSVFilePath"></param>
        /// <returns>json string</returns>
        public static string GetStateCodeWiseSortedCensusData(string indianStateCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaStateCodeCSV> indiaStateCSVData = csvBuilder.LoadStateCSVData(indianStateCensusCSVFilePath);
            List<IndiaStateCodeCSV> sorted = indiaStateCSVData
                                            .OrderBy(x => x.StateCode)
                                            .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }
    }
}
