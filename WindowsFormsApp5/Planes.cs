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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
        }

        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            самолетыBindingSource.AddNew();
        
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            самолетыBindingSource.RemoveCurrent();
            Validate();
            самолетыBindingSource.EndEdit();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            самолетыBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            самолетыBindingSource.MoveNext();
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            самолетыTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Самолеты". При необходимости она может быть перемещена или удалена.
            this.самолетыTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Самолеты);
            модель_самолетаTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Модель_самолета);
        }
    }
}
