using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class Employee
    {
        public Employee()
        {
            TravelPlanEmployee = new HashSet<TravelPlanEmployee>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsDriver { get; set; }
        public string Email { get; set; }

        public virtual ICollection<TravelPlanEmployee> TravelPlanEmployee { get; set; }
    }
}
