Imports System.Text.RegularExpressions

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

    Public Shared Function ValidaEmail(email As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        ' Verifica se o email corresponde a pattern/mascara
        Dim emailAddressMatch As Match = Regex.Match(email, pattern)

        ' Caso corresponda
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If

        'For index As Integer = 0 To email.Length - 1
        'MsgBox(email.Chars(index), MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
        'Next

    End Function

    Public Shared Function ApenasLetras(str As String) As Boolean

        Dim pattern As String = "^[a-zA-Z]$"

        ' Verifica se a letra corresponde a pattern/mascara
        'Dim letraMatch As Match = Regex.Match(letra, pattern)

        ' Caso corresponda
        'If letraMatch.Success Then
        'Return True
        'Else
        'Return False
        'End If

        For index As Integer = 0 To str.Length - 1

            Dim letraMatch As Match = Regex.Match(str.Chars(index), pattern)

            If letraMatch.Success Then

            Else

                If str.Chars(index) <> " " Then
                    Return False
                End If

            End If
            'MsgBox(letra.Chars(index), MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")

        Next

        Return True

    End Function

End Class
