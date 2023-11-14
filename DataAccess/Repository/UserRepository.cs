using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository
    {
        public List<User> GetAll() => UserDAO.Instance.GetAll();

        public User? GetUserById(int id) => UserDAO.Instance.GetById(id);

        public User? GetUserByName(string name) => UserDAO.Instance.GetByName(name);

        public void AddUser(User user) => UserDAO.Instance.AddUser(user);

        public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);

        public void DeleteUser(User user) => UserDAO.Instance.DeleteUser(user);

        public User? GetUserByUserNameAndPassword(string username, string password) => UserDAO.Instance.GetByUserNameAndPassword(username, password);
        public User? GetUserByUserName(string username) => UserDAO.Instance.GetByUserName(username);
    }
}
