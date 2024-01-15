using MoneyMate.Services;
using SQLite;
using System;
using System.IO;
using System.Transactions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyMate
{
    public partial class App : Application
    {
        public static DatabaseService Database;


        public App(string dbPath)
        {
            InitializeComponent();

            Database = new DatabaseService(dbPath);

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#3498db"),
                BarTextColor = Color.White
            };
        }
        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "money.db3");

            Database = new DatabaseService(dbPath);

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#3498db"),
                BarTextColor = Color.White
            };

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}