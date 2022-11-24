using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUCs
{
    public class GenericMaximumUC5<T> where T : IComparable
    {
        public T[] value;
        public GenericMaximumUC5(T[] value)
        {
            this.value = value;
        }
        public T[] Sorting(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sortedValues = Sorting(value);
            return sortedValues[sortedValues.Length - 1];
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
