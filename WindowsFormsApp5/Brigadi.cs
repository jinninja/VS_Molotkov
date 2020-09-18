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
    public partial class Brigadi : Form
    {
        public Brigadi()
        {
            InitializeComponent();
        }

      

        private void SaveSS_Click(object sender, EventArgs e)
        {
            бригадыTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
            MessageBox.Show("Save complete");
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            бригадыBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            бригадыBindingSource.MoveNext();
        }

        private void AddButtonBrig_Click(object sender, EventArgs e)
        {
            бригадыBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            бригадыBindingSource.RemoveCurrent();
            Validate();
            бригадыBindingSource.EndEdit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Brigadi_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Бригады". При необходимости она может быть перемещена или удалена.
            this.бригадыTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Бригады);
            this.типTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Тип);
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
