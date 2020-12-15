using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_sekvensdiagrammer1.ViewModels.Commands;
using WPF_sekvensdiagrammer1.Views.Pages;

namespace WPF_sekvensdiagrammer1.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public Page PageContent { get; set; }

        private ICommand setPageContentCommand { get; set; }
        public ICommand SetPageContent { get { return setPageContentCommand; } }

        public MainWindowViewModel()
        {
            Page home = new Home();
            PageContent = home;

            setPageContentCommand = new SetPageContent(this);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SwapPageContent(string name)
        {
            switch (name)
            {
                case "Home":
                    PageContent = new Home();
                    break;
                case "LoginPage":
                    PageContent = new LoginPage();
                    break;
                default:
                    PageContent = new Home();
                    break;
            }
            OnPropertyChanged("PageContent");

        }


        protected void OnPropertyChanged(string x)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(x));
        }

    }

}
