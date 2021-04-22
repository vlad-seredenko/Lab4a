using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4aA
{
    public class Tablet
    {
        public string Brand;
        public string Model;
        public string Color;
        public int Memory;
        public double Year;
        public double SizeDisplay;
        public bool Bluetooth;
        public bool NFC;
        public int Number;
        public double TotalPrice;
        public double GetYearIncomePerInhabitant()
        {

            return TotalPrice / Number;
        }
    }
    
   
}
