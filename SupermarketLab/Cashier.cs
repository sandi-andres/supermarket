using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketLab
{
    internal class Cashier
    {
        private int minTime;

        private int maxTime;

        private int servingTime;
        public bool taken { get; set; }
        public bool open { get; set; }

        public int timePassed { get; set; }

        internal Cashier(double minTime, double maxTime, int name)
        {
            this.minTime = Convert.ToInt32(minTime * 60);
            this.maxTime = Convert.ToInt32(maxTime * 60);
            taken = false;
            servingTime = 0;
            timePassed = 0;

            if (name == 4) open = false;
            else open = true;
        }

        internal bool Serve()
        {
            bool served = false;

            if (taken)
            {
                timePassed++;

                if (timePassed > servingTime)
                {
                    timePassed = 0;
                    taken = false;
                    served = true;
                }
            }
            return served;
        }

        internal void Take()
        {
            taken = true;
            ServingTime();
        }

        private void ServingTime()
        {
            Random random= new Random();
            servingTime = random.Next(minTime, maxTime + 1);
        }
    }
}
