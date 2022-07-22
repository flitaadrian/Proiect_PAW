
namespace Proiect_PAW
{
    partial class Materie
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbProfesor = new System.Windows.Forms.TextBox();
            this.tbMaterie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewMaterii = new System.Windows.Forms.TreeView();
            this.epMaterie = new System.Windows.Forms.ErrorProvider(this.components);
            this.epProfesor = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnActializare = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStergere = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMaterie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProfesor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActualizare);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbProfesor);
            this.panel1.Controls.Add(this.tbMaterie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 492);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 68);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbProfesor
            // 
            this.tbProfesor.Location = new System.Drawing.Point(153, 183);
            this.tbProfesor.Name = "tbProfesor";
            this.tbProfesor.Size = new System.Drawing.Size(295, 31);
            this.tbProfesor.TabIndex = 3;
            // 
            // tbMaterie
            // 
            this.tbMaterie.Location = new System.Drawing.Point(153, 103);
            this.tbMaterie.Name = "tbMaterie";
            this.tbMaterie.Size = new System.Drawing.Size(295, 31);
            this.tbMaterie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profesor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materie";
            // 
            // treeViewMaterii
            // 
            this.treeViewMaterii.Location = new System.Drawing.Point(666, 102);
            this.treeViewMaterii.Name = "treeViewMaterii";
            this.treeViewMaterii.Size = new System.Drawing.Size(698, 513);
            this.treeViewMaterii.TabIndex = 1;
            this.treeViewMaterii.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewMaterii_MouseClick);
            // 
            // epMaterie
            // 
            this.epMaterie.ContainerControl = this;
            // 
            // epProfesor
            // 
            this.epProfesor.ContainerControl = this;
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
            this.menuStrip1.Size = new System.Drawing.Size(1393, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // inchideToolStripMenuItem
            // 
            this.inchideToolStripMenuItem.Name = "inchideToolStripMenuItem";
            this.inchideToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.inchideToolStripMenuItem.Text = "Inchide";
            this.inchideToolStripMenuItem.Click += new System.EventHandler(this.inchideToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnActializare,
            this.btnStergere});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 80);
            // 
            // btnActializare
            // 
            this.btnActializare.Name = "btnActializare";
            this.btnActializare.Size = new System.Drawing.Size(206, 38);
            this.btnActializare.Text = "Actualizare";
            this.btnActializare.Click += new System.EventHandler(this.btnActializare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(206, 38);
            this.btnStergere.Text = "Stergere";
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(34, 311);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(195, 68);
            this.btnActualizare.TabIndex = 5;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // Materie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 799);
            this.Controls.Add(this.treeViewMaterii);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Materie";
            this.Text = "Materie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMaterie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProfesor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbProfesor;
        private System.Windows.Forms.TextBox tbMaterie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewMaterii;
        private System.Windows.Forms.ErrorProvider epMaterie;
        private System.Windows.Forms.ErrorProvider epProfesor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnActializare;
        private System.Windows.Forms.ToolStripMenuItem btnStergere;
        private System.Windows.Forms.Button btnActualizare;
    }
}