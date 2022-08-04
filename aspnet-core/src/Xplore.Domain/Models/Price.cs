using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Price : FullAuditedAggregateRoot<Guid>
    { 
        public PriceCategory Category { get; set; }
        public decimal? Value { get; set; }
        public Guid IdTrip { get; set; }

        public Trip Trip { get; set; }
    }
}
