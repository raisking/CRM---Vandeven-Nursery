using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form2 newFrm = new Form2();
            newFrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newFrm4 = new Form4();
            newFrm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newFrm3 = new Form3();
            newFrm3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 newFrm3 = new Form3();
            newFrm3.Show();
            this.Hide();
        }
    }
}
