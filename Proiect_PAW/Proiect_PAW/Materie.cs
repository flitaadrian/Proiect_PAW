using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Materie : Form
    {

        List<Materii> listaMaterii;
        Materii materie;
        public Materie()
        {
            InitializeComponent();
            listaMaterii = new List<Materii>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMaterie.Text == "")
            {
                epMaterie.SetError(tbMaterie, "Informatie lipsa");
                epMaterie.Clear();
            }
            else if (tbProfesor.Text == "")
            {
                epProfesor.Clear();
                epProfesor.SetError(tbProfesor, "Informatie lipsa");
            }
            else
            {
                epProfesor.Clear();
                epMaterie.Clear();
                //curataTreeView();
                Materii m = new Materii();
                m.Materie = tbMaterie.Text;
                m.Profesor = tbProfesor.Text;
                listaMaterii.Add(m);
                afisareTreeView();
                // incarcaListBox();
                curataFormular();
            }
        }

        private void curataFormular()
        {
            tbProfesor.Clear();
            tbMaterie.Clear();
        }
        private void afisareTreeView()
        {
            curataTreeView();
            foreach (Materii m in listaMaterii)
            {
                TreeNode node = new TreeNode(m.Materie);
                node.Nodes.Add("Profesor", m.Profesor);
                treeViewMaterii.Nodes.Add(node);
            }
        }

        private void curataTreeView()
        {
            treeViewMaterii.Nodes.Clear();
        }

        private void incarcareActivitatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //curataTreeView();
            FileStream fileStream = new FileStream("activitati.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            String linie = null;
            while ((linie = reader.ReadLine()) != null)
            {
                Materii m = new Materii();
                m.Materie = linie.Split('-')[0];
                m.Profesor = linie.Split('-')[1];
                listaMaterii.Add(m);
            }
            afisareTreeView();
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (treeViewMaterii.SelectedNode != null)
            {

                TreeNode node = treeViewMaterii.SelectedNode;
                int index = node.Index;
              listaMaterii.RemoveAt(index);
                afisareTreeView();
            }
        }

        private void btnActializare_Click(object sender, EventArgs e)
        {
            if (treeViewMaterii.SelectedNode != null)
            {
                TreeNode node = treeViewMaterii.SelectedNode;
                int index = node.Index;
                materie = listaMaterii[index];
                tbMaterie.Text = materie.Materie;
                tbProfesor.Text = materie.Profesor;
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            materie.Materie = tbMaterie.Text;
            materie.Profesor = tbProfesor.Text;

            afisareTreeView();
            curataFormular();
        }

        private void treeViewMaterii_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }
    }
}