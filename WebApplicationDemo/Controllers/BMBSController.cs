using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Common;
using WebApplicationDemo.Model;
using WebApplicationDemo.Service;

namespace WebApplicationDemo.Controllers
{
    [Route("api/[controller]")]
    public class BMBSController : Controller
    {

        private readonly UserService userService = new UserService();

        [HttpPost("Update/{id}/{name}")]
        public ResponseMsg Update(int id, String name)
        {
            return ResponseMsg.Success(userService.Update(id, name));
        }

        [HttpPost("LoadByName/{name}")]
        public ResponseMsg Load(String name)
        {
            List<Users> list = userService.GetByName(name);
            return ResponseMsg.Success(list);

        }

        [HttpPost("GetAll/{currentPage}/{pageSize}")]
        public ResponseMsg GetAllUser(int currentPage, int pageSize)
        {
            return ResponseMsg.Success(userService.GetUsers(currentPage, pageSize));
        }

        [HttpGet]
        public ResponseMsg Get()
        {
            List<Users> list = userService.GetAllUser();
            return ResponseMsg.Success(list);
        }

        [HttpGet("{id}")]
        public ResponseMsg Get(int id)
        {
            Users user = userService.GetUserById(id);
            return ResponseMsg.Success(user);
        }

        [HttpPost("Create/{name}")]
        public ResponseMsg Create(string name)
        {
            Users u = new Users(name);
            return ResponseMsg.Success(userService.Save(u));
        }

        [HttpPost("Delete/{id}")]
        public ResponseMsg Delete(int id)
        {
            return ResponseMsg.Success(userService.Delete(id));
        }
    }
}
