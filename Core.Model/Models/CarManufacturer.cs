using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class CarManufacturer
    {
        public CarManufacturer()
        {
            Car = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}
