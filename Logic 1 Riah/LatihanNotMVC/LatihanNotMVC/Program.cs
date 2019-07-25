using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanNotMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            String Selanjutnya = "Y";
            while (Selanjutnya.ToUpper() == "Y")
            {
                try
                {
                    Console.Write("Input No Soal : ");
                    int noSoal = int.Parse(Console.ReadLine());

                    Console.Write("Input Nilai N : ");
                    int nilaiN = int.Parse(Console.ReadLine());

                    if (noSoal == 1)
                    {
                        int number = 1;
                        int[] sequence = new int[nilaiN];

                        for (int i = 0; i < sequence.Length; i++)
                        {
                            sequence[i] = number;
                            number += 2;
                            Console.Write(sequence[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Soal Tersebut Tidak Ada !");
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    throw;
                }
                Console.WriteLine();
                Console.WriteLine("Apakah Anda Ingin Melanjutkan Soal ? (Y / N)");
                Selanjutnya = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
