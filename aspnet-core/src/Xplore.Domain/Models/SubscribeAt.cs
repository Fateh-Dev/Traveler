using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class SubscribeAt : FullAuditedAggregateRoot<Guid>
    {
        public string IdTrip { get; set; }
        public string IdTourist { get; set; }
        public DateOnly? Date { get; set; }
    }
}
