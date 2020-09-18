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
    public partial class Raspisanie : Form
    {
        public Raspisanie()
        {
            InitializeComponent();
        }

        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            расписанияBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            расписанияBindingSource.RemoveCurrent();
            Validate();
            расписанияBindingSource.EndEdit();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            расписанияBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            расписанияBindingSource.MoveNext();
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            расписанияTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
        }

        private void Raspisanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Расписания". При необходимости она может быть перемещена или удалена.
            this.расписанияTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Расписания);
            расписанияTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Расписания);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
