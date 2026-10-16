Module Module1

    Sub Main()

        Dim name As String
        Dim age As Integer
        Dim heightInMetres As Double
        Dim parish As New List(Of String)()

        Console.WriteLine("Welcome ...")

        Console.Write("What is your name? : ")
        name = Console.ReadLine()

        Console.Write("What is your age? : ")
        age = Convert.ToInt32(Console.ReadLine())

        Console.Write("What is your height in metres? : ")
        heightInMetres = Console.ReadLine()

        Console.Write("What parish do you live in? : ")
        parish.Add("St.Helier")
        parish.Add("St.Lawrence")
        parish.Add("St.Saviour")
        parish.Add("Grouville")
        parish.Add("St.Clement")
        parish.Add("St.Peter")
        parish.Add("St.Brelade")
        parish.Add("St.Ouen")
        parish.Add("St.Mary")
        parish.Add("St.John")
        parish.Add("Trinity")
        parish.Add("St.Martin")

        Console.WriteLine("Hello " + name)
        Console.WriteLine("You are " + age.ToString() + " years old")
        Console.WriteLine("You are " + heightInMetres.ToString() + " metres tall")


        'Now do the same, using Function (Method) calls
        name = GetName("ENTER YOU NAME: ")
        age = GetAge("ENTER YOUR AGE: ")
        heightInMetres = GetHeight("ENTER YOUR HEIGHT: ")
        DisplayDetails(name, age, heightInMetres)

        Console.WriteLine("Hit <ENTER> to finish")
        Console.ReadLine()

    End Sub

    Function GetName(prompt As String) As String

        Dim name As String = ""

        Do
            Console.Write(prompt)
            name = Console.ReadLine().Trim()
            If (name <> "") Then
                Exit Do
            End If

        Loop

        Return name

    End Function

    Function GetAge(prompt As String) As Integer

        Dim age As Integer = 0

        Do
            Console.Write(prompt)
            Dim somedata As String = Console.ReadLine().Trim()
            Dim somebool As Boolean = Int32.TryParse(somedata, age)

            If age > 0 Then
                Exit Do
            Else
                Console.WriteLine("Invalid entry, try again...")
            End If

        Loop

        Return age

    End Function

    Function GetHeight(prompt As String) As Double

        Dim height As Double = 0.0

        Do
            Console.Write(prompt)
            Dim somedata As String = Console.ReadLine().Trim()
            Dim somebool As Boolean = Double.TryParse(somedata, height)

            If height > 0 Then
                Exit Do
            Else
                Console.WriteLine("Invalid entry, try again...")
            End If

        Loop

        Return height

    End Function

    Function DisplayDetails(name As String, age As Integer, height As Double) As Boolean

        Console.WriteLine("Hello " + name)
        Console.WriteLine("You are " + age.ToString() + " years old")
        Console.WriteLine("You are " + height.ToString() + " metres tall")

        Return True

    End Function

End Module
