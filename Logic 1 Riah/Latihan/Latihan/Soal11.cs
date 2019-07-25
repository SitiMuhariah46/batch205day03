using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Soal11
    {
        public Soal11(int inputN)
        {
            result(inputN);
        }

        public void result(int inputN)
        {
            int number = 1;
            string[] sequence = new string[inputN];

            for (int i = 0; i < sequence.Length; i++)
            {   
                if (i <= inputN / 2 )
                {
                    if ((i+1) % 2 == 0)
                    {
                        sequence[i] = "*";
                        sequence[inputN - 1 - i] = "*";
                        
                    }
                    else
                    {
                        sequence[i] = number.ToString();
                        sequence[inputN - 1 - i] = number.ToString();
                        number += 1;
                        
                    }
                    
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
