using Core.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class Car : EntityBase<int>
    {
        public Car()
        {
            TravelPlan = new HashSet<TravelPlan>();
        }

        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public string LicencePlate { get; set; }
        public int? CarTypeId { get; set; }
        public int? CarManufacturerId { get; set; }
        public int? CarColorId { get; set; }

        public virtual CarColor CarColor { get; set; }
        public virtual CarManufacturer CarManufacturer { get; set; }
        public virtual CarType CarType { get; set; }
        public virtual ICollection<TravelPlan> TravelPlan { get; set; }
    }
}
