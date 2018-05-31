using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.DAO;
using WebApplicationDemo.Model;

namespace WebApplicationDemo.Service
{
    public class UserService
    {

        private readonly UserDAO userDAO = new UserDAO();

        public int Update(int id, String name)
        {
            Users u = userDAO.GetUserById(id);
            u.Name = name;
            return userDAO.Update(u);
        }

        public int Delete(long id)
        {
            return userDAO.Delete(id);
        }

        public Users Save(Users users)
        {
            return userDAO.Save(users);
        }

        public Page<Users> GetUsers(int currentPage, int pageSize)
        {
            return userDAO.GetUsers(currentPage, pageSize);
        }

        public List<Users> GetAllUser()
        {
            return userDAO.GetAllUser();
        }

        public List<Users> GetByName(String name)
        {
            return userDAO.GetUserByName(name);
        }

        public Users GetUserById(long id)
        {
            Users user = userDAO.GetUserById(id);
            return user;
        }
    }
}
