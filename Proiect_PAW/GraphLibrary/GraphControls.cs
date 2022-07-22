using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphLibrary
{
    public partial class GraphControls : UserControl
    {
        private List<BarValue> values;

        public GraphControls()
        {
            values = new List<BarValue>();
            ResizeRedraw = true;
            InitializeComponent();
        }
        public List<BarValue> Values
        {
            get { return values; }
            set { values = value; }
        }

        private void GraphControls_Load(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (values.Count > 0)
            {
                Graphics graphics = e.Graphics;
                Rectangle rectangle = e.ClipRectangle;

                int max = 0;
                foreach (BarValue bv in values)
                {
                    if (bv.Value > max)
                        max = bv.Value;
                }

                var scaleFactor = rectangle.Height / max;
                

                var barW = (rectangle.Width - 300) / values.Count;

                for (int i = 0; i < values.Count; i++)
                {
                    var barH = values[i].Value * scaleFactor;
                    graphics.FillRectangle(Brushes.DarkBlue, i * barW, rectangle.Height - barH,
                        barW, barH);

                    graphics.DrawString(values[i].Value.ToString(), new Font("Arial", 10),
                        Brushes.White, i * barW + 1, rectangle.Height - barH);
                }

                var x = rectangle.Width - 250;
                var y = 0;

                graphics.DrawString("Legenda", new Font("Arial", 14),
                        Brushes.DarkBlue, x, y);

                y += 50;

                foreach (BarValue bv in values)
                {
                    graphics.DrawString(bv.Label + ":" + bv.Value, new Font("Arial", 12),
                        Brushes.DarkBlue, x, y);
                    y += 20;
                }
            }
        }

    }
   }

