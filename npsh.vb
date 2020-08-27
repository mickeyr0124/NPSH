Option Strict Off
Option Explicit On
'Imports VB = Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel
'Imports Microsoft.VisualBasic.PowerPacks
'Imports System
'Imports System.IO
'Imports System.Reflection
Friend Class frmPLCData
    Inherits System.Windows.Forms.Form
    '   version 1.6.0 - MHR - 11/23/05
    '   added software calibration
    '   removed using excel sheet for arrays and used database
    '   changed save directory to server

    '   version 1.6.1 - MHR - 1/4/06
    '   Changed Excel sheet setup
    '   added call to cmdExit_click on form unload to make sure excel gets closed

    '   version 1.6.2 - MHR - 1/11/06
    '   added note to spreadsheet to see formulas in Calibration Reference Sheet.xls
    '   changed vapor pressure / specific volume lookup to start at 32 F

    '   version 1.6.3 - MHR - 1/31/06
    '   changed sign in TDH equation from + to - in front of txtSuctionHeight
    '   fixed database for correct NPSH and renamed to NPSHCalibrateData

    '   version 1.6.4 - MHR - 2/6/06
    '   added val() to gauge suction height in NPHS and TDH calcs to prevent errors

    '   version 1.6.5 - MHR - 3/15/06
    '   saved plot data before showing excel

    '   version 1.6.6 - MHR - 6/7/06
    '   added ability to run without flow meter with a constant entered flow

    '   version 1.6.7 - MHR - 6/13/06
    '   added discharge pressure can be gauge or absolute

    '   version 1.6.8 - MHR - 10/03/06
    '   Added trap on 0 flow to ask if user wants to use constant flow box
    '   made THD, NPSH, and Delta suction boxes bigger

    '   version 1.6.9 MHR - 10/9/06
    '   display value of discharge pressure and suction pressure in PSIA

    '   version 1.7.0 - MHR - 12/21/06
    '   used pipe diameter and vapor pressure from rundown database
    '   fixed analog input and thermocouple data retreival and display

    '   version 1.7.1 - MHR - 5/14/07
    '   changed vapor pressure and specific volume back to based on
    '   40 degrees

    '   version 1.7.2 - MHR - 5/23/11
    '   Changed fixed \\checpsa to getting server name from c:\server.txt
    '   changes using network scan for plcs to using addresses like rundown software

    '   versionn1.7.3 - MHR - 4/30/12
    '   Point to plcaddresses.txt instead of addresses.txt

    '   version 1.7.4 - MHR - 5/8/13
    '   Added local debugging if MROSE computer
    '   Added End after calibrate
    '   Added get password to calibrate

    '   version 1.7.5 - MHR - 7/26/18
    '   Added ActiveWorkbook.CheckCompatibility = False before saves
    '   removed plots of suction, etc.
    '   removed component works controls: light and chart

    '   version - 1.7.6 - MHR
    '   fixed charts to insert clear chart instead of one with old data
    '   changed live chart to black background and green trace

    '   version 2.0.0 - MHR
    '   converted to vb.net

    '   version 2.0.1 - MHR - 12/5/18
    '   general cleanup 

    '   version 2.0.2 - MHR - 5/20/20
    '   allow for previous excel file data as inputs for testing
    '   embed chart in worksheet instead of separate chart sheet
    '   use template for new sheet located on server in Databases directory
    '   substituted formula for %head = TDH / Starting TDH
    '   added NPSHr numbers on each worksheet
    '   added pump data retrieve from PumpData database and show on fromt panel

    'variables
    Private IsInitializing As Boolean
    Dim WritingToFile As Boolean 'a file has been chosen to write to
    Dim NominalPipeDiameter() As Single 'array of nominal pipe diameters
    Dim ActualPipeDiameter() As Single 'array of actual pipe diameters
    Dim VaporPressure() As Single 'array of vapor pressure vs temperature
    Dim SpecificVolume() As Single 'array of specific volume vs temperature
    Dim SuctVelHead As Single 'suction velocity head
    Dim DischVelHead As Single 'discharge velocity head
    Dim VaporPress As Single 'vapor pressure at current temperature
    Dim SpecVolume As Single 'specific volume at current temperature
    Dim SuctionPSIA As Single 'suction presure converted to absolute
    Dim DischargePSIA As Single 'discharge pressure converted to absolute
    Dim NPSHa As Single 'calculated NPSH
    Dim TDH As Single 'calculated TDH
    Dim AveNPSHa As Single 'Average of last 5 NPSH values
    Dim PctHead As Single 'Percentage of TDH at start of test
    Dim TestStarted As Boolean 'Test started flag
    Dim FlowForCalcs As Single 'Flow at start of test used for calculations
    Dim ExcelRow As Integer 'Row at which we are writing
    Dim FoundPLC As Boolean 'Communicating with a PLC
    Dim FirstRun As Boolean 'First time that we calc data
    Dim DeltaSuctionPressure As Single 'Average change in suction pressure over the last 5 secs

    Dim inputExcelProcessid As Integer = 0
    Dim outputExcelProcessID As Integer = 0
    Dim inputFileName As String = String.Empty
    Dim inputWorkbook As Workbook
    Dim xlInputApp As Application

    Structure InputData     'structure for input data from excel sheet
        Dim Flow As Single
        Dim SuctPress As Single
        Dim DischPress As Single
        Dim Temp As Single
        Dim ValvePosition As Integer
    End Structure

    Structure PumpData
        Dim SerialNumber As String
        Dim SuctGaugeHeight As String
        Dim DischGaugeHeight As String
        Dim SuctPipeDia As String
        Dim DischPipeDia As String
        Dim StartingFlow As String
        Dim StartingTDH As String
        Dim BP As String
    End Structure
    Dim pd As PumpData

    Dim lstExcelInput As List(Of InputData) 'list of inputdata structure
    Dim rowExcelInput As Integer    'current row
    Dim blnListDone As Boolean = True        'we're done inputting the list of structures
    Dim blnUsingExcelInput As Boolean = False

    Dim Debugging As Integer

    'Server Name Text File
    Const sServerNameTextFile As String = "C:\Server.txt"

    'used to see if dde server is running yet
    ' Private Declare Function FindWindow Lib "USER32" Alias "FindWindowA" (ByVal lpszClassName As String, ByVal lpszWindow As String) As Integer

    Private Sub chkConstantFlow_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkConstantFlow.CheckStateChanged
        If IsInitializing Then
            Exit Sub
        End If
        If chkConstantFlow.CheckState = 1 Then
            txtConstantFlow.Visible = True
            lblConstantFlow.Visible = True
            ' MsgBox "Pete, you better hold that flow constant. OK?"
        Else
            txtConstantFlow.Visible = False
            lblConstantFlow.Visible = False
        End If
    End Sub

    Private Sub cmbDisch_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDisch.SelectedIndexChanged
        If IsInitializing Then
            Exit Sub
        End If
        If cmbDisch.SelectedIndex <> -1 Then 'if there is a discharge diameter chosen, make the background white
            cmbDisch.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        End If
    End Sub

    Private Sub getExcelInputData()
        With OpenFileDialog2
            .CheckFileExists = True
            .Filter = "Excel Files|*.xls;*.xlsx"
            .InitialDirectory = "\\tei-main-01\F\EN\GROUPS\SHARED\Calibration and Rundown\NPSH\"
            Dim result As DialogResult = .ShowDialog
            If result = DialogResult.OK Then
                rowExcelInput = 12  'starting row for data
                lstExcelInput = New List(Of InputData)
                blnListDone = False
                inputFileName = .FileName
            Else
                blnUsingExcelInput = False
                Exit Sub
            End If
        End With

        xlInputApp = New Application
        Dim xlProc = Process.GetProcessesByName("Excel")
        inputExcelProcessid = xlProc(0).id

        'open the excel file and read data into list

        inputWorkbook = xlInputApp.Workbooks.Open(inputFileName)
        ' get the worksheet tab names

        ListBox1.Visible = True
        lblListBox.Visible = True
        ListBox1.Items.Clear()

        For Each w As Worksheet In xlInputApp.Worksheets
            w.Activate()
            ListBox1.Items.Add(w.Name & " -- Number of Rows = " & (w.UsedRange.Rows.Count - 11).ToString)
        Next


    End Sub
    Private Sub cmbPLCLoop_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbPLCLoop.SelectedIndexChanged

        If IsInitializing Then
            Exit Sub
        End If

        'Change the PLC that we're looking at


        'see if it's excel sheet
        If cmbPLCLoop.SelectedItem = "Use Excel Sheet" Then
            'get excel sheet and read columns into list
            'need globals:
            '   lstExcelInput
            '   rowExcelInput
            '   blnListDone
            'maybe want to show number of readings for each tab?
            '    lstExcelInput
            'in tmrgetdde, read out from list into values
            getExcelInputData()
        End If


        For Each p As PLCCommLibrary.PLCComm.PLCStruct In PLCList
            If cmbPLCLoop.SelectedItem = p.PLCName Then
                PLCCm.tDevice = Val(p.PLCDeviceNo)
                Exit For
            End If
        Next


        PLCCm.Connect(ErrorList)
        'write the ave to the plcs

        'PLCCm.WriteData("5000", 2, "1234", ErrorList)
        ' PLCCm.WriteData("1544", 2, Format(ave, "0000"), ErrorList)

        If chkConstantFlow.CheckState = 0 Then
            txtFlow.Text = CStr(PLCCm.ConvertToReal("4050"))
        Else
            txtFlow.Text = CStr(Val(txtConstantFlow.Text))
        End If
        txtSuction.Text = CStr(PLCCm.ConvertToReal("4052") / 10)
        txtDischarge.Text = CStr(PLCCm.ConvertToReal("4054"))
        txtTemperature.Text = CStr(PLCCm.ConvertToReal("4056"))
        '
        '    'the following data are not type real
        txtValvePosition.Text = CStr(PLCCm.ConvertToLong("2004"))
        Me.txtTC1.Text = CStr(PLCCm.ConvertToLong("2200") / 10)
        Me.txtTC2.Text = CStr(PLCCm.ConvertToLong("2202") / 10)
        Me.txtTC3.Text = CStr(PLCCm.ConvertToLong("2204") / 10)
        Me.txtTC4.Text = CStr(PLCCm.ConvertToLong("2206") / 10)

        Me.txtAI1.Text = CStr(PLCCm.ConvertToReal("4060"))
        Me.txtAI2.Text = CStr(PLCCm.ConvertToReal("4062"))
        Me.txtAI3.Text = CStr(PLCCm.ConvertToReal("4064"))
        Me.txtAI4.Text = CStr(PLCCm.ConvertToReal("4066"))

        Me.txtInHg.Text = CStr(PLCCm.ConvertToLong("1460"))

    End Sub

    Private Sub cmbSuction_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSuction.SelectedIndexChanged
        If IsInitializing Then
            Exit Sub
        End If
        If cmbSuction.SelectedIndex <> -1 Then 'if there is a suction diameter chosen, make the background white
            cmbSuction.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        End If
    End Sub

    Private Sub cmdCalibrate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalibrate.Click
        'frmLogin.Show()

        '    ans = MsgBox("You have selected to calibrate the software.  Do you want to continue?", vbYesNo, "Calibrate Software")
        '    If ans = vbNo Then
        '        Calibrating = False
        '        Exit Sub
        '    Else
        '        CalibrateSoftware
        '    End If
        '    If Calibrating Then
        '        CalibrateSoftware
        '    Else
        '        Exit Sub
        '    End If
    End Sub

    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
        ' Close 
        Try
            xlApp.Quit()
        Catch ex As Exception

        End Try

        'kill excel input process 

        Dim xlProc = Process.GetProcessesByName("Excel")
        For Each p As Process In xlProc
            p.Kill()
        Next
        xlApp = Nothing
        End ' we're finished, exit
    End Sub

    Private Sub cmdSaveData_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSaveData.Click
        Dim Answer As Object

        If cmdSaveData.Text = "Save Data" Then

            ' Create the Excel App Object so we can store our data
            xlApp = CreateObject("Excel.Application")
            Dim xlProc = Process.GetProcessesByName("Excel")
            outputExcelProcessID = xlProc(0).id

            Dim MyResult As DialogResult

            'set up dialog box
            OpenFileDialog1.Title = "Open Excel Files"
            OpenFileDialog1.Filter = "Excel Files |*.xls*" 'show Excel files
            OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'in this directory
            OpenFileDialog1.CheckFileExists = False

            MyResult = OpenFileDialog1.ShowDialog()
            If MyResult = DialogResult.Cancel Or OpenFileDialog1.FileName = "" Then
                'MsgBox("Error")
                Exit Sub
            End If

            cmdSaveData.Visible = False 'hide the Save Data button
            cmdSaveData.Text = "Close File" 'change what the button says

            If Dir(OpenFileDialog1.FileName) = "" Then 'if the file name does not exist yet
                SaveFileName = OpenFileDialog1.FileName 'get the name of the file
                If Not IsDBNull(xlApp.Workbooks) Then xlApp.Workbooks.Close() 'if there's a workbook open, close it
                ' Create the Excel Workbook Object.
                On Error GoTo 0
                xlBook = xlApp.Workbooks.Add 'add a workbook
                NewWorkBook(SaveFileName) 'do some stuff for the new workbook
                xlApp.ActiveWorkbook.CheckCompatibility = False
                'xlApp.ActiveWorkbook.SaveAs(Filename:=SaveFileName, FileFormat:=XlWindowState.xlNormal) 'save the file
                MsgBox(OpenFileDialog1.FileName & " has been opened for writing.", MsgBoxStyle.OkOnly, "File Opened") 'tell the user that file is open
            Else 'the file name already exists
                SaveFileName = OpenFileDialog1.FileName
                ' Create the Excel Workbook Object.
                If Not IsDBNull(xlApp.Workbooks) Then xlApp.Workbooks.Close() 'if there's a workbook open, close it
                xlBook = xlApp.Workbooks.Open(SaveFileName) 'get the file name selected
                If GetWorksheetTabs() = MsgBoxResult.No Then 'ask the user if he/she wants a new tab.
                    MsgBox("File not overwritten.", MsgBoxStyle.OkOnly, "File not Opened")
                    cmdSaveData.Text = "Save Data" 'change what the button says
                    txtFileName.Text = "No File Open"
                    cmdSaveData.Visible = True 'show the button
                    Exit Sub
                Else
                    MsgBox(OpenFileDialog1.FileName & " has been opened for writing.", MsgBoxStyle.OkOnly, "File Opened")
                End If
            End If
            txtFileName.Text = "Excel File = " & SaveFileName & vbCrLf & "Worksheet Name = " & WorkSheetName & vbCrLf & "Ready to Write Data. . ." 'tell the user
            WritingToFile = True 'set the flag
            If TestStarted Then 'if we already started the test
                WriteHeader() 'write the header data to the file
            End If
        Else 'we are already writing to the file, and the user wants to close it
            cmdSaveData.Text = "Save Data" 'change what the button says
            cmdSaveData.Visible = True 'show it
            txtFileName.Text = "Excel File = " & SaveFileName & vbCrLf & "Worksheet Name = " & WorkSheetName & vbCrLf & "File Closed" 'tell the user
            WritingToFile = False 'clear the flag
            PlotGraph() 'plot the graph
            MakeSummary()

            xlApp.ActiveWorkbook.CheckCompatibility = False
            xlApp.ActiveWorkbook.Save() 'save the workbook
            xlApp.Visible = True 'show the sheet

        End If

        On Error GoTo 0

        Exit Sub

