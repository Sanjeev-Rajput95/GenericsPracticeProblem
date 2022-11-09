namespace GenericsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** WELCOME TO GENERICS PRACTICE PROBLEM ******************************");

        

            Console.WriteLine("Maximum Interger Number is : " + GenericsMax<int>.MaxIntegerNumber(30, 20, 10));
            Console.WriteLine("Maximum Float Number is : " + GenericsMax<float>.MaxIntegerNumber(30.3f, 45.20f, 76.10f));
            Console.WriteLine("Maximum String Number is : " + GenericsMax<string>.MaxIntegerNumber("78", "34", "10"));

        }
    }
}