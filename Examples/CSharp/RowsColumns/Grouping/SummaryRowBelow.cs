using System.IO;

using Aspose.Cells;

namespace Aspose.Cells.Examples.RowsColumns.Grouping
{
    public class SummaryRowBelow
    {
        public static void Main(string[] args)
        {
            //ExStart:1
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Workbook workbook = new Workbook(dataDir + "sample.xlsx");
            Worksheet worksheet = workbook.Worksheets[0];

            //Grouping first six rows and first three columns
            worksheet.Cells.GroupRows(0, 5, true);
            worksheet.Cells.GroupColumns(0, 2, true);

            //Setting SummaryRowBelow property to false
            worksheet.Outline.SummaryRowBelow = false;

            //Saving the modified Excel file
            workbook.Save(dataDir + "output.xls");
            //ExEnd:1
        }
    }
}
