using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void InputInt(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("A[{0}] =", i);
                string str = Console.ReadLine();
                     int.Parse(str)
            }
        }
    }
}
