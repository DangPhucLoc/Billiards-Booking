using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        public static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public List<User> GetAll()
        {
            using var db = new BBP_CSharpContext();
            return db.Users.ToList();
        }

        public User? GetById(int id)
        {
            return GetAll().FirstOrDefault(u => u.UserId == id);
        }

        public User? GetByUserNameAndPassword(string username, string password)
        {
            return GetAll().FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public User? GetByUserName(string username)
        {
            return GetAll().FirstOrDefault(u => u.Username == username);
        }

        public User? GetByName(string name)
        {
            return GetAll().FirstOrDefault(u => u.FirstName.Contains(name) || u.LastName.Contains(name));
        }

        public void AddUser(User user) 
        {
            using var db = new BBP_CSharpContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            using var db = new BBP_CSharpContext();
            db.Users.Update(user);
            db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            using var db = new BBP_CSharpContext();
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
