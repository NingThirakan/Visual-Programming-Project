using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueShopX.Tables
{
    public class UserTable
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
