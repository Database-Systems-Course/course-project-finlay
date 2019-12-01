using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            password.PasswordChar = '*';

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 50;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            password.MaxLength = 16;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }
    }
}
