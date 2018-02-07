using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Models
{
    public  class OperacjeDb : Connect
    {
        public DataTable select(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            Connection.Open();
            DataTable final = new DataTable();
            final.Load(cmd.ExecuteReader()); //cmd.ExecuteReader() == This will execute the query. || dt.Load == Load all the result to variable
            Connection.Close();
            return final;
        }

        public void update(string query)
        {

        }

        public void update(Zadanie obj)
        {
            string command = String.Format("Insert Into dane(Temat,Priorytet,Termin,Status,Opis) VALUES('{0}','{1}','cz','qwe','ds')",obj.Temat,obj.Priorytet,obj.Termin,obj.Status,obj.Opis);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            //Insert Into dane(Temat,Priorytet,Termin,Status,Opis) VALUES("dsadas","qweqwe",20/12/2012,"ddsad","sdas")
            Connection.Open();
            cmd.ExecuteReader(); //Add a new record to database
            Connection.Close();
            //
        }
    }
}
