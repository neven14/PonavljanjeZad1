using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljaneZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaG MainObjekt = new KlasaG();
            int Broj;
            Console.Write("Upisite broj: ");
            Broj = Convert.ToInt32(Console.ReadLine());
            MainObjekt.Plus10(Broj);
            MainObjekt.f50(Broj);

            Console.ReadKey();
        }
    }
}
