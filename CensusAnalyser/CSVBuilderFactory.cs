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
