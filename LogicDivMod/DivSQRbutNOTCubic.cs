using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDivMod
{
    public interface IPrinter
    {
        void Print(List<Number> numbers);
    }
    public class ConsolePrinter : IPrinter
    {
        public void Print(List<Number> numbers)
        {
            foreach(Number a in numbers)
            {
                Console.WriteLine("Number =  " + a.Q + "  has been found!");
            }
        }
    }

    public interface IValidator
    {
        bool IsValid(Data n);
    }
    public class GeneralValidator : IValidator
    {
        public bool IsValid(Data n)
        {
            try
            {
                if (n.N > 0)
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

    public interface IReader
    {
        Data GetInputData();
    }
    public class ConsoleReader : IReader
    {
        public Data GetInputData()
        {            
            while (true)
            {
                Console.WriteLine("Please, enter any positive integer/natural number : ");                
                int temp;
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    return new Data { N = temp };
                }
                else
                {
                    Console.WriteLine("Wrong data! Please, try again.");
                }
            }                               
        }
    }

    public class Data
    {
        public int N { get; set; }
    }

    public class Number
    {
        public int Q { get; set; }
    }

    public class DivSQRbutNOTCubic
    {
        List<Number> numbers = new List<Number>();

        public IValidator Validator { get; set; }
        public IReader Reader { get; set; }
        public IPrinter Printer { get; set; }

        public DivSQRbutNOTCubic(IReader reader, IValidator validator, IPrinter printer)
        {
            this.Reader = reader;            
            this.Validator = validator;
            this.Printer = printer;
        }

        public void Method()
        {
            int q = 1;            
            Data data = Reader.GetInputData();
            
            if (Validator.IsValid(data))
            {
                while (data.N >= Math.Pow(q, 2))
                {
                    if (data.N % Math.Pow(q, 2) == 0 && data.N % Math.Pow(q, 3) != 0)
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
