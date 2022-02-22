using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace UserCrationTool
{
       internal class read_xlsx
       {
            private string _path;
            private int _start;
            //public WorkSheet sheet;
     
            public string[] _Data(int _row, int startIndex, string filePath)
            {
                _start = startIndex-1;
                _path = filePath;

                string[] data = _read(_row);

                return data;
            }
            private string[] _read(int col)
            {
                FileInfo existingFile = new FileInfo(_path);
                string[] result;

                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                int rowCount = worksheet.Dimension.End.Row - _start;     //get row count
                result = new string[rowCount - _start];

                try
                {
                    for (int row = (_start + 1); row <= rowCount; row++)
                    {
                        result[row - (_start + 1)] = worksheet.Cells[row, col + 1].Value.ToString().Trim();
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
