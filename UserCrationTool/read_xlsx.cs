using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace UserCrationTool
{
       internal class read_xlsx
       {
            private string file_path;
            private int start_row;
     
            public string[] ColumnData(int _row, int startIndex, string filePath)
            {
                start_row = startIndex-1;
                file_path = filePath;

                string[] data = column_Read(_row);

                return data;
            }
            private string[] column_Read(int col)
            {
                FileInfo existingFile = new FileInfo(file_path);
                string[] result;

                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                int rowCount = worksheet.Dimension.End.Row - start_row;     //get row count
                result = new string[rowCount - start_row];

                try
                {
                    for (int row = (start_row + 1); row <= rowCount; row++)
                    {
                        result[row - (start_row + 1)] = worksheet.Cells[row, col + 1].Value.ToString().Trim();
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
