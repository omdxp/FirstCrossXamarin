using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FirstCrossXamarin.Data;
using FirstCrossXamarin.Droid.Data;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]

namespace FirstCrossXamarin.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLiteConnection(path);

            return conn;
        }
    }
}