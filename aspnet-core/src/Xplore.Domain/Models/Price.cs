using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Price : FullAuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public int? Category { get; set; }
        public decimal? Price1 { get; set; }
        public Guid IdTrip { get; set; }
    }
}
