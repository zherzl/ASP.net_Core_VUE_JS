using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class TravelLocation
    {
        public TravelLocation()
        {
            TravelPlanEndLocation = new HashSet<TravelPlan>();
            TravelPlanStartLocation = new HashSet<TravelPlan>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public virtual ICollection<TravelPlan> TravelPlanEndLocation { get; set; }
        public virtual ICollection<TravelPlan> TravelPlanStartLocation { get; set; }
    }
}
