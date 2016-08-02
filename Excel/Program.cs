using System;
using System.Drawing;
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

            string txtLocation = @"D:\ComplianceSpreadsheetTool\W - Copy.xlsm";

            object _missingValue = System.Reflection.Missing.Value;
            var excel = (Application)Marshal.GetActiveObject("Excel.Application");
            excel.Visible = false;

            Workbook theWorkbook = excel.Workbooks.Open(txtLocation, _missingValue, false, _missingValue, _missingValue, _missingValue, true, _missingValue, _missingValue, true, _missingValue, _missingValue, _missingValue);
            theWorkbook.RefreshAll();
            theWorkbook.Worksheets[1].Range("E11", "W15").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, ColorTranslator.ToOle(Color.Black), Type.Missing);
            theWorkbook.Save();
            theWorkbook.Close(true);
            excel.Quit();
        }
    }
}