using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace cassaforte
{
    internal class Cassaforte
    {
        private string matricola;
        private string produttore;
        private string modello;
        private string codiceSegreto;
        private string codiceUtente;
        private string codiceAccesso;

        public string Matricola
        {
            get { return matricola; }
        }

        public string Produttore
        {
            get { return produttore; }
        }

        public string Modello
        {
            get { return modello; }
        }

        public string CodiceSegreto
        {
            get { return codiceSegreto; }
            set { codiceSegreto = value; }
        }

        public string CodiceUtente
        {
            get { return codiceUtente; }
            set { codiceUtente = value; }
        }

        public string CodiceAccesso
        {
            get { return codiceAccesso; }
            set { codiceAccesso = value; }
        }

        public Cassaforte(string Matricola, string Produttore, string Modello,  string CodiceSegreto)
        {
            this.matricola = Matricola;
            this.produttore = Produttore;
            this.modello = Modello;
            this.codiceSegreto = CodiceSegreto;
        }

        public void impostaCodiceUtente(string CodiceUtente)
        {
            if (codiceUtente == null)
            {
                codiceUtente = CodiceUtente;
            }
        }
        public void impostaCodiceAccesso(string CodiceAccesso)
        {
            if (codiceAccesso == null)
            {
                codiceAccesso = CodiceAccesso;
            }
        }

        public void sblocca(string CodiceAccesso, string CodiceUtente)
        {
            int nSblocchi;
            
            if (codiceUtente != null && codiceAccesso != null)
            {
                if (CodiceAccesso == CodiceUtente)
                {
                    MessageBox.Show("cassaforte sbloccata");
                }
                else if (CodiceAccesso != CodiceUtente)
                {
                    MessageBox.Show("codice errato, riprovare");
                    nSblocchi++;
                }
               
            }
        }
        
    }
}
