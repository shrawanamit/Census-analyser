using NUnit.Framework;
using CensusAnalyser;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Nancy.Json;
using System.Linq;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        public const string India_CENSUS_CSV_FILE_PATH = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCensusData.csv";
        public const string WRONG_CSV_FILE_PATH = @"G:\vs\CensusAnalyser\CensusAnalyser\CensusAnalyserManager\IndiaStateCensusData.csv";
        public const string CENSUS_CSV_FILE_PATH_Wrong_Type = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCensusData.txt";
        public const string CENSUS_CSV_FILE_PATH_Wrong_Delimeter = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCensusDataWrongDelimeter.csv";
        public const string India_STATE_CODE_CSV_FILE_PATH = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCode.csv";
        public const string US_CENSUS_CSV_FILE_PATH = @"G:\vs\CensusAnalyser\NUnitTestProject1\CSVFile\USCensusData.csv";
         
        /// <summary>
        /// count no of record in india census csv
        /// </summary>        
        [Test]
        public void GivenCensusCSVFile_ShouldReturn_CorrectNumberOfRecords()
        {
            int indiaCensusCSVDataCount = CensusAnalyserManager.LoadIndiaCensusData(India_CENSUS_CSV_FILE_PATH);
            Assert.AreEqual(29, indiaCensusCSVDataCount);
        }
        //test case 1.2 : cheaking wrong csv file path
        [Test]
        public void GivenWrongCSVFilePath_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaCensusData(WRONG_CSV_FILE_PATH);
            }
            catch (CSVBuilderException e)
            {
                Assert.AreEqual(CSVBuilderException.ExceptionType.WRONG_CSV_FILE_PATH, e.EType);
            }
        }
        //test case 1.3 : cheaking wrong csv file type
        [Test]
        public void GivenWrongCSVFiletype_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaCensusData(CENSUS_CSV_FILE_PATH_Wrong_Type);
            }
            catch (CensusAnalyzerException e)
            {
                Assert.AreEqual(CensusAnalyzerException.ExceptionType.WRONG_CSV_FILE_TYPE, e.EType);
            }
        }
        //test case 1.4 : cheaking wrong csv file type
        [Test]
        public void GivenWrongCSVWrongDelimeter_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaCensusData(CENSUS_CSV_FILE_PATH_Wrong_Delimeter);
            }
            catch (CSVBuilderException e)
            {
                Assert.AreEqual(CSVBuilderException.ExceptionType.WRONG_DELIMETER, e.EType);
            }

        }
        //test case 1.5 : cheaking wrong header in csv file
        [Test]
        public void GivenWrongCSVWrongHeader_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaCensusData(India_STATE_CODE_CSV_FILE_PATH);
            }
            catch (CSVBuilderException e)
            {
                Assert.AreEqual(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, e.EType);
            }

        }

        //test case 2.1 : cheaking no of records in india state csv
        [Test]
        public void GivenIndianStateCensusCSVFile_ShouldReturn_CorrectNumberOfRecords()
        {
            int indiaStateCSVDataCount = CensusAnalyserManager.LoadIndiaStateCode(India_STATE_CODE_CSV_FILE_PATH);
            Assert.AreEqual(37, indiaStateCSVDataCount);
        }

        //test case 2.2 : wrong csv file path
        [Test]
        public void GivenWrongIndiaStateCSVFilePath_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaStateCode(WRONG_CSV_FILE_PATH);
            }
            catch (CSVBuilderException e)
            {
                Assert.AreEqual(CSVBuilderException.ExceptionType.WRONG_CSV_FILE_PATH, e.EType);
            }
        }
        //test case 2.3 : cheaking wrong csv file type
        [Test]
        public void GivenWrongIndiaStateCSVFiletype_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaStateCode(CENSUS_CSV_FILE_PATH_Wrong_Type);
            }
            catch (CSVBuilderException e)
            {
                Assert.AreEqual(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, e.EType);
            }
           
        }
        //test case 2.4 : cheaking wrong Delimeter in csv file 
        [Test]
        public void GivenWrongIndiaStateCSVWrongDelimeter_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaStateCode(CENSUS_CSV_FILE_PATH_Wrong_Delimeter);
            }
            catch (CSVBuilderException e)
            {
                Assert.AreEqual(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, e.EType);
            }
        }
        /// <summary>
        /// //test case 2.5 : cheaking  header in csv file
        /// </summary>
        [Test]
        public void GivenWrongIndiaStateCSVWrongHeader_ShouldReturn_CustomException()
        {
            try
            {
                int csvDataCount = CensusAnalyserManager.LoadIndiaStateCode(India_CENSUS_CSV_FILE_PATH);
            }
            catch (CSVBuilderException e)
            {
                Assert.AreEqual(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, e.EType);
            }

        }
        /// <summary>
        /// use case 3:sorted indian census csv According to state wise 
        /// </summary>
        [Test]
        public void givenIndianCensusCsv_whenSortedOnState_shouldReturnShortedResult()
        {
            string indiaCensusCSVDataJsonString = CensusAnalyserManager.GetStateWiseSortedCensusData(India_CENSUS_CSV_FILE_PATH);
            List<IndiaCensusCSV> listObject = new JavaScriptSerializer().Deserialize<List<IndiaCensusCSV>>(indiaCensusCSVDataJsonString);
            foreach (IndiaCensusCSV str in listObject)
            {
                Assert.AreEqual("Andhra Pradesh", str.State);
                break;
            }
        }

        ///// <summary>
        ///// use case 4:sorted indian State csv According to state code wise 
        ///// </summary>
        [Test]
        public void GivenIndianStateCensusCsv_whenSortedOnState_shouldReturnShortedResult()
        {
            string indiaStateCensusCSVDataJsonString = CensusAnalyserManager.GetStateCodeWiseSortedCensusData(India_STATE_CODE_CSV_FILE_PATH);
            List<IndiaStateCodeCSV> listObject = new JavaScriptSerializer().Deserialize<List<IndiaStateCodeCSV>>(indiaStateCensusCSVDataJsonString);
            foreach (IndiaStateCodeCSV str in listObject)
            {
                Assert.AreEqual("AD", str.StateCode);
                break;
            }
        }

        ///// <summary>
        ///// use case 5:sorted indian State csv According to Population wise 
        ///// </summary>
        [Test]
        public void GivenIndianStateCensusCsv_whenSortedOnPopulation_shouldReturnShortedResult()
        {
            string indiaCensusCSVDataJsonString = CensusAnalyserManager.GetStateWiseSortedCensusData(India_CENSUS_CSV_FILE_PATH);
            List<IndiaCensusCSV> listObject = new JavaScriptSerializer().Deserialize<List<IndiaCensusCSV>>(indiaCensusCSVDataJsonString);
            foreach (IndiaCensusCSV str in listObject)
            {
                Assert.AreEqual("Andhra Pradesh", str.State);
                break;
            }
        }
        ///// <summary>
        ///// use case 6:sorted indian State csv According to Population wise 
        ///// </summary>
        [Test]
        public void GivenIndianStateCensusCsv_whenSortedOnPopulationDencity_shouldReturnShortedResult()
        {
            string indiaCensusCSVDataJsonString = CensusAnalyserManager.GetPopulaionPerSqKmWiseSortedCensusData(India_CENSUS_CSV_FILE_PATH);
            List<IndiaCensusCSV> listObject = new JavaScriptSerializer().Deserialize<List<IndiaCensusCSV>>(indiaCensusCSVDataJsonString);
            foreach (IndiaCensusCSV str in listObject)
            {
                Assert.AreEqual("Arunachal Pradesh", str.State);
                break;
            }
        }
        ///// <summary>
        ///// use case 6:sorted indian State csv According to Population wise 
        ///// </summary>
        [Test]
        public void GivenIndianStateCensusCsv_whenSortedOnStateArea_shouldReturnShortedResult()
        {
            string indiaCensusCSVDataJsonString = CensusAnalyserManager.GetStateAreaWiseSortedCensusData(India_CENSUS_CSV_FILE_PATH);
            List<IndiaCensusCSV> listObject = new JavaScriptSerializer().Deserialize<List<IndiaCensusCSV>>(indiaCensusCSVDataJsonString);
            foreach (IndiaCensusCSV str in listObject)
            {
                Assert.AreEqual("Goa", str.State);
                break;
            }
        }

        /// <summary>
        /// count no of record in india census csv
        /// </summary>        
        [Test]
        public void GivenUSCensusCSVFile_ShouldReturn_CorrectNumberOfRecords()
        {
            int USCensusCSVDataCount = CensusAnalyserManager.LoadUSCensusData(US_CENSUS_CSV_FILE_PATH);
            Assert.AreEqual(51, USCensusCSVDataCount);
        }
        
    }
}