using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практична_робота__2.Матвійчук_Роман
{
    internal class Ex1_option8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const double x = 0.11578,y = 4.675, z = 4.654;
            double res = (y + Math.Cos(z))/(4*y+2*x*Math.Sqrt(x+2));
            Console.WriteLine("При x={0,10:F3}, y={1,5:N2}, z={2,7:N3}"+
                "значення вирази рівне {3,8:F4}", x,y,z,res);
            Console.ReadKey();
        }
    }
}
