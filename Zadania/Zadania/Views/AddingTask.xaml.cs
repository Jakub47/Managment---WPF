using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Zadania.Models;

namespace Zadania.Views
{
    /// <summary>
    /// Interaction logic for AddingTask.xaml
    /// </summary>
    public partial class AddingTask : Window
    {
        Connect connect;
        public AddingTask()
        {
            InitializeComponent();
            connect = new Connect();
        }

        private void chBSwitch_Checked(object sender, RoutedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked == true)
            {
                gdZero.Children.Remove(((CheckBox)sender));
                cldData.Visibility = Visibility.Visible;
            }
        }

        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            if (Zweryfikuj(txtTemat.Text,txtOpis.Text))
            {
                string command = "Insert Into dane(Temat,Priorytet,Termin,Status,Opis)" +
                    "VALUES()";
                MySqlCommand cmd = new MySqlCommand(command, connect.Connection);
                connect.Connection.Open();
                cmd.ExecuteReader(); //Add a new record to database
                connect.Connection.Close();
            }
            else
            {
                MessageBox.Show("Prosze wprowadzic dane!\nTemat lub opis są puste")
            }
        }

        private bool Zweryfikuj(string temat,string opis)
        {
            //Determine whenever user actually write something in field's
            if (!(temat.Equals("") || !(opis.Equals(""))))
                return true;
            else
                return false;
        }
    }
}
