namespace Image_work_lab
{
    partial class End_yes
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
            this.button_end_yes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_end_yes
            // 
            this.button_end_yes.Location = new System.Drawing.Point(262, 186);
            this.button_end_yes.Name = "button_end_yes";
            this.button_end_yes.Size = new System.Drawing.Size(186, 54);
            this.button_end_yes.TabIndex = 3;
            this.button_end_yes.Text = "Закрити тест";
            this.button_end_yes.UseVisualStyleBackColor = true;
            this.button_end_yes.Click += new System.EventHandler(this.button_end_yes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(151, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кредит вам підтверджено";
            // 
            // End_yes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 324);
            this.Controls.Add(this.button_end_yes);
            this.Controls.Add(this.label1);
            this.Name = "End_yes";
            this.Text = "Підтвердження";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_end_yes;
        private System.Windows.Forms.Label label1;
    }
}