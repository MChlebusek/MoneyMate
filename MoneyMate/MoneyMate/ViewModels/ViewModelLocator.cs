using System;
using System.Collections.Generic;
using System.Text;
using MoneyMate.ViewModels;

namespace MoneyMate.ViewModels
{
    public class ViewModelLocator
    {
        public MainViewModel Main => new MainViewModel();
    }
}
