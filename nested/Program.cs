using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 3 number ");
            int n1=Convert.ToInt32(Console.ReadLine()); 
            int n2=Convert.ToInt32(Console.ReadLine());
            int n3=Convert.ToInt32(Console.ReadLine());
            if(n1>n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine($"{n1} is greatest number");
                }
                else
                {
                    Console.WriteLine($"{n3} is greatest number");
                }
            }
            else
            {
                if(n2>n3)
                {
                    Console.WriteLine($"{n2} is greatest number");
                }
                else
                {
                    Console.WriteLine($"{n3} is greatest number");
                }
            }
        }
    }
}
