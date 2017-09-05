Public Class formSummaRuut
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strA As String
        Dim strB As String
        Dim strC As String
        Dim strD As String
        If txtA.Text.Length = 0 Then
            MsgBox("Sisestage operand a!")
            Return
        ElseIf txtB.Text.Length = 0 Then
            MsgBox("Sisestage operand b!")
            Return
        End If
        strA = txtA.Text
        lblSisestatudA.Text = arvuLyhendamine(strA)
        strA = strA.PadLeft(8, "0")
        strB = txtB.Text
        lblSisestatudB.Text = arvuLyhendamine(strB)
        strB = strB.PadLeft(8, "0")
        My.Computer.FileSystem.WriteAllText("C:\testvektorid.txt", vbCrLf, True)
        vaheTulemusteFailiGenereerimine(strA, strB)
        strC = liitmine(strA, strB, 8)
        lblSumma.Text = arvuLyhendamine(strC)
        strC = strC.PadLeft(9, "0")
        strD = korrutamine(strC)
        lblKorrutis.Text = arvuLyhendamine(strD)
    End Sub

    Private Function liitmine(ByVal strLiidetav1 As String, ByVal strLiidetav2 As String, ByVal intLength As Integer)
        Dim summaEhitaja As New Text.StringBuilder()
        summaEhitaja.Length = 0
        Dim strSumma As String = StrDup(intLength, "0")
        Dim strTyhi As String = StrDup(intLength, "0")
        Dim strCarry As New Text.StringBuilder()
        strCarry.Length = 0
        strCarry.Insert(0, strTyhi)
        summaEhitaja.Insert(0, strTyhi)
        summaEhitaja(summaEhitaja.Length - 1) = CStr(Val(strLiidetav1(strLiidetav1.Length - 1)) Xor Val(strLiidetav2(strLiidetav2.Length - 1)))
        strCarry(strCarry.Length - 1) = CStr(Val(strLiidetav1(strLiidetav1.Length - 1)) And Val(strLiidetav2(strLiidetav2.Length - 1)))
        For i As Integer = 0 To (strLiidetav2.Length - 2)
            summaEhitaja(summaEhitaja.Length - 2 - i) = CStr(Val(strLiidetav1(strLiidetav1.Length - 2 - i)) _
                Xor Val(strLiidetav2(strLiidetav2.Length - 2 - i)) Xor Val(strCarry(strCarry.Length - 1 - i)))
            strCarry(strCarry.Length - 2 - i) = CStr(((Val(strLiidetav1(strLiidetav1.Length - 2 - i)) _
                Xor Val(strLiidetav2(strLiidetav2.Length - 2 - i))) And Val(strCarry(strCarry.Length - 1 - i))) _
                Or (Val(strLiidetav1(strLiidetav1.Length - 2 - i)) And Val(strLiidetav2(strLiidetav2.Length - 2 - i))))
        Next
        strSumma = summaEhitaja.ToString
        If summaEhitaja.Length - strLiidetav2.Length > 0 Then
            If Val(strCarry(strCarry.Length - strLiidetav2.Length)) = 1 Then
                summaEhitaja(summaEhitaja.Length - strLiidetav2.Length - 1) = CStr(1)
                strSumma = summaEhitaja.ToString
            End If
        ElseIf summaEhitaja.Length - strLiidetav2.Length = 0 Then
            If Val(strCarry(0)) = 1 Then
                strSumma = "1" & strSumma
            End If
        End If
        Return strSumma
    End Function

    Private Function korrutamine(ByVal strC As String)
        Dim tulemuseEhitaja As New Text.StringBuilder()
        tulemuseEhitaja.Length = 0
        Dim strTulemus As String = StrDup(17, "0")
        Dim strTyhi As String = StrDup(17, "0")
        Dim strSummaShift As String
        tulemuseEhitaja.Insert(0, strTyhi)
        strSummaShift = arvuLyhendamine(strC)
        For counter As Integer = 8 To 0 Step -1
            If Val(strC(counter)) = 1 Then
                vaheTulemusteFailiGenereerimine(strTulemus, strSummaShift)
                strTulemus = liitmine(strTulemus, strSummaShift, 17)
            Else
                vaheTulemusteFailiGenereerimine(strTulemus, strTyhi)
            End If
            strSummaShift = strSummaShift & "0"
        Next
        Return strTulemus
    End Function

    Private Function arvuLyhendamine(ByVal strArv As String)
        While Val(strArv(0)) = 0 And strArv.Length > 1
            strArv = strArv.Remove(0, 1)
        End While
        Return strArv
    End Function

    Private Sub vaheTulemusteFailiGenereerimine(ByVal strOperand1 As String, ByVal strOperand2 As String)
        strOperand1 = strOperand1.PadLeft(17, "0")
        strOperand2 = strOperand2.PadLeft(17, "0")
        strOperand1 = StrReverse(strOperand1)
        strOperand2 = StrReverse(strOperand2)
        Dim strVektor As String = strOperand1 & vbTab & strOperand2 & vbCrLf
        My.Computer.FileSystem.WriteAllText("C:\testvektorid.txt", strVektor, True)
    End Sub
End Class