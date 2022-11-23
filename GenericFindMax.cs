using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUCs
{
    public class GenericFindMax<T> where T: IComparable
    {
        public static void FindMaxValue(T first,T second,T third)  //UC3-refactor 1 (find max using generic method)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)  //data type is unknown bcoz we are using generic in the method hence error will occur so 
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine($"{third} is greater ");
            }
            else
                Console.WriteLine("All Numbers are Equal! ");
        }
    }
}
