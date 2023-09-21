using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticeProblem
{
    internal class Drawing
    {
        int a = 10;
        int b = 20;
        double c = 345.6;
        public void Fun(int a,int b)
        {
            int sum=a+b;

            Console.WriteLine(sum);
        }
        public void Fun(int a,int b,double c)
        {
            double sum = a + b + c;
        }
       
    }
    
}
