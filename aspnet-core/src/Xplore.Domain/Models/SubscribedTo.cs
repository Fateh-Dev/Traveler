using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class SubscribedTo : FullAuditedAggregateRoot<Guid>
    {
        public Guid IdTrip { get; set; }
        public Guid IdTouriste { get; set; }
        public DateOnly? Date { get; set; }
    }
}
