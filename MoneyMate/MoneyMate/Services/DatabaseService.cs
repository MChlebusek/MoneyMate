using System;
using System.Collections.Generic;
using System.IO;
using System.Transactions;
using SQLite;
using SQLiteNetExtensions.Extensions;
using MoneyMate.Models;


namespace MoneyMate.Services
{
    public class DatabaseService
    {
        private readonly SQLiteConnection database;

        public DatabaseService(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            EnsureTablesCreated(); // Создаем таблицы
        }

        private void EnsureTablesCreated()
        {
            database.CreateTable<MoneyTransaction>();
        }

        public List<MoneyTransaction> GetAllTransactions()
        {
            return database.Table<MoneyTransaction>().ToList();
        }

        public void AddTransaction(MoneyTransaction transaction)
        {
            database.Insert(transaction);
        }
    }
}