Public Class EmpLivro
    Private codLivro As Integer
    Private ra As Integer
    Private dataRetirada As Date
    Private dataEntrega As Date

    Public Sub SetCodLivro(codLivro As Integer)
        Me.codLivro = codLivro
    End Sub

    Public Sub SetRa(ra As Integer)
        Me.ra = ra
    End Sub

    Public Sub SetDataRetirada(dataRetirada As Date)
        Me.dataRetirada = dataRetirada
    End Sub

    Public Sub SetDataEntrega(dataEntrega As Date)
        Me.dataEntrega = dataEntrega
    End Sub

    Public Function GetRa()
        Return Me.ra
    End Function

    Public Function GetCodLivro()
        Return Me.codLivro
    End Function

    Public Function GetDataRetirada()
        Return Me.dataRetirada
    End Function

    Public Function GetDataEntrega()
        Return Me.dataEntrega
    End Function

End Class
