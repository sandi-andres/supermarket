using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio2
{
    internal class Supermarket
    {
        public int served { get; set; }
        internal List<int> queueSizes = new List<int>();
        public double queueAverage {get; set; }
        public int maxQueue { get; set; }
        internal int maxWait { get; set; }

        public int cashier4TotalTime { get; set; }

        internal Queue<Customer> queue = new Queue<Customer>();
        internal List<Cashier> cashiers = new List<Cashier>()
        {
            new Cashier(1.5, 2.5, 1),
            new Cashier(2, 5, 2),
            new Cashier(2, 4, 3),
            new Cashier(2, 4.5, 4),
        };
        internal List<Cashier> freeCashiers = new List<Cashier>();

        public int seconds {get; set;}

        internal int customerCount;

        internal Supermarket()
        {
            seconds = 0;
            customerCount = 0;
            served = 0;
            cashier4TotalTime = 0;
            CheckCashiers();

            for (int i = 0; i < 25; i++) queue.Enqueue(new Customer());
        }

        internal bool Next()
        {
            seconds ++;
            ServeCashiers();
            NewCustomer();
            ServeCustomer();
            CheckCashiers();
            SaveCashier4Time();
            ManageCashier4();
            QueueStatistics();
            WaitingTimes();

            return !(seconds == 25201);
        }

        private void ServeCashiers()
        {
            for (int i = 0; i < cashiers.Count; i++)
                if (cashiers[i].Serve())
                    served++;
        }

        private void NewCustomer()
        {
            if (customerCount == 60)
            {
                queue.Enqueue(new Customer());
                customerCount = 0;
            }
            customerCount++;

        }
        private void ServeCustomer()
        {
            if (queue.Count > 0)
            {
                if (freeCashiers.Count > 1)
                {
                    Random random = new Random();
                    freeCashiers[random.Next(freeCashiers.Count)].Take();
                    queue.Dequeue();

                }
                else if (freeCashiers.Count == 1)
                {
                    freeCashiers[0].Take();
                    queue.Dequeue();
                }
            }
        }

        private void CheckCashiers()
        {
            freeCashiers = cashiers.Where(x => !x.taken && x.open).Select(x => x).ToList();
        }

        private void ManageCashier4()
        {
            if (queue.Count > 19) cashiers[3].open = true;
            else cashiers[3].open = false;
        }

        private void QueueStatistics()
        {
            queueSizes.Add(queue.Count);
            queueAverage = Math.Round(queueSizes.Average(), 2);
            maxQueue = queueSizes.Max();
        }

        private void WaitingTimes()
        {
            List<Customer> customers = new List<Customer>();

            customers = queue.ToList();

            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].waitingTime++;
            }

            if (queue.Count > 0)
            {
                int currentMaxWait = customers.Select(x => x).Max(x => x.waitingTime);

                if (currentMaxWait > maxWait) maxWait = currentMaxWait;
            }

        }

        private void SaveCashier4Time()
        {
            if (cashiers[3].open) cashier4TotalTime++;
        }

        internal List<bool> GetCashiersTaken()
        {
            return cashiers.Select(x => x.taken).ToList();
        }

        internal bool GetCashier4Status()
        {
            return cashiers[3].open;
        }

        internal List<int> GetTimesPassed()
        {
            return cashiers.Select(x => x.timePassed).ToList();
        }
    }
}
