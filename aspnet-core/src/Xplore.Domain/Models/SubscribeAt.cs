using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class SubscribeAt : FullAuditedAggregateRoot<Guid>
    {
        public Guid ScheduledTripId { get; set; }
        public ScheduledTrip ScheduledTrip { get; set; }
        public Guid TouristId { get; set; }
        public Tourist Tourist { get; set; }
    }
}
