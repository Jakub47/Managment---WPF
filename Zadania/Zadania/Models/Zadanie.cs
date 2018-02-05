using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Models
{
    class Zadanie
    {
        public string Temat { get; set; }
        private string priorytet;

        public string Priorytet 
        {
            get { return priorytet; }
            set
            {
                if (value != "niski" || value != "normalny" || value != "wysoki")
                    priorytet = "normalny";
                else
                    priorytet = value;
            }
        }

        public DateTime Termin { get; set; }

        private string status;

        public string Status
        {
            get { return status; }
            set
            {
                if (value != "nowy" || value != "W realizacji" || value != "zakończony")
                    status = "nowy";
                else
                    status = value;
            }
        }

        public string Opis { get; set; }

        public Zadanie(string tT,string pR,DateTime tR,string sT,string opis)
        {
            Temat = tT; priorytet = pR; Termin = tR; Status = sT; Opis = opis;
        }

        public Zadanie()
        {
            Temat = ""; priorytet = ""; Termin = DateTime.Now; Status = "";
        }

        public override string ToString()
        {
            return Temat + "\t\t\t" + Priorytet + "\n" + Convert.ToString(Termin) + "\t" + Status;
        }
    }
}
