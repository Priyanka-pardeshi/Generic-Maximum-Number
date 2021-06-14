using System;

namespace MaxUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxNumber objMax = new MaxNumber();
            Console.WriteLine("Enter three integer Number");

            int firstvalue = Convert.ToInt32(Console.ReadLine());
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            int thirdvalue = Convert.ToInt32(Console.ReadLine());

            objMax.MaximumGeneric<int>(firstvalue, secondvalue, thirdvalue);

            Console.WriteLine("Enter float Numbers:");
            double firstfloatvalue = Convert.ToDouble(Console.ReadLine());
            double secondfloatvalue = Convert.ToDouble(Console.ReadLine());
            double thirdfloatvalue = Convert.ToDouble(Console.ReadLine());
            objMax.MaximumGeneric<double>(firstfloatvalue, secondfloatvalue, thirdfloatvalue);

            Console.WriteLine("Enter string");
            string firststr = Console.ReadLine();
            string secondstr = Console.ReadLine();
            string thirdstr = Console.ReadLine();
            objMax.MaximumGeneric<string>(firststr, secondstr, thirdstr);
        }
    }
}
