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

namespace WindowsFormsApp5
{
    public partial class Authhh : Form
    {
        public Authhh()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox2.PasswordChar = '☺';
            else textBox2.PasswordChar = '\0';
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection
              ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=auth.mdb");
            OleDbDataAdapter da = new OleDbDataAdapter
                ("SELECT Rol FROM Auth WHERE log='" + textBox1.Text + "' and pas='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int rol = Convert.ToInt32(dt.Rows[0][0]);
                Form1 fa = new Form1(rol);
                fa.Show();

            }
            else
            {
                MessageBox.Show
                ("Не удается войти.\n" +
            "Не парвильный логин или пароль.\n",
                "ERROR",

                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
