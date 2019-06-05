Option Strict Off
Option Explicit On
Friend Class frmCalibrate
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click

        For i As Integer = 1 To 10000
            vPlot1(0, i) = 0.0
            vPlot1(1, i) = 0.0
        Next i
        Me.Close()
        Calibrating = False
    End Sub

    Private Sub cmdRunCalibration_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRunCalibration.Click
        Dim x As Integer

        OpenCalibrateFile()

        If Not WritingToCalFile Then
            Exit Sub
        End If

        WriteCalHeader()

        For x = 0 To 2
            Semaphore = False
            'UPGRADE_WARNING: Couldn't resolve default property of object UseDataset. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            UseDataset = DataSets(x)
            With MSFlexGrid1
                .Row = x + 1
                .RowSel = x + 1
                .Col = 0
                .ColSel = .Cols - 1
                .HighLight = MSFlexGridLib.HighLightSettings.flexHighlightAlways
            End With
            Semaphore = True
            Calibrating = True
            Do While Semaphore
                System.Windows.Forms.Application.DoEvents()
            Loop
            WriteCalData((x))
        Next x

        MSFlexGrid1.HighLight = MSFlexGridLib.HighLightSettings.flexHighlightNever
        xlApp.ActiveWorkbook.Save() 'save the file

        xlApp.Quit()
        'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        xlApp = Nothing

        End

        cmdExit_Click(cmdExit, New System.EventArgs())
    End Sub

    Private Sub frmCalibrate_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim x As Integer
        Dim Count As Integer

        rs.Open("Data", cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)

        With MSFlexGrid1

            .Redraw = False
            .Clear()
            .Row = 0

            .Col = 0
            .set_ColWidth(0, 750)
            .Text = "Data Set"

            .Col = 1
            .set_ColWidth(1, 1200)
            .Text = "Flow"
            .set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)

            .Col = 2
            .set_ColWidth(2, 1200)
            .Text = "Disch Press"
            .set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)

            .Col = 3
            .set_ColWidth(3, 1200)
            .Text = "Suction Press"
            .set_ColAlignment(3, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)

            .Col = 4
            .set_ColWidth(4, 1200)
            .Text = "Temperature"
            .set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)

            'setup the minimum number of rows & add column headers
            .Rows = 2
            .FixedRows = 1
            .Row = 0
            '        For x = 7 To 10
            '            .Col = x - 7 + 1
            '            .Text = rs.Fields(x).Name
            '            .ColData(x - 7 + 1) = rs.Fields(x).Type
            '        Next

            .Rows = rs.RecordCount + 1
            For Count = 1 To rs.RecordCount

                .set_TextMatrix(Count, 0, Count) 'assign line number
                For x = 0 To 3
                    'we use Variant conversion to avoid any possible NULL errors
                    .set_TextMatrix(Count, x + 1, "" & CObj(rs.Fields(x + 7).Value))
                Next
                rs.MoveNext()
            Next

            .Redraw = True
        End With

        rs.MoveFirst()

        For x = 0 To 2
            DataSets(x).Flow = rs.Fields("Flow").Value
            DataSets(x).SuctionPressure = rs.Fields("SuctPress").Value
            DataSets(x).DischargePressure = rs.Fields("DischPress").Value
            DataSets(x).Temperature = rs.Fields("temp").Value
            DataSets(x).SuctionPipeDia = rs.Fields("SuctPipeDia").Value
            DataSets(x).DischargePipeDia = rs.Fields("DischPipeDia").Value
            DataSets(x).SuctionHeight = rs.Fields("SuctHeight").Value
            DataSets(x).DischargeHeight = rs.Fields("DischHeight").Value
            DataSets(x).BarometricPressure = rs.Fields("BaroPress").Value
            DataSets(x).StartingHead = rs.Fields("StartingHead").Value
            DataSets(x).SuctionVelocityHead = rs.Fields("SuctVelHead").Value
            DataSets(x).DischargeVelocityHead = rs.Fields("DischVelHead").Value
            DataSets(x).SpecificVolume = rs.Fields("SpecificVolume").Value
            DataSets(x).VaporPressure = rs.Fields("VaporPress").Value
            DataSets(x).NPSHa = rs.Fields("NPSHa").Value
            DataSets(x).TDH = rs.Fields("TDH").Value
            DataSets(x).PercentHead = rs.Fields("PctHead").Value
            rs.MoveNext()
        Next x

        rs.Close()

        frmPLCData.cmdSaveData.Visible = False
        frmPLCData.cmdStartTest.Visible = False
    End Sub
    Private Sub OpenCalibrateFile()
        'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        Dim MyResult As DialogResult

        OpenFileDialog1.Title = "Open Excel Calibration Files"
        OpenFileDialog1.Filter = "Excel Files |*.xls" 'show Excel files
        OpenFileDialog1.InitialDirectory = sDirectoryName & "\Software Calibration" 'in this directory

        MyResult = OpenFileDialog1.ShowDialog()
        If MyResult = DialogResult.Cancel Then
            MsgBox("Error")
        End If

        If Dir(OpenFileDialog1.FileName) = "" Then 'if the file name does not exist yet
            SaveFileName = OpenFileDialog1.FileName 'get the name of the file
            If Not IsDBNull(xlApp.Workbooks) Then xlApp.Workbooks.Close() 'if there's a workbook open, close it
            ' Create the Excel Workbook Object.
            On Error GoTo 0
            xlBook = xlApp.Workbooks.Add 'add a workbook
            NewWorkBook() 'do some stuff for the new workbook
            xlApp.ActiveWorkbook.SaveAs(Filename:=SaveFileName, FileFormat:=xlApp.XlWindowState.xlNormal) 'save the file
            MsgBox(OpenFileDialog1.FileName & " has been opened for writing.", MsgBoxStyle.OkOnly, "File Opened") 'tell the user that file is open
        Else 'the file name already exists
            SaveFileName = OpenFileDialog1.FileName
            ' Create the Excel Workbook Object.
            If Not IsDBNull(xlApp.Workbooks) Then xlApp.Workbooks.Close() 'if there's a workbook open, close it
            xlBook = xlApp.Workbooks.Open(SaveFileName) 'get the file name selected
            If GetWorksheetTabs() = MsgBoxResult.No Then 'ask the user if he/she wants a new tab.
                MsgBox("File not overwritten.", MsgBoxStyle.OkOnly, "File not Opened")
                Exit Sub
            Else
                MsgBox(OpenFileDialog1.FileName & " has been opened for writing.", MsgBoxStyle.OkOnly, "File Opened")
            End If
        End If

        On Error GoTo 0

        WritingToCalFile = True

        Exit Sub

