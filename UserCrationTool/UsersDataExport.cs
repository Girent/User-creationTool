using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCrationTool
{
    internal class UsersDataExport
    {
        public void addXlsx(List<string[]> ussrList)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Worksheet1");                

                var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];

                string headerRange = "A1:" + Char.ConvertFromUtf32(ussrList[0].Length + 64) + "1";

                var worksheet = excel.Workbook.Worksheets["Worksheet1"];

                worksheet.Cells[headerRange].LoadFromArrays(ussrList);

                FileInfo excelFile = new FileInfo("users.xlsx");

                excel.SaveAs(excelFile);
            }
        }
    }
}
