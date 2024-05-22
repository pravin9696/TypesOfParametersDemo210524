using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfParametersDemo210524
{
    class student12
    {
        public int roll;
        public string name;
        public int sub1, sub2, sub3, sub4, sub5;
    }
   class MyClass
    {
        //public void sum(int a1,int b1=1000)// default value of b1
        //{
        //    Console.WriteLine(a1+b1);

        //}
        public void sum(int a1=3, int b1=4,int c1=6)
        {
            Console.WriteLine("a1="+a1);
            Console.WriteLine("b1=" + b1);
            Console.WriteLine("c1=" + c1);

        }
        public void addition( float fp,params int[] a1)
        {
            Console.WriteLine("Length of a1="+a1.Length);
            int total = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                total += a1[i];
            }
            Console.WriteLine("total ="+total);
        }
        public void showResult(in student12 std)
        {
            String grad;
            //std = new student12();// invalid not allow to change object
                                    // stored in std parameter
            float per=(std.sub1+ std.sub2+std.sub3+ std.sub4 + std.sub5)/5;
            if (per>70)
            {
                grad = "A+";
            }
            else if(per>60 && per <70)
            {
                grad = "A";
            }
            else if(per>40)
            {
                grad = "pass";
            }
            else
            { grad = "fail";
            }
            Console.WriteLine("Roll="+std.roll);
            Console.WriteLine("Name=" + std.name);
            Console.WriteLine("Per=" + per);
            Console.WriteLine("grad=" + grad);
            
        
            std.roll = 35;
            std.name = "pavan";
            std.sub1 = 45;
            std.sub2 = 45;
            std.sub3 = 55;
            std.sub4 = 75;
            std.sub5 = 85;
        }
        public void InparameterMethod(int x,in int y)
        {
            Console.WriteLine("x="+x+" y="+y);
            x = 1000;
            //y = 2000;//invalid

            int z = 300;
            z = z + y;

            Console.WriteLine("x=" + x + " y=" + y+" z="+z);

        }
        public float Circle_Area_Perimeter(int rad,out float peri)
        {
            float area;  
            area = 3.14f * rad * rad;
            peri = 2 * 3.14f * rad;
            return area;
        }
    }
    internal class ParaDemo220524
    {
    }
}
