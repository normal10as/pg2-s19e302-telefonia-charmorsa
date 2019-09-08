Public Class Equipo
    Private _serie As String
    Public ReadOnly Property Serie As String
        Get
            Return _serie
        End Get

    End Property

    Private _fechaVenta As Date
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
End Class