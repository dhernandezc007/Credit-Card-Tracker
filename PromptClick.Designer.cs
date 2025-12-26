namespace Assignment5
{
    partial class PromptClick
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
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(326, 176);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 22);
            this.tbAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the amount being paid";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(262, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(407, 270);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(107, 23);
            this.btnCANCEL.TabIndex = 3;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // PromptClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmount);
            this.Name = "PromptClick";
            this.Text = "PromptClick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCANCEL;
    }
}