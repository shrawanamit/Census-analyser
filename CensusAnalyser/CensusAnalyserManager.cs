using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System.Collections.Generic;
using System.Linq;

namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {

        static Dictionary<string, IndiaCensusCSV> dictionaryIndianCensus = new Dictionary<string, IndiaCensusCSV>();
        static Dictionary<string, IndiaStateCodeCSV> dicionarytStateCensus = new Dictionary<string, IndiaStateCodeCSV>();

        /// <summary>
        /// load india state census data into map
        /// </summary>
        /// <returns>size of dictionary</returns>
        public static int LoadIndiaCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            dictionaryIndianCensus = indianCensusData.ToDictionary(x => x.State);
            return dictionaryIndianCensus.Count;
        }
        
        /// <summary>
        /// load india state census data into map
        /// </summary>
        /// <returns>size of dictionary</returns>
        public static int LoadIndiaStateCode(string indianStateCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaStateCodeCSV> csvDataTable = csvBuilder.LoadStateCSVData(indianStateCensusCSVFilePath);
            dicionarytStateCensus = csvDataTable.ToDictionary(x => x.StateName);
            return dicionarytStateCensus.Count;
        }


        /// <summary>
        /// short Indian census Data state wise convert into json
        /// </summary>
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
