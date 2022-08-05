using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Review : FullAuditedAggregateRoot<Guid>
    {
        public Guid TouristId { get; set; }

        public Tourist Tourist { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public Guid ScheduledTripId { get; set; }

        public ScheduledTrip ScheduledTrip { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
