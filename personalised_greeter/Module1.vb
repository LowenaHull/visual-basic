Module Module1

    Sub Main()
        Dim userName As String = Nothing
        Dim userAge As Integer = Nothing
        Dim userSalary As Double = Nothing

        Console.WriteLine("What is your name?")
        userName = Console.ReadLine()

        Console.WriteLine("How old are you?")
        userAge = Console.ReadLine()

        Console.WriteLine("What is your salary?")
        userSalary = Console.ReadLine()

        Console.Write("Your name is " & userName)
        Console.Write("     Your age is " & userAge)
        Console.Write("     Your salary is " & userSalary)
        Console.WriteLine()
        Console.WriteLine(vbCrLf)

        Console.WriteLine("Press the enter key to exit.")
        Console.ReadLine()

    End Sub

End Module
