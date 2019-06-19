using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETWORK
{
    class Program
    {
        static void sigmoid(double e, double x, out double z)
        {
            double e2 = e;
            for(int i = 0; i < x;i++)
            {
                e2 *= e;
            }
            double f = (f*x = (1/(1+e2)));
            z = 0;
        }
        static void Main(string[] args)
        {
            double e = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double i1 = double.Parse(Console.ReadLine());
            double w1 = double.Parse(Console.ReadLine());
            double i2 = double.Parse(Console.ReadLine());
            double w2 = double.Parse(Console.ReadLine());

            double Hin = (i1*w1) + (i2*w2);

            sigmoid(e, x, out double f);
            double Sin = f * (Hin);

        }
    }
}
