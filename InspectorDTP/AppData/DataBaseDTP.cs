using Android.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace InspectorDTP.AppData
{
    public class DataBaseDTP
    {
        SQLiteAsyncConnection _database;
        //Подключение к SQLite и взаимодействия с БД
        public DataBaseDTP(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<DTP>().Wait();
        }
        //Метод для получения данных из БД
        public Task<List<DTP>> GetDTPAsync()
        {
            return _database.Table<DTP>().ToListAsync();
        }
        //Метод для сохранения данных в БД
        public Task<int> SaveDTPAsync(DTP dtp)
        {
            return _database.InsertAsync(dtp);
        }
        //Метод для удаления данных
        public Task<int> DeleteDTPAsync(DTP dtp)
        {
            return _database.DeleteAsync(dtp);
        }
        //Метод для обновления данных
        public Task<int> UpdateDTPAsync(DTP dtp)
        {
            if (dtp.ID != 0)
            {
                return _database.UpdateAsync(dtp);
            }
            else
            {
                return _database.InsertAsync(dtp);
            }
        }
    }
}
