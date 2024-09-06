using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        private Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
           
            listView1.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listView1.Items.Add(obj.ToString());
                
            }
        }
    

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();

                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
