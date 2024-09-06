using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barnido
{
    public partial class QueueForm : Form
    {
        private CashierClass cashier;
        public QueueForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            Form Cashier = new CashierWindowQueueForm();
            Cashier.Show();
        }

        private void QueueForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = cashier.CashierGeneratedNumber("P-");
            CashierClass.getNumberInQueue = label1.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
           
        }
    }
}
