using CsvHelper;
using LanguageExt;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CensusAnalyser
{
    //build csv file
    public class CSVBuilder : ICSVBuilder
    {
        /// <summary>
        /// reading census csv file
        /// </summary>
        /// <param name="CSVFilePath"></param>
        /// <returns>List of csv data</returns>
        public List<CensusDAO> LoadCSVData(string CSVFilePath)
        {
            List<CensusDAO> records = new List<CensusDAO>(); 
           
            try
            {
                //using csvHelper to read csv Data and convert into list
                using (var reader = new StreamReader(CSVFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<CensusDAO>().ToList();
                }
                return records;

            }
            catch (FileNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.FILE_NOT_FOUND, "");
            }
            catch (DirectoryNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_CSV_FILE_PATH, "");
            }
            catch (MissingFieldException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_DELIMETER, "");
            }
            catch (HeaderValidationException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, "");
            }
        }
        
         /// <summary>
         /// reading India state csv data
         /// </summary>
         /// <param name="CSVFilePath"></param>
         /// <returns>List of csv data</returns>
        public List<IndiaStateDao> LoadStateCSVData(string CSVFilePath)
        {
            List<IndiaStateDao> records = new List<IndiaStateDao>();
            try
            {
                //using csvHelper to read csv Data and convert into list
                using (var reader = new StreamReader(CSVFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<IndiaStateDao>().ToList();
                }
                return records;
            }
            catch (FileNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.FILE_NOT_FOUND, "");
            }
            catch ( DirectoryNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_CSV_FILE_PATH, "");
            }
            catch (MissingFieldException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_DELIMETER, "");
            }
            catch (HeaderValidationException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, "");
            }
        }

        /// <summary>
        /// Load US census Data
        /// </summary>
        /// <param name="CSVFilePath"></param>
        /// <returns>List of data</returns>
        public List<USCensusdao> LoadUSCensusCSVData(string CSVFilePath)
        {
            List<USCensusdao> records = new List<USCensusdao>();
            try
            {
                //using csvHelper to read csv Data and convert into list
                using (var reader = new StreamReader(CSVFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<USCensusdao>().ToList();
                }
                return records;
            }
            catch (FileNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.FILE_NOT_FOUND, "");
            }
            catch (DirectoryNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_CSV_FILE_PATH, "");
            }
            catch (MissingFieldException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_DELIMETER, "");
            }
            catch (HeaderValidationException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, "");
            }
        }

    }
}
