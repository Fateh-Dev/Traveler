using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Rating : FullAuditedAggregateRoot<Guid>
    { 
        public string Value { get; set; }
        public RatingType Type { get; set; }
        public string IdReview { get; set; }
    }
}
