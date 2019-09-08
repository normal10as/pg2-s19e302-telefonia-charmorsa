Public Class Modelo
    Public Sub New()
        Me.New("")
    End Sub
    Public Sub New(Nombre As String)
        Me.Nombre = Nombre
    End Sub
    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

End Class