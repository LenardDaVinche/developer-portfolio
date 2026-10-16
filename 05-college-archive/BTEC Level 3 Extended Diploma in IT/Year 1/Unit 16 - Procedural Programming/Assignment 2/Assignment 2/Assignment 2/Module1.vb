'Key:'------------------------------------------------------------------------------------ = Seperation of different blocks of code to make easier corrections.

Module Module1

    Sub Main()

        While True

            Dim response As Boolean = PartyCalcMenu()

            If (response = False) Then
                Exit While
            End If
        End While

    End Sub

    Private Function PartyCalcMenu() As Boolean

        While True
            'Loop until user has selected a valid answer

            Console.WriteLine(" ")
            Console.WriteLine("Party Calculator Menu")
            Console.WriteLine(" ")
            Console.WriteLine("-----------------")
            Console.WriteLine(" ")
            Console.WriteLine("*Press enter after typing to continue*")
            Console.WriteLine(" ")
            Console.WriteLine("*All answers have to be in uppercase characters*")
            Console.WriteLine(" ")
            Console.WriteLine("Type 'START' to Use the Party calculator")
            Console.WriteLine("Type 'HELP' Help")
            Console.WriteLine("Type 'EXIT' to exit the application")
            Console.WriteLine("----------------")
            Console.WriteLine("By Leandro Baroca")
            Console.WriteLine("----------------")
            Console.WriteLine()
            'What the user will see (Menu options)

            Dim userinput As String = Console.ReadLine()
            'user imput

            Select Case userinput

                Case "START"
                    Calculator()
                Case "HELP"
                    Help()
                Case "EXIT"
                    Exit While
                Case Else
                    Console.WriteLine("Response not valid, please try again")

            End Select

        End While

    End Function

    Private Function Calculator()

        While True

            Dim price As Decimal
            price = 500
            'This is the starting budged for the party.

            Console.WriteLine(" ")
            '------------------------------------------------------------------------------------
            Console.WriteLine(" ")

            Dim AttendiesUnder18 As Decimal
            Dim AttendiesUnder18price As Decimal

            Console.WriteLine("If there are attendies under 18, how many will there be?")
            'What the user will see.
            AttendiesUnder18 = Console.ReadLine()

            AttendiesUnder18price = AttendiesUnder18 * 7

            Console.WriteLine(" ")
            '------------------------------------------------------------------------------------
            Console.WriteLine(" ")

            Dim AttendiesOver18 As Decimal
            Dim AttendiesOver18price As Decimal

            Console.WriteLine("If there are attendies over 18, how many will there be?")
            'What the user will see.
            AttendiesOver18 = Console.ReadLine()

            AttendiesOver18price = AttendiesOver18 * 10

            '------------------------------------------------------------------------------------

            price = price + (AttendiesUnder18price + AttendiesOver18price)
            'This means the attendies that are both over and under 18's cost will be added to the budget.

            Console.WriteLine(" ")
            '------------------------------------------------------------------------------------
            Console.WriteLine(" ")

            Dim Food As String

            Console.WriteLine("Will food be provided at the party?")
            'What the user will see.
            Food = Console.ReadLine()

            If Food.ToUpper = "Y" Then
                price = price + (AttendiesUnder18price * 0.5) + (AttendiesOver18price * 0.5)
                'This the party budget if variable "Food" was added.

            ElseIf Food.ToUpper = "YES" Then
                price = price + (AttendiesUnder18price * 0.5) + (AttendiesOver18price * 0.5)
                'This the party budget if variable "Food" was added.

            ElseIf Food.ToUpper = "N" Then
                'This means no extra budget was added.

            ElseIf Food.ToUpper = "NO" Then
                'This means no extra budget was added.

            End If

            Console.WriteLine(" ")
            '------------------------------------------------------------------------------------
            Console.WriteLine(" ")

            Dim Band As String

            Console.WriteLine("Will there be a band in the party?")
            'What the user will see.
            Band = Console.ReadLine()

            If Band.ToUpper = "Y" Then

                price = price + 600
                'This the party budget if variable "band" was added.

            ElseIf Band.ToUpper = "YES" Then

                price = price + 600
                'This the party budget if variable "band" was added.

            ElseIf Band.ToUpper = "N" Then
                'This means no extra budget was added.

            ElseIf Band.ToUpper = "NO" Then
                'This means no extra budget was added.

            End If

            '------------------------------------------------------------------------------------

            price = price * 1.175
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine("The total cost of the party will be:")
            Console.WriteLine(price)
            Console.ReadLine()

        End While

    End Function

    Private Function Help()

        Console.WriteLine(" ")
        Console.WriteLine("=======================================")
        Console.WriteLine("HELP")
        Console.WriteLine("=======================================")
        Console.WriteLine(" ")
        Console.WriteLine("For each closed question type in Y/YES or N/NO, otherwise it wont be a valid answer.")
        Console.WriteLine(" ")
        Console.WriteLine("All responses are only accepted when in uppercase. (Have capslock on to make answering easier)")
        Console.WriteLine(" ")
        Console.WriteLine("The total cost for the party will be given at the end.")
        Console.WriteLine(" ")
        Console.WriteLine("If you want to calculate again without restarting the program, press enter and the program will create a new calculator for use.")
        Console.WriteLine(" ")

    End Function

End Module
