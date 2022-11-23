namespace GenericsUCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Use Case's ");
            FindMaximum.FindMaxValue(20, 30, 40);                   //UC2 finding max out of 3 int.
            FindMaximum.FindMaxValue(20.20f, 30.20f, 40.40f);       //UC2 finding max out of 3 float.
        }
    }
}