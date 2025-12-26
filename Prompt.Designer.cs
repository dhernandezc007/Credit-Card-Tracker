namespace Assignment5
{
    partial class Prompt
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
            this.tbPromptName = new System.Windows.Forms.TextBox();
            this.tbPromptOwed = new System.Windows.Forms.TextBox();
            this.tbPromptRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPromptName
            // 
            this.tbPromptName.Location = new System.Drawing.Point(330, 137);
            this.tbPromptName.Name = "tbPromptName";
            this.tbPromptName.Size = new System.Drawing.Size(100, 22);
            this.tbPromptName.TabIndex = 0;
            this.tbPromptName.TextChanged += new System.EventHandler(this.tbPromptName_TextChanged);
            // 
            // tbPromptOwed
            // 
            this.tbPromptOwed.Location = new System.Drawing.Point(200, 254);
            this.tbPromptOwed.Name = "tbPromptOwed";
            this.tbPromptOwed.Size = new System.Drawing.Size(100, 22);
            this.tbPromptOwed.TabIndex = 1;
            // 
            // tbPromptRate
            // 
            this.tbPromptRate.Location = new System.Drawing.Point(452, 254);
            this.tbPromptRate.Name = "tbPromptRate";
            this.tbPromptRate.Size = new System.Drawing.Size(100, 22);
            this.tbPromptRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Name of New Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Amount Owed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Interest Rate";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(217, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(465, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPromptRate);
            this.Controls.Add(this.tbPromptOwed);
            this.Controls.Add(this.tbPromptName);
            this.Name = "Prompt";
            this.Text = "Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPromptName;
        private System.Windows.Forms.TextBox tbPromptOwed;
        private System.Windows.Forms.TextBox tbPromptRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}