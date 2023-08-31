using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            string kata = "NEGIE1";
            string hasil = string.Empty;
            string num = string.Empty;

            for(int i = kata.Length-1 ; i >= 0; i--)
            {
                if (!Char.IsDigit(kata[i]))
                {
                    hasil += kata[i];
                }
                else
                {
                    num += kata[i];
                }
                
            }

            Console.WriteLine($"Hasil = {hasil}{num}");

            Console.ReadKey();
        }
    }
}
