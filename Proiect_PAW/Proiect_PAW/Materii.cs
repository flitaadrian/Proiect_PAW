using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Materii
    {
        String materie;
        String profesor;

        public string Materie
        {
            get { return materie; }
            set { materie = value; }
        }

        public string Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        public Materii() { }
        public Materii(String materie, String profesor)
        {
            this.materie = materie;
            this.profesor = profesor;
        }
    }
}
