using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class TripInclude : FullAuditedAggregateRoot<Guid>
    {
        public string IdTrip { get; set; }
        public string IdInclude { get; set; }
    }
}
