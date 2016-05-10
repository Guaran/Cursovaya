using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovayaRabota
{
    public partial class AddForm : Form
    {
        public CheckBox check = new CheckBox();
        

        public AddForm()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AFDobavBut_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            f.list.Add(new Men(AFNametextBox.Text, AFSurnametextBox.Text, dateTimeBirthday.Text, richTextSomeInformation.Text)); 
            DataGridViewCell checkBox = new DataGridViewCheckBoxCell();
            DataGridViewCell Name = new DataGridViewTextBoxCell();
            DataGridViewCell Surname = new DataGridViewTextBoxCell();
            DataGridViewCell DopInfo = new DataGridViewButtonCell();
            checkBox.Value = false;
            Name.Value = AFNametextBox.Text;
            Surname.Value = AFSurnametextBox.Text;
            DopInfo.Value = "Дополнительно";
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(checkBox, Name, Surname, DopInfo);
            f.dataGridView1.Rows.Add(row);
            Close();
        }
    }
}
