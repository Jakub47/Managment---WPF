using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zadania.Models
{
    public class Win : Window
    {
        public  Window EntryPoint { get; set; }

        public Win(Window getWindows)
        {
            EntryPoint = getWindows;
        }
    }
}
