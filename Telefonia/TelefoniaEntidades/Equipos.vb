Public Class Equipos
    Private _serieEquipo As String
    Public Sub New(modelo As Modelo, serieEquipo As UShort)
        Me.SerieEquipo = serieEquipo
        Me.Modelo = modelo
    End Sub
    Public Property SerieEquipo As String
        Get
            Return _serieEquipo
        End Get
        Set(value As String)
            If value.Length <= 15 And value.Length > 0 Then
                _serieEquipo = value
            End If
        End Set
    End Property
    Private _fechaVenta As Date
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
    Public Sub vender(fecha As Date)
        _fechaVenta = fecha
    End Sub
    Public Overrides Function toString() As String
        Return SerieEquipo
    End Function
    Private _modelo As Modelo
    Public Property Modelo As Modelo
        Get
            Return _Modelo
        End Get
        Set(value As Modelo)
            _Modelo = value
        End Set
    End Property
End Class