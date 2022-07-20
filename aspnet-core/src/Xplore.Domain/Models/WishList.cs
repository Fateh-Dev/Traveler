using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class WishList : FullAuditedAggregateRoot<Guid>
    {
        public string IdTrip { get; set; }
        public string IdTourist { get; set; }
    }
}
