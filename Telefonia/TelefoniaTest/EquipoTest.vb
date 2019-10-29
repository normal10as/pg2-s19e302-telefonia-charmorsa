Imports TelefoniaEntidades
Module EquipoTest
    Public Sub equipo()
        Dim equipo1 As New Equipos(New Modelo("one", New Marca("motorola")), "12345")
        Console.WriteLine("Fecha de venta:" & equipo1.FechaVenta())
        equipo1.vender(Date.Now)
        Console.WriteLine("ToString: " & equipo1.SerieEquipo)
        Console.WriteLine("ToString: " & equipo1.Modelo.toString)
    End Sub
End Module