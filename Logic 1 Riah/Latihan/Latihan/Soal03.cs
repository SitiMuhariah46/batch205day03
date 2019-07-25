using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Soal03
    {
        public Soal03(int inputN)
        {
            result(inputN);
        }

        public void result(int inputN)
        {
            int number = 1;
            int[] sequence = new int[inputN];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = number;
                number += 3;
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(sequence[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
