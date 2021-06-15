using System;

namespace MaxUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //creating object of class MaxNumber
            MaxNumber objMax = new MaxNumber();
            Console.WriteLine("Enter your choice ?? \n1. Integer \n 2.Float \n3.String");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How many Integer Number you Want to check???");
                    int numberOfInput = Convert.ToInt32(Console.ReadLine());
                    //creating array of an input size
                    int[] arr = new int[numberOfInput];
                    
                    for (int a = 0; a < numberOfInput; a++)
                    {
                        arr[a] = Convert.ToInt32(Console.ReadLine());
                    }
                    //calling generic method passing array as an arguments
                    objMax.MaximumGeneric<int>(arr);
                    break;

                case 2:
                    Console.WriteLine("How many float Number you Want to check???");
                    int numberOfFloatInput = Convert.ToInt32(Console.ReadLine());
                    //creating array of an input size
                    double[] arrFloat = new double[numberOfFloatInput];
                    
                    for (int a = 0; a < numberOfFloatInput + 1; a++)
                    {
                        arrFloat[a] = Convert.ToDouble(Console.ReadLine());
                    }
                    //calling generic method passing array as an arguments
                    objMax.MaximumGeneric<double>(arrFloat);
                    break;
            }

        }
    }
}
