using MoneyMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyMate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTransactionPage : ContentPage
    {
        public AddTransactionPage()
        {
            InitializeComponent();
        }

        private void OnAddTransactionClicked(object sender, EventArgs e)
        {
            // Получаем значения из полей ввода
            string description = DescriptionEntry.Text;
            double amount = double.Parse(AmountEntry.Text);
            DateTime date = DatePicker.Date;
            string category = CategoryEntry.Text;

            // Создаем новую транзакцию
            var newTransaction = new MoneyTransaction
            {
                Description = description,
                Amount = amount,
                Date = date,
                Category = category
            };

            // TODO: Добавляем транзакцию в базу данных или другой сервис

            // После добавления переходим обратно на главную страницу
            Navigation.PopAsync();
        }
    }
}