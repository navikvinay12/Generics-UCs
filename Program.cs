using System.Collections;

namespace GenericsUCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Use Case's ");
            Console.WriteLine("Choose any one from below options");
            Console.WriteLine("1:Find Max Num\n" +
                "2:FindMax using Generic Method");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaximum.FindMaxValue(20, 30, 40);                   //UC1 finding max out of 3 int.
                    FindMaximum.FindMaxValue(20.20f, 30.20f, 40.40f);       //UC2 finding max out of 3 float.
                    FindMaximum.FindMaxValue("abc", "def", "ghi");       //UC3 finding max out of 3 string.
                    break;
                case 2:
                    GenericFindMax<int>.FindMaxValue(11, 23, 30);       //find max using generic method
                    break;
                default:
                    Console.WriteLine("Please choose number within given range!");
                    break;
            }
        }
    }
}