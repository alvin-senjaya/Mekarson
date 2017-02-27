namespace ApotekMekarson
{
    partial class PilihSupplierMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNamaSupplier = new System.Windows.Forms.ComboBox();
            this.btnPilih = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Supplier :";
            // 
            // cbNamaSupplier
            // 
            this.cbNamaSupplier.FormattingEnabled = true;
            this.cbNamaSupplier.Location = new System.Drawing.Point(100, 6);
            this.cbNamaSupplier.Name = "cbNamaSupplier";
            this.cbNamaSupplier.Size = new System.Drawing.Size(150, 21);
            this.cbNamaSupplier.TabIndex = 1;
            // 
            // btnPilih
            // 
            this.btnPilih.Location = new System.Drawing.Point(175, 33);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.Size = new System.Drawing.Size(75, 23);
            this.btnPilih.TabIndex = 2;
            this.btnPilih.Text = "Pilih Supplier";
            this.btnPilih.UseVisualStyleBackColor = true;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // PilihSupplierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(263, 67);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.cbNamaSupplier);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PilihSupplierMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PilihSupplierMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNamaSupplier;
        private System.Windows.Forms.Button btnPilih;
    }
}