using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Soal07
    {
        public Soal07(int inputN)
        {
            result(inputN);
        }

        public void result(int inputN)
        {
            int number = 2;
            int[] sequence = new int[inputN];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = number;
                number *= 2;

            }

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
