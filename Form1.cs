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

namespace NepaliDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
       
               
           
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.DroppedDown = true;
            if (comboBox1.Text == "")
            {
                //MessageBox.Show("Please Enter Words !");
                richTextBox4.Clear();
                richTextBox3.Clear();
                richTextBox2.Clear();
                richTextBox5.Clear();
            }
            else
            {
                string strProvider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DB.accdb";
                string strSql = "Select * from td where Nepali='" +comboBox1.Text + "'";
                OleDbConnection conn = new OleDbConnection(strProvider);
                OleDbCommand cmdd = new OleDbCommand(strSql, conn);
                conn.Open();
                cmdd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmdd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                try
                {
                    if (scores.Rows.Count >= 1)
                    {
                        richTextBox2.Text = scores.Rows[0].ItemArray[4].ToString();
                        richTextBox3.Text = scores.Rows[0].ItemArray[3].ToString();
                        richTextBox4.Text = scores.Rows[0].ItemArray[1].ToString();
                        richTextBox5.Text = scores.Rows[0].ItemArray[2].ToString();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            comboBox4.SelectedIndex = 1;
            string q = "select Nepali from td";
            OleDbDataAdapter dt = new OleDbDataAdapter(q, @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DB.accdb");
            DataTable src = new DataTable();
            dt.Fill(src);
            comboBox1.ValueMember = "Nepali";
            comboBox1.DisplayMember = "Nepali";
            comboBox1.DataSource = src;
            comboBox1.Text = "";

            string q1 = "select Neglish from td";
            OleDbDataAdapter dt1 = new OleDbDataAdapter(q1, @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DB.accdb");
            DataTable src1 = new DataTable();
            dt1.Fill(src1);
            comboBox2.ValueMember = "Neglish";
            comboBox2.DisplayMember = "Neglish";
            comboBox2.DataSource = src1;
            comboBox2.Text = "";

            string q2 = "select English from td";
            OleDbDataAdapter dt2 = new OleDbDataAdapter(q2, @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DB.accdb");
            DataTable src2 = new DataTable();
            dt2.Fill(src2);
            comboBox3.ValueMember = "English";
            comboBox3.DisplayMember = "English";
            comboBox3.DataSource = src2;
            comboBox3.Text = "";

            if (comboBox4.SelectedIndex == 0)
            {
                comboBox1.Show();
                comboBox3.Hide();
                comboBox2.Hide();
            }
            if (comboBox4.SelectedIndex == 1)
            {

                comboBox2.Show();
                comboBox1.Hide();
                comboBox3.Hide();
            }
            if (comboBox4.SelectedIndex == 2)
            {

                comboBox3.Show();
                comboBox1.Hide();
                comboBox2.Hide();

            }

        }

       
        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.DroppedDown = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                //MessageBox.Show("Please Enter Words !");
                richTextBox4.Clear();
                richTextBox3.Clear();
                richTextBox2.Clear();
                richTextBox5.Clear();
            }
            else
            {
                string strProvider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DB.accdb";
                string strSql = "Select * from td where Neglish='" + comboBox2.Text + "'";
                OleDbConnection conn = new OleDbConnection(strProvider);
                OleDbCommand cmdd = new OleDbCommand(strSql, conn);
                conn.Open();
                cmdd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmdd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                try
                {
                    if (scores.Rows.Count >= 1)
                    {
                        richTextBox2.Text = scores.Rows[0].ItemArray[4].ToString();
                        richTextBox5.Text = scores.Rows[0].ItemArray[2].ToString();
                        richTextBox3.Text = scores.Rows[0].ItemArray[3].ToString();
                        richTextBox4.Text = scores.Rows[0].ItemArray[1].ToString();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.DroppedDown = true;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                //MessageBox.Show("Please Enter Words !");
                richTextBox4.Clear();
                richTextBox3.Clear();
                richTextBox2.Clear();
                richTextBox5.Clear();
            }
            else
            {
                string strProvider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DB.accdb";
                string strSql = "Select * from td where English='" + comboBox3.Text + "'";
                OleDbConnection conn = new OleDbConnection(strProvider);
                OleDbCommand cmdd = new OleDbCommand(strSql, conn);
                conn.Open();
                cmdd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmdd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                try
                {
                    if (scores.Rows.Count >= 1)
                    {
                        richTextBox2.Text = scores.Rows[0].ItemArray[4].ToString();
                        richTextBox4.Text = scores.Rows[0].ItemArray[1].ToString();
                        richTextBox5.Text = scores.Rows[0].ItemArray[2].ToString();
                        richTextBox3.Text = scores.Rows[0].ItemArray[3].ToString();
                        
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;

                if (comboBox4.SelectedIndex == 0)
                {
                    comboBox1.Show();
                    comboBox3.Hide();
                    comboBox2.Hide();
                }
                if (comboBox4.SelectedIndex == 1)
                {

                    comboBox2.Show();
                    comboBox1.Hide();
                    comboBox3.Hide();
                }
                if (comboBox4.SelectedIndex == 2)
                {

                    comboBox3.Show();
                    comboBox1.Hide();
                    comboBox2.Hide();

                }
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kalukunda.com.np");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:santoshkalukunda@gmail.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/santoshkalukunda");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Santosh Kalukunda");
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox4.DroppedDown= true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox4.DroppedDown = true;
        }
    }
    }
    


