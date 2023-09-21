using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblem
{
    internal class Encapsulation
    {
        private string name ;
        private int age;

        public Encapsulation()
        {
        }

        public Encapsulation(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public static void Name(string name,int age) {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }



    }

}

