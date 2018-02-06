using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Models
{
    static class Weryfikacja
    {

        public static bool Zweryfikuj(string temat, string opis)
        {
            //Determine whenever user actually write something in field's
            if (temat!= null && opis != null )
                return true;
            else
                return false;
        }
    }
}
