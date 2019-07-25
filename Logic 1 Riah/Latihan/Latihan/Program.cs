using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
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
                    Console.Write("Masukan No Soal : ");
                    int noSoal = int.Parse(Console.ReadLine());

                    Console.Write("Masukan Nilai N : ");
                    int inputN = int.Parse(Console.ReadLine());

                    switch (noSoal)
                        {
                            case 1 :
                                Soal01 soal01 = new Soal01(inputN);
                                break;
                            case 2 :
                                Soal02 soal02 = new Soal02(inputN);
                                break;
                            case 3 :
                                Soal03 soal03 = new Soal03(inputN);
                                break;
                            case 4 :
                                Soal04 soal04 = new Soal04(inputN);
                                break;
                        case 5 :
                                Soal05 soal05 = new Soal05(inputN);
                                break;
                        case 6 :
                                Soal06 soal06 = new Soal06(inputN);
                                break;
                        case 7 :
                                Soal07 soal07 = new Soal07(inputN);
                                break;
                        case 8 :
                                Soal08 soal08 = new Soal08(inputN);
                                break;
                        case 9 :
                                Soal09 soal09 = new Soal09(inputN);
                                break;
                        case 10 :
                                Soal10 soal10 = new Soal10(inputN);
                                break;
                        case 11 :
                                Soal11 soal11 = new Soal11(inputN);
                                break;
                            default :
                                Console.WriteLine("No Soal Tidak Tersedia !");
                                break;
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
