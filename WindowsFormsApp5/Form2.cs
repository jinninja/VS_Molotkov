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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet.Билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Билет);
            рейсыTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Рейсы);

        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            билетTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
            MessageBox.Show("Save Complete");
        }

        private void AddStoiButton_Click(object sender, EventArgs e)
        {

            билетBindingSource.AddNew();


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            билетBindingSource.RemoveCurrent();
            Validate();
            билетBindingSource.EndEdit();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            билетBindingSource.MoveNext();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            билетBindingSource.MovePrevious();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
