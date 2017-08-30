using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDivMod
{
    public interface IValidator2
    {
        bool IsValid(Data2 n);
    }
    public class GeneralValidator2 : IValidator2
    {
        public bool IsValid(Data2 n)
        {
            try
            {
                if (n.N > 0 && n.M > 0 && Math.Sqrt(n.M) % 1 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public interface IReader2
    {
        Data2 GetInputData();
    }
    public class ConsoleReader2 : IReader2
    {
        public Data2 GetInputData()
        {
            while (true)
            {
                Console.WriteLine("Please, enter any positive integer/natural numbers where [m] is square of some number : ");
                Console.WriteLine("n, m :");
                int tempn;
                int tempm;
                if (int.TryParse(Console.ReadLine(), out tempn) && int.TryParse(Console.ReadLine(), out tempm))
                {
                    return new Data2 { N = tempn, M = tempm };
                }
                else
                {
                    Console.WriteLine("Wrong data! Please, try again.");
                }
            }
        }
    }

    public class Data2
    {
        public int N { get; set; }
        public int M { get; set; }
    }

    class SQRSumEqualNumber
    {
        List<Number> numbers = new List<Number>();

        public IValidator2 Validator { get; set; }
        public IReader2 Reader { get; set; }
        public IPrinter Printer { get; set; }

        public SQRSumEqualNumber(IReader2 reader, IValidator2 validator, IPrinter printer)
        {
            this.Reader = reader;
            this.Validator = validator;
            this.Printer = printer;
        }

        public void Method()
        {
            int q = 1;
            Data2 data = Reader.GetInputData();

            if (Validator.IsValid(data))
            {
                while (data.N > q)
                {
                    int s = 0;
                    int temp = q;
                    while (temp / 10 != 0)
                    {
                        s += temp % 10;
                        temp = temp / 10;

                    }
                    s += temp;
                    if (Math.Pow(s, 2) == data.M)
                    {
                        numbers.Add(new Number { Q = q });
                    }                    
                    q++;
                }
                Printer.Print(numbers);

                Console.WriteLine("Successfully completed!");
            }
            else
            {
                Console.WriteLine("Invalid data!");
            }    
        }
    }
}
