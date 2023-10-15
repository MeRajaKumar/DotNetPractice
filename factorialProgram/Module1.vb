Module Module1

    Sub Main()

        Dim num, fact As Integer
        num = 0
        fact = 1
        System.Console.WriteLine("plz eneter any integer no:->")
        num = Convert.ToInt32(Console.ReadLine())
        While num > 0
            fact = fact * num
            System.Console.Write(num & " * ")
            num = num - 1
        End While
        System.Console.WriteLine(Chr(8) & Chr(8) & " = " & fact)
        Console.ReadKey()

    End Sub

End Module