ErrHandler:
        'User pressed the Cancel button

        WritingToCalFile = False

        Exit Sub

    End Sub
    Public Sub WriteCalHeader()

        'write the header to the file
        With xlApp
            .Range("B1").Select()
            .ActiveCell.FormulaR1C1 = "NPSH Program Calibration"
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.HorizontalAlignment. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.HorizontalAlignment = xlApp.Constants.xlCenter

            .Range("A3").Select()
            .ActiveCell.FormulaR1C1 = "Date - "

            .Range("B3").Select()
            .ActiveCell.FormulaR1C1 = Now

            .Range("A6").Select()
            .ActiveCell.FormulaR1C1 = "Data Set"

            .Range("C6:E6").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.Merge. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.Merge()
            .ActiveCell.FormulaR1C1 = "1"

            .Range("C7").Select()
            .ActiveCell.FormulaR1C1 = "Input"
            .Range("D7").Select()
            .ActiveCell.FormulaR1C1 = "Correct"
            .Range("E7").Select()
            .ActiveCell.FormulaR1C1 = "Calculated"

            .Range("F6:H6").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.Merge. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.Merge()
            .ActiveCell.FormulaR1C1 = "2"

            .Range("F7").Select()
            .ActiveCell.FormulaR1C1 = "Input"
            .Range("G7").Select()
            .ActiveCell.FormulaR1C1 = "Correct"
            .Range("H7").Select()
            .ActiveCell.FormulaR1C1 = "Calculated"

            .Range("I6:K6").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.Merge. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.Merge()
            .ActiveCell.FormulaR1C1 = "3"

            .Range("I7").Select()
            .ActiveCell.FormulaR1C1 = "Input"
            .Range("J7").Select()
            .ActiveCell.FormulaR1C1 = "Correct"
            .Range("K7").Select()
            .ActiveCell.FormulaR1C1 = "Calculated"

            .Range("C6:K7").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.HorizontalAlignment. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.HorizontalAlignment = xlApp.Constants.xlCenter

            .Range("A8").Select()
            .ActiveCell.FormulaR1C1 = "Inputs"
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.Font. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.Font.Bold = True

            .Range("A9").Select()
            .ActiveCell.FormulaR1C1 = "Flow"

            .Range("A10").Select()
            .ActiveCell.FormulaR1C1 = "Suction Pressure"

            .Range("A11").Select()
            .ActiveCell.FormulaR1C1 = "Discharge Pressure"

            .Range("A12").Select()
            .ActiveCell.FormulaR1C1 = "Temperature"

            .Range("A13").Select()
            .ActiveCell.FormulaR1C1 = "Suction Pipe Dia"

            .Range("A14").Select()
            .ActiveCell.FormulaR1C1 = "Discharge Pipe Dia"

            .Range("A15").Select()
            .ActiveCell.FormulaR1C1 = "Suction Gauge Height"

            .Range("A16").Select()
            .ActiveCell.FormulaR1C1 = "Discharge Gauge Height"

            .Range("A17").Select()
            .ActiveCell.FormulaR1C1 = "Barometric Pressure"

            .Range("A18").Select()
            .ActiveCell.FormulaR1C1 = "Starting Head"

            .Range("A20").Select()
            .ActiveCell.FormulaR1C1 = "Calculated Values"
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.Font. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.Font.Bold = True

            .Range("A21").Select()
            .ActiveCell.FormulaR1C1 = "Suction Vel Head"

            .Range("A22").Select()
            .ActiveCell.FormulaR1C1 = "Discharge Vel Head"

            .Range("A23").Select()
            .ActiveCell.FormulaR1C1 = "Specific Volume"

            .Range("A24").Select()
            .ActiveCell.FormulaR1C1 = "Vapor Pressure"

            .Range("A25").Select()
            .ActiveCell.FormulaR1C1 = "NPSHa"

            .Range("A26").Select()
            .ActiveCell.FormulaR1C1 = "TDH"

            .Range("A27").Select()
            .ActiveCell.FormulaR1C1 = "Percent Head"

            .Range("D20").Select()
            .ActiveCell.FormulaR1C1 = "Correct"

            .Range("E20").Select()
            .ActiveCell.FormulaR1C1 = "Calculated"

            .Range("G20").Select()
            .ActiveCell.FormulaR1C1 = "Correct"

            .Range("H20").Select()
            .ActiveCell.FormulaR1C1 = "Calculated"

            .Range("J20").Select()
            .ActiveCell.FormulaR1C1 = "Correct"

            .Range("K20").Select()
            .ActiveCell.FormulaR1C1 = "Calculated"

            .Range("C9:K27").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.NumberFormat. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.NumberFormat = "0.00"

            xlApp.Range("D20:E27").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xlApp.Selection.Borders(xlApp.XlBordersIndex.xlDiagonalDown).LineStyle = xlApp.Constants.xlNone
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xlApp.Selection.Borders(xlApp.XlBordersIndex.xlDiagonalUp).LineStyle = xlApp.Constants.xlNone
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeLeft)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeTop)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeBottom)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeRight)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlInsideVertical)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlInsideHorizontal)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With

            xlApp.Range("G20:H27").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xlApp.Selection.Borders(xlApp.XlBordersIndex.xlDiagonalDown).LineStyle = xlApp.Constants.xlNone
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xlApp.Selection.Borders(xlApp.XlBordersIndex.xlDiagonalUp).LineStyle = xlApp.Constants.xlNone
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeLeft)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeTop)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeBottom)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeRight)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlInsideVertical)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlInsideHorizontal)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With

            xlApp.Range("J20:K27").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xlApp.Selection.Borders(xlApp.XlBordersIndex.xlDiagonalDown).LineStyle = xlApp.Constants.xlNone
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xlApp.Selection.Borders(xlApp.XlBordersIndex.xlDiagonalUp).LineStyle = xlApp.Constants.xlNone
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeLeft)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeTop)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeBottom)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlEdgeRight)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlInsideVertical)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With
            'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.Selection.Borders(xlApp.XlBordersIndex.xlInsideHorizontal)
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .LineStyle = xlApp.XlLineStyle.xlContinuous
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Weight = xlApp.XlBorderWeight.xlThin
                'UPGRADE_WARNING: Couldn't resolve default property of object Selection.Borders. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .ColorIndex = xlApp.Constants.xlAutomatic
            End With

            .Range("B30").Select()
            .ActiveCell.FormulaR1C1 = "For formulas see:"
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.Font. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.Font.Bold = True

            .Range("B31").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object ActiveSheet.Hyperlinks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xlApp.ActiveSheet.Hyperlinks.Add(Anchor:=xlApp.Selection, Address:="\\checpsa\f\EN\GROUPS\SHARED\Calibration and Rundown\NPSH\Software Calibration\Calibration Reference Sheet.xls", TextToDisplay:="Calibration Reference Sheet")


            '        .Range("B31").Select
            '        .ActiveCell.FormulaR1C1 = "directory as this spreadsheet."
            '        .Selection.Font.Bold = True

            'UPGRADE_WARNING: Couldn't resolve default property of object ActiveSheet.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            With xlApp.ActiveSheet.PageSetup
                'UPGRADE_WARNING: Couldn't resolve default property of object ActiveSheet.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Orientation = xlApp.XlPageOrientation.xlLandscape
            End With


        End With
    End Sub
    Public Sub WriteCalData(ByRef DatasetNumber As Integer)
        Dim Col As String = ""
        Dim cell As String = ""

        Select Case DatasetNumber
            Case 0
                Col = "C"
            Case 1
                Col = "F"
            Case 2
                Col = "I"
            Case Else
        End Select

        With xlApp
            For Row As Integer = 9 To 18
                cell = Col & Trim(Str(Row))
                .Range(cell).Select()
                Select Case Row
                    Case Is = 9
                        .ActiveCell.FormulaR1C1 = UseDataset.Flow
                    Case Is = 10
                        .ActiveCell.FormulaR1C1 = UseDataset.SuctionPressure
                    Case Is = 11
                        .ActiveCell.FormulaR1C1 = UseDataset.DischargePressure
                    Case Is = 12
                        .ActiveCell.FormulaR1C1 = UseDataset.Temperature
                    Case Is = 13
                        .ActiveCell.FormulaR1C1 = UseDataset.SuctionPipeDia
                    Case Is = 14
                        .ActiveCell.FormulaR1C1 = UseDataset.DischargePipeDia
                    Case Is = 15
                        .ActiveCell.FormulaR1C1 = UseDataset.SuctionHeight
                    Case Is = 16
                        .ActiveCell.FormulaR1C1 = UseDataset.DischargeHeight
                    Case Is = 17
                        .ActiveCell.FormulaR1C1 = UseDataset.BarometricPressure
                    Case Is = 18
                        .ActiveCell.FormulaR1C1 = UseDataset.StartingHead
                End Select
            Next Row

            Col = Chr(Asc(Col) + 1)
            For Row As Integer = 21 To 27
                cell = Col & Trim(Str(Row))
                .Range(cell).Select()
                Select Case Row
                    Case Is = 21
                        .ActiveCell.FormulaR1C1 = UseDataset.SuctionVelocityHead
                    Case Is = 22
                        .ActiveCell.FormulaR1C1 = UseDataset.DischargeVelocityHead
                    Case Is = 23
                        .ActiveCell.FormulaR1C1 = UseDataset.SpecificVolume
                    Case Is = 24
                        .ActiveCell.FormulaR1C1 = UseDataset.VaporPressure
                    Case Is = 25
                        .ActiveCell.FormulaR1C1 = UseDataset.NPSHa
                    Case Is = 26
                        .ActiveCell.FormulaR1C1 = UseDataset.TDH
                    Case Is = 27
                        .ActiveCell.FormulaR1C1 = UseDataset.PercentHead
                End Select
            Next Row

            Col = Chr(Asc(Col) + 1)
            For Row As Integer = 21 To 27
                cell = Col & Trim(Str(Row))
                .Range(cell).Select()
                Select Case Row
                    Case Is = 21
                        .ActiveCell.FormulaR1C1 = CSng(frmPLCData.txtSuctVelHead.Text)
                    Case Is = 22
                        .ActiveCell.FormulaR1C1 = CSng(frmPLCData.txtDischVelHead.Text)
                    Case Is = 23
                        .ActiveCell.FormulaR1C1 = CSng(frmPLCData.txtSpVol.Text)
                    Case Is = 24
                        .ActiveCell.FormulaR1C1 = CSng(frmPLCData.txtVapPress.Text)
                    Case Is = 25
                        .ActiveCell.FormulaR1C1 = CSng(frmPLCData.txtNPSHa.Text)
                    Case Is = 26
                        .ActiveCell.FormulaR1C1 = CSng(frmPLCData.txtTDH.Text)
                    Case Is = 27
                        .ActiveCell.FormulaR1C1 = CSng(CDbl(frmPLCData.txtTDH.Text) / UseDataset.StartingHead)
                End Select
            Next Row

            .Columns._Default("A:K").Select()
            'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Selection.Columns. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .Selection.Columns.AutoFit()
        End With

    End Sub
End Class