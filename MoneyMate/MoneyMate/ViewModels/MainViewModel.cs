using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using MoneyMate.Models;
using MoneyMate.Services;

namespace MoneyMate.ViewModels
{
    public class MainViewModel
    {
        private readonly DatabaseService _databaseService;

        public ObservableCollection<MoneyTransaction> Transactions { get; set; }

        public MainViewModel()
        {
            _databaseService = App.Database; // Получаем экземпляр DatabaseService из App.xaml.cs
            LoadTransactions(); // Загружаем транзакции при создании MainViewModel
        }

        private void LoadTransactions()
        {
            // Здесь загружаем транзакции из базы данных и добавляем их в ObservableCollection
            var transactionsFromDb = _databaseService.GetAllTransactions();

            if (transactionsFromDb != null)
            {
                Transactions = new ObservableCollection<MoneyTransaction>(transactionsFromDb as IEnumerable<MoneyTransaction>);
            }
            else
            {
                Transactions = new ObservableCollection<MoneyTransaction>();
            }
        }
        public void AddTransaction(string description, double amount, DateTime date, string category)
        {
            // Создаем новую транзакцию
            var newTransaction = new MoneyTransaction
            {
                Description = description,
                Amount = amount,
                Date = date,
                Category = category
            };

            // Добавляем транзакцию в базу данных
            _databaseService.AddTransaction(newTransaction);

            // Добавляем транзакцию в ObservableCollection для обновления интерфейса
            Transactions.Add(newTransaction);
        }
    }
}