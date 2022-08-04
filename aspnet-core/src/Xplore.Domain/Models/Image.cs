using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Image : AuditedAggregateRoot<Guid>
    {
        public string Url { get; set; }

        public string Description { get; set; }

        public Guid IdTrip { get; set; }

        public Trip Trip { get; set; }
    }
}
