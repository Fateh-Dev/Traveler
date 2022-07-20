using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class TripInclude : FullAuditedAggregateRoot<Guid>
    {
        public Guid IdTrip { get; set; }
        public Guid IdInclude { get; set; }
    }
}
