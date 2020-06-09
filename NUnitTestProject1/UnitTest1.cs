using NUnit.Framework;
using CensusAnalyser;
using System.Data;

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
        //test case 1.1 : cheaking no of records
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
            catch (CensusAnalyzerException e)
            {
                Assert.AreEqual(CensusAnalyzerException.ExceptionType.FILE_NOT_FOUND, e.EType);
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
                Assert.AreEqual(CensusAnalyzerException.ExceptionType.WRONG_CSV_FILE_PATH_TYPE, e.EType);
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
            catch (CensusAnalyzerException e)
            {
                Assert.AreEqual(CensusAnalyzerException.ExceptionType.WRONG_DELIMETER, e.EType);
            }
        }

        //test case 2.1 : cheaking no of records in india state csv
        [Test]
        public void GivenIndianStateCensusCSVFile_ShouldReturn_CorrectNumberOfRecords()
        {
            int indiaStateCSVDataCount = CensusAnalyserManager.LoadIndiaStateCode(India_STATE_CODE_CSV_FILE_PATH);
            Assert.AreEqual(37, indiaStateCSVDataCount);
        }
    }
}