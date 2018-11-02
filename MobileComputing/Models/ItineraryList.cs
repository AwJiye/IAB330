using System;
using SQLite;
namespace MobileComputing.Models
{
    public class ItineraryList
    {
        [PrimaryKey,AutoIncrement]
        public int TripId{
            get;
            set;
        }

        public string TripName{
            get;
            set;
        }

        public DateTime StartDate{
            get;
            set;
        }

        public DateTime EndDate{
            get;
            set;
        }

        public string TripDestination{
            get;
            set;
        }

        public int TripBudget{
            get;
            set;
        }



    }
}
