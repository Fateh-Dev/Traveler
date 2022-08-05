using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class ScheduledTrip : FullAuditedAggregateRoot<Guid>
    {
        public DateTime? Date { get; set; }

        public string Description { get; set; }

        public Guid TripId { get; set; }

        public Trip Trip { get; set; }

        public ICollection<Price> Prices { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<SubscribeAt> subscribedTourists { get; set; }
    }
}
