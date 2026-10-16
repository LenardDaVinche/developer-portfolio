Module Module1

    Sub Main()

        Dim fName As String
        Console.Write("How much money do you have in your pocket?")
        fName = Console.ReadLine()

        If (fName >= 2.0 And fName < 1000000.0) Then
            Console.Write("You can buy a sandwich.")
        ElseIf (fName < 2.0) Then
            Console.WriteLine("You don't have enough money.")
        ElseIf (fName >= 1000000.0) Then
            Console.WriteLine("That's a lot of money!")

        End If
        Console.ReadLine()
    End Sub

End Module
