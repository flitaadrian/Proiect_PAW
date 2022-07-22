using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Proiect
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public DateTime Data_Plecare { get; set; }
        public string Descriere { get; set; }

        public Proiect()
        {

        }

        public Proiect(int id, string nume, DateTime data, string descriere)
        {
            Id = id;
            Nume = nume;
            Data_Plecare = data;
            Descriere = descriere;
           
        }

    }
}
