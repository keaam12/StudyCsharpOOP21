using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = TxtUserID.Text + "\n" + TxtPassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
