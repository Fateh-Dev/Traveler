using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Rating : FullAuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public Guid IdTrip { get; set; }
        public Guid IdTourist { get; set; }
    }
}
