Module Module1

    Sub Main()

        'Display main menu.
        While True

            Dim response As Boolean = MainMenu()

            If (response = False) Then
                Exit While
            End If
        End While


    End Sub


    Private Function MainMenu() As Boolean


        ' Loop until user has selected a valid menu choice
        While True

            ' Display menu options
            Console.WriteLine()
            Console.WriteLine("*****************")
            Console.WriteLine("    Main Menu")
            Console.WriteLine("*****************")
            Console.WriteLine()

            Console.WriteLine("1. Test Method1()")
            Console.WriteLine("2. Test Method2()")
            Console.WriteLine("0. QUIT")
            Console.WriteLine("*****************")
            Console.WriteLine()
            Console.Write("> ")

            ' Get user choice
            Dim userinput As String = Console.ReadLine()

            Select Case userinput

                Case "1"
                    Method1()
                Case "2"
                    Method2()
                Case "0"
                    Exit While
                Case Else
                    Console.WriteLine("Response not valid, please try again")

            End Select

        End While


    End Function



    Private Function Method1()

        Console.WriteLine("=======================================")
        Console.WriteLine("Now in Method1. Hit <ENTER> to continue")
        Console.WriteLine("=======================================")

    End Function


    Private Function Method2()

        Console.WriteLine("=======================================")
        Console.WriteLine("Now in Method2. Hit <ENTER> to continue")
        Console.WriteLine("=======================================")

    End Function


End Module
