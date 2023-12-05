using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtip.Models
{
    public class Tip
    {
        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private double persent;
        public double Persent
        {
            get { return persent; }
            set
            {
                if (value > 1)
                {
                    persent = value / 100.0;
                }
                else
                {
                    persent = value;
                }

            }
        }

        public Tip(double amount, double persent)
        {
            this.Amount = amount;
            this.Persent = persent;
        }
        public Tip() : this(0, 0) { }//prazen ctor

        public double CalculateTip()
        {
            return Amount * Persent;
        }
        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
