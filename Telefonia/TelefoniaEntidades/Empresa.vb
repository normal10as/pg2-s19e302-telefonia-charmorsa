Public Class Empresa
    Private _RazonSocial As String
    Public Property RazonSocial As String
        Get
            Return _RazonSocial

        End Get
        Set(value As String)
            _RazonSocial = value
        End Set
    End Property


    Private _cuit As String
    Public Property Cuit As String
        Get
            Return _cuit

        End Get
        Set(value As String)
            _cuit = value
        End Set
    End Property
End Class