using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Avoid : FullAuditedAggregateRoot<Guid>
    {
        public string IdStuff { get; set; }
        public string IdTrip { get; set; }
    }
}
