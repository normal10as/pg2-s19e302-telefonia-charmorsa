Public Class Modelo
    Public Sub New(nombreModelo As String, marca As Marca)
        Me.NombreModelo = nombreModelo
        Me.Marca = marca
    End Sub
    Private _nombreModelo As String
    Private _marca As Marca
    Public Property NombreModelo As String
        Get
            Return _nombreModelo
        End Get
        Set(value As String)
            If value.Length <= 50 And value.Length > 0 Then
                _nombreModelo = value
            End If
        End Set
    End Property

    Public Property Marca As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property
    Public Overrides Function toString() As String
        Return NombreModelo
    End Function
End Class