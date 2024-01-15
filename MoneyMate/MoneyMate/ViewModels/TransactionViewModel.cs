using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Transactions;

namespace MoneyMate.ViewModels
{
    public class TransactionViewModel
    {
        private List<Transaction> transactions;

        public ObservableCollection<Transaction> Transactions { get; set; }

        public TransactionViewModel()
        {
            Transactions = new ObservableCollection<Transaction>();
            LoadTransactions(); // Загрузка данных из базы данных
        }

        private void LoadTransactions()
        {
            // Логика загрузки данных из базы данных или другого источника
            // transactions = DatabaseService.GetAllTransactions();

            // Преобразование в ObservableCollection для привязки к представлению
            foreach (var transaction in transactions)
            {
                Transactions.Add(transaction);
            }
        }
    }
}