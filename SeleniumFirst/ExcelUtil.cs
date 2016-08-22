using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class ExcelUtil
    {
        public static DataTable ExcelToDataTable(string fileName)
        {
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTableCollection table = result.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;
        }

        public static List<DataCollection> dataCol = new List<DataCollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable Table = ExcelToDataTable(fileName);

            for (int i = 1; i <= Table.Rows.Count; i++)
            {
                for (int j = 0; j < Table.Columns.Count; j++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = i,
                        colName = Table.Columns[j].ColumnName,
                        colValue = Table.Rows[i - 1][j].ToString()

                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }

            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }

    public class DataCollection
    {

        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }

      
    }
}
