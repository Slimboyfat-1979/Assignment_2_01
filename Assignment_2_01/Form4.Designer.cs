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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(89, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Customer Name: ";
            // 
            // customerEntry
            // 
            this.customerEntry.Location = new System.Drawing.Point(89, 224);
            this.customerEntry.Name = "customerEntry";
            this.customerEntry.Size = new System.Drawing.Size(202, 23);
            this.customerEntry.TabIndex = 2;
            // 
            // customerEntrySubmit
            // 
            this.customerEntrySubmit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerEntrySubmit.Location = new System.Drawing.Point(137, 305);
            this.customerEntrySubmit.Name = "customerEntrySubmit";
            this.customerEntrySubmit.Size = new System.Drawing.Size(115, 56);
            this.customerEntrySubmit.TabIndex = 3;
            this.customerEntrySubmit.Text = "Submit";
            this.customerEntrySubmit.UseVisualStyleBackColor = true;
            this.customerEntrySubmit.Click += new System.EventHandler(this.customerEntrySubmit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.customerEntrySubmit);
            this.Controls.Add(this.customerEntry);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.customerEntry, 0);
            this.Controls.SetChildIndex(this.customerEntrySubmit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerEntry;
        private System.Windows.Forms.Button customerEntrySubmit;
    }
}