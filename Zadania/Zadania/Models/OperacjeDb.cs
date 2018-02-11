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

        public void update(Zadanie obj)
        {
            string command = String.Format("Insert Into dane(Temat,Priorytet,Termin,Status,Opis) VALUES('{0}','{1}','{2}','{3}','{4}')",obj.Temat,obj.Priorytet,obj.Termin,obj.Status,obj.Opis);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            //Insert Into dane(Temat,Priorytet,Termin,Status,Opis) VALUES("dsadas","qweqwe",20/12/2012,"ddsad","sdas")
            Connection.Open();
            cmd.ExecuteReader(); //Add a new record to database
            Connection.Close();
            //
        }

        public string find(string Temat)
        {
            string result = "";
            string command = String.Format("Select Opis from dane Where Temat = '{0}'", Temat);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) result += reader.GetString(0);
            Connection.Close();
            return result;
        }

        public int findId(string Temat)
        {
            int Id = 0;
            string command = String.Format("Select Id from dane Where Temat = '{0}'", Temat);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) Id = reader.GetInt32(0);
            Connection.Close();
            return Id;
        }

        public string takeTemat(int id)
        {
            string Temat = "";
            string command = String.Format("Select Temat from dane Where id = '{0}'", id);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) Temat = reader.GetString(0);
            Connection.Close();
            return Temat;
        }

        public string takePriorytet(int id)
        {
            string Priorytet = "";
            string command = String.Format("Select Priorytet from dane Where id = '{0}'", id);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) Priorytet = reader.GetString(0);
            Connection.Close();
            return Priorytet;
        }

        public string takeTermin(int id)
        {
            string Termin = "";
            string command = String.Format("Select Termin from dane Where id = '{0}'", id);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) Termin = reader.GetString(0);
            Connection.Close();
            return Termin;
        }

        public string takeStatus(int id)
        {
            string Status = "";
            string command = String.Format("Select Status from dane Where id = '{0}'", id);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) Status = reader.GetString(0);
            Connection.Close();
            return Status;
        }

        public string takeOpis(int id)
        {
            string Opis = "";
            string command = String.Format("Select Opis from dane Where id = '{0}'", id);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) Opis = reader.GetString(0);
            Connection.Close();
            return Opis;
        }


        public void delete(string opis)
        {
            string command = String.Format("DELETE FROM dane WHERE Opis = '{0}'", opis);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            cmd.ExecuteReader();
            Connection.Close();
        }

        public void update(int id,string temat,string priorytet,string termin,string status,string opis)
        {
            string command = String.Format("UPDATE dane SET Temat = '{0}',Priorytet = '{1}',Termin='{2}',Status='{3}',Opis='{4}'",
                temat,priorytet,termin,status,opis);
            MySqlCommand cmd = new MySqlCommand(command, Connection);
            Connection.Open();
            cmd.ExecuteReader();
            Connection.Close();
        }
    }
}
