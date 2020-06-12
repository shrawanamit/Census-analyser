using EO.Internal;
using System;
using LanguageExt.ClassInstances;
using System.Collections.Generic;
using NPOI.SS.Formula.Functions;

namespace CensusAnalyser
{
    interface ICSVBuilder
    {
        public List<IndiaCensusCSV> LoadCSVData(string CSVFilePath);
       
        public List<IndiaStateCodeCSV> LoadStateCSVData(string CSVFilePath);
        public List<USCensusCSV> LoadUSCensusCSVData(string CSVFilePath);

    }
}
