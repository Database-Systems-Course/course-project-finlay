using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class Form1 : Form

    {
        string makevar;
        string modelvar;
        int minyearvar;
        int maxyearvar;
        int minpricevar;
        int maxpricevar;
        string fueltypevar;
        string trantypevar;
        int acvar;
        int plockvar;
        int pwindowsvar;
        int psteervar;
        int pshiftervar;
        int airbagvar;
        int absbrakesvar;
        int sunroofvar;
        int infotainvar;
        int fmamvar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet2.Car' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectDataSet1.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this.projectDataSet1.Car);
            // TODO: This line of code loads data into the 'projectDataSet.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this.projectDataSet.Car);
            // TODO: This line of code loads data into the '_Project_Finlay_new_DataSet.Car' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_Project_FinlayDataSet.Car' table. You can move, or remove it, as needed.

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
            DBconnectioncs c = new DBconnectioncs(); 
            DataTable d = c.Select("Select Car.RegistrationID, from Car");
            dataGridView2.DataSource = d;
        }
        
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            minyear.MaxLength = 4;
           
        }
        

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            maxyear.MaxLength = 4;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (plock.Checked)
            {
                plockvar = 1;
            }
            else
            {
                plockvar = 0;
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            minprice.MaxLength = 7;
            
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            maxprice.MaxLength = 7;
        }

        

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (fmam.Checked)
            {
                fmamvar = 1;
            }
            else
            {
                fmamvar = 0;
            }
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

            minpricevar = Convert.ToInt32(minprice.Text);
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            maxpricevar = Convert.ToInt32(maxyear.Text);
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            maxyearvar = Convert.ToInt32(maxyear.Text);

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

            string temp = minyear.Text;
            if (temp.Length== 4)
            {
                minyearvar = Convert.ToInt32(minyear.Text);
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

            maxyearvar = Convert.ToInt32(maxyear.Text);
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

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Absbrakes_CheckedChanged(object sender, EventArgs e)
        {
            if (absbrakes.Checked)
            {
                absbrakesvar = 1;
            }
            else
            {
                absbrakesvar = 0;
            }
        }

        private void Airbag_CheckedChanged(object sender, EventArgs e)
        {
            if (airbag.Checked)
            {
                airbagvar = 1;
            }
            else
            {
                airbagvar = 0;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fueltypevar = fueltype.Text;
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            maketxt.MaxLength = 15;         
        }

        private void Modeltxt_TextChanged(object sender, EventArgs e)
        {
            modeltxt.MaxLength  = 15;
        }

        private void Modeltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!char.IsLetter(l) && l != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            modelvar = modeltxt.Text;
        }

        private void Maketxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!char.IsLetter(l) && l != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            makevar = maketxt.Text;
        }

        private void trantype_SelectedIndexChanged(object sender, EventArgs e)
        {
            trantypevar = trantype.Text;
        }

        private void ac_CheckedChanged(object sender, EventArgs e)
        {
            if (ac.Checked)
            {
                acvar = 1;
            }
            else
            {
                acvar = 0;
            }
        }

        private void pwindows_CheckedChanged(object sender, EventArgs e)
        {
            if (pwindows.Checked)
            {
                pwindowsvar = 1;
            }
            else
            {
                pwindowsvar = 0;
            }
        }

        private void psteer_CheckedChanged(object sender, EventArgs e)
        {
            if (psteer.Checked)
            {
                psteervar = 1;
            }
            else
            {
                psteervar = 0;
            }
        }

        private void pshifter_CheckedChanged(object sender, EventArgs e)
        {
            if (plock.Checked)
            {
                pshiftervar = 1;
            }
            else
            {
                pshiftervar = 0;
            }
        }

        private void sunroof_CheckedChanged(object sender, EventArgs e)
        {
            if (sunroof.Checked)
            {
                sunroofvar = 1;
            }
            else
            {
                sunroofvar = 0;
            }
        }

        private void infotain_CheckedChanged(object sender, EventArgs e)
        {
            if (infotain.Checked)
            {
                infotainvar = 1;
            }
            else
            {
                infotainvar = 0;
            }
        }
    }
}
