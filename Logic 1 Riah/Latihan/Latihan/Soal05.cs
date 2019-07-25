using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Soal05
    {
        public Soal05(int inputN)
        {
            result(inputN);
        }

        public void result (int inputN)
        {
            int number = 1;
            String[] sequence = new String[inputN];

            for (int i = 0; i < sequence.Length; i++)
            {
                 if ((i+1) % 3 == 0)
                {
                    sequence[i] = "*";                    
                }
                 else
                 {
                    sequence[i] = number.ToString();
                    number += 4;
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
