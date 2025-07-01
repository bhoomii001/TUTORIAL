using System;


namespace TUTORIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            int a=Convert.ToInt32(Console.ReadLine());
            

            if(a%2==0)
            {
                Console.WriteLine("it is even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.Read();
        }
    }
}
