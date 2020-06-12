using CsvHelper;
using LanguageExt;
using LanguageExt.ClassInstances;
using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
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
        public List<IndiaCensusCSV> LoadCSVData(string CSVFilePath)
        {
            List<IndiaCensusCSV> records = new List<IndiaCensusCSV>(); ;
            try
            {
                //using csvHelper to read csv Data and convert into list
                using (var reader = new StreamReader(CSVFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<IndiaCensusCSV>().ToList();
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
            catch (CsvHelper.MissingFieldException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_DELIMETER, "");
            }
            catch (CsvHelper.HeaderValidationException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, "");
            }
        }
        
         /// <summary>
         /// reading India state csv data
         /// </summary>
         /// <param name="CSVFilePath"></param>
         /// <returns>List of csv data</returns>
        public List<IndiaStateCodeCSV> LoadStateCSVData(string CSVFilePath)
        {
            List<IndiaStateCodeCSV> records = new List<IndiaStateCodeCSV>();
            try
            {
                //using csvHelper to read csv Data and convert into list
                using (var reader = new StreamReader(CSVFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<IndiaStateCodeCSV>().ToList();
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
            catch (CsvHelper.MissingFieldException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.WRONG_DELIMETER, "");
            }
            catch (CsvHelper.HeaderValidationException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.INVALID_CENSUS_DATA, "");
            }
        }
      
    }
}
