using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Soal09
    {
        public Soal09(int inputN)
        {
            result(inputN);
        }

        public void result(int inputN)
        {
            int number = 4;
            String[] sequence = new string[inputN];

            for (int i = 0; i < sequence.Length; i++)
            {
                if ((i+1) % 3 == 0)
                {
                    sequence[i] = "*";
                }
                else
                {
                    sequence[i] = number.ToString();
                    number *= 4;
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
