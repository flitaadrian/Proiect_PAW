
namespace Proiect_PAW
{
    partial class FormProiecte
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
            this.dgvProiecte = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Plecare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.dtPlecare = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProiecte)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProiecte
            // 
            this.dgvProiecte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProiecte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Data_Plecare,
            this.Descriere});
            this.dgvProiecte.Location = new System.Drawing.Point(46, 96);
            this.dgvProiecte.Name = "dgvProiecte";
            this.dgvProiecte.RowHeadersWidth = 82;
            this.dgvProiecte.RowTemplate.Height = 33;
            this.dgvProiecte.Size = new System.Drawing.Size(687, 512);
            this.dgvProiecte.TabIndex = 0;
            this.dgvProiecte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProiecte_MouseDoubleClick);
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 10;
            this.Nume.Name = "Nume";
            this.Nume.Width = 200;
            // 
            // Data_Plecare
            // 
            this.Data_Plecare.HeaderText = "Data_Plecare";
            this.Data_Plecare.MinimumWidth = 10;
            this.Data_Plecare.Name = "Data_Plecare";
            this.Data_Plecare.Width = 200;
            // 
            // Descriere
            // 
            this.Descriere.HeaderText = "Descriere";
            this.Descriere.MinimumWidth = 10;
            this.Descriere.Name = "Descriere";
            this.Descriere.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNume);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.tbDescriere);
            this.panel1.Controls.Add(this.dtPlecare);
            this.panel1.Location = new System.Drawing.Point(826, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 512);
            this.panel1.TabIndex = 1;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(37, 56);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(466, 31);
            this.tbNume.TabIndex = 4;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(164, 353);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(200, 79);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adaugare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(37, 177);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(466, 31);
            this.tbDescriere.TabIndex = 1;
            // 
            // dtPlecare
            // 
            this.dtPlecare.Location = new System.Drawing.Point(37, 120);
            this.dtPlecare.Name = "dtPlecare";
            this.dtPlecare.Size = new System.Drawing.Size(466, 31);
            this.dtPlecare.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem,
            this.inchideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1623, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(101, 38);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // inchideToolStripMenuItem
            // 
            this.inchideToolStripMenuItem.Name = "inchideToolStripMenuItem";
            this.inchideToolStripMenuItem.Size = new System.Drawing.Size(113, 38);
            this.inchideToolStripMenuItem.Text = "Inchide";
            this.inchideToolStripMenuItem.Click += new System.EventHandler(this.inchideToolStripMenuItem_Click);
            // 
            // FormProiecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProiecte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProiecte";
            this.Text = "FormProiecte";
            this.Load += new System.EventHandler(this.FormProiecte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProiecte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProiecte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Plecare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.DateTimePicker dtPlecare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideToolStripMenuItem;
    }
}