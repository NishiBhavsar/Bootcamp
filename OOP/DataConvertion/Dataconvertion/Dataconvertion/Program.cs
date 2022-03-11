using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConversion
{
    class Program
    {
        public int i = 10;
        public float f = 20.1111f;
        public double d = 20.1111111;
        public decimal dc = 20.11111111111111m;

        public string Str = "1000";
        public object Obj = 100;

        
        static void Main(string[] args)
        {
            Program P = new Program();

            Console.WriteLine("Integer i:" + P.i);
            Console.WriteLine("float f:" + P.f);
            Console.WriteLine("double d:" + P.d);
            Console.WriteLine("decimal dc:" + P.dc);

         
            int i1 = (int)P.f;
            Console.WriteLine("Converted Integer i1:" + i1);

          
            float f1 = (float)P.i;
            Console.WriteLine("Converted float f1:" + f1);

            
            var v = (int)P.i;
            Console.WriteLine("Converted Implicit Variable v:" + v);

            
            Console.WriteLine("String STR:" + P.Str);
            Console.WriteLine("Converted Integer From String:" + Int32.Parse(P.Str));

            
            Console.WriteLine("Converted Integer From String:" + Convert.ToInt32(P.Str));

            
            P.Str = null;
            Console.WriteLine("Converted Integer From String:" + Convert.ToInt32(P.Str));

         
            P.Str = "111";
            int i;
            bool b = Int32.TryParse(P.Str, out i);
            Console.WriteLine("Converted Integer From String Is Possible:" + b);
            Console.WriteLine("Converted Integer From String:" + i);

            Object Obj2 = (string)P.Str;
            Console.WriteLine("Converted Object From String:" + Obj2);

            Console.WriteLine("Converted String From Object:" + Convert.ToString(P.Obj));


            
            int i2;
            bool b2 = Int32.TryParse((string)P.Str, out i2);


            Console.ReadKey();
        }
    }
}
