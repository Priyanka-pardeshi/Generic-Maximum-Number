using System;

namespace MaxUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber objMax = new MaxNumber();
            Console.WriteLine("Enter three int Number");

            int firstvalue = Convert.ToInt32(Console.ReadLine());
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            int thirdvalue = Convert.ToInt32(Console.ReadLine());

            objMax.MaximumGeneric<int>(firstvalue, secondvalue, thirdvalue);

            Console.WriteLine("Enter float val:");
            double firstFloatValue = Convert.ToDouble(Console.ReadLine());
            double secondFloatValue = Convert.ToDouble(Console.ReadLine());
            double thirdFloatValue = Convert.ToDouble(Console.ReadLine());
            objMax.MaximumGeneric<double>(firstFloatValue, secondFloatValue, thirdFloatValue);

            Console.WriteLine("Enter string");
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            string thirdStr = Console.ReadLine();
            objMax.MaximumGeneric<string>(firstStr, secondStr, thirdStr);
        }
    }
}
