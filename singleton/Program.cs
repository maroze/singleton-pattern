using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chocolate;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.getInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.getInstance();

            Console.WriteLine(boiler.GetHashCode());
            Console.WriteLine(boiler2.GetHashCode());

            Console.ReadKey();
        }
    }
}
