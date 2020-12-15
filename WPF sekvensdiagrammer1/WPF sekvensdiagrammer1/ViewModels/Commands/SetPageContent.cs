using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_sekvensdiagrammer1.ViewModels.Commands
{
    public class SetPageContent : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MainWindowViewModel vm;

        public SetPageContent(MainWindowViewModel mwvm)
        {
            vm = mwvm;

        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.SwapPageContent(parameter.ToString());

        }

    }

}
