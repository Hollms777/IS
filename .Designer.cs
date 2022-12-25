using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Image_work_lab
{
    partial class TheThirdQuestion
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Question_yes;
        private System.Windows.Forms.RadioButton radioButton_Question_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Question_answer;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Question_yes = new System.Windows.Forms.RadioButton();
            this.radioButton_Question_no = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Question_answer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Question_yes);
            this.groupBox1.Controls.Add(this.radioButton_Question_no);
            this.groupBox1.Location = new System.Drawing.Point(66, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір";
            // 
            // radioButton_Question_yes
            // 
            this.radioButton_Question_yes.Location = new System.Drawing.Point(85, 37);
            this.radioButton_Question_yes.Name = "radioButton_Question_yes";
            this.radioButton_Question_yes.Size = new System.Drawing.Size(104, 24);
            this.radioButton_Question_yes.TabIndex = 0;
            this.radioButton_Question_yes.Text = "Так";
            this.radioButton_Question_yes.CheckedChanged += new System.EventHandler(this.radioButton_Question_yes_CheckedChanged);
            // 
            // radioButton_Question_no
            // 
            this.radioButton_Question_no.AutoSize = true;
            this.radioButton_Question_no.Location = new System.Drawing.Point(281, 44);
            this.radioButton_Question_no.Name = "radioButton_Question_no";
            this.radioButton_Question_no.Size = new System.Drawing.Size(35, 17);
            this.radioButton_Question_no.TabIndex = 2;
            this.radioButton_Question_no.TabStop = true;
            this.radioButton_Question_no.Text = "Ні";
            this.radioButton_Question_no.UseVisualStyleBackColor = true;
            this.radioButton_Question_no.CheckedChanged += new System.EventHandler(this.radioButton_Question_no_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ваш вік менше 45 років?\r\n";
            // 
            // button_Question_answer
            // 
            this.button_Question_answer.Location = new System.Drawing.Point(220, 219);
            this.button_Question_answer.Name = "button_Question_answer";
            this.button_Question_answer.Size = new System.Drawing.Size(136, 62);
            this.button_Question_answer.TabIndex = 5;
            this.button_Question_answer.Text = "Підтвердити вибір";
            this.button_Question_answer.UseVisualStyleBackColor = true;
            this.button_Question_answer.Click += new System.EventHandler(this.button_Question_answer_Click);
            // 
            // TheThirdQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Question_answer);
            this.Name = "TheThirdQuestion";
            this.Text = "Питання";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public int answer;
        private void Form4_Load(object sender, System.EventArgs e)
        {

        }

        private void radioButton_Question_yes_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                answer = 1;
            }
        }

        private void button_Question_answer_Click(object sender, System.EventArgs e)
        {
            if (answer == 1)
            {
                SecondQuestion newForm = new SecondQuestion();
                newForm.Show();
                this.Hide();
            }
            else
            {
                
                End_no newForm = new End_no();
                newForm.Show();
                this.Hide();
            }
        }

        private void radioButton_Question_no_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                answer = 2;
            }
        }
    }
}