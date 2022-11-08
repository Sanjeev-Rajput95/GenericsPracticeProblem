namespace GenericsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** WELCOME TO GENERICS PRACTICE PROBLEM ******************************");


            int maxNumber = GenericsMax.MaxIntNumber(854, 764, 909);
            Console.WriteLine("\n Maximum Number is " + maxNumber);
        }
    }
}