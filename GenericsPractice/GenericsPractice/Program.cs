namespace GenericsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** WELCOME TO GENERICS PRACTICE PROBLEM ******************************");


            int maxNumber = GenericsMax.MaxIntNumber(854, 1764, 1909);
            Console.WriteLine("\n Maximum Number at 3rd position  is " + maxNumber);
        }
    }
}