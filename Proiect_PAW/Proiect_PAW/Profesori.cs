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
    public partial class Profesori : Form
    {
        List<Profesor> listaProfesori;
        String connectionString;
        OleDbConnection connection;
        
        public Profesori()
        {
            listaProfesori = new List<Profesor>();
            connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Profesori.accdb";
            connection = new OleDbConnection(connectionString);
            InitializeComponent();
        }

        private void Profesori_Load(object sender, EventArgs e)
        {
            incarcaProfesori();
        }

        private void incarcaProfesori()
        {
            dgvProfesori.Rows.Clear();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Profesori";
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Profesor profesor = new Profesor(Convert.ToInt32(dataReader["ID"]),
                        dataReader["Nume"].ToString(),
                        dataReader["Prenume"].ToString(),
                        dataReader["Materie"].ToString());

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProfesori);
                    row.Cells[0].Value = profesor.Nume;
                    row.Cells[1].Value = profesor.Prenume;
                    row.Cells[2].Value = profesor.Materie;

                    row.Tag = profesor;

                    listaProfesori.Add(profesor);
                    dgvProfesori.Rows.Add(row);
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

                command.CommandText = "SELECT MAX(ID) FROM Profesori";
                int cod = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = "INSERT INTO Profesori VALUES(?,?,?,?)";
                command.Parameters.Add("ID", OleDbType.Integer).Value = cod + 1;
                command.Parameters.Add("Nume", OleDbType.Char).Value = tbNume.Text;
                command.Parameters.Add("Descriere", OleDbType.VarChar).Value = tbPrenume.Text;
                command.Parameters.Add("Descriere", OleDbType.VarChar).Value = tbMaterie.Text;

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                incarcaProfesori();
                tbNume.Clear();
                tbPrenume.Clear();
               tbMaterie.Clear();
            }
        }

        private void dgvProfesori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count != 0)
            {
                Profesor profesor = (Profesor)dgvProfesori.SelectedRows[0].Tag;
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM imprumut WHERE ID=" + profesor.Id;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    incarcaProfesori();
                }
            }
        }

       

        private void dgvProfesori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count != 0)
            {
                Profesor profesor = (Profesor)dgvProfesori.SelectedRows[0].Tag;
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Profesori WHERE ID=" + profesor.Id;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    incarcaProfesori();
                }
            }
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
