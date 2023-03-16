Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Threading
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Structure AddType

    Dim certNumber As Integer
    Dim certRange As Integer
    Dim dSold As Date
    Dim soldTo As String
    Dim dRedeemed As String
    Dim notes As String
    Dim fut1 As String
    Dim fut2 As String
End Structure
Module Module1
    Public gridRow As Integer
    Public endReached As Boolean
    Public y As Integer
    Public i As Integer
    Public lastRow As Integer

    ' Public giftArray() As AddType
    Public giftList As New List(Of AddType)
    Public giftWork As AddType

    Public excelFname As String
    Public xl As Excel.Application
    Public xlsheet As Excel.Worksheet
    Public xlwbook As Excel.Workbook
    Public giftCert As New AddType
    Public gridLoaded As Boolean
    Public alreadyLoaded As Boolean
    Public todayIs As String
    Public lastCert As Integer
    Public nextCert As Integer
    Public startIns As Integer
    Public lastListRow As Integer
    Public rangeCnt As Integer
    Public rangeStart As Integer, rangeEnd As Integer
    Public giftBefore As Integer  'row of the cert before Range insert
    Public giftAfter As Integer   'row of the cert after Range insert
    Public changesMade As Boolean  'true if any sales/redeems made
    Public giftPath As String

    Public Function verValidDate(ByVal checkInputValue As String) As Boolean

        Dim isValid As Boolean  ' = regex.IsMatch(checkInputValue)

        'Verify whether entered date is Valid date.
        Dim dt As DateTime
        isValid = DateTime.TryParseExact(checkInputValue, "dd/MM/yyyy", New CultureInfo("en-GB"), DateTimeStyles.None, dt)
        Return isValid

    End Function

    Public Sub setNext()
        ' cklocInList(999999)
        'If lastCert = 900000 Then

        ' End If
        Dim gwCnt As Integer
        Dim huh As Integer = giftList.Count  '
        gwCnt = giftList.Count - 1  '01/19/2023 this is 900000 end of file row
        giftCert = giftList(gwCnt)
        If gwCnt = 0 Then
            lastCert = giftCert.certNumber
            Exit Sub
        End If
        'get last cert nr before 900000 cert
        gwCnt = gwCnt - 1
        giftCert = giftList(gwCnt)
        lastCert = giftCert.certNumber
        nextCert = lastCert + 1
    End Sub


    Public Sub secWait(wsecs As Integer)
        For loopVar = 1 To wsecs Step 1
            Thread.Sleep(1000)
        Next
    End Sub
    Public Sub msWait30(ms As Integer) 'really 125ms
        For loopVar = 1 To ms Step 1
            Thread.Sleep(125)
        Next
    End Sub


    Public Sub reGenExcel()
        Dim rgePath As String = "C:\Gift Certificates\"
        '1) copy Gift Certificate from Gift Certificate Master.xlsx to Gift Certificate Master Temp.xlsx
        FileCopy("C:\Gift Certificates\Gift Certificates Master.xlsx", "C:\Gift Certificates\Gift Certificates Master Temp.xlsx")
        '2) remove old backup (if present)
        If File.Exists(rgePath & "Gift Certificates Backup.xlsx") Then
            My.Computer.FileSystem.DeleteFile(rgePath & "Gift Certificates Backup.xlsx")
        End If
        '3) copy current .xlsx file to Backup
        FileCopy("C:\Gift Certificates\Gift Certificates.xlsx", "C:\Gift Certificates\Gift Certificates Backup.xlsx")
        '4) generate new .xlsx file using giftList 
        xl = New Microsoft.Office.Interop.Excel.Application
        excelFname = "C:\Gift Certificates\Gift Certificates Master Temp.xlsx"
        lastRow = UsedRows(excelFname, "Sheet1") + 1
        xlwbook = xl.Workbooks.Open(excelFname)
        xlsheet = xlwbook.Sheets.Item(1)

        Dim eRow As Integer = 6, gRow As Integer = 0
        For gRow = 0 To giftList.Count - 1
            'build eRow here
            xlsheet.Cells(eRow, 1).Value = giftList(gRow).certNumber
            xlsheet.Cells(eRow, 2).Value = giftList(gRow).certRange
            xlsheet.Cells(eRow, 3).Value = giftList(gRow).dSold
            xlsheet.Cells(eRow, 4).Value = giftList(gRow).soldTo
            xlsheet.Cells(eRow, 5).Value = giftList(gRow).dRedeemed
            xlsheet.Cells(eRow, 6).Value = giftList(gRow).notes
            xlsheet.Cells(eRow, 7).Value = giftList(gRow).fut1
            xlsheet.Cells(eRow, 8).Value = giftList(gRow).fut2
            Call DoSummary_Out(giftList(gRow))
            eRow += 1
        Next
        xlwbook.Close(SaveChanges:=True)
        xl.Quit()
        'Now delete current Gift Certificates.xlsx
        My.Computer.FileSystem.DeleteFile(rgePath & "Gift Certificates.xlsx")
        ' Then rename the ...Temp.xlsx to Gift Certificates.xlsx
        My.Computer.FileSystem.RenameFile("C:\Gift Certificates\Gift Certificates Master Temp.xlsx", "Gift Certificates.xlsx")
        alreadyLoaded = False
    End Sub



    Public Sub readABook(nRow)
        ' Dim certNumber As Integer
        ' Dim certRange As Integer
        ' Dim dSold As Date
        ' Dim soldTo As String
        ' Dim dRedeemed As Date
        ' Dim notes As String
        ' Dim fut1 As String
        ' Dim fut2 As String
        'Summary1
        'Dim BeginSoldNred As Integer
        'Dim BeginSoldRed As Integer
        'Dim EndSoldNred As Integer
        ' Dim endSoldRed As Integer

        Dim huh As Integer

        With giftCert
            .certNumber = getCellVal(nRow, 1)
            huh = .certNumber
            If .certNumber = 0 Then
                '    MsgBox("Last Row=" & nRow - 1)
                endReached = True
                Exit Sub
            End If
            .certRange = getCellVal(nRow, 2)
            .dSold = getCellVal(nRow, 3)
            .soldTo = getCellVal(nRow, 4)
            .dRedeemed = getCellVal(nRow, 5)
            .notes = getCellVal(nRow, 6)
            .fut1 = getCellVal(nRow, 7)
            .fut2 = getCellVal(nRow, 8)
            '            Summary1.TotalSold += 1    'add to total sold 
            DoSummary_In(giftCert)

        End With
        ' giftArray(UBound(giftArray)) = giftCert
        'ReDim Preserve giftArray(UBound(giftArray) + 1)
        giftList.Add(giftCert)


    End Sub

    Public Function getCellVal(gvRow, gvCol) As String
        Dim tstRange As String
        tstRange = RangeAddressTest(xlsheet, gvRow, gvCol)
        getCellVal = xlsheet.Range(tstRange).Value
    End Function



    Public Function RangeAddressTest(inSheet As Excel.Worksheet, inRow As Integer, inCol As Integer) As String

        Dim xlSheet As Excel.Worksheet

        Dim cell As Range
        Dim fullAddress As String
        Dim rowAddress As String, columnAddress As String

        Dim detailsArray
        xlSheet = inSheet

        'select your cell
        cell = xlSheet.Cells(inRow, inCol)



        fullAddress = cell.Address

        detailsArray = Split(fullAddress, "$")

        columnAddress = detailsArray(1)
        rowAddress = detailsArray(2)


        '       MsgBox("Full Address: " & fullAddress _
        '               & vbCrLf & vbCrLf &
        '              "Column Address: " & columnAddress _
        '               & vbCrLf & vbCrLf &
        '              "Row Address: " & rowAddress)
        RangeAddressTest = "" & columnAddress & rowAddress & ""

    End Function
    Public Function UsedRows(
    ByVal FileName As String, ByVal SheetName As String) As Integer

        Dim RowsUsed As Integer = -1

        If IO.File.Exists(FileName) Then
            Dim xlApp As Excel.Application = Nothing
            Dim xlWorkBooks As Excel.Workbooks = Nothing
            Dim xlWorkBook As Excel.Workbook = Nothing
            Dim xlWorkSheet As Excel.Worksheet = Nothing
            Dim xlWorkSheets As Excel.Sheets = Nothing

            xlApp = New Excel.Application
            xlApp.DisplayAlerts = False
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(FileName)

            xlApp.Visible = False

            xlWorkSheets = xlWorkBook.Sheets

            For x As Integer = 1 To xlWorkSheets.Count

                xlWorkSheet = CType(xlWorkSheets(x), Excel.Worksheet)

                If xlWorkSheet.Name = SheetName Then
                    Dim xlCells As Excel.Range = Nothing
                    xlCells = xlWorkSheet.Cells

                    Dim xlTempRange As Excel.Range =
                        xlCells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell)

                    RowsUsed = xlTempRange.Row
                    Runtime.InteropServices.Marshal.FinalReleaseComObject(xlTempRange)
                    xlTempRange = Nothing

                    Runtime.InteropServices.Marshal.FinalReleaseComObject(xlCells)
                    xlCells = Nothing

                    Exit For
                End If

                Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkSheet)
                xlWorkSheet = Nothing

            Next

            xlWorkBook.Close()
            xlApp.UserControl = True
            xlApp.Quit()

            ' ReleaseComObject(xlWorkSheets)
            ' ReleaseComObject(xlWorkSheet)
            ' ReleaseComObject(xlWorkBook)
            '' ReleaseComObject(xlWorkBooks)
            '  ReleaseComObject(xlApp)
        Else
            Throw New Exception("'" & FileName & "' not found.")
        End If

        Return RowsUsed

    End Function

    Public Function txtCenter(txt, cnt)
        Dim cWork As String, i
        cWork = Space(cnt)
        i = (cnt - Len(txt)) / 2
        Mid(cWork, i, Len(txt)) = txt
        txtCenter = cWork
    End Function
    Public Sub showGrid2()
        Dim y As Integer
        Dim huh As Integer
        Dim c1 As String, c2 As String, c3 As String, c4 As String, c5 As String, c6 As String

        gridRow = 1
        'huh = UBound(giftArray)
        huh = giftList.Count

        gridRow = 1
        For y = 0 To giftList.Count - 1
            giftCert = giftList(y)
            With giftCert
                Dim x As String() = {giftCert.certNumber, giftCert.certRange, giftCert.dSold, giftCert.soldTo, giftCert.dRedeemed, giftCert.notes, giftCert.fut1, giftCert.fut2}
                Reports.DataGridView1.Rows.Add(x)
            End With
        Next

    End Sub
    Public Sub addRow(rowData As AddType)

    End Sub
    Public Sub LoadGiftFile()
        If System.IO.File.Exists("C:\Gift Certificates\Gift Certificates.xlsx") Then
            DoLoad()
        Else
            'the file doesn't exist
            'copy the Master.xlsx to the file
            FileCopy("C:\Gift Certificates\Gift Certificates Master.xlsx", "C:\Gift Certificates\Gift Certificates.xlsx")

            DoLoad()
        End If
    End Sub
    Public Sub DoLoad()
        xl = New Microsoft.Office.Interop.Excel.Application
        excelFname = "C:\Gift Certificates\Gift Certificates.xlsx"
        lastRow = UsedRows(excelFname, "Sheet1") + 1
        xlwbook = xl.Workbooks.Open(excelFname)
        xlsheet = xlwbook.Sheets.Item(1)

        'read complete file
        i = 6
        Do Until endReached = True          'was lastRow = i 01/19/2023
            Call readABook(i)
            '            If endReached = True Then Exit Do
            i = i + 1
        Loop
        xlwbook.Close()
        xl.UserControl = True
        xl.Quit()
        alreadyLoaded = True
        frmMenu.PictureBox1.Visible = False
        frmMenu.Label1.Visible = False

    End Sub
    Public Sub upDateExcel()
        'if changesMade = True
        '1) copy current file the backup
        '2) open master Gift Certiface file
        '3) write new master after updating from giftList
        '4) close
    End Sub


    Public Function cklocInList(wCert As Integer) As Boolean 'checks if goes on end of list
        Dim gwCnt As Integer
        Dim huh As Integer = giftList.Count  '


        gwCnt = giftList.Count - 1  '01/19/2023 this is 900000 end of file row
        giftCert = giftList(gwCnt)
        lastCert = giftCert.certNumber
        If wCert > lastCert Then
            cklocInList = False  'greater than last, then add it
            Exit Function
        End If
        ' Either needs to be inserted or a duplicate
        '       nextCert =

        cklocInList = True
        Return cklocInList
    End Function
    Public Function findInList(fCert As String) As Boolean
        Dim fWork As AddType
        For i As Integer = 0 To giftList.Count - 1
            fWork = giftList(i)
            If fCert = fWork.certNumber Then
                findInList = True
                Return findInList
            End If
        Next
        findInList = False
        Return findInList


    End Function

End Module
