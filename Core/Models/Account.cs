using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public enum Role
    {
        User,
        Administrator
    }
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
