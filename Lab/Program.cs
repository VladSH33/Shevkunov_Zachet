using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            List<User> data = reader.ReadTxt("input.txt");

            using (DbWorker db = new DbWorker())
            {
                //db.Users.RemoveRange(db.Users);
                //db.SaveChanges();
                foreach (User user in data)
                {
                    db.Users.Add(user);
                }
                db.SaveChanges();
                CheckDb(db);
            }
        }

        private static void CheckDb(DbWorker db)
        {
            var users = db.Users;
            foreach (User user in users)
            {
                Console.WriteLine(user.Date + " " + user.Name + " " + user.Money + " " + user.Currency);
            }
        }
    }
}
