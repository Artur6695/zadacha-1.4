using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__1
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, size;
            Console.WriteLine("Введите выражение:");
            string text = Console.ReadLine();
            Char[] a = text.ToArray();
            size = a.Length;
            String[] m = new String[size];
            for (i = 0; i < size; i++)
            {
                m[i] = Convert.ToString(a[i]);
            }
            int b = 0;
            int slagaemoe;
            int sum = 0;
            String plus = "+";
            String minus = "-";
            if (m[0].Equals(minus))
            {
                slagaemoe = Convert.ToInt32(m[1]);
                sum -= slagaemoe;
                b++;
            }
            else
            {
                slagaemoe = Convert.ToInt32(m[0]);
                sum += slagaemoe;
            }
            for (i = b; i < size; i++)
            {
                if (m[i].Equals(plus))
                {
                    slagaemoe = Convert.ToInt32(m[i + 1]);
                    sum += slagaemoe;
                }
                else
                {
                    if (m[i].Equals(minus))
                    {
                        slagaemoe = Convert.ToInt32(m[i + 1]);
                        sum -= slagaemoe;
                    }


                }
            }
            Console.Write("Выражение после вычисления: " + sum);
            Console.ReadLine();
        }
    }
}
