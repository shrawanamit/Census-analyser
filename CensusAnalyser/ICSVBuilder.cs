using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CensusAnalyser
{
    interface ICSVBuilder
    {
      public DataTable LoadCSVData( string csvPath);
    }
}
