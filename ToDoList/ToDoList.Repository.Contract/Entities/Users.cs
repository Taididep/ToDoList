﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Repository.Contract.Entities;

namespace ToDoList.Repository.Contract
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserInfo UserInfo { get; set; }
    }
}
