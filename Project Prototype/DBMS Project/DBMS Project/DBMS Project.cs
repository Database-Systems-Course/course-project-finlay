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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4;
           
        }
        

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 4;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 7;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 7;
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 4;
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 9;
        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!char.IsLetter(l) && l != 8)
            {
                e.Handled = true;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tr = e.KeyChar;
            if (!char.IsLetter(tr) && tr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
