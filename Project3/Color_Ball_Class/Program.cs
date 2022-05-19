using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3;



namespace Project3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Question 1");


            ////Set size for random generated numbers here
            //int size = 10;

            //int[] numbers = GenerateNumbers(size);
            //Console.WriteLine("Random generated numbers: ");
            //PrintNumbers(numbers);


            //Reverse(numbers);
            //Console.WriteLine("\nReversed generated numbers: ");
            //PrintNumbers(numbers);




            //Console.WriteLine("\n\nNext Question2\n");
            //Console.ReadKey();



            //Console.Write("Enter the nth number of the Fibonacci Series: ");
            //int numFib = Convert.ToInt32(Console.ReadLine());

            //Console.Write(NthFibonacciNumber(numFib));

            

            Color color1 = new Color(18,243,107,255);
            Ball ball1 = new Ball(4, color1);

            //throw the ball 3 times
            ball1.Throw();
            ball1.Throw();
            ball1.Throw();
            Console.WriteLine("Throw count of Ball 1 before popping: " + ball1.getNumThrows());

            //pop the ball
            ball1.Pop();

            //throw the ball twice again after popping the ball
            ball1.Throw();
            ball1.Throw();

            //print the number of throws : should be same (as ball was popped)
            Console.WriteLine("Throw count of Ball 1 after popping: " + ball1.getNumThrows());


            Console.WriteLine();

            //create another color and ball object
            Color color2 = new Color();
            Ball ball2 = new Ball(2, color2);

            ball2.Pop(); //pop the ball

            //throw the ball2 5 times
            for (int i = 0; i < 5; i++) ball2.Throw();

            //output should be zero as ball was popped initially
            Console.WriteLine("Ball 2 throw count: " + ball2.getNumThrows());


            

        }

        //public static int[] GenerateNumbers(int size)
        //{
        //    int min = 0;
        //    int max = 10;
        //    int[] randArr = new int[size];
        //    Random randNums = new Random();

        //    for (int i = 0; i < randArr.Length; i++)
        //    {
        //        randArr[i] = randNums.Next(min, max);

        //    }
        //    return randArr;
        //}


        //public static int[] Reverse(int[] arrNums)
        //{
        //    int i = 0;
        //    int j = arrNums.Length - 1;

        //    while (i < j)
        //    {
        //        var temp = arrNums[i];
        //        arrNums[i] = arrNums[j];
        //        arrNums[j] = temp;
        //        i++;
        //        j--;
        //    }

        //    return arrNums;
        //}


        //static void PrintNumbers(int[] arrNumbers)
        //{
        //    foreach (var itemN in arrNumbers)
        //    {
        //        Console.Write(itemN + " ");
        //    }
        //}


        //public static int NthFibonacciNumber(int n)
        //{
        //    if ((n == 0) || (n == 1))
        //    {
        //        return n;
        //    }
        //    else
        //    {
        //        return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
        //    }
        //}




    }


       
}
