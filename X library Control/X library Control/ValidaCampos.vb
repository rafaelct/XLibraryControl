Public Class ValidaCampos

    Public Shared Function ApenasNumeros(l As Char)

        REM Dim str = "abcdefghijklmnopqrstuvxwyzABCDEFGHIJKLMNOPQRSTUVXWYZ"

        Console.WriteLine(Asc(l))

        If Asc(l) = 8 Then
            Return l
        End If

        Select Case l
            Case "0"
                ApenasNumeros = l
            Case "1"
                ApenasNumeros = l
            Case "2"
                ApenasNumeros = l
            Case "3"
                ApenasNumeros = l
            Case "4"
                ApenasNumeros = l
            Case "5"
                ApenasNumeros = l
            Case "6"
                ApenasNumeros = l
            Case "7"
                ApenasNumeros = l
            Case "8"
                ApenasNumeros = l
            Case "9"
                ApenasNumeros = l
            Case Else
                ApenasNumeros = ""
                MsgBox("Favor inserir apenas números!", vbExclamation, "CAMPO TIPO NÚMERO")
        End Select
    End Function
End Class
