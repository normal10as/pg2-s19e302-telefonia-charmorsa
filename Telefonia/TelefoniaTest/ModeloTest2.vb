Imports TelefoniaEntidades
Module ModeloTest
    Public Sub modelo()
        Dim modelo1 As New Modelo("one", New Marca("motorola"))
        Console.WriteLine("Nombre modelo: " & modelo1.NombreModelo)
        Console.WriteLine("ToString: " & modelo1.toString())
        Console.WriteLine("ToString: " & modelo1.Marca.toString())
    End Sub
End Module