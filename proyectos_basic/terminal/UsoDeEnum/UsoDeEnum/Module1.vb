Imports System

Module Module1
    Enum FirstDayOfWeek
        Activo1 = 1
        Activo2 = 2
        Activo3 = 3
        Activo4 = 4
    End Enum
    Sub Main()
        Dim items As Array
        items = System.Enum.GetValues(GetType(FirstDayOfWeek))
        Dim items2 As Array
        items2 = System.Enum.GetNames(GetType(FirstDayOfWeek))
        'Dim item As String
        For Each item As FirstDayOfWeek In [Enum].GetValues(GetType(FirstDayOfWeek))
            Console.WriteLine(item)
            Console.WriteLine([Enum].GetName(GetType(FirstDayOfWeek), item))
            'Console.WriteLine(items(i))
            'Console.WriteLine(items2(i))
        Next

        'For Each temp As FirstDayOfWeek In GetType(FirstDayOfWeek)
        '    Console.WriteLine(temp)
        '    Console.WriteLine(temp.ToString)
        'Next

        Console.ReadKey()
    End Sub

End Module