ErrHandler:
        'User pressed the Cancel button
        WritingToFile = False 'make sure the flag is cleared
        txtFileName.Text = "" 'no file name
        cmdSaveData.Text = "Save Data" 'change what the button says
        cmdSaveData.Visible = True
        txtFileName.Text = "No File Open"
        Exit Sub

    End Sub

    Private Sub cmdStartTest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStartTest.Click

        Dim i As Integer
        Dim ans As Integer
        Dim problem As Boolean 'flag for if the user filled in all of the required fields

        cmdCalibrate.Visible = False

        If CDbl(txtFlow.Text) = 0 And cmdStartTest.Text = "Start Test" Then
            ans = MsgBox("The flow is 0, do you want to use the Constant Flow Box?", MsgBoxStyle.YesNo, "Flow is 0")
            If ans = MsgBoxResult.Yes Then
                chkConstantFlow.CheckState = System.Windows.Forms.CheckState.Checked
                Exit Sub
            End If
        End If

        If cmdStartTest.Text = "Stop Test" Then
            cmdStartTest.Text = "Start Test" 'change the caption
            cmdSaveData_Click(cmdSaveData, New System.EventArgs()) 'save the data
            TestStarted = False
            txtFlowForCalcs.Text = ""
            txtAveTDH.Text = ""
            txtPctHead.Text = ""
            txtFileName.Text = "No File Open"
            txtFlowDisplay.BackColor = System.Drawing.Color.White
            txtDeltaSuctionPressure.BackColor = System.Drawing.Color.White
            Exit Sub
        Else
            cmdStartTest.Text = "Stop Test"
        End If


        'if we are starting test

        For i = 0 To 9999 'initialize the plot with the
            vPlot1(i, 0) = NPSHa 'current calculated data
            vPlot1(i, 1) = TDH
        Next i

        rowExcelInput = 0

        problem = False 'did the user fill all of the fields required?

        If cmbSuction.SelectedIndex = -1 Then 'if he didn't choose a suction diameter
            cmbSuction.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF) '  make the dropdown red
            problem = True ' and say we have a problem
        Else
            cmbSuction.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF) 'else, clear the background
        End If

        If cmbDisch.SelectedIndex = -1 Then 'if he didn't choose a discharge diameter
            cmbDisch.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF) '  make the dropdown red
            problem = True '  and say we have a problem
        Else
            cmbDisch.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF) 'else, clear the background
        End If

        If txtSN.Text = "" Then 'if there is no serial number
            txtSN.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF) '  make the background red
            problem = True '  and say we have a problem
        Else
            txtSN.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF) 'else, clear the background
        End If

        If problem Then 'if the fields are missing
            MsgBox("Test not started.  Select / Fill in the fields that are highlighted.", MsgBoxStyle.OkOnly, "Data Missing") 'tell the user
            cmdStartTest.Text = "Start Test"
            Exit Sub 'don't start the test
        End If

        'if we get here, we have all of the fields filled in ok
        If Not WritingToFile Then 'if there is no file chosen yet
            ans = MsgBox("You did not choose a file to save data.  Do you want to do that now?", MsgBoxStyle.YesNo, "No File Open") 'ask if the user wants to save to file
            If ans = MsgBoxResult.Yes Then 'if he does
                cmdSaveData_Click(cmdSaveData, New System.EventArgs()) 'press the button for him
            End If
        End If

        'say writing to file
        txtFileName.Text = "Excel File = " & SaveFileName & vbCrLf & "Worksheet Name = " & WorkSheetName & vbCrLf & "Writing Data. . ." 'tell the user

        txtAveTDH.Text = Format(TDH, "##0.00") 'save the tdh in average tdh

        'set the npsh vs tdh plot scales
        'CWGraph2.Axes.Item(2).Minimum = 90   'set tdh from -25
        'CWGraph2.Axes.Item(2).Maximum = 102  '  to 25 over the tdh

        If blnUsingExcelInput Then
            txtFlowForCalcs.Text = pd.StartingFlow
            txtAveTDH.Text = pd.StartingTDH
            txtInHgDisplay.Text = pd.BP
        Else
            txtFlowForCalcs.Text = txtFlowDisplay.Text 'save the curent flow in flowforcalcs
        End If


        TestStarted = True 'say the test has been started

        If WritingToFile Then 'if we're already writing to a file
            WriteHeader() 'write the header to the file
        End If

    End Sub


    Private Sub frmPLCData_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim RetVal As Integer 'used for starting dde server call
        Dim i As Integer
        Dim j As Integer
        Dim vAns As Object
        Dim sServerName As String = ""
        Debugging = 0

        On Error GoTo NoFile
        FileOpen(1, sServerNameTextFile, OpenMode.Input)
        Input(1, sServerName)
        FileClose(1)
        GoTo GotName

