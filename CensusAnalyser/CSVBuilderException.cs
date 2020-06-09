using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    public class CSVBuilderException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_FILE, FILE_NOT_FOUND
        }
        public ExceptionType EType;

        public CSVBuilderException(ExceptionType EType, string message) : base(message)
        {
            this.EType = EType;
        }
    }
}
