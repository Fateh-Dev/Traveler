using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class SubscribeAt : FullAuditedAggregateRoot<Guid>
    {
        public Guid IdTrip { get; set; }
        public Trip Trip { get; set; }
        public Guid IdTourist { get; set; }
        public Tourist Tourist { get; set; }
        public DateOnly? Date { get; set; }
    }
}
