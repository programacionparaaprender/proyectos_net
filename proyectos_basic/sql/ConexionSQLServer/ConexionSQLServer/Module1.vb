

Module Module1

    Sub Main()
        'MostrarEstructuraProcedimiento()
        Dim conexion As New Conexion
        'Dim dt As DataTable = conexion.MostrarEstructuraAdapter()

        'MostrarEstructuraFuncion()
        'insertarProcedure()
        Dim lista As List(Of Usuario) = conexion.MostrarLista()
        For Each usuario In lista
            Console.WriteLine("{0} {1} {2}", usuario.Id, usuario.Usuario, usuario.Pass)
        Next
        Dim temp = lista.Where(Function(a) a.Usuario.Contains("William"))
        Dim temp2 = From proc In lista
                    Where proc.Usuario.Contains("William")
                    Select proc
        'Console.WriteLine(temp2.Usuario)
        Console.ReadKey()
    End Sub

End Module
