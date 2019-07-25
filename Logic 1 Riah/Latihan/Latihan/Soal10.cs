using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Soal10
    {
        public Soal10(int inputN)
        {
            result(inputN);
        }

        public void result(int inputN)
        {
            int number = 3;
            string[] sequence = new string[inputN];

            for (int i = 0; i < sequence.Length; i++)
            {
                if ((i+1) % 4 == 0)
                {
                    sequence[i] = "XXX";
                    number *= 3;
                }
                else
                {
                    sequence[i] = number.ToString();
                    number *= 3;
                }
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
