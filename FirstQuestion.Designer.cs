namespace Image_work_lab
{
    partial class FirstQuestion
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
            this.button_firstQuestion_answer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_firstQuestion_no = new System.Windows.Forms.RadioButton();
            this.radioButton_firstQuestion_yes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_firstQuestion_answer
            // 
            this.button_firstQuestion_answer.Location = new System.Drawing.Point(237, 197);
            this.button_firstQuestion_answer.Name = "button_firstQuestion_answer";
            this.button_firstQuestion_answer.Size = new System.Drawing.Size(136, 62);
            this.button_firstQuestion_answer.TabIndex = 0;
            this.button_firstQuestion_answer.Text = "Підтвердити вибір";
            this.button_firstQuestion_answer.UseVisualStyleBackColor = true;
            this.button_firstQuestion_answer.Click += new System.EventHandler(this.button_firstQuestion_answer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ви навчались у вищому навчальному закладі \r\nза цією спеціальністю?\r\n";
            // 
            // radioButton_firstQuestion_no
            // 
            this.radioButton_firstQuestion_no.AutoSize = true;
            this.radioButton_firstQuestion_no.Location = new System.Drawing.Point(281, 44);
            this.radioButton_firstQuestion_no.Name = "radioButton_firstQuestion_no";
            this.radioButton_firstQuestion_no.Size = new System.Drawing.Size(35, 17);
            this.radioButton_firstQuestion_no.TabIndex = 2;
            this.radioButton_firstQuestion_no.TabStop = true;
            this.radioButton_firstQuestion_no.Text = "Ні";
            this.radioButton_firstQuestion_no.UseVisualStyleBackColor = true;
            this.radioButton_firstQuestion_no.CheckedChanged += new System.EventHandler(this.radioButton_firstQuestion_no_CheckedChanged);
            // 
            // radioButton_firstQuestion_yes
            // 
            this.radioButton_firstQuestion_yes.Location = new System.Drawing.Point(85, 37);
            this.radioButton_firstQuestion_yes.Name = "radioButton_firstQuestion_yes";
            this.radioButton_firstQuestion_yes.Size = new System.Drawing.Size(104, 24);
            this.radioButton_firstQuestion_yes.TabIndex = 0;
            this.radioButton_firstQuestion_yes.Text = "Так";
            this.radioButton_firstQuestion_yes.CheckedChanged += new System.EventHandler(this.radioButton_firstQuestion_yes_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_firstQuestion_yes);
            this.groupBox1.Controls.Add(this.radioButton_firstQuestion_no);
            this.groupBox1.Location = new System.Drawing.Point(83, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір";
            // 
            // FirstQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_firstQuestion_answer);
            this.Name = "FirstQuestion";
            this.Text = "Питання";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_firstQuestion_answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_firstQuestion_no;
        private System.Windows.Forms.RadioButton radioButton_firstQuestion_yes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}