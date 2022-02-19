using System;
using System.Linq;
using IronXL;

namespace UserCrationTool
{
       public class read_xlsx
       {
            public string _path;
            public int _start, _end;
            public WorkSheet sheet;
            /// <summary>
            /// Передавайте диапазон столбцов таким образом"ABCDE...."
            /// </summary>
            /// <param name="_range"></param>
            /// <returns></returns>
        public string[][] _Data(string _range)
            {
                string[][] data = new string[_range.Length][];

                for (int column = 0; column < _range.Length; column++)
                {
                    data[column] = _read(readable_column:Convert.ToString(_range[column]));

                }
                return data;
            }

            /// <summary>
            /// Input column index, return column
            /// </summary>
            /// <param name="readable_column"></param>
            /// <returns></returns>
            string[] _read(string readable_column)
            {
                WorkBook workbook = WorkBook.Load(_path);
                sheet = workbook.WorkSheets.First();

                _end = (sheet.Rows.Length);
                string[] result = new string[_end];
                int i = 0;

                foreach (var cell in sheet[readable_column + _start + ":" + readable_column + _end])
                {
                    result[i] = cell.Text;
                    i++;
                }
                return result;
            }

        }
}
