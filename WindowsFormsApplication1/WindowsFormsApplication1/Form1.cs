using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\it3883group4-01\Desktop\Group4\Assignment 7\Project2DB.accdb;
                                    Persist Security Info=False;";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newFrm = new Form2();
            newFrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newFrm3 = new Form3();
            newFrm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newFrm4 = new Form4();
            newFrm4.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\it3883group4-01\Desktop\Group4\Assignment 7\Project2DB.accdb;
                                    Persist Security Info=False;";
                connection.Open();
                check.Text = "Connection Successful";
               
                connection.Close();
            }
            catch(Exception f)
            {

                MessageBox.Show("Error" + f);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            // Form7 = new Form7();
            // aa.Show();
            try
            {

                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * from Data where username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    //count = count + 1; 
                    count++;


                }
                if (count == 1)
                {
                   // MessageBox.Show("Welcome!!!");
                  
                    connection.Close();
                    connection.Dispose();
                    this.Hide();
                    Form7 f7= new Form7();
                    f7.ShowDialog();


                }
                else if (count > 1)
                {
                    MessageBox.Show(" Incorrect username and password!!!");

                }
                else
                {
                    MessageBox.Show(" Username and Password is not correct!!!");
                }

                connection.Close();

            }

            catch (Exception x)
            {

                MessageBox.Show("Error try again!!!" + x);
            }
        }
    }
}
