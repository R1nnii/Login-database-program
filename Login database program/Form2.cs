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
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\khvin\source\repos\Login database program\Login database program\Database.mdf;Integrated Security = True");
            cn.Open();

        }

        private void nologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void logK_Click(object sender, EventArgs e)
        {
            if (textlogKode.Text != string.Empty || textlogBruger.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from [Table] where brugernavn='" + textlogBruger.Text + "' and kodeord='" + textlogKode.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Form3 Form3 = new Form3();
                    Form3.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Dit kodeord eller brugernavn er forkert ", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("udfyld alle fælter.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textlogBruger_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
