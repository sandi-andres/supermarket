using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        Supermarket supermarket = new Supermarket();

        public Form1()
        {
            InitializeComponent();
            RefreshUI();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            TimeSpan time = TimeSpan.FromSeconds(supermarket.seconds);

            labelTime.Text = string.Format("{0:D2}H : {1:D2}M : {2:D2}S",
                time.Hours,
                time.Minutes,
                time.Seconds);

            if (!this.supermarket.Next()) timer.Enabled = false;

            RefreshUI();

        }

        private void RefreshUI()
        {
            List<bool> cashiersTaken = supermarket.GetCashiersTaken();

            labelFila.Text = supermarket.queue.Count.ToString();
            if (cashiersTaken[0])
            {
                labelCashier1.Text = "TAKEN";
                labelCashier1.ForeColor = Color.Red;
            }
            else
            {
                labelCashier1.Text = "FREE";
                labelCashier1.ForeColor = Color.Green;
            }

            if (cashiersTaken[1])
            {
                labelCashier2.Text = "TAKEN";
                labelCashier2.ForeColor = Color.Red;
            }
            else
            {
                labelCashier2.Text = "FREE";
                labelCashier2.ForeColor = Color.Green;
            }

            if (cashiersTaken[2])
            {
                labelCashier3.Text = "TAKEN";
                labelCashier3.ForeColor = Color.Red;
            }
            else
            {
                labelCashier3.Text = "FREE";
                labelCashier3.ForeColor = Color.Green;
            }

            if (cashiersTaken[3])
            {
                labelCashier4.Text = "TAKEN";
                labelCashier4.ForeColor = Color.Red;
            }
            else
            {
                labelCashier4.Text = "FREE";
                labelCashier4.ForeColor = Color.Green;
            }

            if (supermarket.GetCashier4Status())
            {
                labelStatusCashier4.Text = "OPEN";
                labelStatusCashier4.ForeColor = Color.Blue;
            }
            else
            {
                labelStatusCashier4.Text = "CLOSED";
                labelStatusCashier4.ForeColor= Color.Red;
            }

            List<int> timePassed = supermarket.GetTimesPassed();

            TimeSpan timeCashier1 = TimeSpan.FromSeconds(timePassed[0]);
            labelCashierTime1.Text = string.Format("{0:D2} : {1:D2}",
                timeCashier1.Minutes,
                timeCashier1.Seconds);

            TimeSpan timeCashier2 = TimeSpan.FromSeconds(timePassed[1]);
            labelCashierTime2.Text = string.Format("{0:D2} : {1:D2}",
                timeCashier2.Minutes,
                timeCashier2.Seconds);

            TimeSpan timeCashier3 = TimeSpan.FromSeconds(timePassed[2]);
            labelCashierTime3.Text = string.Format("{0:D2} : {1:D2}",
                timeCashier3.Minutes,
                timeCashier3.Seconds);

            TimeSpan timeCashier4 = TimeSpan.FromSeconds(timePassed[3]);
            labelCashierTime4.Text = string.Format("{0:D2} : {1:D2}",
                timeCashier4.Minutes,
                timeCashier4.Seconds);

            labelServed.Text = supermarket.served.ToString();
            labelAverageQueue.Text = supermarket.queueAverage.ToString();
            labelMaxQueue.Text = supermarket.maxQueue.ToString();

            TimeSpan maxWaitingTime = TimeSpan.FromSeconds(supermarket.maxWait);
            labelMaxWait.Text = string.Format("{0:D2} : {1:D2} : {2:D2}",
                maxWaitingTime.Hours,
                maxWaitingTime.Minutes,
                maxWaitingTime.Seconds);

            TimeSpan totalTimeCashier4 = TimeSpan.FromSeconds(supermarket.cashier4TotalTime);
            labelTimeOpenCashier4.Text = string.Format("{0:D2} : {1:D2} : {2:D2}",
                totalTimeCashier4.Hours,
                totalTimeCashier4.Minutes,
                totalTimeCashier4.Seconds);
        }
    }
}
