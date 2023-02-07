using Buttons;
using System;

namespace quiz
{
    public partial class Form1 : Form
    {
        public quizz My_Pn;
        public butt butt_1;
        public butt butt_2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ///ez
            ///
            {
                this.button1 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(16, 295);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 23);
                this.button1.TabIndex = 0;
                this.button1.Text = "button1";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Visible = false;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(175, 295);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(75, 23);
                this.button2.TabIndex = 1;
                this.button2.Text = "button2";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Visible = false;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.button1);
            }
            pictureBox1.Image = pictureBox2.Image;
            My_Pn = new ez();
            if (radioButton1 != null)
            {
                radioButton1.Visible = false;
            }
            if (radioButton2 != null)
            {
                radioButton2.Visible = false;
            }
            if (checkBox1 != null)
            {
                checkBox1.Visible = false;
            }
            if (checkBox2 != null)
            {
                checkBox2.Visible = false;
            }
            if (button1 != null)
            {
                button1.Visible = true;
            }
            if (button2 != null)
            {
                button2.Visible = true;
            }
            button1.Text = My_Pn.button1().Taxte();
            button2.Text = My_Pn.button2().Taxte();
            label1.Text = My_Pn.Qwest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///midl
            ///
            {
                this.checkBox1 = new System.Windows.Forms.CheckBox();
                this.checkBox2 = new System.Windows.Forms.CheckBox();// 
                                                                     // checkBox1
                                                                     // 
                this.checkBox1.AutoSize = true;
                this.checkBox1.Location = new System.Drawing.Point(80, 336);
                this.checkBox1.Name = "checkBox1";
                this.checkBox1.Size = new System.Drawing.Size(83, 19);
                this.checkBox1.TabIndex = 3;
                this.checkBox1.Text = "checkBox1";
                this.checkBox1.UseVisualStyleBackColor = true;
                this.checkBox1.Visible = false;
                // 
                // checkBox2
                // 
                this.checkBox2.AutoSize = true;
                this.checkBox2.Location = new System.Drawing.Point(80, 361);
                this.checkBox2.Name = "checkBox2";
                this.checkBox2.Size = new System.Drawing.Size(83, 19);
                this.checkBox2.TabIndex = 4;
                this.checkBox2.Text = "checkBox2";
                this.checkBox2.UseVisualStyleBackColor = true;
                this.checkBox2.Visible = false;
                this.Controls.Add(this.checkBox2);
                this.Controls.Add(this.checkBox1);
            }
            pictureBox1.Image = pictureBox2.Image;
            My_Pn = new midl();
            if (radioButton1 != null)
            {
                radioButton1.Visible = false;
            }
            if (radioButton2 != null)
            {
                radioButton2.Visible = false;
            }
            if (checkBox1 != null)
            {
                checkBox1.Visible = true;
            }
            if (checkBox2 != null)
            {
                checkBox2.Visible = true;
            }
            if (button1 != null)
            {
                button1.Visible = false;
            }
            if (button2 != null)
            {
                button2.Visible = false;
            }
            checkBox1.Text = My_Pn.button1().Taxte();
            checkBox1.Text = My_Pn.button2().Taxte();
            label1.Text = My_Pn.Qwest();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ///asian
            ///
            {
                this.radioButton1 = new System.Windows.Forms.RadioButton();
                this.radioButton2 = new System.Windows.Forms.RadioButton();// 
                                                                           // radioButton1
                                                                           // 
                this.radioButton1.AutoSize = true;
                this.radioButton1.Location = new System.Drawing.Point(193, 336);
                this.radioButton1.Name = "radioButton1";
                this.radioButton1.Size = new System.Drawing.Size(94, 19);
                this.radioButton1.TabIndex = 5;
                this.radioButton1.TabStop = true;
                this.radioButton1.Text = "radioButton1";
                this.radioButton1.UseVisualStyleBackColor = true;
                this.radioButton1.Visible = false;
                // 
                // radioButton2
                // 
                this.radioButton2.AutoSize = true;
                this.radioButton2.Location = new System.Drawing.Point(193, 360);
                this.radioButton2.Name = "radioButton2";
                this.radioButton2.Size = new System.Drawing.Size(94, 19);
                this.radioButton2.TabIndex = 6;
                this.radioButton2.TabStop = true;
                this.radioButton2.Text = "radioButton2";
                this.radioButton2.UseVisualStyleBackColor = true;
                this.radioButton2.Visible = false;
            }
            pictureBox1.Image = pictureBox2.Image;
            My_Pn = new Asian(1);
            if (radioButton1 != null)
            {
                radioButton1.Visible = true;
            }
            if (radioButton2 != null)
            {
                radioButton2.Visible = true;
            }
            if (checkBox1 != null)
            {
                checkBox1.Visible = false;
            }
            if (checkBox2 != null)
            {
                checkBox2.Visible = false;
            }
            if (button1 != null)
            {
                button1.Visible = false;
            }
            if (button2 != null)
            {
                button2.Visible = false;
            }
            radioButton1.Text = My_Pn.button1().Taxte();
            radioButton2.Text = My_Pn.button2().Taxte();
            label1.Text = My_Pn.Qwest();
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            My_Pn.button1().On_Click();
        }
    }
}