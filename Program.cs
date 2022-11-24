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
                "2:FindMax using Generic Method\n" +
                "3:FindMax using Generic Class\n" +
                "4:Param Concept~takes any no of parameters\n" +
                "5:Generic Concept .");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaximum.FindMaxValue(20, 30, 40);                   //UC1 finding max out of 3 int.
                    FindMaximum.FindMaxValue(20.20f, 30.20f, 40.40f);       //UC2 finding max out of 3 float.
                    FindMaximum.FindMaxValue("abc", "def", "ghi");       //UC3 finding max out of 3 string.
                    break;
                case 2:
                    FindMaxGenericMethod<int>.FindMaxValue(11, 23, 30);       //find max using generic method
                    FindMaxGenericMethod<float>.FindMaxValue(20.45f, 30.11f, 12.99f);       //find max using generic method
                    FindMaxGenericMethod<string>.FindMaxValue("abc","def","ghi");       //find max using generic method
                    break;
                case 3:
                    //FindMaxGenericClass<int> genericObj1 = new FindMaxGenericClass<int>(20, 30, 12);
                    //genericObj1.TestMaximum();
                    new FindMaxGenericClass<int>(20, 30, 12).TestMaximum();                   //find max using generic class .
                    new FindMaxGenericClass<float>(20.45f, 30.11f, 12.99f).TestMaximum();
                    new FindMaxGenericClass<string>("abc", "def","ghi").TestMaximum();
                    break;
                case 4:     //UC4 .
                    FindMaxParams.MaxValue(45, 23, 54, 6, 23, 43);  //using param -sample 1
                    FindMaxParams.MaxValue(45, 6, 23, 43);      //using param-sample 2
                    break;
                case 5:     //UC5
                    //we cannot write the Main() in Generic class it will provide error ,so always write generic class separately .
                    int[] arr = { 23, 21, 32, 45, 65, 33 };
                    GenericMaximumUC5<int> genericObj = new GenericMaximumUC5<int>(arr);
                    genericObj.PrintMaxValue();
                    break;
                default:
                    Console.WriteLine("Please choose number within given range!");
                    break;
            }
        }
    }
}