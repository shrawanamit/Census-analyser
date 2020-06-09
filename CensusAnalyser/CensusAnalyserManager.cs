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
            DataTable csvDataTable = CSVBuilder.LoadCSVData( indianCensusCSVFilePath);
            return csvDataTable.Rows.Count;
        }
        //load india state census data
        public static int LoadIndiaStateCode(string indianStateCensusCSVFilePath)
        {
            DataTable csvDataTable= CSVBuilder.LoadCSVData(indianStateCensusCSVFilePath);
            return csvDataTable.Rows.Count;
        }
    }
}
