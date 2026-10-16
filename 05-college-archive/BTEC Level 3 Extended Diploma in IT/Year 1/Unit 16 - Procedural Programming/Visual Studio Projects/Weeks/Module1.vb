Module Module1

    Sub Main()

        Dim cost As Double
        Dim runningTotal As Double = 0
        Do


            'Get user to enter a price
            Console.Write("Enter a price: ")
            cost = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("You entered " + cost.ToString)

            runningTotal = runningTotal + cost
            Console.WriteLine("Total so far is " + runningTotal.ToString())


        Loop Until cost = 0.0



        Console.ReadLine()
    End Sub

End Module
