﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Models
{
    public class Zadanie
    {
        public string Temat { get; set; }
        private string priorytet;

        public string Priorytet 
        {
            get { return priorytet; }
            set
            {
                    priorytet = value;
            }
        }

        private string termin;
        public string Termin
        {
            get
            {
                return termin;
            }

            set
            {
                termin = value;
            }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set
            {
                    status = value;
            }
        }

        public string Opis { get; set; }

        public Zadanie(string tT,string pR,string tR,string sT,string opis)
        {
            Temat = tT; priorytet = pR; Termin = tR; Status = sT; Opis = opis;
        }

        public Zadanie()
        {
            Temat = ""; priorytet = ""; Termin = ""; Status = "";
        }

        public override string ToString()
        {
            return Temat + "\t\t\t" + Priorytet + "\n" + Termin+ "\t" + Status;
        }
    }
}
