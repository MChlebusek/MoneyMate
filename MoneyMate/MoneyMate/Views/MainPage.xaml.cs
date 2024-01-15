using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MoneyMate.Models;
using System.Transactions;
using MoneyMate.ViewModels;
using MoneyMate.Views;

namespace MoneyMate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
        }
        private async void OnNavigateToAddTransactionPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTransactionPage());
        }

    }
}