NoFile:
        i = MsgBox("There is no file called 'server.txt' in the C:\ directory.  I can create a file if you know the server name.  Do you know the server name?", MsgBoxStyle.YesNo, "No Server Name File found")
        If i = MsgBoxResult.Yes Then
            sServerName = InputBox("Enter the server name in UNC format, like, \\TEI-MAIN-01\ . Note the back slashes: two before and one after the name.", "Get Server Name")
            FileOpen(1, sServerNameTextFile, OpenMode.Output)
            WriteLine(1, sServerName)
            FileClose(1)
        Else
            i = MsgBox("You need to create a file called 'server.txt' in the C:\ directory. The file must contain the server name in UNC form, like '\\TEI-MAIN-01\'. Going to end the program now.", MsgBoxStyle.OkOnly, "Server Name not known.")
            End
        End If


GotName:
        On Error GoTo 0


        'If UCase(VB.Left(GetMachineName, 5)) = "MROSE" Then 'if mickey, see if we want to be in debug
        '    i = MsgBox("Debug?", MsgBoxStyle.YesNo)
        '    If i = MsgBoxResult.Yes Then
        '        Debugging = 1
        '        sServerName = "C:\Databases\"
        '    Else
        '    End If
        'End If

        If System.Diagnostics.Debugger.IsAttached = False Then
            Me.Text = "Version " & My.Application.Deployment.CurrentVersion.ToString
        Else
            Me.Text = "Version " & My.Application.Info.Version.ToString
        End If


        lblVersion.Text = Me.Text


        'sDataBaseName = "NPSHCalibrateData.mdb"

        FirstRun = True 'first time doing calcs

        'assure that the timers are off

        Me.tmrGetDDE.Enabled = False
        Me.tmrStartUp.Enabled = False

        'turn on the PLC led
        Me.tmrGetDDE.Enabled = True

        'initialize
        'initialize the PLC network
        If Not (PLCCm.NetworkInit(ErrorList)) Then
            MsgBox("Errors found in Network Initialization", vbOKOnly, "Network Initialization Errors")
        End If


        If Debugging = 0 Then
            'find all plcs in the network
            If Not PLCCm.ScanNetwork(PLCList, ErrorList) Then
                MsgBox("Errors found in Network Initialization", vbOKOnly, "Network Initialization Errors")
            End If

            PLCCm.SortPLCList(PLCList)

            'If PLCList.Count = 0 Then
            '    MsgBox("No PLCs found. . . ", vbOKOnly, "No PLCs Found")
            '    End
            'End If

            If PLCList.Count > 0 Then
                For Each p As PLCCommLibrary.PLCComm.PLCStruct In PLCList
                    cmbPLCLoop.Items.Add(p.PLCName)
                Next
            End If

            'add use excel sheet to end of list
            cmbPLCLoop.Items.Add("Use Excel Sheet")

            Dim DeviceCount As Integer

            DeviceCount = PLCList.Count

            Me.cmbPLCLoop.SelectedIndex = 0
            FoundPLC = True
        End If 'if debugging = 0

        If Debugging = 0 Then
            sDataBaseName = sServerName & "f\groups\shared\databases\PumpData 2k.mdb"
        Else
            sDataBaseName = "C:\databases\PumpData 2k.mdb"
        End If

        With cn
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDataBaseName & ";Persist Security Info=False"
            .Open()
        End With

        'get the data from the excel sheet and populate arrays for lookup tables
        'the excel sheet is in sDirectoryName and is called npshdata.xls - see fillarray
        FillArray("PipeDiameters", 2, ActualPipeDiameter)
        FillArray("PipeDiameters", 1, NominalPipeDiameter)
        FillArray("VaporPressure", 2, VaporPressure)
        FillArray("VaporPressure", 3, SpecificVolume)

        cn.Close()

        'sDataBaseName = My.Application.Info.DirectoryPath & "\NPSHCalibrateData.mdb"
        With cn
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDataBaseName & ";Persist Security Info=False"
            .Open()
        End With


        'fill the dropdown lists of pipe diameters from the arrays
        For i = 0 To UBound(NominalPipeDiameter)
            Me.cmbDisch.Items.Add(Format(NominalPipeDiameter(i), "#0.00"))
            Me.cmbSuction.Items.Add(Format(NominalPipeDiameter(i), "#0.00"))
        Next i

        UseDataset.Flow = 0

        'close any running excel processes
        If Process.GetProcessesByName("Excel").GetLength(0) > 0 Then
            Dim ans As MsgBoxResult = MsgBox("Excel is running.  May I close it?", vbYesNo, "Excel is Running")
            If ans = vbYes Then
                For Each p As Process In Process.GetProcessesByName("Excel")
                    p.Kill()
                Next
            Else
                MsgBox("Cannot continue with Excel running.  Shutting down. . .")
                End
            End If

        End If

        '' Create the Excel App Object so we can store our data
        'xlApp = CreateObject("Excel.Application")
        'Dim xlProc = Process.GetProcessesByName("Excel")
        'outputExcelProcessID = xlProc(0).id

    End Sub

    Private Sub frmPLCData_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cmdExit_Click(cmdExit, New System.EventArgs())
    End Sub

    Private Sub tmrGetDDE_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrGetDDE.Tick

        Dim i As Integer
        Dim strData As String 'for writing to scrolling display
        Dim Conversion_Renamed As Single 'for inHg from plc
        Dim LastSuctionPressure As Single 'suction pressure last reading


        If Not FoundPLC And Not Calibrating Then Exit Sub 'if no plc, don't do any of this


        If Not Calibrating Then
            If blnUsingExcelInput And blnListDone = False Then
                'getting data from excel sheet
                'get data from lstexcelinput
                Dim datastruct As InputData = New InputData
                datastruct = lstExcelInput(rowExcelInput)
                Me.txtFlow.Text = datastruct.Flow
                Me.txtSuction.Text = datastruct.SuctPress           'input for both pressures in PSIA
                Me.txtDischarge.Text = datastruct.DischPress        '   "
                Me.txtTemperature.Text = datastruct.Temp
                Me.txtValvePosition.Text = datastruct.ValvePosition
                Me.txtInHgDisplay.Text = pd.BP
                SuctionPSIA = datastruct.SuctPress
                DischargePSIA = datastruct.DischPress

                Me.lbldatarow.Visible = True
                Me.lbldatarow.Text = "At Data Point " & rowExcelInput.ToString & " of " & lstExcelInput.Count.ToString & " Data Points"
                rowExcelInput += 1
                If rowExcelInput >= lstExcelInput.Count Then
                    'stop input data
                    blnListDone = True
                    Me.lbldatarow.Text = "No More Data Input"
                    cmdStartTest_Click(cmdStartTest, New System.EventArgs())
                End If
            Else
                'get here to format the data that we got from the plc
                '  and do the npsh and tdh calculations

                Me.shpGetPLCData.Visible = True 'turn the PLC led on

                Me.txtInHg.Text = CStr(PLCCm.ConvertToLong("1460"))

                'the following data are type real
                If chkConstantFlow.CheckState = 0 Then
                    txtFlow.Text = CStr(PLCCm.ConvertToReal("4050"))
                Else
                    txtFlow.Text = CStr(Val(txtConstantFlow.Text))
                End If

                'all pressures from PLC  are in psig, so convert to psia
                Dim Conversion = CDbl(txtInHg.Text) * 0.491 / 100

                txtSuction.Text = CStr(PLCCm.ConvertToReal("4052") / 10) + Conversion
                txtDischarge.Text = CStr(PLCCm.ConvertToReal("4054")) + Conversion
                txtTemperature.Text = CStr(PLCCm.ConvertToReal("4056"))
                '
                '    'the following data are not type real
                txtValvePosition.Text = CStr(PLCCm.ConvertToLong("2004"))
                Me.txtTC1.Text = CStr(PLCCm.ConvertToLong("2200") / 10)
                Me.txtTC2.Text = CStr(PLCCm.ConvertToLong("2202") / 10)
                Me.txtTC3.Text = CStr(PLCCm.ConvertToLong("2204") / 10)
                Me.txtTC4.Text = CStr(PLCCm.ConvertToLong("2206") / 10)

                Me.txtAI1.Text = CStr(PLCCm.ConvertToReal("4060"))
                Me.txtAI2.Text = CStr(PLCCm.ConvertToReal("4062"))
                Me.txtAI3.Text = CStr(PLCCm.ConvertToReal("4064"))
                Me.txtAI4.Text = CStr(PLCCm.ConvertToReal("4066"))


            End If
        End If

        If Calibrating And UseDataset.Flow = 0 Then
            Me.shpGetPLCData.Visible = False 'turn the PLC led on
            Semaphore = False
            Exit Sub
        End If

        If Calibrating And UseDataset.Flow <> 0 Then
            txtFlow.Text = CStr(UseDataset.Flow)
            txtSuction.Text = CStr(10 * UseDataset.SuctionPressure)
            txtDischarge.Text = CStr(UseDataset.DischargePressure)
            txtTemperature.Text = CStr(UseDataset.Temperature)
            txtSuctGaugeHeight.Text = CStr(UseDataset.SuctionHeight)
            txtDischGaugeHeight.Text = CStr(UseDataset.DischargeHeight)
            txtInHg.Text = CStr(100 * UseDataset.BarometricPressure)
            txtAveTDH.Text = CStr(UseDataset.StartingHead)
            For i = 0 To cmbSuction.Items.Count - 1
                If CDbl(cmbSuction.Items(cmbSuction.SelectedIndex)) Then 'VB6.GetItemString(cmbSuction, i)) = UseDataset.SuctionPipeDia Then
                    cmbSuction.SelectedIndex = i
                    Exit For
                End If
                cmbSuction.SelectedIndex = -1
            Next i
            For i = 0 To cmbDisch.Items.Count - 1
                If CDbl(cmbDisch.Items(cmbDisch.SelectedIndex)) Then 'VB6.GetItemString(cmbDisch, i)) = UseDataset.DischargePipeDia Then
                    cmbDisch.SelectedIndex = i
                    Exit For
                End If
                cmbDisch.SelectedIndex = -1
            Next i
        End If

        'modify the data from PLC format to a format that we can use
        '   and update the screen
        Me.txtFlowDisplay.Text = Format(Val(txtFlow.Text), "###0.00")
        LastSuctionPressure = Val(txtSuctionDisplay.Text) 'save last reading
        txtSuctionDisplay.Text = Format(CDbl(txtSuction.Text), "##0.00")
        Me.txtDischargeDisplay.Text = Format(Val(txtDischarge.Text), "##0.00")
        Me.txtTemperatureDisplay.Text = Format(Val(txtTemperature.Text), "##0.00")
        Me.txtValvePositionDisplay.Text = txtValvePosition.Text

        If Not Calibrating Then
            Me.txtTC1Display.Text = Format(CDbl(txtTC1.Text) / 10, "##0.0")
            Me.txtTC2Display.Text = Format(CDbl(txtTC2.Text) / 10, "##0.0")
            Me.txtTC3Display.Text = Format(CDbl(txtTC3.Text) / 10, "##0.0")
            Me.txtTC4Display.Text = Format(CDbl(txtTC4.Text) / 10, "##0.0")

            Me.txtAI1Display.Text = Format(Val(txtAI1.Text), "##0.00")
            Me.txtAI2Display.Text = Format(Val(txtAI2.Text), "##0.00")
            Me.txtAI3Display.Text = Format(Val(txtAI3.Text), "##0.00")
            Me.txtAI4Display.Text = Format(Val(txtAI4.Text), "##0.00")

            Me.txtInHgDisplay.Text = Format(CDbl(txtInHg.Text) / 100, "#0.00")
        End If

        If TestStarted Then 'see which flow we should use
            FlowForCalcs = CSng(txtFlowForCalcs.Text)
            If CDbl(txtFlowForCalcs.Text) <> 0 Then
                If (System.Math.Abs(CDbl(txtFlowDisplay.Text) - CDbl(txtFlowForCalcs.Text)) / CDbl(txtFlowForCalcs.Text)) > 0.01 Then
                    txtFlowDisplay.BackColor = System.Drawing.Color.Red
                Else
                    txtFlowDisplay.BackColor = System.Drawing.Color.White
                End If
            End If
            DeltaSuctionPressure = (4 * DeltaSuctionPressure + LastSuctionPressure - CDbl(txtSuctionDisplay.Text)) / 5
            txtDeltaSuctionPressure.Text = Format(-DeltaSuctionPressure, "#0.000")
            If Val(txtTDH97.Text) < 99 Then
                If System.Math.Abs(CDbl(txtDeltaSuctionPressure.Text)) > 0.01 Or System.Math.Abs(CDbl(txtDeltaSuctionPressure.Text)) < 0.005 Then
                    txtDeltaSuctionPressure.BackColor = System.Drawing.Color.Red
                Else
                    txtDeltaSuctionPressure.BackColor = System.Drawing.Color.White
                End If
            Else
                If System.Math.Abs(CDbl(txtDeltaSuctionPressure.Text)) > 0.03 Or System.Math.Abs(CDbl(txtDeltaSuctionPressure.Text)) < 0.01 Then
                    txtDeltaSuctionPressure.BackColor = System.Drawing.Color.Red
                Else
                    txtDeltaSuctionPressure.BackColor = System.Drawing.Color.White
                End If
            End If
        Else
            DeltaSuctionPressure = 0
            FlowForCalcs = CSng(txtFlowDisplay.Text)
            txtDeltaSuctionPressure.Text = "--"
        End If

        'velocity head
        If cmbSuction.SelectedIndex = -1 Then 'if no suction diameter chosen
            txtSuctVelHead.Text = CStr(0)
        Else
            SuctVelHead = (0.002592 * FlowForCalcs ^ 2) / (ActualPipeDiameter(cmbSuction.SelectedIndex) ^ 4)
        End If
        txtSuctVelHead.Text = Format(SuctVelHead, "0.00")

        If cmbDisch.SelectedIndex = -1 Then 'if no discharge diameter chosen
            txtDischVelHead.Text = CStr(0)
            '        MsgBox "You need to choose a Discharge Pipe Diameter", vbOKOnly, "No discharge Pipe Diameter Chosen"
        Else
            DischVelHead = (0.002592 * FlowForCalcs ^ 2) / (ActualPipeDiameter(cmbDisch.SelectedIndex) ^ 4)
        End If
        txtDischVelHead.Text = Format(DischVelHead, "0.00")

        ''convert gauges to absolute
        'Conversion_Renamed = CDbl(txtInHg.Text) * 0.491 / 100

        ''data from plc is in gage
        'SuctionPSIA = Val(txtSuctionDisplay.Text) '+ Conversion_Renamed
        ''txtSuctionDisplay.Text = Format(Val(SuctionPSIA), "##00.00")

        ''If RadioButtonGauge.Checked = True Then 'gauge
        ''    DischargePSIA = Val(txtDischargeDisplay.Text) + Conversion_Renamed
        ''Else 'absolute
        'DischargePSIA = Val(txtDischargeDisplay.Text)
        ''End If

        'txtDischargeDisplay.Text = Format(Val(DischargePSIA), "##00.00") 'show the value

        'lookup vapor pressure and specific volume in the arrays that we made
        'if temp is out of range, say so and exit
        If Val(txtTemperatureDisplay.Text) < 40 Or Val(txtTemperatureDisplay.Text) > 165 Then
            If (Val(txtTemperatureDisplay.Text) <> 0) And (Val(txtTemperatureDisplay.Text) <> 32) Then
                MsgBox("Temperature is out of range...Cannot complete calculations.", MsgBoxStyle.OkOnly, "Temperature Out of Range")
            End If
            Exit Sub
        Else
            i = Val(txtTemperatureDisplay.Text) - 40
            VaporPress = VaporPressure(i)
            txtVapPress.Text = Format(VaporPress, "0.0000")
            SpecVolume = SpecificVolume(i)
            txtSpVol.Text = Format(SpecVolume, "0.0000")
        End If

        If Not ((txtSuctGaugeHeight.Text = "") Or (txtDischGaugeHeight.Text = "")) Then
            'NPSHa
            NPSHa = (144 * SpecVolume * (SuctionPSIA - VaporPress)) + (Val(txtSuctGaugeHeight.Text) / 12) + SuctVelHead
            txtNPSHa.Text = Format(NPSHa, "##0.00")

            'tdh
            TDH = (144 * SpecVolume * (DischargePSIA - SuctionPSIA)) + DischVelHead - SuctVelHead + (Val(txtDischGaugeHeight.Text) / 12) - (Val(txtSuctGaugeHeight.Text) / 12)
            txtTDH.Text = Format(TDH, "##0.00")
        End If

        If FirstRun Then
            txtAveTDH.Text = CStr(TDH) 'set average = reading the first time through
            FirstRun = False
        End If

        If TestStarted Or Calibrating Then
            txtPctHead.Text = Format(TDH * 100 / CDbl(txtAveTDH.Text), "##0.0")
        Else
            txtAveTDH.Text = Format((4 * Val(txtAveTDH.Text) + TDH) / 5, "##0.00")
        End If

        'write the data to the screen
        strData = ""
        strData = String.Format("{0,6:HH:mm:ss}{1,8:f2}{2,7:F2}{3,7:F2}{4,7:F2}{5,7:F2}{6,7:F2}{7,7:F2}{8,7:F2}{9,7:F2}%", TimeOfDay, Val(txtFlowDisplay.Text), Val(txtSuctionDisplay.Text), Val(txtDischargeDisplay.Text), Val(txtTemperatureDisplay.Text), Val(txtSuctVelHead.Text), Val(txtDischVelHead.Text), Val(txtTDH.Text), Val(txtNPSHa.Text), Val(txtPctHead.Text) * 1)

        If Len(strData & vbCrLf & rtbDataOut.Text) > 1024 Then
            rtbDataOut.Text = ((strData & vbCrLf & rtbDataOut.Text).Substring(0, 1024))
        Else
            rtbDataOut.Text = strData & vbCrLf & rtbDataOut.Text
        End If

        'if there's a file open, write to it at the current row
        '  then increment the row
        If WritingToFile And TestStarted Then
            With xlApp
                .Range("A" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(TimeOfDay, "HH:mm:ss")

                .Range("B" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(Val(txtFlowDisplay.Text), "000.0")

                .Range("C" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(Val(txtSuctionDisplay.Text), "000.00")

                .Range("D" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(Val(txtDischargeDisplay.Text), "000.00")

                .Range("E" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(Val(txtTemperatureDisplay.Text), "000.00")

                .Range("F" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(Val(txtValvePositionDisplay.Text), "00")

                .Range("G" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(SuctVelHead, "00.00")

                .Range("H" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(DischVelHead, "00.00")

                .Range("I" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(Val(txtSpVol.Text), "0.0000")

                .Range("J" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(Val(txtVapPress.Text), "00.0000")

                .Range("K" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(NPSHa, "000.00")

                .Range("L" & Format(ExcelRow)).Select()
                .ActiveCell.FormulaR1C1 = Format(TDH, "000.00")

                Dim pctHead As String = "=L" & Format(ExcelRow) & "/$C$2"
                .Range("M" & Format(ExcelRow)).Select()
                .ActiveCell.Formula = pctHead
                .ActiveCell.NumberFormat = "#00.00%"

                ExcelRow = ExcelRow + 1
            End With
        End If


        'update the npsh vs tdh chart
        '  move the all of data down by 1 and add the new data at the end
        If CDbl(txtAveTDH.Text) <> 0 Then
            For i = 1 To 9999
                vPlot1(i, 0) = vPlot1(i + 1, 0)
                vPlot1(i, 1) = vPlot1(i + 1, 1)
            Next i
            vPlot1(10000, 0) = NPSHa
            vPlot1(10000, 1) = 100 * TDH / CDbl(txtAveTDH.Text)
            '        vPlot1(10000, 0) = 100 * TDH / txtAveTDH
            '        vPlot1(10000, 1) = NPSHa
        End If

        Chart1.Series(0).Points.Clear()

        For i = 1 To 10000
            Chart1.Series(0).Points.AddXY(vPlot1(i, 0), vPlot1(i, 1))
        Next

        With Chart1
            .ChartAreas(0).AxisX.Title = "NPSH"
            .ChartAreas(0).AxisY.Title = "% TDH"

            .ChartAreas(0).AxisY.Minimum = 94

            .ChartAreas(0).AxisY.Maximum = 103
            .ChartAreas(0).AxisY.Interval = 3
            ' .ChartAreas(0).AxisY.MajorGrid.Interval = 10
            ' .ChartAreas(0).AxisY.MinorGrid.Interval = 1

            .ChartAreas(0).AxisX.Maximum = 10 * (Int((SetGraphMax(vPlot1, 0) / 10) + 0.5) + 1)
            .ChartAreas(0).AxisX.Minimum = 10 * (Int((SetGraphMin(vPlot1, 0) / 10) - 0.5))

            .ChartAreas(0).AxisX.Interval = 5 'Int(.ChartAreas(0).AxisX.Maximum / 5)
        End With

        'update big TDH and NPSHa data as long as %TDH is >= 97%

        If (TDH / CDbl(txtAveTDH.Text)) >= 0.97 Then
            txtTDH97.Text = Format(100 * TDH / CDbl(txtAveTDH.Text), "000.0")
            txtNPSHa97.Text = txtNPSHa.Text
        End If

        Me.shpGetPLCData.Visible = False 'turn the PLC led on

        Semaphore = False

    End Sub
    Private Sub tmrStartUp_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrStartUp.Tick
        'we waited for a while for the dde server to start, disable the timer
        tmrStartUp.Enabled = False
    End Sub
    Private Sub FillArray(ByRef TableName As String, ByRef ColumnNumber As Integer, ByRef ArrayToFill() As Single)

        'fill an array with data from the database CalibrateData.mdb in the application directory

        'initialize arrays
        Dim i As Integer

        rs.Open(TableName, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)

        ReDim ArrayToFill(rs.RecordCount - 1) 'make the array that size - 1 cause it's 0-based
        rs.MoveFirst()

        'fill the array as we go down the column in excel
        For i = 0 To rs.RecordCount - 1
            ' Fill the array with values from the worksheet.
            ArrayToFill(i) = rs.Fields(ColumnNumber).Value
            rs.MoveNext()
        Next i

        rs.Close()
    End Sub

    Private Sub txtSN_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSN.TextChanged
        If IsInitializing = True Then
            Exit Sub
        End If
        If txtSN.Text <> "" Then 'if there is a sn, make the background white
            txtSN.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        End If
    End Sub
    Private Sub WriteHeader()
        Dim TextToWrite As String

        'write the header to the file
        With xlApp
            .Range("C1").Select()
            .ActiveCell.FormulaR1C1 = txtSN.Text

            .Range("H1").Select()
            .ActiveCell.FormulaR1C1 = Today

            .Range("C2").Select()
            .ActiveCell.FormulaR1C1 = txtAveTDH.Text

            .Range("H2").Select()
            .ActiveCell.FormulaR1C1 = txtInHgDisplay.Text

            .Range("C3").Select()
            .ActiveCell.FormulaR1C1 = txtFlowForCalcs.Text

            .Range("H3").Select()
            .ActiveCell.FormulaR1C1 = txtSuctGaugeHeight.Text

            .Range("C4").Select()
            .ActiveCell.FormulaR1C1 = cmbPLCLoop.Items(cmbPLCLoop.SelectedIndex)

            .Range("H4").Select()
            .ActiveCell.FormulaR1C1 = txtDischGaugeHeight.Text

            .Range("H6").Select()
            .ActiveCell.FormulaR1C1 = cmbSuction.Items(cmbSuction.SelectedIndex)

            .Range("H5").Select()
            .ActiveCell.FormulaR1C1 = cmbDisch.Items(cmbDisch.SelectedIndex)

            .Range("A7").Select()
            .ActiveCell.FormulaR1C1 = "Comment:"

            TextToWrite = Replace(txtComment.Text, vbCrLf, " - ")
            .Range("C7").Select()
            .ActiveCell.FormulaR1C1 = TextToWrite
            .Selection.WrapText = False
            ExcelRow = 12 'start writing at row 12

        End With
    End Sub
    Sub PlotGraph()
        Dim ns As Series
        Dim ns1 As Series
        Dim ChartSheet As Chart
        Dim j As Integer

        With xlApp
            ChartSheet = .Charts.Add ' xlapp.Charts.Add 'add a chart
            xlApp.ActiveChart.ChartArea.Clear()
            With ChartSheet
                .ChartType = XlChartType.xlXYScatterSmoothNoMarkers 'make it an xy with no markers

                'x and y ranges
                '            ActiveChart.SeriesCollection(1).XValues = xlApp.Worksheets(WorkSheetName).Range("K12:K" & Format$(ExcelRow - 1))
                '           ActiveChart.SeriesCollection(1).Values = xlApp.Worksheets(WorkSheetName).Range("M12:M" & Format$(ExcelRow - 1))
                ns1 = xlApp.ActiveChart.SeriesCollection.NewSeries
                ns1.XValues = xlApp.Worksheets(WorkSheetName).Range("K12:K" & Format(ExcelRow - 1))
                ns1.Values = xlApp.Worksheets(WorkSheetName).Range("M12:M" & Format(ExcelRow - 1))

                '        ActiveChart.SeriesCollection(1).XValues = "=" & WorkSheetName & "!$K$12:$K$" & Format$(ExcelRow - 1)  'xlApp.Worksheets(WorkSheetName).Range("K12:K" & Format$(ExcelRow - 1))
                '        ActiveChart.SeriesCollection(1).Values = "=" & WorkSheetName & "!$M$12:$M$" & Format$(ExcelRow - 1)  'xlApp.Worksheets(WorkSheetName).Range("K12:K" & Format$(ExcelRow - 1))

                'make the chart a new sheet and add the sheet name
                .Location(XlChartLocation.xlLocationAsNewSheet, "Chart " & WorkSheetName)
                'white inside
                .PlotArea.Interior.ColorIndex = Constants.xlNone

                'set the titles for the axes
                .Axes(XlAxisType.xlValue).HasTitle = True
                .Axes(XlAxisType.xlValue).AxisTitle.Text = "TDH(%)"
                .Axes(XlAxisType.xlCategory).HasTitle = True
                .Axes(XlAxisType.xlCategory).AxisTitle.Text = "NPSHa"

                'adjust the scale for 90 to 100%
                .Axes(XlAxisType.xlValue).MinimumScale = ".9"
                .Axes(XlAxisType.xlValue).MaximumScale = "1.01"
                .Axes(XlAxisType.xlValue).MajorUnit = "0.01"

                'show major gridlines
                .Axes(XlAxisType.xlValue).HasMajorGridlines = True
                .Axes(XlAxisType.xlCategory).HasMajorGridlines = True

                'no legend
                xlApp.ActiveChart.HasLegend = False

                'set the chart title as the serial number2
                xlApp.ActiveChart.HasTitle = True
                xlApp.ActiveChart.ChartTitle.Text = txtSN.Text & vbCr & WorkSheetName & vbCr & Today

            End With

            If xlApp.Worksheets.Count = 1 Then 'first sheet in this file
                xlApp.ActiveChart.Copy(Before:=xlApp.Sheets(1))
                xlApp.Sheets(1).Select()
                xlApp.ActiveChart.Name = "All runs"
                xlApp.ActiveChart.HasLegend = True
                For j = 1 To xlApp.ActiveChart.SeriesCollection.Count - 1
                    xlApp.ActiveChart.SeriesCollection(1).Delete()
                Next j
                xlApp.ActiveChart.SeriesCollection(1).Name = WorkSheetName
                xlApp.ActiveChart.ChartTitle.Text = txtSN.Text & vbCr & Today
                xlApp.ActiveChart.SeriesCollection(1).Border.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
            Else
                xlApp.Sheets("All runs").Select()
                ns = xlApp.ActiveChart.SeriesCollection.NewSeries
                ns.XValues = xlApp.Worksheets(WorkSheetName).Range("K12:K" & Format(ExcelRow - 1))
                ns.Values = xlApp.Worksheets(WorkSheetName).Range("M12:M" & Format(ExcelRow - 1))
                ns.Name = WorkSheetName
                Select Case xlApp.ActiveChart.SeriesCollection.Count
                    Case 2
                        ns.Border.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
                    Case 3
                        ns.Border.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
                    Case 4
                        ns.Border.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Lime)
                    Case 5
                        ns.Border.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Cyan)
                    Case 6
                        ns.Border.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta)
                    Case 7
                End Select
            End If

            'move the chart to embed in worksheet
            With xlApp.Charts("Chart " & WorkSheetName)
                .Location(Where:=XlChartLocation.xlLocationAsObject, Name:=WorkSheetName)
            End With

            'position and fix size

            Dim RngToCover As Range
            Dim ChtOb As ChartObject

            'use sheet name from above
            xlApp.Worksheets(WorkSheetName).activate

            RngToCover = xlApp.ActiveSheet.Range("O10:X40")
            ChtOb = xlApp.ActiveChart.Parent
            ChtOb.Height = RngToCover.Height ' resize
            ChtOb.Width = RngToCover.Width   ' resize
            ChtOb.Top = RngToCover.Top       ' reposition
            ChtOb.Left = RngToCover.Left     ' reposition


        End With

        '    xlApp.Quit
        '
        '    Dim makesummary As MakeNPSHSummary.ExcelRoutines
        '    Set makesummary = New MakeNPSHSummary.ExcelRoutines
        '    makesummary.WorkbookName = SaveFileName
        '    makesummary.makesummary
        '
        '    ' Create the Excel App Object so we can store our data
        '    Set xlApp = CreateObject("Excel.Application")
        '    xlApp.Workbooks.Open (SaveFileName)
        '    xlApp.Visible = True
    End Sub
    Public Sub CalibrateSoftware()
        frmCalibrate.Show()
        'Calibrating = True

    End Sub

    Function SetGraphMax(ByRef Plothead(,) As Single, ByRef arrayIndex As Integer) As Integer

        Dim i As Integer
        Dim m As Single

        m = 0
        For i = 0 To UBound(Plothead, arrayIndex + 1)
            If Plothead(i, arrayIndex) > m Then
                m = Plothead(i, arrayIndex)
            End If
        Next i
        SetGraphMax = m '10 * (Int((m / 10) + 0.5) + 1)

    End Function
    Function SetGraphMin(ByRef Plothead(,) As Single, ByRef arrayIndex As Integer) As Integer

        Dim i As Integer
        Dim m As Single

        m = 100
        For i = 0 To UBound(Plothead, arrayIndex + 1)
            If Plothead(i, arrayIndex) < m Then
                m = Plothead(i, arrayIndex)
            End If
        Next i
        SetGraphMin = m '10 * (Int((m / 10) + 0.5) - 1)

    End Function

    Private Sub MakeSummary()
        'if worksheet count = 3, then we have the first run and all runs.  we need to make the summary sheet
        'Dim SummaryWorksheet As excel.Worksheet
        'Dim wsCount As Integer
        'Dim arrayrows As Integer

        'so we can write data back to current sheet
        Dim currentSheetFlow As Single
        Dim currentSheetHead As Single

        Dim xlRange As Range

        'count of worksheets in workbook
        Dim WorksheetsCount As Integer = xlApp.Worksheets.Count
        Dim xlSheet As Worksheet

        'if a worksheet named Summary exists, delete cause we're going to overwrite it
        For Each xlSheet In xlBook.Worksheets
            If xlSheet.Name = "NPSHr Summary" Then
                xlApp.Application.DisplayAlerts = False
                xlSheet.Delete()
                xlApp.Application.DisplayAlerts = True
            End If
        Next

        'now there should be no worksheet names summary, so make a new one at the beginning

        '       xlSheet = xlApp.Worksheets.Add(Before:=xlApp.Charts("all runs"))    'add a new worksheet
        xlSheet = xlApp.Worksheets.Add(Before:=xlApp.Worksheets(1))    'add a new worksheet
        xlSheet.Name = "NPSHr Summary"       'give it the desired name

        Dim aRows As Integer = WorksheetsCount
        Dim aCols As Integer = 2 - 1
        Dim ArrayForExcel(aRows, aCols) As Object     'want to have text and numbers, so use object
        ArrayForExcel(0, 0) = "Flow (GPM)"
        ArrayForExcel(0, 1) = "NPSHr (ft)"

        'now go through each worksheet and find two columns and then entries in the columns
        ' columns are NPSHa, Flow and % Head
        ' entries are % head > 97.0 and the one above it.
        Dim MaxPct As Single
        Dim MinPct As Single
        Dim MaxNPSHa As Single
        Dim MinNPSHa As Single
        Dim MaxFlow As Single
        Dim MinFlow As Single
        Dim MinRow As Integer
        Dim i As Integer = 1
        Dim SN As String = ""
        Dim BadNPSHr As Boolean = False

        For Each xlSheet In xlBook.Worksheets
            If xlSheet.Name <> "NPSHr Summary" Then
                BadNPSHr = False
                If i = 1 Then
                    xlRange = xlSheet.Range("C1")
                    SN = xlRange.Value.ToString
                    'SN = 'SN.Substring(Len("Serial Number - "))
                End If

                xlRange = xlSheet.UsedRange.Find("% Head")
                Dim PctCol As Integer = xlRange.Column
                Dim PctColLtr As Char = Chr(Asc("A") + PctCol - 1)
                Dim MinPctRow As Integer = xlRange.Row
                xlRange = xlSheet.Range(PctColLtr + (MinPctRow + 1).ToString & ":" & PctColLtr + xlSheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row.ToString)

                For Each xlcell As Range In xlRange
                    If IsNumeric(xlcell.Value) Then
                        If xlcell.Value < 0.97 Then
                            MinRow = xlcell.Row
                            MinPct = xlcell.Value
                            BadNPSHr = False
                            Exit For
                        End If
                        BadNPSHr = True
                    End If
                Next

                If Not BadNPSHr Then
                    MaxPct = xlSheet.Range(PctColLtr + (MinRow - 1).ToString & ":" & PctColLtr + (MinRow - 1).ToString).Value

                    xlRange = xlSheet.Range("A" & MinPctRow.ToString, xlSheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell)).Find("NPSHa")
                    Dim NPSHaCol As Integer = xlRange.Column
                    Dim NPSHaColLtr As Char = Chr(Asc("A") + NPSHaCol - 1)
                    MaxNPSHa = xlSheet.Range(NPSHaColLtr + (MinRow - 1).ToString & ":" & NPSHaColLtr + (MinRow - 1).ToString).Value
                    MinNPSHa = xlSheet.Range(NPSHaColLtr + (MinRow).ToString & ":" & NPSHaColLtr + (MinRow).ToString).Value

                    xlRange = xlSheet.Range("A" & MinPctRow.ToString, xlSheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell)).Find("Flow")
                    Dim FlowCol As Integer = xlRange.Column
                    Dim FlowColLtr As Char = Chr(Asc("A") + FlowCol - 1)
                    MaxFlow = xlSheet.Range(FlowColLtr + (MinRow - 1).ToString & ":" & FlowColLtr + (MinRow - 1).ToString).Value
                    MinFlow = xlSheet.Range(FlowColLtr + (MinRow).ToString & ":" & FlowColLtr + (MinRow).ToString).Value

                    ArrayForExcel(i, 0) = Interpolate(MaxFlow, MinFlow, MaxPct, MinPct)
                    ArrayForExcel(i, 1) = Interpolate(MaxNPSHa, MinNPSHa, MaxPct, MinPct)
                    'save data to write back into our sheet
                    If xlSheet.Name = WorkSheetName Then
                        currentSheetFlow = ArrayForExcel(i, 0)
                        currentSheetHead = ArrayForExcel(i, 1)
                    End If
                End If
                i += 1
            End If
            'If Not BadNPSHr Then
            '    i += 1
            'End If
        Next

        With xlApp.ActiveWorkbook.Sheets("NPSHr Summary")
            .activate()


            Dim rge As Range = .Range("A1:A1")
            rge = rge.Resize(aRows + 1, aCols + 1)        'expand to size we need for array
            rge.Value = ArrayForExcel               'copy array

            rge.Columns.AutoFit()
            rge.NumberFormat = "#,##0.00"

        End With

        Dim xlWorksheet As Worksheet = xlApp.ActiveWorkbook.Sheets("NPSHr Summary")
        Dim xlCharts As ChartObjects = xlWorksheet.ChartObjects
        Dim myChart As ChartObject = xlCharts.Add(xlWorksheet.Cells(3, 4).left, xlWorksheet.Cells(3, 4).top, 650, 350)
        Dim chartPage As Chart = myChart.Chart

        With chartPage
            Dim ns As Series = .SeriesCollection.NewSeries
            ns.XValues = xlWorksheet.Range("A2:A" & Format(aRows + 1))
            ns.Values = xlWorksheet.Range("B2:B" & Format(aRows + 1))

            Dim tl As Trendline = ns.Trendlines.Add(XlTrendlineType.xlPolynomial)
            tl.Order = 2


            'set legend to be displayed or not
            .HasLegend = False
            'set legend location
            '            .Legend.Position = Excel.XlLegendPosition.xlLegendPositionRight
            'select chart type
            .ChartType = XlChartType.xlXYScatter
            'chart title
            .HasTitle = True
            .ChartTitle.Text = SN & vbLf & "NPSHr vs Flow Rate"
            'set titles for Axis values and categories
            Dim xlAxisCategory, xlAxisValue As Axes
            xlAxisCategory = CType(chartPage.Axes(, XlAxisGroup.xlPrimary), Axes)
            xlAxisCategory.Item(XlAxisType.xlCategory).HasTitle = True
            xlAxisCategory.Item(XlAxisType.xlCategory).AxisTitle.Characters.Text = "Flow (gpm)"
            xlAxisValue = CType(chartPage.Axes(, XlAxisGroup.xlPrimary), Axes)
            xlAxisValue.Item(XlAxisType.xlValue).HasTitle = True
            xlAxisValue.Item(XlAxisType.xlValue).AxisTitle.Characters.Text = "NPSHr"
        End With
        'Dim series1 As Series = CType(.SeriesCollection(1), Series)
        '.SeriesCollection(1).Trendlines.Add(XlTrendlineType.xlPolynomial)
        'write npshr data back to worksheet
        xlApp.Worksheets(WorkSheetName).activate
        xlApp.Range("C5").FormulaR1C1 = String.Format("{0:000.00}", currentSheetFlow.ToString)
        xlApp.Range("C6").FormulaR1C1 = String.Format("{0:000.00}", currentSheetHead.ToString)
    End Sub

    Private Function Interpolate(ByVal HiVal As Single, ByVal LowVal As Single, ByVal HiPctHead As Single, ByVal LowPctHead As Single, Optional ByVal ActualPctHead As Single = 0.97) As Single
        Dim PctHead As Single

        PctHead = (ActualPctHead - LowPctHead) / (HiPctHead - LowPctHead)
        Interpolate = PctHead * (HiVal - LowVal) + LowVal


    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim numOfRows As Integer = 0
        Dim wName As String = sender.selecteditem.ToString
        Dim wNamesub As String = wName.Substring(0, wName.IndexOf(" -- "))
        For Each w As Worksheet In xlInputApp.Worksheets
            If w.Name = wNamesub Then
                numOfRows = w.UsedRange.Rows.Count - 11
                w.Activate()
            End If
        Next

        Dim s As InputData
        'Dim l As List(Of InputData) = New List(Of InputData)
        pd = New PumpData

        With xlInputApp.ActiveSheet
            For r As Integer = 12 To numOfRows + 12
                s = New InputData
                s.Flow = .cells(r, 2).value
                s.SuctPress = .cells(r, 3).value
                s.DischPress = .cells(r, 4).value
                s.Temp = .cells(r, 5).value
                s.ValvePosition = .cells(r, 6).value
                lstExcelInput.Add(s)
            Next r

            'see if this is a modified sheet with serial number, etc. separate from the title, or the old sheet with one string and an = sign

            If .range("A1").value.Contains("-") Then
                pd.SerialNumber = splitString(.range("A1").value)
                pd.StartingTDH = splitString(.range("A2").value)
                pd.StartingFlow = splitString(.range("A3").value)
                pd.SuctPipeDia = String.Format("{0:0.00}", splitString(.range("A5").value))
                pd.BP = splitString(.range("E2").value)
                pd.SuctGaugeHeight = splitString(.range("E3").value)
                pd.DischGaugeHeight = splitString(.range("E4").value)
                pd.DischPipeDia = String.Format("{0:0.00}", splitString(.range("E5").value))
            Else
                'fill pump data
                pd.SerialNumber = .range("C1").value
                pd.StartingTDH = .range("C2").value
                pd.StartingFlow = .range("C3").value
                pd.SuctPipeDia = String.Format("{0:0.00}", .range("H6").value)
                pd.BP = .range("H2").value
                pd.SuctGaugeHeight = .range("H3").value
                pd.DischGaugeHeight = .range("H4").value
                pd.DischPipeDia = String.Format("{0:0.00}", .range("H5").value)
            End If

        End With

        'fill in screen
        Me.txtSN.Text = pd.SerialNumber
        Me.txtSuctGaugeHeight.Text = pd.SuctGaugeHeight
        Me.txtDischGaugeHeight.Text = pd.DischGaugeHeight
        Me.cmbSuction.SelectedItem = pd.SuctPipeDia
        Me.cmbDisch.SelectedItem = pd.DischPipeDia
        Me.txtAveTDH.Text = pd.StartingTDH
        'Me.txtFlowForCalcs.Text = pd.StartingFlow

        'use first pd from l
        rowExcelInput = 0
        blnListDone = False
        blnUsingExcelInput = True


        lblInputData.Text = "Input Data From -> " & inputFileName & " - Tab " & wNamesub
        lblInputData.Visible = True

        ListBox1.Visible = False
        lblListBox.Visible = False

        'kill excel input process that we just opened
        Dim xlProc = Process.GetProcessesByName("Excel")
        For Each p As Process In xlProc
            If p.Id = inputExcelProcessid Then
                p.Kill()
            End If
        Next

        Me.cmdSaveData.Focus()

    End Sub
    Private Function splitString(strIn As String) As String
        If strIn.Contains("=") Then
            Dim parmString() As String
            parmString = strIn.Split("=")
            Return Trim(parmString(1))
        ElseIf strIn.Contains("-") Then
            Dim split As Int16 = strIn.IndexOf("-")
            Return Trim(strIn.Substring(split + 1))
        Else
            Return ""
        End If

    End Function
    Private Function stripData(info As String) As String
        'remove data (330.18) from string like Barometric Pressure = 30.18
        Dim li As Integer = info.LastIndexOf(" ")
        stripData = info.Substring(li + 1)
    End Function

    Private Sub txtSN_Leave(sender As Object, e As EventArgs) Handles txtSN.Leave
        'serial number entered, do some lookup
        'see if the serial number exists in pumpdata

        Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDataBaseName & ";Persist Security Info=False"
        Dim SQLString As String = "SELECT TempPumpData.SerialNumber, TempPumpData.BillToCustomer, TempPumpData.ModelNumber, TempPumpData.SalesOrderNumber, TempPumpData.NPSHr, " &
            "TempPumpData.ImpellerDia, TempPumpData.DesignFlow,TempPumpData.DesignTDH, CirculationPath.Description, Voltage.Description, Frequency.Description, RPM.Description " &
            "From RPM INNER Join (((CirculationPath INNER Join TempPumpData On CirculationPath.CirculationPath = TempPumpData.CirculationPath) " &
            "INNER Join Frequency On TempPumpData.Frequency = Frequency.Frequency) INNER Join Voltage On TempPumpData.Voltage = Voltage.Voltage) ON RPM.RPM = TempPumpData.RPM " &
            "WHERE (((TempPumpData.SerialNumber)= '" & txtSN.Text & "' ));"


        Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection(ConnectionString)

            Dim cmd As OleDbCommand = New OleDbCommand(SQLString, con)
            con.Open()

            Dim rdr As OleDbDataReader
            rdr = cmd.ExecuteReader

            rdr.Read()

            If Not rdr.HasRows Then
                lblCustomer.Text = String.Empty
                lblModelNumber.Text = String.Empty
                lblSalesOrder.Text = String.Empty
                lblNPSHr.Text = String.Empty
                lblImpDia.Text = String.Empty
                lblCircPath.Text = String.Empty
                lblVoltage.Text = String.Empty
                lblFrequency.Text = String.Empty
                lblRPM.Text = String.Empty
                lblDesignFlow.Text = String.Empty
                lblDesignTDH.Text = String.Empty
            Else
                lblCustomer.Text = RdrData(rdr, "BillToCustomer")
                lblModelNumber.Text = RdrData(rdr, "ModelNumber")
                lblSalesOrder.Text = RdrData(rdr, "SalesOrderNumber")
                lblNPSHr.Text = RdrData(rdr, "NPSHr")
                lblImpDia.Text = RdrData(rdr, "ImpellerDia")
                lblCircPath.Text = RdrData(rdr, "CirculationPath.Description")
                lblVoltage.Text = RdrData(rdr, "Voltage.Description")
                lblFrequency.Text = RdrData(rdr, "Frequency.Description")
                lblRPM.Text = RdrData(rdr, "RPM.Description")
                lblDesignFlow.Text = RdrData(rdr, "DesignFlow")
                lblDesignTDH.Text = RdrData(rdr, "DesignTDH")
            End If
            rdr.Close()

        End Using
    End Sub

    Private Function RdrData(rdr As OleDbDataReader, fname As String) As String
        If IsDBNull(rdr(fname)) Then
            RdrData = String.Empty
        Else
            RdrData = rdr(fname)
        End If

    End Function
End Class