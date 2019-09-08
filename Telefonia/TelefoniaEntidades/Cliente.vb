Public Class Cliente
    Private _cliente As UInteger
    Public Property Cuenta As UInteger
        Get
            Return _cliente
        End Get
        Set(value As UInteger)
            _cliente = value
        End Set
    End Property

End Class