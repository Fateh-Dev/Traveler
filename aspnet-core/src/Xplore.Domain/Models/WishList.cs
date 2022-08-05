using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class WishList : FullAuditedAggregateRoot<Guid>
    {
        public Guid TripId { get; set; }

        public Trip Trip { get; set; }

        public Guid TouristId { get; set; }

        public Tourist Tourist { get; set; }
    }
}
