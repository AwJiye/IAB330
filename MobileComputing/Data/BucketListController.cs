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
    public class BucketListController
    {
        static object locker = new object();

        SQLiteConnection database;

        public BucketListController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<BucketList>();
        }

        public BucketList GetBucketList()
        {
            lock(locker)
            {
                if (database.Table<BucketList>().Count() == 0)
                {
                    return null;
                }
                else 
                {
                    return database.Table<BucketList>().First();
                }
            }
        }

        public int SaveBucketList(BucketList list)
        {
            lock(locker)
            {
                if(list.ActivitiesID != 0)
                {
                    database.Update(list);
                    return list.ActivitiesID;
                }else
                {
                    return database.Insert(list);
                }
            }
        }

        public int DeleteBucketList(int ActivitiesId)
        {
            lock(locker)
            {
                return database.Delete<BucketList>(ActivitiesId);
            }
        }
    }
}
