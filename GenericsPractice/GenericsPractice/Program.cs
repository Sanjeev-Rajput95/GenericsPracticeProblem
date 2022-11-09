namespace GenericsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** WELCOME TO GENERICS PRACTICE PROBLEM ******************************");

          //  GenericsMax genericsObj = new GenericsMax();

            Console.WriteLine("Maximum Interger Number is : " + GenericsMax.MaxIntNumber<int>(30, 20, 10));
            Console.WriteLine("Maximum Float Number is : " + GenericsMax.MaxIntNumber<float>(30.3f, 45.20f, 76.10f));
            Console.WriteLine("Maximum String Number is : " + GenericsMax.MaxIntNumber<string>("78", "34", "10"));

        }
    }
}