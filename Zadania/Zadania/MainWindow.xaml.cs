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
        private int ZadanieId = -1;

        public MainWindow()
        {
            InitializeComponent();
            actionsOnDatabase = new OperacjeDb();
            canRefresh = false;
            Refresh();    
        }

        private void createGrid(Grid clone,Zadanie element)
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
                createGrid(dodaj, ListZZadaniami.ListZadan.ElementAtOrDefault(i));
                dodaj.Margin = new Thickness(0,5,0,0);
                dodaj.PreviewMouseLeftButtonDown += Dodaj_PreviewMouseLeftButtonDown;
                ZbiorZadan.Children.Add(dodaj);
            }

        }

        private void Dodaj_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = ((Grid)(sender)); List<string> items = new List<string>();
            foreach(TextBlock txtTemat in item.Children)
            {
                items.Add(txtTemat.Text);
            }
            //Pierwszy/t/t/t
            string result = "";
            for(int i =0;i<items.ElementAt(0).Length;i++)
            {
                if (items.ElementAt(0).ElementAt(i) == '\t') break;
                    result += items.ElementAt(0).ElementAt(i);
            }

            txtOpisGlowny.Text = string.Empty;
            txtOpisGlowny.Text = actionsOnDatabase.find(result);
            ZadanieId = actionsOnDatabase.findId(result);
            //txtOpisGlowny.Text += ((Grid)(sender)).Children.Fo
        }

        private void btnUsun_Click(object sender, RoutedEventArgs e)
        {
            actionsOnDatabase.delete(txtOpisGlowny.Text);
            Refresh();
            txtOpisGlowny.Text = "";
        }

        private void btnZmodyfikuj_Click(object sender, RoutedEventArgs e)
        {
            //Po 10/02/2018 -> Masz Stworzyć Widok i Zmodyfikować Dane
            //Następnie Wprowadzić Sortowanie
            if(ZadanieId < 0) { MessageBox.Show("Nie można zmodyfikować Zadanie"); return; }
            this.Hide();
            ModifyTask mT = new ModifyTask(ZadanieId); mT.Show(); 

        }
    }
}
