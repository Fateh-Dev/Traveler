using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Activity : FullAuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Tools { get; set; }

        public Guid IdTrip { get; set; }
    }
}
