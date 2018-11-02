using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileComputing.Models;
using SQLite;
using Xamarin.Forms;

namespace MobileComputing.Data
{
    public class ItineraryListController
    {
        static object locker = new object();

        SQLiteConnection database;

        public ItineraryListController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<ItineraryList>();
        }

        public ItineraryList GetItineraryList()
        {
            lock (locker)
            {
                if (database.Table<ItineraryList>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<ItineraryList>().First();
                }
            }
        }

        public int SaveItineraryList(ItineraryList trip)
        {
            lock (locker)
            {
                if (trip.TripId != 0)
                {
                    database.Update(trip);
                    return trip.TripId;
                }
                else
                {
                    return database.Insert(trip);
                }
            }
        }

        public int DeleteItineraryList(int TripId)
        {
            lock (locker)
            {
                return database.Delete<ItineraryList>(TripId);
            }
        }
    }
}
