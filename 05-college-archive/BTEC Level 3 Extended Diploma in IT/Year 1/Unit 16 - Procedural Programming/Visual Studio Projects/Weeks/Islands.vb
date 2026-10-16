Module Module1

    Sub Main()

        Dim fName As String
        Console.Write("What island do you live on?")
        fName = Console.ReadLine()

        If fName.ToUpper() = "JERSEY" Then
            Console.WriteLine("Hey, that's pretty good!")
            Console.ReadLine()
        ElseIf fName.ToUpper() = "GUERNSEY" Then
            Console.WriteLine("That's good to know!")
            Console.ReadLine()
        ElseIf fName.ToUpper() = "SARK" Then
            Console.WriteLine("How do you even have a PC?")
            Console.ReadLine()
        ElseIf fName.ToUpper() = "United Kingdom" Then
            Console.WriteLine("Great!")
            Console.ReadLine()
        ElseIf fName.ToUpper() = "WHAT IS YOUR NAME?" Then
            Console.WriteLine("I'm a computer. I have no designated name.")
            Console.ReadLine()

        End If

    End Sub

End Module