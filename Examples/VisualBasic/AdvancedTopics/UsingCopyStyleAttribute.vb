Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports System.Data

Namespace Aspose.Cells.Examples.AdvancedTopics
    Public Class UsingCopyStyleAttribute
        Public Shared Sub Main(ByVal args() As String)
            'ExStart:1
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Create Students DataTable
            Dim dtStudent As New DataTable("Student")

            'Define a field in it
            Dim dcName As New DataColumn("Name", GetType(String))
            dtStudent.Columns.Add(dcName)

            'Add three rows to it
            Dim drName1 As DataRow = dtStudent.NewRow()
            Dim drName2 As DataRow = dtStudent.NewRow()
            Dim drName3 As DataRow = dtStudent.NewRow()

            drName1("Name") = "John"
            drName2("Name") = "Jack"
            drName3("Name") = "James"

            dtStudent.Rows.Add(drName1)
            dtStudent.Rows.Add(drName2)
            dtStudent.Rows.Add(drName3)



            Dim filePath As String = dataDir & "TestSmartMarkers.xlsx"

            'Create a workbook from Smart Markers template file
            Dim workbook As New Workbook(filePath)

            'Instantiate a new WorkbookDesigner
            Dim designer As New WorkbookDesigner()

            'Specify the Workbook
            designer.Workbook = workbook

            'Set the Data Source
            designer.SetDataSource(dtStudent)

            'Process the smart markers
            designer.Process()

            'Save the Excel file
            workbook.Save(filePath & dataDir & "_out1.out.xlsx", SaveFormat.Xlsx)
            'ExEnd:1


        End Sub
    End Class
End Namespace