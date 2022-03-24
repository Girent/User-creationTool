using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace UserCrationTool
{
       internal class ReadXlsx
       {
        private string file_Path;
            private int start_Row;
     
            public string[] ColumnData(int _column, int startIndex, string filePath)
            {
                start_Row = startIndex;
                file_Path = filePath;

                string[] data = column_Read(_column);

                return data;
            }
            private string[] column_Read(int column)
            {
                FileInfo existingFile = new FileInfo(file_Path);
                string[] result;

                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                int rowCount = worksheet.Dimension.End.Row;     //get row count
                result = new string[rowCount-start_Row];

                try
                {
                    for (int row = (start_Row+1); row <= rowCount; row++)
                    {
                        result[row - (start_Row+1)] = worksheet.Cells[row, column+1].Value.ToString().Trim();
                    }
                }
                catch (Exception ext)
                {
                    Clipboard.SetText(ext.ToString());
                    MessageBox.Show("Incorrect value selected, check data (error copied to clipboard)", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Application.Restart();
                }
            }
            return result;
            }

        }
}
