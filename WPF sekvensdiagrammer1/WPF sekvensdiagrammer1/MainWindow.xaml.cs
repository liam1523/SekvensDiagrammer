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
using WPF_sekvensdiagrammer1.ViewModels;

namespace WPF_sekvensdiagrammer1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MainWindowViewModel mwvm = new MainWindowViewModel();
            DataContext = mwvm;
            InitializeComponent();

        }
    }
}
