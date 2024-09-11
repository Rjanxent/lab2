using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cashiering
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            // Timer setup for automatic refreshing
            timer = new Timer();
            timer.Interval = 1000; // Refresh every second
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        public void DisplayCashierQueue(IEnumerable CashierList) 
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList) 
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue(); // Remove the first item
                DisplayCashierQueue(CashierClass.CashierQueue); // Refresh the list
            }
        }
        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void RemoveItemQueue() 
        {
          CashierClass.CashierQueue.Dequeue();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



      
    }
}
