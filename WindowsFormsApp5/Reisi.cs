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
    public partial class Reisi : Form
    {
        public Reisi()
        {
            InitializeComponent();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            рейсыBindingSource.MovePrevious();
        }

        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            рейсыBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            рейсыBindingSource.RemoveCurrent();
            Validate();
            рейсыBindingSource.EndEdit();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            рейсыBindingSource.MoveNext();
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            рейсыTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Рейсы);
        }

        private void Reisi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Рейсы);
            this.бригадыTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Бригады);
            this.расписанияTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Расписания);
            this.самолетыTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Самолеты);
            this.маршрутTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Маршрут);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
