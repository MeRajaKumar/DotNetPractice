Module Module1

    Sub Main()
        Dim i, j, k As Integer
        System.Console.WriteLine("Plz enter two number for addition :- ")
        i = Convert.ToInt32(Console.ReadLine())
        j = Convert.ToInt32(Console.ReadLine())
        k = i + j

        Console.WriteLine("Sum of two numbers = " & k)
        Console.ReadKey()
    End Sub

End Module
