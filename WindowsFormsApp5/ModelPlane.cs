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
    public partial class ModelPlane : Form
    {
        public ModelPlane()
        {
            InitializeComponent();
        }

        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            модельСамолетаBindingSource.AddNew();
        
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            модельСамолетаBindingSource.RemoveCurrent();
            Validate();
            модельСамолетаBindingSource.EndEdit();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            модельСамолетаBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            модельСамолетаBindingSource.MoveNext();
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            модель_самолетаTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
        }

        private void ModelPlane_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Модель_самолета". При необходимости она может быть перемещена или удалена.
            this.модель_самолетаTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Модель_самолета);
            модель_самолетаTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Модель_самолета);
        }
    }
}
