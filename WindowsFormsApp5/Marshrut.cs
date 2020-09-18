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
    public partial class Marshrut : Form
    {
        public Marshrut()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Marshrut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Маршрут". При необходимости она может быть перемещена или удалена.
            this.маршрутTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Маршрут);
            маршрутTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Маршрут);
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            маршрутTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1.Маршрут);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            маршрутBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            маршрутBindingSource.MoveNext();
        }

        private void AddStoiButton_Click(object sender, EventArgs e)
        {
            маршрутBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            маршрутBindingSource.RemoveCurrent();
            Validate();
            маршрутBindingSource.EndEdit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
