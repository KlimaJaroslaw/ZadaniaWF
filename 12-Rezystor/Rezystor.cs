using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Rezystor
{
    class Rezystor
    {
        int cyfra1;
        int cyfra2;
        double mnoznik;
        double tolerancja;
        double rezystancja;

        public double Tolerancja { get { return tolerancja; } }

        public Rezystor(int cyfra1, int cyfra2, double mnoznik, double tolerancja)
        {
            this.cyfra1 = cyfra1;
            this.cyfra2 = cyfra2;
            this.mnoznik = mnoznik;
            this.tolerancja = tolerancja;
            
        }

        public double ObliczRezystancje(Rezystor rezystor)
        {
            this.rezystancja = (double)((((rezystor.cyfra1 * 10) + (rezystor.cyfra2)) * mnoznik)/1000);            
            return rezystancja;
        }
        
    }
}
