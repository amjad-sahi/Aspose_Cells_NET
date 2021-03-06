using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.Worksheets.Management
{
    public class AccessingWorksheetsusingSheetName
    {
        public static void Main(string[] args)
        {
            //ExStart:1
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            string InputPath = dataDir + "book1.xlsx";

            //Creating a file stream containing the Excel file to be opened
            FileStream fstream = new FileStream(InputPath, FileMode.Open);

            //Instantiating a Workbook object
            //Opening the Excel file through the file stream
            Workbook workbook = new Workbook(fstream);

            //Accessing a worksheet using its sheet name
            Worksheet worksheet = workbook.Worksheets["Sheet1"];
            Cell cell = worksheet.Cells["A1"];
            Console.WriteLine(cell.Value);
            //Saving the Excel file
           // workbook.Save(dataDir + "output.xlsx");

            //ExEnd:1
        }
    }
}
