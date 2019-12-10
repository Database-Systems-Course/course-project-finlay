
namespace DBMS_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modellbl = new System.Windows.Forms.Label();
            this.makelbl = new System.Windows.Forms.Label();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.maketxt = new System.Windows.Forms.TextBox();
            this.trantype = new System.Windows.Forms.ComboBox();
            this.fueltype = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxprice = new System.Windows.Forms.TextBox();
            this.minprice = new System.Windows.Forms.TextBox();
            this.fmam = new System.Windows.Forms.CheckBox();
            this.infotain = new System.Windows.Forms.CheckBox();
            this.sunroof = new System.Windows.Forms.CheckBox();
            this.absbrakes = new System.Windows.Forms.CheckBox();
            this.airbag = new System.Windows.Forms.CheckBox();
            this.pshifter = new System.Windows.Forms.CheckBox();
            this.psteer = new System.Windows.Forms.CheckBox();
            this.pwindows = new System.Windows.Forms.CheckBox();
            this.plock = new System.Windows.Forms.CheckBox();
            this.ac = new System.Windows.Forms.CheckBox();
            this.maxyear = new System.Windows.Forms.TextBox();
            this.minyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.carBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modellbl);
            this.groupBox1.Controls.Add(this.makelbl);
            this.groupBox1.Controls.Add(this.modeltxt);
            this.groupBox1.Controls.Add(this.maketxt);
            this.groupBox1.Controls.Add(this.trantype);
            this.groupBox1.Controls.Add(this.fueltype);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maxprice);
            this.groupBox1.Controls.Add(this.minprice);
            this.groupBox1.Controls.Add(this.fmam);
            this.groupBox1.Controls.Add(this.infotain);
            this.groupBox1.Controls.Add(this.sunroof);
            this.groupBox1.Controls.Add(this.absbrakes);
            this.groupBox1.Controls.Add(this.airbag);
            this.groupBox1.Controls.Add(this.pshifter);
            this.groupBox1.Controls.Add(this.psteer);
            this.groupBox1.Controls.Add(this.pwindows);
            this.groupBox1.Controls.Add(this.plock);
            this.groupBox1.Controls.Add(this.ac);
            this.groupBox1.Controls.Add(this.maxyear);
            this.groupBox1.Controls.Add(this.minyear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 424);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // modellbl
            // 
            this.modellbl.AutoSize = true;
            this.modellbl.Location = new System.Drawing.Point(3, 47);
            this.modellbl.Name = "modellbl";
            this.modellbl.Size = new System.Drawing.Size(39, 13);
            this.modellbl.TabIndex = 40;
            this.modellbl.Text = "Model:";
            // 
            // makelbl
            // 
            this.makelbl.AutoSize = true;
            this.makelbl.Location = new System.Drawing.Point(5, 21);
            this.makelbl.Name = "makelbl";
            this.makelbl.Size = new System.Drawing.Size(37, 13);
            this.makelbl.TabIndex = 39;
            this.makelbl.Text = "Make:";
            // 
            // modeltxt
            // 
            this.modeltxt.Location = new System.Drawing.Point(81, 44);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(55, 20);
            this.modeltxt.TabIndex = 38;
            this.modeltxt.TextChanged += new System.EventHandler(this.Modeltxt_TextChanged);
            this.modeltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Modeltxt_KeyPress);
            // 
            // maketxt
            // 
            this.maketxt.Location = new System.Drawing.Point(80, 18);
            this.maketxt.Name = "maketxt";
            this.maketxt.Size = new System.Drawing.Size(57, 20);
            this.maketxt.TabIndex = 37;
            this.maketxt.TextChanged += new System.EventHandler(this.TextBox2_TextChanged_1);
            this.maketxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Maketxt_KeyPress);
            // 
            // trantype
            // 
            this.trantype.FormattingEnabled = true;
            this.trantype.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.trantype.Location = new System.Drawing.Point(80, 151);
            this.trantype.Name = "trantype";
            this.trantype.Size = new System.Drawing.Size(121, 21);
            this.trantype.TabIndex = 36;
            this.trantype.SelectedIndexChanged += new System.EventHandler(this.trantype_SelectedIndexChanged);
            // 
            // fueltype
            // 
            this.fueltype.FormattingEnabled = true;
            this.fueltype.Items.AddRange(new object[] {
            "Petrol",
            "CNG",
            "Diesel"});
            this.fueltype.Location = new System.Drawing.Point(80, 125);
            this.fueltype.Name = "fueltype";
            this.fueltype.Size = new System.Drawing.Size(121, 21);
            this.fueltype.TabIndex = 35;
            this.fueltype.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Transmission:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fuel Type:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price Range:";
            // 
            // maxprice
            // 
            this.maxprice.Location = new System.Drawing.Point(158, 99);
            this.maxprice.Name = "maxprice";
            this.maxprice.Size = new System.Drawing.Size(43, 20);
            this.maxprice.TabIndex = 28;
            this.maxprice.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            this.maxprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox5_KeyPress);
            // 
            // minprice
            // 
            this.minprice.Location = new System.Drawing.Point(81, 99);
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(43, 20);
            this.minprice.TabIndex = 27;
            this.minprice.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.minprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // fmam
            // 
            this.fmam.AutoSize = true;
            this.fmam.Location = new System.Drawing.Point(5, 390);
            this.fmam.Name = "fmam";
            this.fmam.Size = new System.Drawing.Size(62, 17);
            this.fmam.TabIndex = 25;
            this.fmam.Text = "FM/AM";
            this.fmam.UseVisualStyleBackColor = true;
            this.fmam.CheckedChanged += new System.EventHandler(this.CheckBox12_CheckedChanged);
            // 
            // infotain
            // 
            this.infotain.AutoSize = true;
            this.infotain.Location = new System.Drawing.Point(5, 366);
            this.infotain.Name = "infotain";
            this.infotain.Size = new System.Drawing.Size(84, 17);
            this.infotain.TabIndex = 24;
            this.infotain.Text = "Infotainment";
            this.infotain.UseVisualStyleBackColor = true;
            this.infotain.CheckedChanged += new System.EventHandler(this.infotain_CheckedChanged);
            // 
            // sunroof
            // 
            this.sunroof.AutoSize = true;
            this.sunroof.Location = new System.Drawing.Point(5, 343);
            this.sunroof.Name = "sunroof";
            this.sunroof.Size = new System.Drawing.Size(63, 17);
            this.sunroof.TabIndex = 23;
            this.sunroof.Text = "Sunroof";
            this.sunroof.UseVisualStyleBackColor = true;
            this.sunroof.CheckedChanged += new System.EventHandler(this.sunroof_CheckedChanged);
            // 
            // absbrakes
            // 
            this.absbrakes.AutoSize = true;
            this.absbrakes.Location = new System.Drawing.Point(5, 320);
            this.absbrakes.Name = "absbrakes";
            this.absbrakes.Size = new System.Drawing.Size(83, 17);
            this.absbrakes.TabIndex = 22;
            this.absbrakes.Text = "ABS Brakes";
            this.absbrakes.UseVisualStyleBackColor = true;
            this.absbrakes.CheckedChanged += new System.EventHandler(this.Absbrakes_CheckedChanged);
            // 
            // airbag
            // 
            this.airbag.AutoSize = true;
            this.airbag.Location = new System.Drawing.Point(5, 300);
            this.airbag.Name = "airbag";
            this.airbag.Size = new System.Drawing.Size(61, 17);
            this.airbag.TabIndex = 21;
            this.airbag.Text = "Airbags";
            this.airbag.UseVisualStyleBackColor = true;
            this.airbag.CheckedChanged += new System.EventHandler(this.Airbag_CheckedChanged);
            // 
            // pshifter
            // 
            this.pshifter.AutoSize = true;
            this.pshifter.Location = new System.Drawing.Point(5, 277);
            this.pshifter.Name = "pshifter";
            this.pshifter.Size = new System.Drawing.Size(97, 17);
            this.pshifter.TabIndex = 20;
            this.pshifter.Text = "Paddle Shifters";
            this.pshifter.UseVisualStyleBackColor = true;
            this.pshifter.CheckedChanged += new System.EventHandler(this.pshifter_CheckedChanged);
            // 
            // psteer
            // 
            this.psteer.AutoSize = true;
            this.psteer.Location = new System.Drawing.Point(5, 254);
            this.psteer.Name = "psteer";
            this.psteer.Size = new System.Drawing.Size(98, 17);
            this.psteer.TabIndex = 19;
            this.psteer.Text = "Power Steering";
            this.psteer.UseVisualStyleBackColor = true;
            this.psteer.CheckedChanged += new System.EventHandler(this.psteer_CheckedChanged);
            // 
            // pwindows
            // 
            this.pwindows.AutoSize = true;
            this.pwindows.Location = new System.Drawing.Point(5, 230);
            this.pwindows.Name = "pwindows";
            this.pwindows.Size = new System.Drawing.Size(103, 17);
            this.pwindows.TabIndex = 18;
            this.pwindows.Text = "Power Windows";
            this.pwindows.UseVisualStyleBackColor = true;
            this.pwindows.CheckedChanged += new System.EventHandler(this.pwindows_CheckedChanged);
            // 
            // plock
            // 
            this.plock.AutoSize = true;
            this.plock.Location = new System.Drawing.Point(5, 204);
            this.plock.Name = "plock";
            this.plock.Size = new System.Drawing.Size(88, 17);
            this.plock.TabIndex = 17;
            this.plock.Text = "Power Locks";
            this.plock.UseVisualStyleBackColor = true;
            this.plock.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.Location = new System.Drawing.Point(5, 182);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(40, 17);
            this.ac.TabIndex = 16;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.CheckedChanged += new System.EventHandler(this.ac_CheckedChanged);
            // 
            // maxyear
            // 
            this.maxyear.Location = new System.Drawing.Point(157, 70);
            this.maxyear.Name = "maxyear";
            this.maxyear.Size = new System.Drawing.Size(43, 20);
            this.maxyear.TabIndex = 13;
            this.maxyear.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.maxyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // minyear
            // 
            this.minyear.Location = new System.Drawing.Point(81, 71);
            this.minyear.Name = "minyear";
            this.minyear.Size = new System.Drawing.Size(43, 20);
            this.minyear.TabIndex = 12;
            this.minyear.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.minyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model Year:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(85, 447);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // carBindingSource2
            // 
            this.carBindingSource2.DataMember = "Car";
            // 
            // carBindingSource3
            // 
            this.carBindingSource3.DataMember = "Car";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.carBindingSource4;
            this.dataGridView2.Location = new System.Drawing.Point(241, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(447, 407);
            this.dataGridView2.TabIndex = 9;
            // 
            // carBindingSource4
            // 
            this.carBindingSource4.DataMember = "Car";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 493);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DBMS Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox maxyear;
        private System.Windows.Forms.TextBox minyear;
        private System.Windows.Forms.CheckBox fmam;
        private System.Windows.Forms.CheckBox infotain;
        private System.Windows.Forms.CheckBox sunroof;
        private System.Windows.Forms.CheckBox absbrakes;
        private System.Windows.Forms.CheckBox airbag;
        private System.Windows.Forms.CheckBox pshifter;
        private System.Windows.Forms.CheckBox psteer;
        private System.Windows.Forms.CheckBox pwindows;
        private System.Windows.Forms.CheckBox plock;
        private System.Windows.Forms.CheckBox ac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxprice;
        private System.Windows.Forms.TextBox minprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;

        //private DBMS_Project._Project_FinlayDataSet _Project_FinlayDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        //private DBMS_Project._Project_FinlayDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        //private DBMS_Project._Project_Finlay_new_DataSet _Project_Finlay_new_DataSet;
        private System.Windows.Forms.BindingSource carBindingSource1;
        //private DBMS_Project.ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource carBindingSource2;
        //private DBMS_Project.ProjectDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.TextBox maketxt;
        private System.Windows.Forms.ComboBox trantype;
        private System.Windows.Forms.ComboBox fueltype;
        private System.Windows.Forms.Label modellbl;
        private System.Windows.Forms.Label makelbl;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private System.Windows.Forms.BindingSource carBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView2;
        
        private System.Windows.Forms.BindingSource carBindingSource4;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //private DBMS_Project.ProjectDataSet projectDataSet;

        //private DBMS_Project._Project_Finlay_new_DataSetTableAdapters.CarTableAdapter carTableAdapter1;
    }
}

