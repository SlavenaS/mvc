using MVCtip.Models;
using MVCtip.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtip.Controllers
{
    class TipController
    {
        private Tip tip = new Tip();
        private Display display = new Display();

        public TipController()
        {
            display.Input();

            tip.Amount = display.Amount;
            tip.Persent = display.Persent;

            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();

            display.Output();
        }
    }
}
