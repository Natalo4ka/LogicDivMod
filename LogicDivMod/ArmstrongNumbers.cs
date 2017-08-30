using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDivMod
{
    class ArmstrongNumbers
    {
        List<Number> numbers = new List<Number>();
        
        public IReader Reader { get; set; }
        public IPrinter Printer { get; set; }

        public ArmstrongNumbers(IReader reader, IPrinter printer)
        {
            this.Reader = reader;            
            this.Printer = printer;
        }

        public void Method()
        {
            int q = 10;
            Data data = new Data
            {
                N = 999
            };
            while (q <= data.N)
            {
                int temp = q;
                List<int> chysla = new List<int>();
                while (temp / 10 != 0)
                {
                    chysla.Add(temp % 10);
                    temp = temp / 10;
                }
                chysla.Add(temp);
                temp = 0;
                foreach (int n in chysla)
                {
                    temp += (int)Math.Pow(n, chysla.Count);
                }
                if (temp == q)
                {
                    numbers.Add(new Number { Q = q });
                }                
                q++;
            }

            Printer.Print(numbers);
            Console.WriteLine("Successfully completed!");            
        }
    }
}
