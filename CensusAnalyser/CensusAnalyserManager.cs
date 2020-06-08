using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.IO;

namespace CensusAnalyser
{
    public class CensusAnalyserManager
    {
        public static DataTable LoadCensusData(string CSVFilePath)
        {
                DataTable csvData = new DataTable();

                try
                {
                    using (TextFieldParser csvReader = new TextFieldParser(CSVFilePath))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }

                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            //Making empty value as null
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                    return csvData;
                }
                catch (FileNotFoundException)
                {
                    throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.FILE_NOT_FOUND, "");
                }
                catch (ArgumentNullException)
                {
                    throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.EMPTY_FILE, "");
                }
        }
    }
}
