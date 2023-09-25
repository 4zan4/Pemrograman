using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            var pen = comboBox1.Text;
            var per = listBox1.Text;

            textBox2.Text = string.Format("Halo {0}", nama);
            textBox3.Text = string.Format("Pendidikan anda {0} ya?", pen);
            textBox4.Text = string.Format("Anda seorang {0}, hebat !!!", per);
        }
    }
}
