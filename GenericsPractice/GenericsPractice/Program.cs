namespace GenericsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** WELCOME TO GENERICS PRACTICE PROBLEM ******************************");


            double maxFlotingNo = GenericsMax.MaxIntNumber(85.4, 117.6, 19.0);
            Console.WriteLine("\n Maximum floating number for 2nd position is = " + maxFlotingNo);
        }
    }
}