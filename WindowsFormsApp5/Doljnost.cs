using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Doljnost : Form
    {
        public Doljnost()
        {
            InitializeComponent();
        }
        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            должностьBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            должностьBindingSource.RemoveCurrent();
            Validate();
            должностьBindingSource.EndEdit();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            должностьBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            должностьBindingSource.MoveNext();
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            должностьTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Doljnost_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Должность);
            this.должностьTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Должность);
        }
    }
}
