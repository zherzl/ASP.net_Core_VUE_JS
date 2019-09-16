using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class CarType
    {
        public CarType()
        {
            Car = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string TypeOfCar { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}
