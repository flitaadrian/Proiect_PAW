
namespace Proiect_PAW
{
    partial class Profesori
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
            this.dgvProfesori = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbMaterie = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inchideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProfesori
            // 
            this.dgvProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Prenume,
            this.Materie});
            this.dgvProfesori.Location = new System.Drawing.Point(53, 93);
            this.dgvProfesori.Name = "dgvProfesori";
            this.dgvProfesori.RowHeadersWidth = 82;
            this.dgvProfesori.RowTemplate.Height = 33;
            this.dgvProfesori.Size = new System.Drawing.Size(705, 583);
            this.dgvProfesori.TabIndex = 0;
            this.dgvProfesori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProfesori_MouseDoubleClick);
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 10;
            this.Nume.Name = "Nume";
            this.Nume.Width = 200;
            // 
            // Prenume
            // 
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.MinimumWidth = 10;
            this.Prenume.Name = "Prenume";
            this.Prenume.Width = 200;
            // 
            // Materie
            // 
            this.Materie.HeaderText = "Materie";
            this.Materie.MinimumWidth = 10;
            this.Materie.Name = "Materie";
            this.Materie.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.tbMaterie);
            this.panel1.Controls.Add(this.tbPrenume);
            this.panel1.Controls.Add(this.tbNume);
            this.panel1.Location = new System.Drawing.Point(872, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 583);
            this.panel1.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(181, 325);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(164, 84);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbMaterie
            // 
            this.tbMaterie.Location = new System.Drawing.Point(88, 236);
            this.tbMaterie.Name = "tbMaterie";
            this.tbMaterie.Size = new System.Drawing.Size(356, 31);
            this.tbMaterie.TabIndex = 2;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(88, 152);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(356, 31);
            this.tbPrenume.TabIndex = 1;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(88, 58);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(356, 31);
            this.tbNume.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inchideToolStripMenuItem,
            this.inapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1508, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inchideToolStripMenuItem
            // 
            this.inchideToolStripMenuItem.Name = "inchideToolStripMenuItem";
            this.inchideToolStripMenuItem.Size = new System.Drawing.Size(113, 38);
            this.inchideToolStripMenuItem.Text = "Inchide";
            this.inchideToolStripMenuItem.Click += new System.EventHandler(this.inchideToolStripMenuItem_Click);
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(101, 38);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // Profesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProfesori);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Profesori";
            this.Text = "Profesori";
            this.Load += new System.EventHandler(this.Profesori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbMaterie;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inchideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
    }
}