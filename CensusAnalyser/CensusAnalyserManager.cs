using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {

        static Dictionary<string, IndiaCensusCSV> dictionaryIndianCensus = new Dictionary<string,IndiaCensusCSV>();
        static Dictionary<string, IndiaStateCodeCSV> dicionarytStateCensus = new Dictionary<string, IndiaStateCodeCSV>();

        /// <summary>
        /// load india state census data into map
        /// </summary>
        /// <returns>size of dictionary</returns>
        public static int LoadIndiaCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            Dictionary<string, IndiaCensusCSV> dictionaryIndianCensus = indianCensusData.ToDictionary(m => m.State);
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
        /// short Indian State census Data stateCode wise convert into json
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
        /// <summary>
        /// short Indian census Data Population wise convert into json string
        /// </summary>
        /// <param name="indianCensusCSVFilePath"></param>
        /// <returns>json string</returns>
        public static string GetPopulationWiseSortedCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            List<IndiaCensusCSV> sorted = indianCensusData
                                          .OrderBy(x => x.Population)
                                          .Reverse()
                                          .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }

        /// <summary>
        /// short Indian State census Data Population per sq kilometer wise convert into json
        /// </summary>
        /// <returns>json string</returns>
        public static string GetPopulaionPerSqKmWiseSortedCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            List<IndiaCensusCSV> sorted = indianCensusData
                                            .OrderBy(x => x.DensityPerSqKm)
                                            .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }
        /// <summary>
        /// short Indian State census Data According to Area of state wise convert into json
        /// </summary>
        /// <returns>json string</returns>
        public static string GetStateAreaWiseSortedCensusData(string india_CENSUS_CSV_FILE_PATH)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaCensusCSV> indianCensusData = csvBuilder.LoadCSVData(india_CENSUS_CSV_FILE_PATH);
            List<IndiaCensusCSV> sorted = indianCensusData
                                            .OrderBy(x => x.AreaInSqKm)
                                            .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }
        public static int LoadUSCensusData(string USCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<USCensusCSV> USCensusData = csvBuilder.LoadUSCensusCSVData(USCensusCSVFilePath);
            Dictionary<string, USCensusCSV> USCensusDataDict = USCensusData.ToDictionary(m => m.State);
            return USCensusDataDict.Count;
        }
    }
}
