Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Worksheets.Management
    Public Class RemovingWorksheetsUsingSheetIndex
        Public Shared Sub Main(ByVal args() As String)
            'ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Creating a file stream containing the Excel file to be opened
            Dim fstream As New FileStream(dataDir & "book1.xls", FileMode.Open)

            'Instantiating a Workbook object
            'Opening the Excel file through the file stream
            Dim workbook As New Workbook(fstream)

            'Removing a worksheet using its sheet index
            workbook.Worksheets.RemoveAt(0)

            'Save workbook
            workbook.Save(dataDir & "output.xls")
            'ExEnd:1

        End Sub
    End Class
End Namespace