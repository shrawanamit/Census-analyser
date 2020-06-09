using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.IO;

namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {
        //loading India census data
        public static int LoadIndiaCensusData(string indianCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            DataTable csvDataTable = csvBuilder.LoadCSVData( indianCensusCSVFilePath);
            return csvDataTable.Rows.Count;
        }
        //load india state census data
        public static int LoadIndiaStateCode(string indianStateCensusCSVFilePath)
        {
            ICSVBuilder csvBuilder = CSVBuilderFactory.CreateCSVBuilder();
            DataTable csvDataTable= csvBuilder.LoadCSVData(indianStateCensusCSVFilePath);
            return csvDataTable.Rows.Count;
        }
    }
}
