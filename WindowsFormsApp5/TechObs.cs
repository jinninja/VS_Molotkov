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
    public partial class TechObs : Form
    {
        public TechObs()
        {
            InitializeComponent();
        }

        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            техническоеОбслуживаниеBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            техническоеОбслуживаниеBindingSource.RemoveCurrent();
            Validate();
            техническоеОбслуживаниеBindingSource.EndEdit();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            техническоеОбслуживаниеBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            техническоеОбслуживаниеBindingSource.MoveNext();
        }

        private void TechObs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Техническое_обслуживание". При необходимости она может быть перемещена или удалена.
            this.техническое_обслуживаниеTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Техническое_обслуживание);
            техническое_обслуживаниеTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Техническое_обслуживание);
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            техническое_обслуживаниеTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
