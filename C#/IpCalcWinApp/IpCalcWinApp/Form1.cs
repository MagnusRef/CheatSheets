using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpCalcWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ip MyIP = new ip(textBox1.Text, textBox2.Text);
            MyIP.convert();
            MyIP.result();
            MyIP.convertback();
            textBox3.Text = MyIP.getResult();
        }
    }
}
