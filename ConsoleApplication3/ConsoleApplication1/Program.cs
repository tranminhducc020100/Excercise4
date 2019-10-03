﻿using System;
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
            //Console.WriteLine("Hello Everybody");
            //Console.WriteLine(IsOdd(3));
            //Console.WriteLine(IsEven(4));
            //Console.WriteLine(IsPrime(8));
            //Console.WriteLine(Square(5));
            //Console.WriteLine(Cube(4));
            //Console.WriteLine(Factorial(4));
            //Console.WriteLine(Abs(-1));
            //Console.WriteLine(Rand1());
            //Console.WriteLine(Rand2());
            //Console.WriteLine(Ceil(7.6f));
            Console.WriteLine(Floor(8.2f));
        }
        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                {
                    return false;
                }
            return true;
        }

        public static int Square(int n)
        {
            return n * n;
        }

        public static int Cube(int n)
        {
            return n * n * n;
        }

        public static int Pow(int x, int y)
        {
            int rs = 1;
            for (int i = 1; i <= y; i++)
                rs = rs * x;
            return rs;
        }

        public static long Factorial(long n)
        {
            int f = 1;
            for (int i = 2; i <= n; i++)
                f = f * 1;
            return f;
        }

        public static int Abs(int n)
        {
            if (n < 0)
                n = n * (-1);
            return n;
        }

        public static int Rand1()
        {
            Random rd = new Random();
            int num = rd.Next();
            return num;
        }

        //public static float Rand2()
        //{
        //Random rd = new Random();
        //float num = 
        //return num;
        //}

        public static int Ceil(float x)
        {
            if (x - (int)x == 0 || x < 0)
            {
                return (int)x;
            }
            return (int)(x) + 1;
        }

        public static int Floor(float x)
        {
            return x >= 0 ? (int)x : (int)x - 1;
        }
    }
}
    

