using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Rating : FullAuditedAggregateRoot<Guid>
    { 
        public int Value { get; set; }
        public RatingType Type { get; set; }
        public Guid ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
