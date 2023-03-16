Imports System.Globalization

Module Module2
    Public Structure SummarIes
        Dim CurrentSold As Integer
        Dim CurrentRedem As Integer
        Dim TotalRcdsIn As Integer
        Dim TotalRcdsOut As Integer
        Dim BeginSoldNred As Integer
        Dim BeginSoldRed As Integer
        Dim EndSoldNred As Integer
        Dim EndSoldRed As Integer

    End Structure
    Public Summary1 As SummarIes
    Public Sub DoSummary_In(In_Work As AddType)
        If In_Work.certNumber = "900000" Then Exit Sub
        Dim IsDate As Boolean = CkIsDate(In_Work.dRedeemed)
        Summary1.TotalRcdsIn += 1
        If IsDate = True Then
            Summary1.BeginSoldRed += 1
        Else
            Summary1.BeginSoldNred += 1
        End If
    End Sub
    Public Sub DoSummary_Out(Out_Work As AddType)
        If Out_Work.certNumber = "900000" Then Exit Sub
        Summary1.TotalRcdsOut += 1
        Dim IsDate As Boolean = CkIsDate(Out_Work.dRedeemed)
        If IsDate = True Then
            Summary1.EndSoldRed += 1
        Else
            Summary1.EndSoldNred += 1
        End If
    End Sub
    Public Function CkIsDate(inDate As String) As Boolean
        Dim iDLeng As Integer = Len(inDate)
        If iDLeng = 0 Then Return False
        Return True
    End Function
    Public Sub SumSame() 'no change this run
        Summary1.EndSoldRed = Summary1.BeginSoldRed
        Summary1.EndSoldNred = Summary1.BeginSoldNred
    End Sub



End Module
