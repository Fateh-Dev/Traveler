using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Image : AuditedAggregateRoot<Guid>
    { 
        public string IdTrip { get; set; }
    }
}
