using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Soal01
    {
        public Soal01(int inputN)
        {
            result(inputN);
        }

        public void result(int inputN)
        {
            int number = 1;
            int[] Sequence = new int[inputN];

            for (int i = 0; i < Sequence.Length; i++)
            {
                Sequence[i] = number;
                number += 2;
                
            }

            for (int i = 0; i < Sequence.Length; i++)
            {
                
                Console.Write(Sequence[i] + " ");
                
            }

            Console.WriteLine();


        }
    }
}
