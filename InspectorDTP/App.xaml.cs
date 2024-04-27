using InspectorDTP.AppData;
using InspectorDTP.Services;
using InspectorDTP.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InspectorDTP
{
    public partial class App : Application
    {
        static DataBaseDTP database;
        //Прописываем код для обращение к файлу базы данных, в которой будут хранится все данные
        public static DataBaseDTP Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBaseDTP(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dtp.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
