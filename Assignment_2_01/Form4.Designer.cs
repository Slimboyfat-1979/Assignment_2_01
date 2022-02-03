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
            this.customerEntrySubmit.Location = new System.Drawing.Point(119, 363);
            this.customerEntrySubmit.Name = "customerEntrySubmit";
            this.customerEntrySubmit.Size = new System.Drawing.Size(115, 56);
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
            this.label4.Location = new System.Drawing.Point(130, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Balance:";
            // 
            // customerBalanceEntry
            // 
            this.customerBalanceEntry.Location = new System.Drawing.Point(77, 293);
            this.customerBalanceEntry.Name = "customerBalanceEntry";
            this.customerBalanceEntry.Size = new System.Drawing.Size(227, 23);
            this.customerBalanceEntry.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
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
    }
}