using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("본 설문을 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();
        }
    }
}
