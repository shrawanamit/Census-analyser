using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    public class CSVBuilderException : Exception
    {
        /// <summary>
        /// Declearing custum Exception message
        /// </summary>
        public enum ExceptionType
        {
            EMPTY_FILE, FILE_NOT_FOUND, INVALID_CENSUS_DATA, WRONG_CSV_FILE_PATH, WRONG_CSV_FILE_TYPE,
            WRONG_DELIMETER,WRONG_Header
        }
        public ExceptionType EType;

        public CSVBuilderException(ExceptionType EType, string message) : base(message)
        {
            this.EType = EType;
        }
    }
}
