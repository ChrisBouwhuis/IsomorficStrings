using System;
using ClassLib;

namespace IsometricStringChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isometricStringChecker = new Checker();
            bool result = isometricStringChecker.IsIsometric("egg", "add");
            Console.WriteLine(result);
        }
    }
}
