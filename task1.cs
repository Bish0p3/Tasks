using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double num1 = 0; 
        int counter = 0;
        Random random = new Random();

        do
        {
            num1 = random.NextDouble();
            //Console.WriteLine(num1);
            counter++;
        }
        while (num1 <= 0.90 || num1 >= 0.91);

        Console.WriteLine("Number of iterations: {0}", counter);
    }
}