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
    public partial class Form1 : Form
    {
        int role;
        public Form1(int rol)
        {
            InitializeComponent();
            role = rol;
            switch (role)
            {
                case 1:

                    MessageBox.Show
                ("Вы вошли как администратор",
                "welcome",
                MessageBoxButtons.OK);


                    break;
                case 2:

                    BrigB.Visible = false;
                    ReisiB.Visible = false;
                    typeB.Visible = false;
                    DoljB.Visible = false;
                    MarshB.Visible = false;
                    ModelSB.Visible = false;
                    PlanesB.Visible = false;
                    TechObsB.Visible = false;

                    break;
                default:

                    break;
            }
        }

        private void Reys_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
                ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
               ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Brigadi f = new Brigadi();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
               ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Doljnost f = new Doljnost();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
              ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Marshrut f = new Marshrut();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
             ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            ModelPlane f = new ModelPlane();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
             ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Personal f = new Personal();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
             ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Raspisanie f = new Raspisanie();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
             ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Reisi f = new Reisi();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
             ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            Planes f = new Planes();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
             ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            TechObs f = new TechObs();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection
             ("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Microsoft_Access_Baza_dannykh_2.mdb");
            type f = new type();
            f.Show();
        }
    }
}
