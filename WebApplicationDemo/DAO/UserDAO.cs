using NPoco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Common;
using WebApplicationDemo.Model;

namespace WebApplicationDemo.DAO
{
    public class UserDAO
    {

        public void SaveOrUpdate(Users users)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                dm.Save(users);
                dm.CompleteTransaction();
            }
        }

        public int Delete(long id)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                var users = dm.SingleById<Users>(id);
                int number = dm.Delete(users);
                dm.CompleteTransaction();
                return (int)number;
            }
        }

        public int Delete(Users users)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                int number = dm.Delete(users);
                dm.CompleteTransaction();
                return (int)number;
            }
        }

        public int Update(Users users)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                object number = dm.Update(users);
                dm.CompleteTransaction();
                return (int)number;
            }
        }

        public Users Save(Users users)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                object id = dm.Insert(users);
                dm.CompleteTransaction();
                Users u = dm.SingleById<Users>(id);
                return u;
            }
        }


        public Page<Users> GetUsers(int currentPage, int pageSize)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                Page<Users> pagedUsers = dm.Page<Users>(currentPage, pageSize, "select u.* from users u order by id");
                dm.CompleteTransaction();
                return pagedUsers;
            }
                
        }

        public List<Users> GetUserByName(String name)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                List<Users> list = dm.Query<Users>().Where("NAME LIKE @0", "%" + name + "%").ToList();
                dm.CompleteTransaction();
                return list;
            }
        }

        public List<Users> GetAllUser()
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                List<Users> list = dm.Fetch<Users>("select * from Users");
                dm.CompleteTransaction();
                return list;
            }
        }

        public Users GetUserById(long id)
        {
            using (var dm = new DataManager())
            {
                dm.BeginTransaction();
                var user = dm.Query<Users>().Where(p => p.Id == id).FirstOrDefault();
                dm.CompleteTransaction();
                return user;
            }
             
        }
    }
}
