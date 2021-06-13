using System;

namespace MaxUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber objMax = new MaxNumber();
            Console.WriteLine("Enter three int and float no");
           
                    int firstIntValue = Convert.ToInt32(Console.ReadLine());
                    int secondIntValue = Convert.ToInt32(Console.ReadLine());
                    int thirdIntValue = Convert.ToInt32(Console.ReadLine());
                    objMax.MaximumInt(firstIntValue, secondIntValue, thirdIntValue);
            
                    double firstFloatValue = Convert.ToDouble(Console.ReadLine());
                    double secondFloatValue = Convert.ToDouble(Console.ReadLine());
                    double thirdFloatValue = Convert.ToDouble(Console.ReadLine());
                    objMax.MaximumDouble(firstFloatValue, secondFloatValue, thirdFloatValue);

                    Console.WriteLine("Enter string");
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    string thirdStr = Console.ReadLine();
                    objMax.MaximumStr(firstStr, secondStr, thirdStr);
        }
    }
}
