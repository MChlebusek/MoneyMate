using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace MoneyMate.Models
{
    public class MoneyTransaction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
    }
}