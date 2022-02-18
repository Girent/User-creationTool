using System;
using System.Linq;
using IronXL;

namespace UserCrationTool
{
       public class read_xlsx
       {
            public string _path;
            public int _start, _end;

            public string[][] _Data(string _range)
            {
                string[][] data = new string[_range.Length][];

                for (int column = 0; column < _range.Length; column++)
                {
                    data[column] = _read(Convert.ToString(_range[column]));

                }
                return data;
            }

            /// <summary>
            /// Input column index, return column
            /// </summary>
            /// <param name="column"></param>
            /// <returns></returns>
            string[] _read(string column)
            {
                WorkBook workbook = WorkBook.Load(_path);
                WorkSheet sheet = workbook.WorkSheets.First();

                string[] result = new string[_end - _start];
                int i = 0;

                foreach (var cell in sheet[column + _start + ":" + column + _end])
                {
                    result[i] = cell.Text;
                    i++;
                }
                return result;
            }

        }
}
