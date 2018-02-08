using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zadania.Models;
using Zadania.Views;

namespace Zadania
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OperacjeDb actionsOnDatabase;
        public static bool canRefresh;
        DataTable dt;

        public MainWindow()
        {
            InitializeComponent();
            actionsOnDatabase = new OperacjeDb();
            canRefresh = false;
            Refresh();    
        }

        private void createGrid(Grid original,Grid clone,Zadanie element)
        {
            TextBlock t = new TextBlock(); t.Text = "";
            t.Text += element.ToString(); t.Foreground = new SolidColorBrush(Colors.Blue); t.FontSize = 18;
            clone.Children.Add(t);
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            //Create a Logic for adding a new Task to the DataBase! Also remember about refreshing!!!!
            this.Hide();
            AddingTask aT = new AddingTask();  aT.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //When the user will press Save Button from the other window .. canRefresh => Well the user can switch manually like first time, using
            //diffrent applications and switching back to our by canRefresh we check if that "request" came directly from closing thatwindow.
            if(canRefresh)
            {
                canRefresh = false;
                dt = actionsOnDatabase.select("select * from dane");
                this.Show();
            }
        }

        public static void Pokaz()
        {
            new MainWindow().Show();
        }

        private void Refresh()
        {
            dt = actionsOnDatabase.select("select * from dane"); //Create a Local Database in method
            ZbiorZadan.Children.Clear(); //Clear all => Update

            //List<DataRow> list = dt.AsEnumerable().ToList();
            // For each row, print the values of each column.

            ListZZadaniami.ListZadan = new List<Zadanie>();
            foreach (DataRow row in dt.Rows)
            {
                Zadanie chwilowy = new Zadanie();
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.ColumnName.Equals("Temat")) chwilowy.Temat = row[column].ToString();
                    if (column.ColumnName.Equals("Priorytet")) chwilowy.Priorytet = row[column].ToString();
                    if (column.ColumnName.Equals("Termin")) chwilowy.Termin = row[column].ToString();
                    if (column.ColumnName.Equals("Status")) chwilowy.Status = row[column].ToString();
                }
                ListZZadaniami.ListZadan.Add(chwilowy);
            }

            for (int i = 0; i < ListZZadaniami.ListZadan.Count(); i++)
            {
                Grid dodaj = new Grid();
                createGrid(gdZadanie, dodaj, ListZZadaniami.ListZadan.ElementAtOrDefault(i));
                ZbiorZadan.Children.Add(dodaj);
            }

        }
    }
}
