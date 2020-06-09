using EO.Internal;
using System;
using LanguageExt.ClassInstances;

namespace CensusAnalyser
{
    interface ICSVBuilder
    {
        public int LoadCSVData(string CSVFilePath);
        public int LoadStateCSVData(string CSVFilePath);
    }
}
