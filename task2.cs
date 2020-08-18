using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double num1 = 0;
        double countTotal = 0;
        Random random = new Random();

        for (int i = 0; i < 10000; i++)
        {
            int counter = 0;
            do
            {
                num1 = random.NextDouble();
                //Console.WriteLine(num1);
                counter++;
            }
            while (num1 <= 0.90 || num1 >= 0.91);
            //Console.WriteLine("Number of iterations: {0}", count);
            countTotal += counter;
        }
        //Console.WriteLine(countall);
        Console.WriteLine("Average number of iterations: {0}", countTotal/10000);
    }
}