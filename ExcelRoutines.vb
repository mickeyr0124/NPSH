Option Strict Off
Option Explicit On
Imports Microsoft.Office.Interop.Excel
Imports PLCCommLibrary
Imports System.Collections.Generic
Module ExcelRoutines
    Public Declare Function GetComputerName Lib "kernel32" Alias "GetComputerNameA" (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer

    'instantiate new class of plc communications
    Public PLCCm As New PLCCommLibrary.PLCComm

    'declare a list for plcs
    Public PLCList As List(Of PLCComm.PLCStruct) = New List(Of PLCComm.PLCStruct)

    'declare an error list for PCL Comm
    Public ErrorList As List(Of String) = New List(Of String)

    Structure DataSet
        Dim Flow As Single 'input flow
        Dim SuctionPressure As Single 'input suct press
        Dim DischargePressure As Single 'input disch press
        Dim Temperature As Single 'input temp
        Dim SuctionPipeDia As Integer 'input suct pipe dia
        Dim DischargePipeDia As Integer 'input disch pipe dia
        Dim SuctionHeight As Integer 'input suction gage height
        Dim DischargeHeight As Integer 'input disch gage height
        Dim BarometricPressure As Single 'input barometric pressure
        Dim StartingHead As Single 'input starting head
        Dim SuctionVelocityHead As Single 'output suct vel head
        Dim DischargeVelocityHead As Single 'output disch vel head
        Dim SpecificVolume As Single 'output specific vol
        Dim VaporPressure As Single 'output vapor pressure
        Dim NPSHa As Single 'output NPSHa
        Dim TDH As Single 'output TDH
        Dim PercentHead As Single 'output percent head
    End Structure

    Public DataSets(2) As DataSet
    Public UseDataset As DataSet
    Public Calibrating As Boolean 'in the process of calibrating
    Public vPlot1(10000, 1) As Single 'NPSH vs TDH plot
    Public Semaphore As Boolean

    Public Const sDirectoryName As String = "\\checpsa\f\en\groups\shared\Calibration and Rundown\NPSH"
    Public sDataBaseName As String
    Public SaveFileName As String
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Public xlApp As Application ' Excel Application Object
    Public xlBook As Workbook ' Excel Workbook Object

    Public WorkSheetName As String 'Worksheet Tab Name
    Public WritingToCalFile As Boolean


    Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As Single, ByRef Source As Long, ByVal Length As Integer)

    Public Sub NewWorkBook()

        'we've just added a new workbook, delete sheet1, sheet2, etc
        xlApp.DisplayAlerts = False
        While xlApp.Worksheets.Count > 1
            xlApp.Worksheets(1).Delete() 'delete the sheet
        End While
        xlApp.DisplayAlerts = True

        WorkSheetName = InputBox("Enter Title Worksheet Name for this run.") 'get the desired name
        xlApp.Worksheets(1).Name = WorkSheetName 'and name the sheet

    End Sub
    Public Function GetWorksheetTabs() As Object

        'see what worksheet tabs alread exist in the excel worksheet

        Dim intSheets As Integer 'number of sheets in the workbook
        Dim i As Integer
        Dim s As String
        Dim ans As Object
        Dim NameOK As Boolean

        intSheets = xlApp.Worksheets.Count 'how many sheets are there?

        'define a crlf string
        s = vbCrLf

        For i = 1 To intSheets
            s = s & xlApp.Worksheets(i).Name & vbCrLf 'add in the worksheet name
        Next i

        'tell the user the names so far and ask if he/she wants to add another
        ans = MsgBox("You have the following Worksheet Names in " & SaveFileName & ": " & s & "Do you want to add another sheet to this file?", MsgBoxStyle.YesNo, "Sheets in Excel File")

        'get the answer
        If ans = MsgBoxResult.No Then
            GetWorksheetTabs = MsgBoxResult.No 'set up flag for when we return to the calling subroutine
            Exit Function
        End If

        'get worksheet name from user and check to see that it's not already used

        NameOK = False 'start assuming that the name is bad

        While Not NameOK 'as long as it's bad, stay in this loop
            WorkSheetName = InputBox("Enter Worksheet Name for this run.") 'ask for name

            If WorkSheetName = "" Then 'if we get a nul return or user presses cancel
                GetWorksheetTabs = MsgBoxResult.No
                Exit Function
            End If

            For i = 1 To xlApp.Worksheets.Count 'go through all of the existing sheets
                If WorkSheetName = xlApp.Worksheets(i).Name Then 'if the names are the same
                    MsgBox("The name " & WorkSheetName & " already exists for a Worksheet.  Please try again.", MsgBoxStyle.OkOnly, "Bad Worksheet Name") 'tell the user
                    NameOK = False
                    Exit For
                End If
                NameOK = True 'if we make it thru say the name is ok
            Next i
        End While

        xlApp.Worksheets.Add(, xlApp.Worksheets(xlApp.Worksheets.Count)) 'add a worksheer
        xlApp.Worksheets(xlApp.Worksheets.Count).Name = WorkSheetName 'give it the desired name
        GetWorksheetTabs = MsgBoxResult.Yes 'say that the results were ok

    End Function
    Public Function GetMachineName() As String

        Dim plngSize As Integer
        Dim pstrBuffer As String

        pstrBuffer = Space(200)

        plngSize = Len(pstrBuffer)

        If GetComputerName(pstrBuffer, plngSize) Then
            GetMachineName = Left(pstrBuffer, plngSize)
        Else
            GetMachineName = ""
        End If
    End Function
End Module