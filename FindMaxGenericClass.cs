using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUCs
{
    public class FindMaxGenericClass<T> where T : IComparable //UC3-refactor 2  (extending interface because to have CompareTo().)
    {
        public T first, second, third;
        public FindMaxGenericClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T FindMaxValue(T first, T second, T third)  //return type is T and (T's are data types which are unknown ,depends on passed value )
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)  //data type is unknown bcoz we are using generic in the method hence error will occur so defined where T and IComparable
            {
                Console.WriteLine($"{first} is greater");
                return first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{second} is greater");
                return second;
            }
            else
            {
                Console.WriteLine($"{third} is greater ");
                return third;
            }
        }
        public void TestMaximum()
        {
            Console.WriteLine("The Max Value is : " + FindMaxValue(first, second, third)); //calling implicitly FindMaxValue() as per said condition.
        }
    }
}
