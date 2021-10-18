using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3GabrielMatosevic20211018
{
    class Vozilo
    {
        bool JeLiLeti;
        bool JeLiPlovi;

        public void KudaVozi()
        {
            Console.WriteLine(this.GetType().Name + " Leti = " + JeLiLeti + " Plovi = " + JeLiPlovi);
        }

        public Vozilo(bool jeLiLeti, bool jeLiPlovi)
        {
            JeLiLeti = jeLiLeti;
            JeLiPlovi = jeLiPlovi;
        }
    }
}
