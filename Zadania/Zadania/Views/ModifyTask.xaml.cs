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
    /// Interaction logic for ModifyTask.xaml
    /// </summary>
    public partial class ModifyTask : Window
    {
        OperacjeDb actionsOnDatabase;
        int id;
        public ModifyTask(int id)
        {
            InitializeComponent();
            this.id = id;
            actionsOnDatabase = new OperacjeDb();
            txtTemat.Text = actionsOnDatabase.takeTemat(id);
            cBPriorytet.SelectedValue = actionsOnDatabase.takePriorytet(id);
            if(actionsOnDatabase.takeTermin(id) != string.Empty)
            {
                txtNoDate.Visibility = Visibility.Hidden;
                cldData.Visibility = Visibility.Visible;
                cldData.SelectedDate = DateTime.Parse(actionsOnDatabase.takeTermin(id));
            }
            cBStatus.SelectedValue = actionsOnDatabase.takeStatus(id);
            txtOpis.Text = actionsOnDatabase.takeOpis(id);
        }
        private void btnZmodyfikuj_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)cBPriorytet.SelectedItem;
            string valuePrio = typeItem.Content.ToString();

            ComboBoxItem typeItem2 = (ComboBoxItem)cBStatus.SelectedItem;
            string valueST = typeItem2.Content.ToString();

            actionsOnDatabase.update(id,txtTemat.Text, valuePrio, cldData.SelectedDate.Value, valueST, txtOpis.Text);

            //This window
            this.Close();

            //Main Windows
            MainWindow.canRefresh = true;
            MainWindow.Pokaz();
        }
    }
}
