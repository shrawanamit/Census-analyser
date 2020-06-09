using CsvHelper;
using LanguageExt.ClassInstances;
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
        public int LoadCSVData(string CSVFilePath)
        {
            List<IndiaCensusCSV> records = new List<IndiaCensusCSV>(); ;
            try
            {
                using (var reader = new StreamReader(CSVFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<IndiaCensusCSV>().ToList<IndiaCensusCSV>();
                }
                return records.Count;

            }
            catch (FileNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.FILE_NOT_FOUND, "");
            }
            catch (ArgumentNullException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.EMPTY_FILE, "");
            }
        }
        public int LoadStateCSVData(string CSVFilePath)
        {
            List<IndiaStateCodeCSV> records = new List<IndiaStateCodeCSV>(); ;
            try
            {
                using (var reader = new StreamReader(CSVFilePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<IndiaStateCodeCSV>().ToList<IndiaStateCodeCSV>();
                }
                return records.Count;

            }
            catch (FileNotFoundException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.FILE_NOT_FOUND, "");
            }
            catch (ArgumentNullException)
            {
                throw new CSVBuilderException(CSVBuilderException.ExceptionType.EMPTY_FILE, "");
            }
        }
    }
}
