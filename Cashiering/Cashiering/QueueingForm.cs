using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashiering
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

            

        }
        public class CashierClass
        {
            private int x; // Initial value
            public static string getNumberInQueue = "";
            public static Queue<string> CashierQueue;

            // Constructor
            public CashierClass()
            {
                x = 10000;
                CashierQueue = new Queue<string>();
            }

            // Method to generate the queue number
            public string CashierGeneratedNumber(string CashierNumber)
            {
                x++;
                CashierNumber = CashierNumber + x.ToString();
                return CashierNumber;
            }
        }
    }
}
        





