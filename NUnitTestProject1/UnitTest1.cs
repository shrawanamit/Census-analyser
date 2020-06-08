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

        public static string CENSUS_CSV_FILE_PATH = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCensusData.csv";
        public static string WRONG_CSV_FILE_PATH = @"G:\vs\CensusAnalyser\CensusAnalyser\CensusAnalyserManager\IndiaStateCensusData.csv";
        public static string CENSUS_CSV_FILE_PATH_Wrong_Type = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCensusData.txt";
        public static string CENSUS_CSV_FILE_PATH_Wrong_Delimeter = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCensusDataWrongDelimeter.csv";

        //test case 1.1 : cheaking no of records
        [Test]
        public void GivenCensusCSVFile_ShouldReturn_CorrectNumberOfRecords()
        {
            DataTable csvData = CensusAnalyserManager.LoadCensusData(CENSUS_CSV_FILE_PATH);
            Assert.AreEqual(29, csvData.Rows.Count);
        }
        //test case 1.2 : cheaking wrong csv file path
        [Test]
        public void GivenWrongCSVFilePath_ShouldReturn_CustomException()
        {
            try
            {
                DataTable csvData = CensusAnalyserManager.LoadCensusData(WRONG_CSV_FILE_PATH);
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
                DataTable csvData = CensusAnalyserManager.LoadCensusData(CENSUS_CSV_FILE_PATH_Wrong_Type);
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
                DataTable csvData = CensusAnalyserManager.LoadCensusData(CENSUS_CSV_FILE_PATH_Wrong_Delimeter);
            }
            catch (CensusAnalyzerException e)
            {
                Assert.AreEqual(CensusAnalyzerException.ExceptionType.WRONG_DELIMETER, e.EType);
            }
        }

    }
}