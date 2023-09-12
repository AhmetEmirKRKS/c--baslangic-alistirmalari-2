using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_.alıştırmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "True";
            bool sb1=bool.Parse(metin1); 
            bool sb2=Convert.ToBoolean(metin1);
            Console.WriteLine(metin1);
            int s1 = 100;
         byte byte1=(byte)s1;
            float float1 = s1;
            Console.WriteLine(s1);
            byte b1 = 10;
            decimal d1 = b1;
            Console.WriteLine(d1);
            Console.ReadLine();
        }
    }
}
