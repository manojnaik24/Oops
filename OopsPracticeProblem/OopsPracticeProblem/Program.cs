using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oops Concept Practice Problem");
            Console.WriteLine("1) Create a program with object and class concept with example."+
                              "\n2) Create a program with Inheritance concept with example."+
                              "\n3) Create a program with Polymorphism concept along with types of polymorphism." +
                              "\n4) Create a program with Encapsulation concept with example."+
                              "\n0) Quit");
            int n=int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Enter the valid Input");
                return;
            }
            else
            {
                switch (n)
                {
                    case 1:

                        ObjectCalss o= new ObjectCalss();
                        o.Print();
                        break;

                        case 2:
                        ChildClass c=new ChildClass();
                        c.ParentClass();
                        ChildClass.Division();
                        break;

                        case 3:
                       Drawing d= new Drawing();
                        Shape .Fun();
                        break; 

                        case 4:
                        string name= Console.ReadLine();
                        int age=int.Parse(Console.ReadLine()) ;
                        Encapsulation.Name(name,age);


                        break;
                        

                }
            }
            Console.ReadLine();
        }
    }
}
