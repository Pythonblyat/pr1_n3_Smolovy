using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_n3_Smolovyk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hrivnas(x): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("kopiiki(y): ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("bulochki(n): ");
            int n = int.Parse(Console.ReadLine());

            int totalKopiiki = x * 100 + y;
            int totalSumKopiiki = totalKopiiki * n;

            int totalHrivnas = totalSumKopiiki / 100;
            int totalKop = totalSumKopiiki % 100;

            Console.WriteLine($"For {n} bulochok u should pay {totalHrivnas} hriven {totalKop} kopiiok");


        }
    }
}
