using System;
using SQLite;
namespace MobileComputing.Models
{
    public class BucketList
    {

        [PrimaryKey,AutoIncrement]
        public int ActivitiesID{
            get;
            set;
        }

        public string ActivitiesName{
            get;
            set;
        }

        public string LocationAddr{
            get;
            set;
        }

        public int TimeSpend{
            get;
            set;
        }

        public float Budget{
            get;
            set;
        }

        public string NickName{
            get;
            set;
        }

    }
}
