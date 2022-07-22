
namespace Proiect_PAW
{
    partial class FormGf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGf));
            this.graphControls1 = new GraphLibrary.GraphControls();
            this.SuspendLayout();
            // 
            // graphControls1
            // 
            this.graphControls1.Location = new System.Drawing.Point(228, 12);
            this.graphControls1.Name = "graphControls1";
            this.graphControls1.Size = new System.Drawing.Size(998, 789);
            this.graphControls1.TabIndex = 0;
            this.graphControls1.Values = ((System.Collections.Generic.List<GraphLibrary.BarValue>)(resources.GetObject("graphControls1.Values")));
            this.graphControls1.Load += new System.EventHandler(this.graphControls1_Load);
            // 
            // FormGf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.graphControls1);
            this.Name = "FormGf";
            this.Text = "FormGf";
            this.ResumeLayout(false);

        }

        #endregion

        private GraphLibrary.GraphControls graphControls1;
    }
}