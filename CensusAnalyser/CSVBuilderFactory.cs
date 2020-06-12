namespace CensusAnalyser
{   
    /// <summary>
    /// Creating object of CSVBuilder Class
    /// </summary>
    class CSVBuilderFactory
    {
        public static ICSVBuilder CreateCSVBuilder()
        {
            return new CSVBuilder();
        }
    }
}
