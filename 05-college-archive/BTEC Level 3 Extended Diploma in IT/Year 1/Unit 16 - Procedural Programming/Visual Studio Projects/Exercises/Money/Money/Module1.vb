Module Module1

    Sub Main()

        Dim fName As String
        Console.Write("How much money do you have in your pocket?")
        fName = Console.ReadLine()

        If (fName >= 2.0 And fName < 1000000.0) Then
            Console.Write("You can buy a sandwich.")
        ElseIf (fName < 2.0) Then
            Console.WriteLine("You need a Job.")
        ElseIf (fName >= 1000000.0) Then
            Console.WriteLine("You're rich!")

        End If
        Console.ReadLine()
    End Sub

End Module
