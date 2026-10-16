Module Module1

    Sub Main()

        Dim numbers As New List(Of Double)

        numbers.Add("1")

        Dim contained As Boolean = numbers.Contains("1")

        If (contained = True) Then
            Console.WriteLine("The number 1 has been added")

        End If

        numbers.Remove("1")

        Do While (True)

            Console.Write("enter a number : ")
            Dim number As String = Console.ReadLine()

            number = number.Trim()

            If (number = "") Then

                Console.WriteLine("No number entered")
            End If

            If (numbers.Contains(number)) Then

                Console.WriteLine(number + " is already in list")

            Else

                numbers.Add(number)

                Console.WriteLine()
                Console.WriteLine("List currently contains the following")
                For Each somenumber As String In numbers
                    Console.WriteLine(somenumber)
                    Console.WriteLine()
                Next

            End If

            Console.Write("enter a number to remove from the list : ")
            number = Console.ReadLine()

            number = number.Trim()

            If (numbers.Contains(number)) Then

                numbers.Remove(number)

                Console.WriteLine()
                Console.WriteLine("List currently contains the following")
                For Each somenumber As String In numbers
                    Console.WriteLine(somenumber)
                    Console.WriteLine()
                Next

            End If

        Loop

    End Sub

End Module
