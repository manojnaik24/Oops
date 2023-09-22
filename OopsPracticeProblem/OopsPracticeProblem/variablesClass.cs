using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblem
{
    internal class variablesClass
    {
        public void Variabl()
        {
            int integerVar = 42;
            uint unsignedIntVar = 100;
            short shortVar = -12345;
            ushort unsignedShortVar = 56789;
            long longVar = 1234567890;
            ulong unsignedLongVar = 1234567890123456789;

            // Floating-point types
            float floatVar = 3.14f;
            double doubleVar = 2.71828;
            decimal decimalVar = 123.456m;

            // Character type
            char charVar = 'A';

            // Boolean type
            bool boolVar = true;

            // String type
            string stringVar = "Hello, C#!";


            Console.WriteLine($"int: {integerVar}");
            Console.WriteLine($"uint: {unsignedIntVar}");
            Console.WriteLine($"short: {shortVar}");
            Console.WriteLine($"ushort: {unsignedShortVar}");
            Console.WriteLine($"long: {longVar}");
            Console.WriteLine($"ulong: {unsignedLongVar}");
            Console.WriteLine($"float: {floatVar}");
            Console.WriteLine($"double: {doubleVar}");
            Console.WriteLine($"decimal: {decimalVar}");
            Console.WriteLine($"char: {charVar}");
            Console.WriteLine($"bool: {boolVar}");
            Console.WriteLine($"string: {stringVar}");
        
    }
    }
}
