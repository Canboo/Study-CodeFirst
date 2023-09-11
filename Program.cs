using System;
using api.Models;

namespace api;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new ApiContext())
        {
            db.Users.Add(new User()
            {
                UserName = "User 1"
            });
            db.Users.Add(new User()
            {
                UserName = "User 2"
            });

            db.SaveChanges();
        }

        using (var db = new ApiContext())
        {
            Console.WriteLine("查詢新增後的所有資料");
            foreach (var item in db.Users)
            {
                Console.WriteLine(item.Id + " " + item.UserName);
            }
        }

        using (var db = new ApiContext())
        {
            foreach (var item in db.Users)
            {
                item.UserName += "!";
                item.ModifyTime = DateTime.Now;
            }

            db.SaveChanges();
        }

        using (var db = new ApiContext())
        {
            Console.WriteLine("查詢更新後的所有資料");
            foreach (var item in db.Users)
            {
                Console.WriteLine(item.Id + " " + item.UserName);
            }
        }

        using (var db = new ApiContext())
        {
            var item = db.Users.Find(1);
            if (item != null)
            {
                db.Users.Remove(item);
                db.SaveChanges();
            }
        }

        using (var db = new ApiContext())
        {
            Console.WriteLine("查詢刪除編號 1 資料後的所有資料");
            foreach (var item in db.Users)
            {
                Console.WriteLine(item.Id + " " + item.UserName);
            }
        }
    }
}