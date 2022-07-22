using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proiect_PAW
{
    public partial class Form1: Form
    {
        List<Student> listaStudenti;
        public Form1()
        {
            InitializeComponent();
            listaStudenti = new List<Student>();
        }

       
        private void golireLista()
        {
            lvStudenti.Items.Clear();
        }


        private void populeazaLista()
        {
            golireLista();
            foreach (Student student in listaStudenti)
            {
                ListViewItem item = new ListViewItem(student.Nume);
                item.SubItems.Add(student.Prenume);
                item.SubItems.Add(student.TipFrecventa);
                item.SubItems.Add(student.An.ToString());
                item.SubItems.Add(student.Profil.ToString());
                item.SubItems.Add(student.Optionale);
               
               

                lvStudenti.Items.Add(item);
            }
        }



        private void golireFormular()
        {
            tbNume.Clear();
            tbPrenume.Clear();
           tbTipFrecventa.Clear();
            cbI.Checked = false;
            cbII.Checked = false;
            cbIII.Checked = false;
            rbAntreprenoriat.Checked = false;
            rbNegocieri.Checked = false;
            rbMRAI.Checked = false;
            cbProfil.SelectedItem= null;
            

        }
            private void btClear_Click(object sender, EventArgs e)
           {
            golireFormular();

            }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Nume = tbNume.Text;
            student.Prenume = tbPrenume.Text;
            student.TipFrecventa = tbTipFrecventa.Text;
            if (cbProfil.SelectedItem != null)
                student.Profil = cbProfil.SelectedItem.ToString();
            if (cbI.Checked)
                student.An = 1;
            else if (cbII.Checked)
                student.An = 2;
            else if (cbIII.Checked)
                student.An = 3;
            else
                MessageBox.Show("An inmatriculare necompletat");

            if (rbAntreprenoriat.Checked)
                student.Optionale = "Antreprenoriat";
            if (rbMRAI.Checked)
                student.Optionale = "MRAI";
            if (rbNegocieri.Checked)
                student.Optionale = "Negocieri";

            try
            {
                if (tbNume.Text == "")
                    throw new ExceptieValidare();
                else if (tbPrenume.Text == "")
                    throw new ExceptieValidare();
                else if (tbTipFrecventa.Text == "")
                    throw new ExceptieValidare();
            }
            catch (ExceptieValidare ex)
            {
                MessageBox.Show(ex.Message);
            }

            listaStudenti.Add(student);
            populeazaLista();
            golireFormular();
           

        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text == "")
            {
                epNume.SetError(tbNume, "Informatie lipsa");
                e.Cancel = true;
            }
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenume.Text == "")
            {
                epNume.SetError(tbNume, "Informatie lipsa");
                e.Cancel = true;
            }
        }

        private void tbTipFrecventa_Validated(object sender, EventArgs e)
        {
            epTipFrecventa.Clear();
        }

        private void tbTipFrecventa_Validating(object sender, CancelEventArgs e)
        {
            if (tbTipFrecventa.Text == "")
            {
                epNume.SetError(tbNume, "Informatie lipsa");
                e.Cancel = true;
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 14);
            Brush brush = Brushes.DarkBlue;
            Pen pen = new Pen(brush);
            PageSettings settings = printDocument1.DefaultPageSettings;
            var totalW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalH;
                totalH = totalW;
                totalW = temp;
            }

            var cellW = totalW / 4;
            var cellH = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawRectangle(pen, x, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);

            graphics.DrawString("Nume", font, brush, x, y);
            graphics.DrawString("Prenume", font, brush, x + cellW, y);
            graphics.DrawString("Tip Frecventa", font, brush, x + cellW * 2, y);
            graphics.DrawString("An", font, brush, x + cellW * 3, y);


            y += cellH;

            foreach (Student s in listaStudenti)
            {
                graphics.DrawRectangle(pen, x, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);

                graphics.DrawString(s.Nume, font, brush, x, y);
                graphics.DrawString(s.Prenume, font, brush, x + cellW, y);
                graphics.DrawString(s.TipFrecventa.ToString(), font, brush, x + 2 * cellW, y);
                graphics.DrawString(s.An.ToString(), font, brush, x + 3 * cellW, y);

                y += cellH;
            }
        }

        private void lvStudenti_DoubleClick(object sender, EventArgs e)
        {
            if (lvStudenti.SelectedItems[0] != null)
            {
                ListViewItem item = lvStudenti.SelectedItems[0];
                int index = item.Index;
                Student student = listaStudenti[index];
                Actualizare form = new Actualizare(student);
                form.ShowDialog();
                populeazaLista();
            }
        }

        private Student getStudentFromList(ListViewItem item)
        {
            Student student = new Student();
            student.Nume = item.SubItems[0].Text;
            student.Prenume = item.SubItems[1].Text;
            student.TipFrecventa = item.SubItems[2].Text;
            student.An = Int32.Parse(item.SubItems[3].Text);
            student.Profil = item.SubItems[4].Text;
            student.Optionale = item.SubItems[5].Text;
            return student;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveTxt_Click(object sender, EventArgs e)
        {

            if (lvStudenti.SelectedItems[0] != null)
            {
                ListViewItem item = lvStudenti.SelectedItems[0];
                Student s = getStudentFromList(item);

                FileStream file = new FileStream("student.txt", FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(file);
                streamWriter.Write(s);
                streamWriter.Close();
                file.Close();


            }
        }

        private void btnSalvareXml_Click(object sender, EventArgs e)
        {
            if (lvStudenti.SelectedItems[0] != null)
            {
                ListViewItem item = lvStudenti.SelectedItems[0];
                Student s = getStudentFromList(item);

                FileStream file = new FileStream("student.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                xmlSerializer.Serialize(file, s);
                file.Close();
            }
        }

        private void lvStudenti_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuSave.Show(Cursor.Position);
             
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lvStudenti.SelectedItems[0] != null)
            {
                ListViewItem item = lvStudenti.SelectedItems[0];
                int index = item.Index;
                listaStudenti.RemoveAt(index);
                populeazaLista();
            }
        }

        private void btnMaterii_Click(object sender, EventArgs e)
        {
            Materie form = new Materie();
            form.ShowDialog();
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGf form = new FormGf(listaStudenti);
            form.ShowDialog();
        }

        private void btnProiecte_Click(object sender, EventArgs e)
        {
            FormProiecte form = new FormProiecte();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnProfesori_Click(object sender, EventArgs e)
        {
            Profesori form = new Profesori();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
