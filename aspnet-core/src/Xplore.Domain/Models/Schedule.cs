using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Schedule : FullAuditedAggregateRoot<Guid>
    {
        public Guid IdTrip { get; set; }
        public Trip Trip { get; set; }
        public Guid IdGuide { get; set; }
        public Guide Guide { get; set; }
        public DateOnly? Date { get; set; }
    }
}
