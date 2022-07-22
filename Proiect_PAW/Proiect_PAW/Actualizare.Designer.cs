
namespace Proiect_PAW
{
    partial class Actualizare
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
            this.tbTipFrecventa = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.msActualizare = new System.Windows.Forms.MenuStrip();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.tbProifil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOptional = new System.Windows.Forms.TextBox();
            this.msActualizare.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTipFrecventa
            // 
            this.tbTipFrecventa.Location = new System.Drawing.Point(470, 278);
            this.tbTipFrecventa.Name = "tbTipFrecventa";
            this.tbTipFrecventa.Size = new System.Drawing.Size(333, 31);
            this.tbTipFrecventa.TabIndex = 14;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(470, 221);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(333, 31);
            this.tbPrenume.TabIndex = 13;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(470, 155);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(333, 31);
            this.tbNume.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tip Frecventa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "An";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Proifil";
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(379, 551);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(313, 103);
            this.btnActualizare.TabIndex = 25;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // msActualizare
            // 
            this.msActualizare.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msActualizare.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msActualizare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem,
            this.inapoiToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.msActualizare.Location = new System.Drawing.Point(0, 0);
            this.msActualizare.Name = "msActualizare";
            this.msActualizare.Size = new System.Drawing.Size(1046, 40);
            this.msActualizare.TabIndex = 26;
            this.msActualizare.Text = "menuStrip1";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(470, 349);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(333, 31);
            this.tbAn.TabIndex = 27;
            // 
            // tbProifil
            // 
            this.tbProifil.Location = new System.Drawing.Point(470, 418);
            this.tbProifil.Name = "tbProifil";
            this.tbProifil.Size = new System.Drawing.Size(333, 31);
            this.tbProifil.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Optional";
            // 
            // tbOptional
            // 
            this.tbOptional.Location = new System.Drawing.Point(470, 475);
            this.tbOptional.Name = "tbOptional";
            this.tbOptional.Size = new System.Drawing.Size(333, 31);
            this.tbOptional.TabIndex = 30;
            // 
            // Actualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 695);
            this.Controls.Add(this.tbOptional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbProifil);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTipFrecventa);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msActualizare);
            this.MainMenuStrip = this.msActualizare;
            this.Name = "Actualizare";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Actualizare_Load);
            this.msActualizare.ResumeLayout(false);
            this.msActualizare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTipFrecventa;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.MenuStrip msActualizare;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TextBox tbProifil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOptional;
    }
}