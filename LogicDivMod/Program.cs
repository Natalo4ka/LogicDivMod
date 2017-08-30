using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDivMod
{
    class Program
    {
#region Initial value
        public static int n = 421;
        public static int m = 4;
#endregion

        static void Main(string[] args)
        {
#region Some comments

            //First();//n=27;

            //Second();

            //Console.WriteLine(1/10==0);
            //if (Math.Sqrt(m)%1!=0)
            //{
            //    Console.WriteLine("Double");
            //}
            //Console.WriteLine(Math.Sqrt(m));


            //Third();


            //double t;
            //if (double.TryParse(Console.ReadLine(),out t))
            //{
            //    Console.WriteLine("Int");
            //}
            //else
            //{
            //    Console.WriteLine("Ooops");
            //}

            //if(t % 1 == 0)
            //{
            //    Console.WriteLine("true");
            //}

#endregion

            //**************************************************************************************************************

            //DivSQRbutNOTCubic d = new DivSQRbutNOTCubic(new ConsoleReader(), new GeneralValidator(), new ConsolePrinter());
            //d.Method();

            //SQRSumEqualNumber s = new SQRSumEqualNumber(new ConsoleReader2(), new GeneralValidator2(), new ConsolePrinter());
            //s.Method();

            ArmstrongNumbers a=new ArmstrongNumbers(new ConsoleReader(), new ConsolePrinter());
            a.Method();

            Console.ReadKey();
        }

#region Logic implementing

        static void First()
        {
            int q = 1;
            while (n >= Math.Pow(q, 2))
            {
                if (n % Math.Pow(q, 2) == 0 && n % Math.Pow(q, 3) != 0)
                {
                    Console.WriteLine("Find q = " + q);
                }

                Console.WriteLine(q);
                q++;

            }

            Console.WriteLine("End of circle!");
        }

        static void Second()
        {
            int q = 1;
            if (Math.Sqrt(m) % 1 == 0)
            {
                while (n > q)
                {
                    int s = 0;
                    int temp = q;
                    while (temp / 10 != 0)
                    {
                        if (Math.Sqrt(m) > s)
                        {
                            s += temp % 10;
                            temp = temp / 10;
                        }
                        else
                        {
                            Console.WriteLine("*");
                            break;
                        }
                    }
                    s += temp;
                    if (Math.Pow(s, 2) == m)
                    {
                        Console.WriteLine("Find q = " + q);
                    }

                    Console.WriteLine(q);
                    q++;

                }
            }

            Console.WriteLine("End of circle!");
        }

        static void Third()
        {
            int q = 10;            

            while (q <= 999)
            {
                int temp = q;
                List<int> numbers = new List<int>();
                while (temp / 10 != 0)
                {                    
                    numbers.Add(temp % 10);
                    temp = temp / 10;
                }
                numbers.Add(temp);
                temp = 0;
                foreach(int n in numbers)
                {
                    temp += (int)Math.Pow(n, numbers.Count);
                }
                if (temp==q)
                {
                    Console.WriteLine("Find Armstrong number = " + q);
                }
                Console.WriteLine(q);
                q++;
            }

            Console.WriteLine("End of circle!");
        }

#endregion
    }
}
