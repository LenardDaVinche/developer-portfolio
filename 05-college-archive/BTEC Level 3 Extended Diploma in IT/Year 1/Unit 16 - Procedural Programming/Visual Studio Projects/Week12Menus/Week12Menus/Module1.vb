Module Module1

    Sub Main()

        'Display main menu.
        While True

            Console.WriteLine("-----------------")
            Console.WriteLine("Party Calculator")
            Console.WriteLine("-----------------")

            Dim response As String = MainMenu()

            If (response = False) Then
                Exit While
            End If
        End While


    End Sub


    Private Function MainMenu() As String

        While True

            Console.WriteLine("Would you like a band?(Y/N)")

            Dim userinput As String = Console.ReadLine()

            Select Case userinput

                Case "Y"
                    Band()
                Case "N"
                    Band()
                Case Else
                    Console.WriteLine("Response not valid, please try again")

            End Select

        End While


    End Function



    Private Function Band() As String

        Console.WriteLine("=======================================")
        Console.WriteLine("Now in Method1. Hit <ENTER> to continue")
        Console.WriteLine("=======================================")

    End Function


    Private Function AttendiesUnder18() As String


        Console.WriteLine("Now in Method2. Hit <ENTER> to continue")


    End Function



    Private Function AttendiesOver18() As String

        Console.WriteLine("=======================================")
        Console.WriteLine("Now in Method1. Hit <ENTER> to continue")
        Console.WriteLine("=======================================")

    End Function

    Private Function Food() As String

        Console.WriteLine("=======================================")
        Console.WriteLine("Now in Method2. Hit <ENTER> to continue")
        Console.WriteLine("=======================================")

    End Function