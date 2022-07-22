using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Profesor
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Materie { get; set; }

        public Profesor()
        {

        }

        public Profesor(int id, string nume, string prenume, string materie)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            Materie = materie;
            
        }
    }
}
