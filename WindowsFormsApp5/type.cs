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
    public partial class type : Form
    {
        public type()
        {
            InitializeComponent();
        }

        private void AddButtonDolj_Click(object sender, EventArgs e)
        {
            типBindingSource.AddNew();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            типBindingSource.RemoveCurrent();
            Validate();
            типBindingSource.EndEdit();
        }

        private void type_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_Baza_dannykh_2DataSet1.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.microsoft_Access_Baza_dannykh_2DataSet1.Тип);
            типTableAdapter.Fill(microsoft_Access_Baza_dannykh_2DataSet1.Тип);
        }

        private void SaveSS_Click(object sender, EventArgs e)
        {
            типTableAdapter.Update(microsoft_Access_Baza_dannykh_2DataSet1);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            типBindingSource.MovePrevious();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            типBindingSource.MoveNext();
        }

       
    }
}
