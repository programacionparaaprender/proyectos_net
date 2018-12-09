Module Module1

    Sub Main()
        Dim lista As New List(Of Persona)
        lista.Add(New Persona("06789456", "Jose", "Correa"))
        lista.Add(New Persona("06789457", "Manuel", "Correa"))
        lista.Add(New Persona("06789458", "Ana", "Correa"))
        lista.Add(New Persona("06789459", "Maria", "Correa"))
        lista.Add(New Persona("06789455", "Pedro", "Correa"))
        Dim filtro = From proc In lista Where proc.Nombre.Contains("a") Select proc
        Dim temp As List(Of Persona) = filtro.ToList
        For Each persona In 
                'ucase convierte en mayuscula
            Console.WriteLine($"{UCase(persona.Nombre)} {UCase(persona.Apellido)}")
        Next
        Console.ReadKey()

    End Sub

End Module
