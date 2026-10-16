Module Module1

    Sub Main()

        Console.Write("How many subjects are you studying? ")
        Dim noOfSubjects As Integer = Console.ReadLine()
        Dim subjects(0 To noOfSubjects - 1) As String

        Dim i As Integer
        i = 0
        Do Until i = noOfSubjects
            Console.Write("Enter a name of a subject: ")
            subjects(1) = Console.ReadLine()
            i = i + 1
        Loop

        Array.Sort(subjects)

        Console.WriteLine("The first subject is " + subjects(0))
        Console.WriteLine("The second subject is " + subjects(1))

        i = 0
        Do Until i = noOfSubjects
            Console.WriteLine(subjects(i))
            i = i + 1
        Loop

        Array.Resize(subjects, 16)
        subjects(15) = "New"
        Console.WriteLine("press <ENTER> to close.")
        Console.ReadLine()
    End Sub

End Module
