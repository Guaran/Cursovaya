using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovayaRabota
{
    public partial class Form1 : Form
    {
        internal MensList list = new MensList();
        public Form1()
        {
            InitializeComponent();
            list.Download();
            list.Show(dataGridView1);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DobavBut_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Owner = this;
            f.ShowDialog();
        }

        public void UdalBut_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.Equals(true))
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    i--;
                }
            }*/
            list.Delete(dataGridView1);
        }

        public void DopInfo_Click(object sender, EventArgs e)
        {
            DInfo f = new DInfo();
            f.Owner = this;
            f.ShowDialog();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.Save();
        }
    }
}
