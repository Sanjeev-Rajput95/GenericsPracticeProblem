namespace GenericsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** WELCOME TO GENERICS PRACTICE PROBLEM ******************************");


            string maxStr = GenericsMax.MaxIntNumber("Apple", "Banana", "Peach");
            Console.WriteLine("\n Maximum string is : " + maxStr);
        }
    }
}