using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGitù
{
     class Alunno
    {
        string nome, cognome, toString, restituzione ;
        int età;
        public Alunno (string nome, string cognome, string toString, string restituzione, int età)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.toString = toString;
            this.restituzione = restituzione;   
            this.età = età;
               
        }

        public string getNome() { return nome; }
        
        public string getCognome() { return cognome; }

        public string getToString() { return toString; }
        public int getEtà() { return età; }
        
        public string getRestituzione(string restituzione) 
        {
            if (età > 16)
            {
                return "triennio";
            }
            else if(età < 16) { return "Biennio"; }
            
        }

    }
}
