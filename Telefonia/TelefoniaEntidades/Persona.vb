Public Class Persona
    Public Sub New()
        Me.New("", "", 0)
    End Sub
    Public Sub New(Apellido As String, Nombre As String, Documento As UInteger)
        Me.Apellido = Apellido
        Me.Nombre = Nombre
        Me.Documento = Documento
    End Sub

    Private _apellido As String
    Public Property Apellido As String
        Get
            Return _apellido

        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre

        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private _documento As String
    Public Property Documento As UInteger
        Get
            Return _documento

        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property
End Class