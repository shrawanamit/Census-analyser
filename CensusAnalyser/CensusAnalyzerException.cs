using System;
using System.Runtime.Serialization;

namespace CensusAnalyser
{
    [Serializable]
    public class CensusAnalyzerException : Exception
    {
       

        public enum ExceptionType
        {
            WRONG_CSV_FILE_PATH, WRONG_CSV_FILE_TYPE,
            WRONG_DELIMETER, INVALID_CENSUS_DATA
        }
        public ExceptionType EType;

        public CensusAnalyzerException(ExceptionType EType, string message) : base(message)
        {
            this.EType = EType;
        }
    }
}