Public Class Equipo
    Public Sub New()
        Me.New("")
    End Sub

    Public Sub New(Serie As String)
        Me.Serie = Serie
    End Sub

    Private _serie As String
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = value
        End Set
    End Property

    Private _fechaVenta As Date
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
End Class