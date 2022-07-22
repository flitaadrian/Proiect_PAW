using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormProiecte : Form
    {
        List<Proiect> listaProiecte;
        String connectionString;
        OleDbConnection connection;
        
        public FormProiecte()
        {

            listaProiecte = new List<Proiect>();
            connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Proiecte.accdb";
            connection = new OleDbConnection(connectionString);
            InitializeComponent();
        }

        private void FormProiecte_Load(object sender, EventArgs e)
        {
            incarcaProiecte();
        }

        private void incarcaProiecte()
        {
            dgvProiecte.Rows.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Proiecte";
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Proiect proiect = new Proiect(Convert.ToInt32(dataReader["ID"]),
                        dataReader["Nume"].ToString(),
                        Convert.ToDateTime(dataReader["Data_Plecare"]),
                        dataReader["Descriere"].ToString());
                        
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProiecte);
                    row.Cells[0].Value = proiect.Nume;
                    row.Cells[1].Value = proiect.Data_Plecare.ToShortDateString();
                    row.Cells[2].Value = proiect.Descriere;
     
                    row.Tag = proiect;

                    listaProiecte.Add(proiect);
                    dgvProiecte.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "SELECT MAX(ID) FROM Proiecte";
                int cod = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = "INSERT INTO Proiecte VALUES(?,?,?,?)";
                command.Parameters.Add("ID", OleDbType.Integer).Value = cod + 1;
                command.Parameters.Add("Nume", OleDbType.Char).Value = tbNume.Text;
                command.Parameters.Add("Data_Plecare", OleDbType.Date).Value = dtPlecare.Value;
                command.Parameters.Add("Descriere", OleDbType.VarChar).Value = tbDescriere.Text;
                
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                incarcaProiecte();
                tbNume.Clear();
                dtPlecare.Value = DateTime.Now;
                tbDescriere.Clear();
            }

        }

      

        

        private void dgvProiecte_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvProiecte.SelectedRows.Count != 0)
            {
                Proiect proiect = (Proiect)dgvProiecte.SelectedRows[0].Tag;
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Proiecte WHERE ID=" + proiect.Id;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    incarcaProiecte();
                }
            }
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
