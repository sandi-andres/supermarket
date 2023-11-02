namespace SupermarketLab
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFila = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCashier1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCashier2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCashier3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCashier4 = new System.Windows.Forms.Label();
            this.labelStatusCashier4 = new System.Windows.Forms.Label();
            this.labelCashierTime1 = new System.Windows.Forms.Label();
            this.labelCashierTime2 = new System.Windows.Forms.Label();
            this.labelCashierTime3 = new System.Windows.Forms.Label();
            this.labelCashierTime4 = new System.Windows.Forms.Label();
            this.labelServed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAverageQueue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaxQueue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMaxWait = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTimeOpenCashier4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(66, 92);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 16);
            this.labelTime.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "QUEUE";
            // 
            // labelFila
            // 
            this.labelFila.AutoSize = true;
            this.labelFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFila.Location = new System.Drawing.Point(155, 136);
            this.labelFila.Name = "labelFila";
            this.labelFila.Size = new System.Drawing.Size(0, 16);
            this.labelFila.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "CASHIER #1";
            // 
            // labelCashier1
            // 
            this.labelCashier1.AutoSize = true;
            this.labelCashier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashier1.Location = new System.Drawing.Point(282, 52);
            this.labelCashier1.Name = "labelCashier1";
            this.labelCashier1.Size = new System.Drawing.Size(43, 16);
            this.labelCashier1.TabIndex = 4;
            this.labelCashier1.Text = "FREE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "CASHIER #2";
            // 
            // labelCashier2
            // 
            this.labelCashier2.AutoSize = true;
            this.labelCashier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashier2.Location = new System.Drawing.Point(282, 160);
            this.labelCashier2.Name = "labelCashier2";
            this.labelCashier2.Size = new System.Drawing.Size(43, 16);
            this.labelCashier2.TabIndex = 6;
            this.labelCashier2.Text = "FREE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "CASHIER #3";
            // 
            // labelCashier3
            // 
            this.labelCashier3.AutoSize = true;
            this.labelCashier3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashier3.Location = new System.Drawing.Point(402, 51);
            this.labelCashier3.Name = "labelCashier3";
            this.labelCashier3.Size = new System.Drawing.Size(43, 16);
            this.labelCashier3.TabIndex = 8;
            this.labelCashier3.Text = "FREE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "CASHIER #4";
            // 
            // labelCashier4
            // 
            this.labelCashier4.AutoSize = true;
            this.labelCashier4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashier4.Location = new System.Drawing.Point(402, 161);
            this.labelCashier4.Name = "labelCashier4";
            this.labelCashier4.Size = new System.Drawing.Size(43, 16);
            this.labelCashier4.TabIndex = 10;
            this.labelCashier4.Text = "FREE";
            // 
            // labelStatusCashier4
            // 
            this.labelStatusCashier4.AutoSize = true;
            this.labelStatusCashier4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusCashier4.Location = new System.Drawing.Point(482, 160);
            this.labelStatusCashier4.Name = "labelStatusCashier4";
            this.labelStatusCashier4.Size = new System.Drawing.Size(0, 16);
            this.labelStatusCashier4.TabIndex = 12;
            // 
            // labelCashierTime1
            // 
            this.labelCashierTime1.AutoSize = true;
            this.labelCashierTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashierTime1.Location = new System.Drawing.Point(282, 81);
            this.labelCashierTime1.Name = "labelCashierTime1";
            this.labelCashierTime1.Size = new System.Drawing.Size(55, 16);
            this.labelCashierTime1.TabIndex = 17;
            this.labelCashierTime1.Text = "00:00:00";
            // 
            // labelCashierTime2
            // 
            this.labelCashierTime2.AutoSize = true;
            this.labelCashierTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashierTime2.Location = new System.Drawing.Point(282, 186);
            this.labelCashierTime2.Name = "labelCashierTime2";
            this.labelCashierTime2.Size = new System.Drawing.Size(55, 16);
            this.labelCashierTime2.TabIndex = 18;
            this.labelCashierTime2.Text = "00:00:00";
            // 
            // labelCashierTime3
            // 
            this.labelCashierTime3.AutoSize = true;
            this.labelCashierTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashierTime3.Location = new System.Drawing.Point(402, 77);
            this.labelCashierTime3.Name = "labelCashierTime3";
            this.labelCashierTime3.Size = new System.Drawing.Size(55, 16);
            this.labelCashierTime3.TabIndex = 19;
            this.labelCashierTime3.Text = "00:00:00";
            // 
            // labelCashierTime4
            // 
            this.labelCashierTime4.AutoSize = true;
            this.labelCashierTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashierTime4.Location = new System.Drawing.Point(402, 188);
            this.labelCashierTime4.Name = "labelCashierTime4";
            this.labelCashierTime4.Size = new System.Drawing.Size(55, 16);
            this.labelCashierTime4.TabIndex = 20;
            this.labelCashierTime4.Text = "00:00:00";
            // 
            // labelServed
            // 
            this.labelServed.AutoSize = true;
            this.labelServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServed.Location = new System.Drawing.Point(214, 262);
            this.labelServed.Name = "labelServed";
            this.labelServed.Size = new System.Drawing.Size(14, 16);
            this.labelServed.TabIndex = 21;
            this.labelServed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "CUSTOMERS SERVED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "QUEUE AVERAGE SIZE";
            // 
            // labelAverageQueue
            // 
            this.labelAverageQueue.AutoSize = true;
            this.labelAverageQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverageQueue.Location = new System.Drawing.Point(214, 304);
            this.labelAverageQueue.Name = "labelAverageQueue";
            this.labelAverageQueue.Size = new System.Drawing.Size(14, 16);
            this.labelAverageQueue.TabIndex = 23;
            this.labelAverageQueue.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "QUEUE MAX SIZE";
            // 
            // labelMaxQueue
            // 
            this.labelMaxQueue.AutoSize = true;
            this.labelMaxQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxQueue.Location = new System.Drawing.Point(214, 344);
            this.labelMaxQueue.Name = "labelMaxQueue";
            this.labelMaxQueue.Size = new System.Drawing.Size(14, 16);
            this.labelMaxQueue.TabIndex = 25;
            this.labelMaxQueue.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "MAX WAIT";
            // 
            // labelMaxWait
            // 
            this.labelMaxWait.AutoSize = true;
            this.labelMaxWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxWait.Location = new System.Drawing.Point(468, 257);
            this.labelMaxWait.Name = "labelMaxWait";
            this.labelMaxWait.Size = new System.Drawing.Size(14, 16);
            this.labelMaxWait.TabIndex = 27;
            this.labelMaxWait.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(292, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 32);
            this.label11.TabIndex = 30;
            this.label11.Text = "CASHIER 4 \r\nOPENED TIME";
            // 
            // labelTimeOpenCashier4
            // 
            this.labelTimeOpenCashier4.AutoSize = true;
            this.labelTimeOpenCashier4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOpenCashier4.Location = new System.Drawing.Point(468, 304);
            this.labelTimeOpenCashier4.Name = "labelTimeOpenCashier4";
            this.labelTimeOpenCashier4.Size = new System.Drawing.Size(14, 16);
            this.labelTimeOpenCashier4.TabIndex = 29;
            this.labelTimeOpenCashier4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 384);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTimeOpenCashier4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelMaxWait);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMaxQueue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAverageQueue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelServed);
            this.Controls.Add(this.labelCashierTime4);
            this.Controls.Add(this.labelCashierTime3);
            this.Controls.Add(this.labelCashierTime2);
            this.Controls.Add(this.labelCashierTime1);
            this.Controls.Add(this.labelStatusCashier4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelCashier4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelCashier3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCashier2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCashier1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCashier1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCashier2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCashier3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCashier4;
        private System.Windows.Forms.Label labelStatusCashier4;
        private System.Windows.Forms.Label labelCashierTime1;
        private System.Windows.Forms.Label labelCashierTime2;
        private System.Windows.Forms.Label labelCashierTime3;
        private System.Windows.Forms.Label labelCashierTime4;
        private System.Windows.Forms.Label labelServed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAverageQueue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMaxQueue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMaxWait;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTimeOpenCashier4;
    }
}

