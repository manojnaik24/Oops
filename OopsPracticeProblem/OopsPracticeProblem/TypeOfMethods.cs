using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblem
{
    internal class TypeOfMethods
    {

        int a = 28, b = 29;
           public  void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Method Demo!");
            }

           public  void Add(int a, int b)
            {
            Console.WriteLine(a + b); 
            }

          public  void DisplayResult(string operation, int result)
            {
                Console.WriteLine($"Result of {operation}: {result}");
            }
       public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

       
    }
}
