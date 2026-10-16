Module Module1

    Sub Main()

        'Create a VB List to store strings
        'Note use of the 'new' keyword. We'll talk about this
        'a lot more when we get into Object-Oriented Programming (OOP)
        Dim names As New List(Of String)


        ' --------------------------------------------------------------------------------
        ' Some play first!
        ' --------------------------------------------------------------------------------
        ' 

        ' Add a name to the list
        names.Add("Leandro")


        ' Does the list contain the name Christopher
        Dim contained As Boolean = names.Contains("Leandro")

        If (contained = True) Then
            Console.WriteLine("Well done. The name Leandro has been added to the list")
        End If


        ' Remove a name from the list
        names.Remove("Leandro")


        ' Loop forever!!!
        Do While (True)

            ' --------------------------------------------------------------------------------
            ' Now get some user interaction and add a name
            ' --------------------------------------------------------------------------------
            '

            ' Ask the user to enter a name
            Console.Write("Enter a name : ")
            Dim name As String = Console.ReadLine()

            ' Trim any leading And trailing spaces
            name = name.Trim()

            ' Did the user enter anything?
            '  If Not, return (ie exit) from this method immediately
            If (name = "") Then

                Console.WriteLine("No name entered")
            End If



            ' Is the name that was entered already in the list?
            If (names.Contains(name)) Then

                Console.WriteLine(name + " is already in list")

            Else

                ' Not in list, so add it
                names.Add(name)



                ' Display the list of names so far
                Console.WriteLine()
                Console.WriteLine("List currently contains the following")
                For Each somename As String In names
                    Console.WriteLine(somename)
                    Console.WriteLine()
                Next

            End If





            ' --------------------------------------------------------------------------------
            ' Now get some user interaction, and offer to remove a name
            ' --------------------------------------------------------------------------------
            '
            ' Ask the user to enter a name
            Console.Write("Enter a name to remove from list: ")
            name = Console.ReadLine()                  ' Note variable 'name' already declared

            ' Trim any leading and trailing spaces
            name = name.Trim()

            If (names.Contains(name)) Then

                names.Remove(name)

                ' Display the list of names so far
                Console.WriteLine()
                Console.WriteLine("List currently contains the following")
                For Each somename As String In names
                    Console.WriteLine(somename)
                    Console.WriteLine()
                Next

            End If




            ' End of outer 'forever' loop

        Loop


    End Sub

End Module
