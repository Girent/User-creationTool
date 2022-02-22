using System;
using System.Linq;
using IronXL;

namespace UserCrationTool
{
       public class read_xlsx
       {
            private string _path;
            private int _start;
            public WorkSheet sheet;
        /// <summary>
        /// Pass column range like this"ABCDE...."
        /// </summary>
        /// <param name="_range"></param>
        /// <returns></returns>
        public string[] _Data(string _range, int startIndex, string filePath)
            {
                _start = startIndex;
                _path = filePath;

                string[] data = _read(_range);

                return data;
            }

            /// <summary>
            /// Input column index, return column
            /// </summary>
            /// <param name="readable_column"></param>
            /// <returns></returns>
            private string[] _read(string readable_column)
            {
                WorkBook workbook = WorkBook.Load(_path);
                sheet = workbook.WorkSheets.First();

                string[] result = new string[sheet.Rows.Length - (_start-1)];
                int items = 0;
                //int _end = sheet.Rows.Length - _start;

                foreach (var cell in sheet[readable_column + _start + ":" + readable_column + sheet.Rows.Length])
                {
                    result[items] = cell.Text;
                    items++;
                }
                return result;
            }

        }
}
