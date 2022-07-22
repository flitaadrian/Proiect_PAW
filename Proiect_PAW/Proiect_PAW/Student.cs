using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Student
    {
        String nume;
        String prenume;
        String tipFrecventa;
        int an;
        String profil;
        String optionale;
       

        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public String Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public String TipFrecventa
        {
            get { return tipFrecventa; }
            set { tipFrecventa = value; }
        }

        public int An
        {
            get { return an; }
            set { an = value; }
        }

        public String Profil
        {
            get { return profil; }
            set { profil = value; }
        }

        public String Optionale
        {
            get { return optionale; }
            set { optionale = value; }
        }

       

        public override string ToString()
        {
            String message = "Studentul " + nume + " " + prenume + ", inmatriculat in anul " +
                An + " cu tip frecventa " + tipFrecventa + ", pe profil " + profil +
                " avand optionalul " + optionale;
            
            return message;
        }

        
    }
}
