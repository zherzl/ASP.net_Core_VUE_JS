using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class CarColor
    {
        public CarColor()
        {
            Car = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Color { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}
