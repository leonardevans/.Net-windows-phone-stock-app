using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp2
{
    class DatabaseOperations
    {
        public void addUser(string username, string password)
        {
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                User_details user = new User_details();
                user.username = username;
                user.password = password;
                context.Users.InsertOnSubmit(user);
                context.SubmitChanges();

            }
        }

        public void addItem(string itemname, double price, int quantity)
        {
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                Item_details item = new Item_details();
                item.itemname = itemname;
                item.price = price;
                item.quantity = quantity;
                context.Items.InsertOnSubmit(item);
                context.SubmitChanges();
            }
        }

        public IList<User_details> getAllUsers()
        {
            IList<User_details> list = null;
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<User_details> query = from c in context.Users select c;
                list = query.ToList();
            }

            return list;

        }

        public IList<Item_details> getAllItems()
        {
            IList<Item_details> list = null;
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<Item_details> query = from c in context.Items select c;
                list = query.ToList();
            }

            return list;

        }


        public Items getItem(int id)
        {
            Items item = null;
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<Item_details> entityQuery = from c in context.Items where c.ID == id select c;
                Item_details selectItem = entityQuery.FirstOrDefault();
                if (selectItem != null)
                {
                    item = new Items();
                    item.id = id;
                    item.itemname = selectItem.itemname;
                    item.price = selectItem.price;
                    item.quantity = selectItem.quantity;
                }
                
            }

            return item;
        }

        public Users getLoginUser(string username, string password)
        {
            Users user = null;
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<User_details> entityQuery = from c in context.Users where c.username.Equals(username) && c.password.Equals(password) select c;
                User_details selectUser = entityQuery.FirstOrDefault();
                if (selectUser != null)
                {
                    user = new Users();
                    user.id = selectUser.ID;
                    user.username = selectUser.username;
                    user.passord = selectUser.password;
                }

            }
            return user;
        }

        public Users getUser(string username)
        {
            Users user = null;
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<User_details> entityQuery = from c in context.Users where c.username.Equals(username) select c;
                User_details selectUser = entityQuery.FirstOrDefault();
                if (selectUser != null)
                {
                    user = new Users();
                    user.id = selectUser.ID;
                    user.username = selectUser.username;
                    user.passord = selectUser.password;
                }

            }
            return user;
        }

        public void updateUser(int id, string username, string password) {
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<User_details> entityQuery = from c in context.Users where c.ID == id select c;
                User_details entityToUpdate = entityQuery.FirstOrDefault();
                entityToUpdate.username = username;
                entityToUpdate.password = password;
                context.SubmitChanges();
            }
        }

        public void updateItem(int id, string itemname, double price, int quantity)
        {
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<Item_details> entityQuery = from c in context.Items where c.ID == id select c;
                Item_details entityToUpdate = entityQuery.FirstOrDefault();
                entityToUpdate.itemname = itemname;
                entityToUpdate.price = price;
                entityToUpdate.quantity = quantity;
                context.SubmitChanges();
            }
        }

        public List<Items> searchItems(string search)
        {
            List<Items> searchedList = new List<Items>();
            IList<Item_details> searchedItems = null;
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<Item_details> entityQuery = from c in context.Items where c.itemname.Contains(search) select c;
                 searchedItems = entityQuery.ToList();
                if (searchedItems != null)
                {
                    foreach (Item_details item in searchedItems)
                    {
                        Items i = new Items();
                        i.id = item.ID;
                        i.itemname = item.itemname;
                        i.price = item.price;
                        i.quantity = item.quantity;
                        searchedList.Add(i);
                    }
                }
            }

            return searchedList;

        }

        public List<Users> getUsers()
        {
            IList<User_details> users = this.getAllUsers();
            List<Users> allUsers = new List<Users>();
            foreach (User_details ud in users)
            {
                Users n = new Users();
                n.id = ud.ID;
                n.username = ud.username;
                n.passord = ud.password;
                allUsers.Add(n);

            }
            return allUsers;
        }


        public List<Items> getItems()
        {
            IList<Item_details> items = this.getAllItems();
            List<Items> allItems = new List<Items>();
            foreach (Item_details itemd in items)
            {
                Items n = new Items();
                n.id = itemd.ID;
                n.itemname = itemd.itemname;
                n.price = itemd.price;
                n.quantity = itemd.quantity;
                allItems.Add(n);

            }
            return allItems;
        }

        public void deleteUser(int id) {
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<User_details> entityQuery = from c in context.Users where c.ID == id select c;
                User_details entityToDelete = entityQuery.FirstOrDefault();
                context.Users.DeleteOnSubmit(entityToDelete);
                context.SubmitChanges();
            }
        }


        public void deleteItem(int id)
        {
            using (StockDataContext context = new StockDataContext(StockDataContext.DbConnectionString))
            {
                IQueryable<Item_details> entityQuery = from c in context.Items where c.ID == id select c;
                Item_details entityToDelete = entityQuery.FirstOrDefault();
                context.Items.DeleteOnSubmit(entityToDelete);
                context.SubmitChanges();
            }
        }

        
    }

    class Users
    {
        public int id { get; set; }
        public string username { get; set; }
        public string passord { get; set; }
    }

    class Items
    {
        public int id { get; set; }
        public string itemname { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
    }
}
