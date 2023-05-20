using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_database_program
{
    public partial class Form1 : Form
    {
       SqlCommand cmd;
       SqlConnection cn;
       SqlDataReader dr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\khvin\source\repos\Login database program\Login database program\Database.mdf;Integrated Security = True");
            cn.Open();
        }

        private void loginknap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }

        private void brugerknap_Click(object sender, EventArgs e)
        {
            if (textkode2.Text != string.Empty || textkode1.Text != string.Empty || textbruger1.Text != string.Empty)
            {
                if (textkode1.Text == textkode2.Text)
                {
                    cmd = new SqlCommand("select * from [Table] where brugernavn='" + textbruger1.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Brugernavn er allerede brugt, vælg et andet brugernavn", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into [Table] values(@brugernavn,@kodeord)", cn);
                        cmd.Parameters.AddWithValue("brugernavn", textbruger1.Text);
                        cmd.Parameters.AddWithValue("kodeord", textkode1.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Din Account er blevet lavet . du kan logge ind nu.", "færdig", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hust at indskrive begge kodeord rigtig og ens ", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Udfyld alle felterne.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
