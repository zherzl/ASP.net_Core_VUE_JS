using Core.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Models
{
    public class AppUser : EntityBase<int>
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        //public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
