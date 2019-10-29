Imports TelefoniaEntidades
Module LineaTest
    Public Sub linea()
        Dim marca1 As New Marca("samsung")
        Dim modelo1 As New Modelo("s8+", marca1)
        Dim equipo1 As New Equipos(modelo1, "5646974")
        Dim linea1 As New Linea(3764, 804323, equipo1)
        Console.WriteLine("Codigo area + numero: {0}{1}", linea1.CodigoArea, linea1.Numero)
        Console.WriteLine("Suspendo la linea")
        linea1.suspender()
        Console.WriteLine("Estado de linea: " & linea1.Estado)
        Console.WriteLine("toString: " & linea1.toString)
        Console.WriteLine("activo la linea")
        linea1.reactivar()
        Console.WriteLine("Estado de linea: " & linea1.Estado)
        Console.WriteLine("toString: " & linea1.toString)

    End Sub
End Module