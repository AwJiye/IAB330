using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using MobileComputing.Data;
using Xamarin.Forms;
using MobileComputing.iOS.Data;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace MobileComputing.iOS.Data
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {
        }

        public SQLite.SQLiteConnection GetConnection (){

            var fileName = "Trips.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath,"..","Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);

            return connection;
        }
    }
}
