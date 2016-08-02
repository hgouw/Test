using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Excel
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\My Documents\My Projects\Test\Excel\App_Data\W.xlsm";
            var excel = (Application)Marshal.GetActiveObject("Excel.Application");
            excel.Visible = false;
            Workbook workbook = excel.Workbooks.Open(path, Missing.Value, false, Missing.Value, Missing.Value, Missing.Value, true, Missing.Value, Missing.Value, true, Missing.Value, Missing.Value, Missing.Value);
            workbook.RefreshAll();
            workbook.Worksheets["Legal Obligation Register"].Range("E11", "W171").Cells.Borders.Color = ColorTranslator.ToOle(Color.Black);
            workbook.Worksheets["Tools"].Range("A6", "F581").Cells.Borders.Color = ColorTranslator.ToOle(Color.Black);
            workbook.Save();
            workbook.Close(true);
            excel.Quit();
        }
    }
}