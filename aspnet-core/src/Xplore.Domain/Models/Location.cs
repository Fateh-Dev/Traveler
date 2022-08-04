using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Location : FullAuditedAggregateRoot<Guid>
    {
        public string Description { get; set; }

        public string GpsLocation { get; set; }

        public Guid IdTrip { get; set; }

        public Trip Trip { get; set; }

        public LocationType Type { get; set; }

        public int? Order { get; set; }
    }
}
