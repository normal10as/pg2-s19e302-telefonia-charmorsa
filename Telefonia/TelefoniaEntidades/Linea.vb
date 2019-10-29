Imports TelefoniaEntidades
Public Class Linea
    Public Sub New(codigoArea As UShort, Numero As UInteger, equipo As Equipos)
        Me.CodigoArea = codigoArea
        Me.Numero = Numero
        Me.Equipo = equipo
    End Sub
    Private _codigoArea As UShort
    Private _equipos As Equipos
    Public Property Equipo As Equipos
        Get
            Return _equipos
        End Get
        Set(value As Equipos)
            _equipos = value
        End Set
    End Property
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value >= 100 And value <= 9999 Then
                _codigoArea = value
            End If
        End Set
    End Property

    Private _numero As UInteger
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value >= 100000 And value <= 9999999 Then
                _numero = value
            End If

        End Set
    End Property

    Public ReadOnly Property Estado As String
        Get
            If LineaEstadoActivo Then
                Return "activo"
            Else
                Return "suspendido"
            End If
        End Get
    End Property
    Private LineaEstadoActivo As Boolean = True
    Public Sub suspender()
        LineaEstadoActivo = False
    End Sub
    Public Sub reactivar()
        LineaEstadoActivo = True
    End Sub

    Public Overrides Function toString() As String
        Dim resultado As String
        resultado = CodigoArea & " " & Numero
        If Not LineaEstadoActivo Then
            resultado += " suspendida"
        End If
        Return resultado
    End Function
End Class