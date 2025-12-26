namespace Assignment5
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAnother = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(538, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Another Card";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(538, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Card";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAnother
            // 
            this.btnAnother.Location = new System.Drawing.Point(538, 181);
            this.btnAnother.Name = "btnAnother";
            this.btnAnother.Size = new System.Drawing.Size(100, 23);
            this.btnAnother.TabIndex = 3;
            this.btnAnother.Text = "Another II";
            this.btnAnother.UseVisualStyleBackColor = true;
            this.btnAnother.Click += new System.EventHandler(this.btnAnother_Click);
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(538, 240);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(100, 23);
            this.btnExist.TabIndex = 4;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount Owed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "$ Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(194, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(194, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(194, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(194, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(65, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 212);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(663, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Michael Scott";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnAnother);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "A5-Fall 2024";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAnother;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
    }
}

