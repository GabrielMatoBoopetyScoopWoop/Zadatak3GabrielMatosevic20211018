using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3GabrielMatosevic20211018
{
    class Program
    {
        static void Main(string[] args)
        {
            Brod Barka = new Brod();
            Zrakoplov Avion = new Zrakoplov();
            Barka.KudaVozi();
            Avion.KudaVozi();
            Console.ReadKey();
        }
    }
}
