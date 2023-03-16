Imports System.Windows.Controls

Public Class Summary
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a New row first as it will include the columns you've created at design-time.
        Application.DoEvents()
        '   Public Structure SummarIes
        '      Dim CurrentSold As Integer
        '       Dim CurrentRedem As Integer
        '       Dim TotalSold As Integer
        '       Dim TotalRedem As Integer
        '       Dim BeginSoldNred As Integer
        '      Dim BeginSoldRed As Integer
        '      Dim EndSoldNred As Integer
        '      Dim endSoldRed As Integer
        '
        '      End Structure
        '       Public Summary1 As SummarIes
        Dim rowId As Integer = Dgv.Rows.Add()

        ' Grab the New row!
        Dim row As DataGridViewRow = Dgv.Rows(rowId)

        ' Add the data
        row.Cells("Column1").Value = "Sales-Not Redeemed"
        Dim c2Amt = Summary1.BeginSoldNred.ToString("N0")
        row.Cells("Column2").Value = c2Amt
        Dim c3Amt = Summary1.EndSoldNred.ToString("N0")
        row.Cells("Column3").Value = c3Amt
        '***************************
        rowId = Dgv.Rows.Add
        row = Dgv.Rows(rowId)
        row.Cells("Column1").Value = "Sales-Redeemed"
        c2Amt = Summary1.BeginSoldRed.ToString("N0")
        row.Cells("Column2").Value = c2Amt
        c3Amt = Summary1.EndSoldRed.ToString("N0")
        row.Cells("Column3").Value = c3Amt
        '******************************
        rowId = Dgv.Rows.Add
        row = Dgv.Rows(rowId)
        row.Cells("Column1").Value = "Total Records"
        c2Amt = Summary1.TotalRcdsIn.ToString("N0")
        row.Cells("Column2").Value = c2Amt
        c3Amt = Summary1.TotalRcdsOut.ToString("N0")
        row.Cells("Column3").Value = c3Amt

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim box = New frmMenu()
        Me.Close()
        box.Show()

    End Sub
End Class