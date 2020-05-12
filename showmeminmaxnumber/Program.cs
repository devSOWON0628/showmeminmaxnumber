using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                int now;
                Console.Write("숫자를 입력해주세요:");
                now = int.Parse(Console.ReadLine());


                if (now > max)
                {
                    max = now;
                }

                if (i == 0)
                {
                    min = now;
                }
                else if (now < min) min = now;

            }
            Console.WriteLine("\n제일 큰 수는 " + max);
            Console.WriteLine("제일 작은 수는" + min);
        }
    }
}
