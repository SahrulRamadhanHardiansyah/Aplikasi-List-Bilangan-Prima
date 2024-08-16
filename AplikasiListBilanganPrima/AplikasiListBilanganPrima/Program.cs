using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiListBilanganPrima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi List Bilangan Prima");
            Console.WriteLine("\n========================================================================================================================");
            Console.WriteLine("Nama : Sahrul Ramadhan Hardiansyah");
            Console.WriteLine("Kelas : X - PPLG");
            Console.WriteLine("Absen : 31");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\nList Bilangan Prima :");
            
            
            for (int num = 2; num <= 1000; num++) //Melakukan loop dari dua hingga seribu
            {
                bool isPrime = true; //Mengasumsikan bilangan prima sebagai isPrime dan menetapkan isPrime menjadi True
                for (int i = 2; i <= Math.Sqrt(num); i++) //Melakukan loop dari dua hingga akar kuadrat dari num
                {
                    if (num % i == 0) //Jika num habis dibagi oleh salah satu angka dalam loop
                    {
                        isPrime = false; //Maka isPrime diatur menjadi false
                        break;//dan loop dihentikan
                    }
                }

                if (isPrime) //Jika setelah loop isPrime masih True
                {
                    Console.WriteLine(num + " ");  //Maka num adalah bilangan prima dan tampilkan list bilangan prima ke console
                }

            }

        }
    }
}
