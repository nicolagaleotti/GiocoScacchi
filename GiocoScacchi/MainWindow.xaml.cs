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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Elementi;

namespace GiocoScacchi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (char c = 'A'; c <= 'H'; c++)
            {
                for (int n = 1; n <= 8; n++)
                {
                    if ((c - 'A') % 2 == 1 && n % 2 == 1 || (c - 'A') % 2 == 0 && n % 2 == 0)
                    {
                        //nero
                    }
                    else
                    {
                        //bianco
                    }
                }
            }
        }
    }
}
