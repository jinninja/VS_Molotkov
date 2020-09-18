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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            персоналBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            персоналBindingSource.RemoveCurrent();
            Validate();
            персоналBindingSource.EndEdit();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            персоналBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            персоналBindingSource.MoveNext();
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            персоналTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Персонал);
            this.бригадыTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Бригады);
            this.должностьTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Должность);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
