using System;
using System.Collections.Generic;

namespace Core.Model.Models
{
    public partial class TravelPlanEmployee
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? TravelPlanId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual TravelPlan TravelPlan { get; set; }
    }
}
