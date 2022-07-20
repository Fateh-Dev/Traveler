using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class EnchargeOf : FullAuditedAggregateRoot<Guid>
    {
        public string IdTrip { get; set; }
        public string IdGuide { get; set; }
        public DateOnly? Date { get; set; }
    }
}
