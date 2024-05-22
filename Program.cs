using System.Security.Cryptography;

namespace TypesOfParametersDemo210524
{
    class student
    {
        private int roll;
        public void setRoll(int rl)
        {
            roll = rl;
        }
        public int getRoll()
        {
            return roll;
        }
    }
    class temp
    {    
        public void stringConcat(string s1,string s2,string s3)
        {
            String s4 = s1 +" "+ s2 +" "+ s3;
            Console.WriteLine("Result String ="+s4);
        }
     public void sum(int x, int y)//parametes  // value type parameters   //call by value
        {
            int total = x + y; //15
            Console.WriteLine(total);
            x = 1111;
            y = 2222;
        }
        public float multiplication(int a, float b)
        {
            float result = a * b;//invalid
                                 //return a*b; //valid
            return result;// invalid
        }

        public void changeNumber(ref int x,ref int y,ref int z)// ref type
        {
            Console.WriteLine("inside Method:");
            Console.WriteLine("x="+x+" y="+y+" z="+z);
            x = 111;
            y = 222;
            z = 333;
            Console.WriteLine("inside method change x y & z");
            Console.WriteLine("x=" + x + " y=" + y + " z=" + z);
        }
        public void changeRoll(ref student ss)// call by reference 
        {
            Console.WriteLine("#### hash key of ss=" + ss.GetHashCode());
            Console.WriteLine("before Change roll inside method=" + ss.getRoll());
            // ss.roll = 555;
            ss.setRoll(555);
            Console.WriteLine("after Change roll inside method=" + ss.getRoll());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //temp t1 = new temp();

            //t1.sum(100, 200);

            //int a = 5;
            //int b = 10;
            //t1.sum(a, b);//arguments 2 arguments
            //Console.WriteLine(a + " " + b);//5 10
            #endregion

            #region 210524 Programs
            //temp t2 = new temp();
            ////int a = 1000;
            ////int b = 2000;
            ////int c = 3000;
            ////Console.WriteLine("before calling method :");
            ////Console.WriteLine("a= "+a+" b="+b+" c="+c);
            ////t2.changeNumber(ref a, ref b, ref c); //ref type argument
            ////Console.WriteLine("after calling method :");
            ////Console.WriteLine("a= " + a + " b=" + b + " c=" + c);
            //student s1 = new student();
            //Console.WriteLine("#### hash key of s1=" + s1.GetHashCode());
            //s1.setRoll(999);
            //Console.WriteLine("before call method roll=" + s1.getRoll());
            //t2.changeRoll(ref s1);
            //Console.WriteLine("after call method roll=" + s1.getRoll());
            //float result = t2.multiplication(b: 3.14f, a: 100);
            //Console.WriteLine(result);
            //string a = "GTH";
            //string b = "pune";
            //string c = "Maharashtra";
            //t2.stringConcat(s3:a, s1:b, s2:c);
            #endregion

            MyClass mobj = new MyClass();
            // float per = 23;
            //float area= mobj.Circle_Area_Perimeter(20, out per);
            // Console.WriteLine("Area of Circle ="+area+" Perimeter of Circle ="+per);
            //int temp = 123;
            //mobj.InparameterMethod(100,temp);

            //student12 stud1 = new student12();
            //stud1.roll = 111;
            //stud1.name = "rajesh";
            //stud1.sub1 = 45;
            //stud1.sub2 = 45;
            //stud1.sub3 = 55;
            //stud1.sub4 = 75;
            //stud1.sub5 = 85;

            //mobj.showResult(stud1);
            //Console.WriteLine("-----------------------");
            //mobj.showResult(stud1);
            //mobj.addition(1.1f,11, 22, 33, 44);
            //Console.WriteLine("------------------");
            //mobj.addition(6.5f,11, 22);
            //Console.WriteLine("------------------");
            //mobj.addition(11);
            //Console.WriteLine("------------------");
            //mobj.addition(3.14f);
            //int[] myAray = new int[] { 1, 2, 3 };
            //mobj.addition(myAray);
            mobj.sum();
            Console.WriteLine("------------------");
            mobj.sum(111);
            Console.WriteLine("------------------");
            mobj.sum(111,222);
            Console.WriteLine("------------------");
            mobj.sum(111,222,333);
        }
    }
}
