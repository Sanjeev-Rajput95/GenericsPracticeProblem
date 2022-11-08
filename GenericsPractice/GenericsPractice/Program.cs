namespace GenericsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** WELCOME TO GENERICS PRACTICE PROBLEM ******************************");


            int maxNumber = GenericsMax.MaxIntNumber(154, 64, 90);
            Console.WriteLine("\n Maximum Number is " + maxNumber);
        }
    }
}