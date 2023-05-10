﻿using System;
using System.Dynamic;

namespace menu // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void InputA(ref int a)
        {
            a = Convert.ToInt32(Console.ReadLine());
        }
        static void InputB(ref int b)
        {
            b = Convert.ToInt32(Console.ReadLine());
        }
        static void WritePlus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void WriteMinus(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void WriteMul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void WriteDiv(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Ввести A (1)\nВвести B (2)\nвыполнить операцию “+” (3)\nвыполнить операцию “-” (4)\nвыполнить операцию “*” (5)\nвыполнить операцию “/” (6)");
            string v;
            v = Console.ReadLine();
            int a = 0; int b = 0;
            switch (v)
            {
                case "1":
                    {
                        InputA(ref a);
                    }
                    break;
                case "2":
                    {
                        InputA(ref b);
                    }
                    break;
                case "3":
                    {
                        WritePlus(a, b);
                    }
                    break;
                case "4":
                    {
                        WriteMinus(a, b);
                    }
                    break;
                case "5":
                    {
                        WriteMul(a, b);
                    }
                    break;
                case "6":
                    {
                        WriteDiv(a, b);
                    }
                    break;
            }
        }
        
    }
}