namespace Assignment_2_01
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.customerEntry = new System.Windows.Forms.TextBox();
            this.customerEntrySubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerBalanceEntry = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Customer Name: ";
            // 
            // customerEntry
            // 
            this.customerEntry.Location = new System.Drawing.Point(77, 210);
            this.customerEntry.Name = "customerEntry";
            this.customerEntry.Size = new System.Drawing.Size(227, 23);
            this.customerEntry.TabIndex = 2;
            // 
            // customerEntrySubmit
            // 
            this.customerEntrySubmit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerEntrySubmit.Location = new System.Drawing.Point(78, 529);
            this.customerEntrySubmit.Name = "customerEntrySubmit";
            this.customerEntrySubmit.Size = new System.Drawing.Size(227, 56);
            this.customerEntrySubmit.TabIndex = 3;
            this.customerEntrySubmit.Text = "Submit";
            this.customerEntrySubmit.UseVisualStyleBackColor = true;
            this.customerEntrySubmit.Click += new System.EventHandler(this.customerEntrySubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Balance For Everyday Account:";
            // 
            // customerBalanceEntry
            // 
            this.customerBalanceEntry.Location = new System.Drawing.Point(78, 314);
            this.customerBalanceEntry.Name = "customerBalanceEntry";
            this.customerBalanceEntry.Size = new System.Drawing.Size(227, 23);
            this.customerBalanceEntry.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 23);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Balance For Investment Account:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 452);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 23);
            this.textBox2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Balance For Omni Account:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 634);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerBalanceEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerEntrySubmit);
            this.Controls.Add(this.customerEntry);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.customerEntry, 0);
            this.Controls.SetChildIndex(this.customerEntrySubmit, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.customerBalanceEntry, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerEntry;
        private System.Windows.Forms.Button customerEntrySubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerBalanceEntry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}