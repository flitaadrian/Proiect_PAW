using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Actualizare : Form
    {
        Student instance;
       

        public Actualizare(Student student)
        {
            InitializeComponent();
            instance = student;
        }

        private void Actualizare_Load(object sender, EventArgs e)
        {
            completareFormular(instance);
        }

        private void completareFormular(Student instance)
        {
            tbNume.Text = instance.Nume;
            tbPrenume.Text = instance.Prenume;
            tbTipFrecventa.Text = instance.TipFrecventa;
            tbAn.Text = instance.An.ToString();
            tbTipFrecventa.Text = instance.TipFrecventa;
            tbProifil.Text = instance.Profil;
            tbOptional.Text = instance.Optionale;

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("student.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(file, instance);
            file.Close();
            golireFormular();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("student.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Student student = (Student)binaryFormatter.Deserialize(file);
            file.Close();
            completareFormular(student);
        }

        private void golireFormular()
        {
            tbTipFrecventa.Clear();
            tbPrenume.Clear();
            tbNume.Clear();
            tbAn.Clear();
            tbProifil.Clear();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            instance.An = Int32.Parse(tbAn.Text);
            instance.Profil = tbProifil.Text;
            instance.Nume = tbNume.Text;
            instance.Prenume = tbPrenume.Text;
            instance.TipFrecventa = tbTipFrecventa.Text;
            instance.Optionale = tbOptional.Text;
            this.Close();
        }
    }
}
