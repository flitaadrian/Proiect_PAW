using GraphLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormGf : Form
    {
        List<BarValue> values;

        public FormGf(List<Student> students)
        {
            values = new List<BarValue>();
            foreach (Student s in students)
            {
                values.Add(new BarValue(s.Nume + " " + s.Prenume, s.An));
            }
            InitializeComponent();
        }

        private void graphControls1_Load(object sender, EventArgs e)
        {
            graphControls1.Values = values;
        }
    }
}
