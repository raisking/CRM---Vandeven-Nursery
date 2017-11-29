using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {

            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\it3883group4-01\Desktop\Group4\Assignment 7\Project2DB.accdb;
                                    Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 newFrm = new Form7();
            newFrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try { 
            
             // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Insert into Customer (CustID,FirstName,LastName,Address,PhoneNumber,Email,PaymentMethod) values('"+ textBox1.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_address.Text + "','" + txt_Pnumber.Text + "','" + txt_email.Text + "','" + comboBox1.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show(" Customer Added SUCCESSFUL!");
             
               connection.Close();

            }


            catch(Exception x)
            {

                MessageBox.Show("Error try again!!!" + x);
            }
                   }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select*from Customer";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

            }
            catch (Exception xxx)
            {

                MessageBox.Show("Errro try again!!!" + xxx);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //delete data from access database (make sure to comment if any changes)
            try
            {
                //DO NOT CHANGE
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "DELETE from Customer WHERE CustID =" + textBox1.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();
                textBox1.Clear();
                MessageBox.Show("Date Deleted SUCCESSFUL");
                connection.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show("Errror try again !!!" + ee);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Edit Data
            //Edit data
            //edit data into access database 
            try
            {

                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " UPDATE Customer set FirstName = '" + txt_fname.Text + "' ,LastName= '" + txt_lname.Text + "',Address= '" + txt_address.Text + "',PhoneNumber= '" + txt_Pnumber.Text + "',Email= '" + txt_email.Text + "',PaymentMethod= '" + comboBox1.Text + "'WHERE CustID = " + textBox1.Text + "";
                MessageBox.Show(" Data Edit SUCCESSFUL!");
                command.CommandText = query;
                command.ExecuteNonQuery();
                textBox1.Clear();
                txt_fname.Clear();
                txt_lname.Clear();
                txt_address.Clear();
                txt_Pnumber.Clear();
                txt_email.Clear();
                //txt_Pmethod.Clear();
                connection.Close();

            }
            catch (Exception mx)
            {

                MessageBox.Show("Errro try again!!!" + mx);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                // Donot make any changes
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM Customer WHERE CustID =" + textBox1.Text + "";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                textBox1.Clear();
                connection.Close();

            }
            catch (Exception xxx)
            {

                MessageBox.Show("Errro try again!!!" + xxx);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            txt_Pnumber.Clear();
            txt_email.Clear();
            comboBox1.ResetText();
        }
   
    }
}//end 
