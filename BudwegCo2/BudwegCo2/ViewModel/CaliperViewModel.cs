using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudwegCo2.Model;

namespace BudwegCo2.ViewModel
{
    public class CaliperViewModel
    {

        private Caliper caliper;
        public int Amount { get; set; }

        public double SavedCo2 { get; set; }

        public double AmountCo2Saved { get; set; }

        public CaliperViewModel(Caliper caliper)
        {
            Amount = caliper.Amount;
            SavedCo2 = caliper.SavedCo2;
            AmountCo2Saved = caliper.AmountCo2Saved;
        }

        
    }

}

