using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Place : FullAuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string GpsLocation { get; set; }
        public Guid IdTrip { get; set; }
        public string Type { get; set; }
        public int? Order { get; set; }
    }
}
