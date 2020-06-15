using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {
      
        /// <summary>
        /// load india state census data into map
        /// </summary>
        /// <returns>size of dictionary</returns>
        public static int LoadIndiaCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<CensusDAO> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            Dictionary<string, CensusDAO> dictionaryIndianCensus = indianCensusData.ToDictionary(m => m.State);
            return dictionaryIndianCensus.Count;
        }
        
        /// <summary>
        /// load india state census data into map
        /// </summary>
        /// <returns>size of dictionary</returns>
        public static int LoadIndiaStateCode(string indianStateCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<IndiaStateDao> csvDataTable = csvBuilder.LoadStateCSVData(indianStateCensusCSVFilePath);
            Dictionary<string, IndiaStateDao> dicionarytStateCensus = csvDataTable.ToDictionary(x => x.StateCode);
            return dicionarytStateCensus.Count;
        }

        /// <summary>
        /// load US state census data into map
        /// </summary>
        /// <returns>size of dictionary</returns>
        public static int LoadUSCensusData(string USCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<USCensusdao> USCensusData = csvBuilder.LoadUSCensusCSVData(USCensusCSVFilePath);
            Dictionary<string, USCensusdao> USCensusDataDict = USCensusData.ToDictionary(x => x.State);
            return USCensusDataDict.Count;
        }


        /// <summary>
        /// short Indian census Data state wise convert into json
        /// </summary>
        /// <returns>json string</returns>
        public static string GetStateWiseSortedCensusData(string indianCensusCSVFilePath) 
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<CensusDAO> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            List<CensusDAO> sorted = indianCensusData
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
            List<IndiaStateDao> indiaStateCSVData = csvBuilder.LoadStateCSVData(indianStateCensusCSVFilePath);
            List<IndiaStateDao> sorted = indiaStateCSVData
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
            List<CensusDAO> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            List<CensusDAO> sorted = indianCensusData
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
            List<CensusDAO> indianCensusData = csvBuilder.LoadCSVData(indianCensusCSVFilePath);
            List<CensusDAO> sorted = indianCensusData
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
            List<CensusDAO> indianCensusData = csvBuilder.LoadCSVData(india_CENSUS_CSV_FILE_PATH);
            List<CensusDAO> sorted = indianCensusData
                                            .OrderBy(x => x.AreaInSqKm)
                                            .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }
      
        /// <summary>
        /// short US census Data Population wise convert into json string
        /// </summary>
        /// <param name="indianCensusCSVFilePath"></param>
        /// <returns>json string</returns>
        public static string GetPopulationWiseSortedUSCensusData(string usCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<USCensusdao> USCensusData = csvBuilder.LoadUSCensusCSVData(usCensusCSVFilePath);
            List<USCensusdao> sorted = USCensusData
                                          .OrderBy(x => x.Population)
                                          .Reverse()
                                          .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }

        /// <summary>
        /// short US census Data Density Per SqKm wise convert into json string
        /// </summary>
        /// <param name="indianCensusCSVFilePath"></param>
        /// <returns>json string</returns>

        public static string GetPopulationDensityWiseSortedUSCensusData(string uS_CENSUS_CSV_FILE_PATH)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<USCensusdao> USCensusData = csvBuilder.LoadUSCensusCSVData(uS_CENSUS_CSV_FILE_PATH);
            List<USCensusdao> sorted = USCensusData
                                          .OrderBy(x => x.DensityPerSqKm)
                                          .Reverse()
                                          .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;
        }

        /// <summary>
        /// short US census Data Total Area wise convert into json string
        /// </summary>
        /// <param name="indianCensusCSVFilePath"></param>
        /// <returns>json string</returns>
        public static string GetAreaWiseSortedUSCensusData(string uS_CENSUS_CSV_FILE_PATH)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            List<USCensusdao> USCensusData = csvBuilder.LoadUSCensusCSVData(uS_CENSUS_CSV_FILE_PATH);
            List<USCensusdao> sorted = USCensusData
                                          .OrderBy(x => x.TotalArea)
                                          .Reverse()
                                          .ToList();
            string json = JsonConvert.SerializeObject(sorted);
            return json;

        }
    }
}
