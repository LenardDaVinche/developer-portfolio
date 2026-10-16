Module Module1

    Sub Main()

        Console.Write("Loops demonstration.  Hit <ENTER> to start")
        Console.ReadLine()

        ' A 'for' loop example, using 'break' to break out prematurely
        Console.WriteLine()
        Console.Write("A 'for' loop demonstration.  Hit <ENTER> to start")
        Console.ReadLine()
        For i As Integer = 0 To 9 Step 1

            Console.Write("Enter a city : ")
            Dim name As String = Console.ReadLine()
            If (name.Trim() = "") Then
                Exit For    ' Break If user entered Nothing
            End If

            Console.WriteLine("City number " + (i + 1).ToString + " is " + name)
        Next


        ' A 'do while' loop example. This loop will always execute at least once
        Console.WriteLine()
        Console.Write("A 'do while' loop demonstration.  Hit <ENTER> to start")
            Console.ReadLine()
        Dim price As Double = 0
        Do
            Console.Write("Enter a price, or 0 : ")
            price = Convert.ToDouble(Console.ReadLine())
        Loop While (price > 0)



        ' A 'while' loop example. This loop will execute zero or more times
        Console.WriteLine()
        Console.Write("A 'while' loop demonstration.  Hit <ENTER> to start")
        Console.ReadLine()
        Dim age As Integer = 1
        Do While (age <> 0)
            Console.Write("Enter an age, or 0 : ")
            age = Convert.ToInt32(Console.ReadLine())
        Loop



        Console.Write("HIt <ENTER> to finish and close application")
        Console.ReadLine()

    End Sub

End Module
