using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практична_робота__2.Матвійчук_Роман
{
    internal class Ex2_option8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const double k= 14, m = 0.42, a = 5;
            double x, y, Z;
            x = Math.Sqrt(Math.Pow((k+6.1),3));
            y = Math.Pow(Math.Log(k),4)+(Math.Pow(m,-6)/(m+5.3));
            Z = Math.Cos((x * x) / (0.14)) + Math.Log(a / 5);
            Console.WriteLine("При k={0}, m={1} та a={2} обчислено x={3,8:N3}, y={4,7:F3}, F={5,8:F4}", k,m,a,x, y, Z);
            Console.ReadKey();
        }
    }
}
