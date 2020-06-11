using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    public class Integral
    {

    public static double[] getIntegralParams(string integralParams)
    {
      string[] temp = integralParams.Trim().Split(' ');

      double[] result = new double [3];

      for (int i = 0; i < 3; ++i)
      {
        result[i] = Convert.ToDouble(temp[i]);
      }

      return result;

    }

    private static double IntegralFunc(double p)
    {
      return (5 * Math.Pow(p, 3) + 2 * (p - 150));
    }

    public static double GetIntegral(double a, double b, int n)
    {
      double s = 0;

      double h = (b - a) / n;

      double xi, xi1;

      Parallel.For(0, n, i =>
      {
        xi = a + i * h;
        xi1 = a + (i + 1) * h;
        s += (IntegralFunc(xi) + IntegralFunc(xi1));
      });

      //for (int i = 0; i < n; i++)
      //{
      //  xi = a + i * h;
      //  xi1 = a + (i + 1) * h;
      //  s += (IntegralFunc(xi) + IntegralFunc(xi1));
      //}

      s = s * h / 2;

      return s;

    }

  }
}
