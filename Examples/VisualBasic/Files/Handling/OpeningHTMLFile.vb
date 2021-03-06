Imports System.IO

Imports Aspose.Cells
Imports System

Namespace Aspose.Cells.Examples.Files.Handling
    Public Class OpeningHTMLFile
        Public Shared Sub Main(ByVal args() As String)
            'ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)


            Dim filePath As String = dataDir & "Book1.html"

            'Instantiate LoadOptions specified by the LoadFormat.
            Dim loadOptions As New HTMLLoadOptions(LoadFormat.Html)

            'Create a Workbook object and opening the file from its path
            Dim wb As New Workbook(filePath, loadOptions)
            'Save the MHT file
            wb.Save(filePath & "output.xlsx")
            'ExEnd:1


        End Sub
    End Class
End Namespace
