using System;
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
            /*
            var path = @"D:\ComplianceSpreadsheetTool\W.xlsm";
            var application = (Application)Marshal.GetActiveObject("Excel.Application");
            application.Visible = false;
            try
            {
                application.ActiveWorkbook.Close();
                var workbook = application.Workbooks.Open(path, 0, false, 5, "", "", true, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                var worksheet = workbook.Worksheets.Item[1];
                worksheet.get_Range("E12", "G15").BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick, (XlColorIndex)3, ColorTranslator.ToOle(Color.Black), Type.Missing);
                workbook.Close();
                application.Quit();
            }
            catch (Exception ex)
            {
                //workbook.Close();
                throw;
            }
            */

            string path = @"C:\My Documents\My Projects\Test\Excel\App_Data\W.xlsm"; //@"..\..\App_Data\W.xlsm";
            var excel = (Application)Marshal.GetActiveObject("Excel.Application");
            excel.Visible = false;
            Workbook workbook = excel.Workbooks.Open(path, Missing.Value, false, Missing.Value, Missing.Value, Missing.Value, true, Missing.Value, Missing.Value, true, Missing.Value, Missing.Value, Missing.Value);
            workbook.RefreshAll();
            //var range = workbook.Worksheets["Legal Obligation Register"].Range("E11", "W171");
            //range.Cells.Borders.Color = ColorTranslator.ToOle(Color.Black);
            workbook.Worksheets["Legal Obligation Register"].Range("E11", "W171").Cells.Borders.Color = ColorTranslator.ToOle(Color.Black);
            workbook.Worksheets["Tools"].Range("A6", "F581").Cells.Borders.Color = ColorTranslator.ToOle(Color.Black);
            workbook.Save();
            workbook.Close(true);
            excel.Quit();
        }
    }
}