namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtLivingExpense = new System.Windows.Forms.TextBox();
            this.txtYearsToRetire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbTotalToRetire = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate Retirement Savings Needed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLivingExpense
            // 
            this.txtLivingExpense.Location = new System.Drawing.Point(15, 25);
            this.txtLivingExpense.Name = "txtLivingExpense";
            this.txtLivingExpense.Size = new System.Drawing.Size(100, 20);
            this.txtLivingExpense.TabIndex = 1;
            // 
            // txtYearsToRetire
            // 
            this.txtYearsToRetire.Location = new System.Drawing.Point(15, 88);
            this.txtYearsToRetire.Name = "txtYearsToRetire";
            this.txtYearsToRetire.Size = new System.Drawing.Size(100, 20);
            this.txtYearsToRetire.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What Is Your Annual Living Expense?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "How Many Years Do You Expect To Retire For?";
            // 
            // rtbTotalToRetire
            // 
            this.rtbTotalToRetire.Location = new System.Drawing.Point(261, 9);
            this.rtbTotalToRetire.Name = "rtbTotalToRetire";
            this.rtbTotalToRetire.Size = new System.Drawing.Size(203, 99);
            this.rtbTotalToRetire.TabIndex = 5;
            this.rtbTotalToRetire.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 155);
            this.Controls.Add(this.rtbTotalToRetire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYearsToRetire);
            this.Controls.Add(this.txtLivingExpense);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLivingExpense;
        private System.Windows.Forms.TextBox txtYearsToRetire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbTotalToRetire;
    }
}

