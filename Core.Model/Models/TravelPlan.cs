using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class TravelPlan
    {
        public TravelPlan()
        {
            TravelPlanEmployee = new HashSet<TravelPlanEmployee>();
        }

        public int Id { get; set; }
        public int StartLocationId { get; set; }
        public int EndLocationId { get; set; }
        public int CarId { get; set; }
        public bool? IsDriving { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? ChangeDate { get; set; }

        public virtual Car Car { get; set; }
        public virtual TravelLocation EndLocation { get; set; }
        public virtual TravelLocation StartLocation { get; set; }
        public virtual ICollection<TravelPlanEmployee> TravelPlanEmployee { get; set; }
    }
}
