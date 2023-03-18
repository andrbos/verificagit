using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGitù
{
     class scuola
    {
        string cognome, indirizzo;
        int orariApertura, orariChiusura;
        public scuola(string cognome, string indirizzo, int orariApertura, int orariChiusura) 
        { 
            this.cognome = cognome;
            this.indirizzo = indirizzo; 
            this.orariChiusura = orariChiusura;
            this.orariApertura= orariApertura;
        }
    }
}
