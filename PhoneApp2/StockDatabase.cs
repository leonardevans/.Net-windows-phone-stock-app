using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PhoneApp2
{
    public class StockDataContext : DataContext
    {
        public static string DbConnectionString = @"isostore:/StockDatabase.sdf";

        public StockDataContext(string connectionString)
            : base(connectionString)
        {

        }

        public Table<User_details> Users
        {
            get
            {
                return this.GetTable<User_details>();
            }
        }

        public Table<Item_details> Items
        {
            get
            {
                return this.GetTable<Item_details>();
            }
        }
   

    }


    [Table]
    public class Item_details
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }

        [Column]
        public string itemname
        {
            get;
            set;
        }

        [Column]
        public double price
        {
            get;
            set;
        }

        [Column]
        public int quantity
        {
            get;
            set;
        }
    }

    [Table]
    public class User_details
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }

        [Column]
        public string username
        {
            get;
            set;
        }

        [Column]
        public string password
        {
            get;
            set;
        }
    }
}
