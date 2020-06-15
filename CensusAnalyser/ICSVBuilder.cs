using EO.Internal;
using System;
using LanguageExt.ClassInstances;
using System.Collections.Generic;
using NPOI.SS.Formula.Functions;

namespace CensusAnalyser
{
    interface ICSVBuilder
    {
        public List<CensusDAO> LoadCSVData(string CSVFilePath);
        public List<IndiaStateDao> LoadStateCSVData(string CSVFilePath);
        public List<USCensusdao> LoadUSCensusCSVData(string CSVFilePath);

    }
}
