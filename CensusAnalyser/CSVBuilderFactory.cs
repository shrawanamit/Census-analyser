using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    class CSVBuilderFactory
    {
        public static ICSVBuilder CreateCSVBuilder()
        {
            return new CSVBuilder();
        }
    }
}
