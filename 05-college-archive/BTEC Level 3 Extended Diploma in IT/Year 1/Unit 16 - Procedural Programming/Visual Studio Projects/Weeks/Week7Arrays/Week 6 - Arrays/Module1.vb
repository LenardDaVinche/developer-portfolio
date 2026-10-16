Module Module1

    Sub Main()


        Console.Write("How many teams are there? ")
        Dim noOfTeams As Integer = Console.ReadLine()
        Dim teams(0 To noOfTeams - 1) As String

        Dim i As Integer
        i = 0
        Do Until i = noOfTeams
            Console.Write("Enter a team's name: ")
            teams(i) = Console.ReadLine()
            i = i + 1
        Loop

        Array.Sort(teams)

        'teams(0) = "Montreal Canadians"
        'teams(1) = "Philadelphia Flyers"
        'teams(2) = "Vancouver Canuks"
        'teams(4) = "Colerado Avalanche"

        Console.WriteLine("The first team is " + teams(0))
        Console.WriteLine("The second team is " + teams(1))

        i = 0
        Do Until i = noOfTeams
            Console.WriteLine(teams(i))
            i = i + 1
        Loop

        Array.Resize(teams, 16)
        teams(15) = "New"
        Console.WriteLine("Press <Enter> to close.")
        Console.ReadLine()

    End Sub

End Module
