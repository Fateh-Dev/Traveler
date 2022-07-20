using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Rating : FullAuditedAggregateRoot<Guid>
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Rating1 { get; set; }
        public string IdTrip { get; set; }
        public string IdTourist { get; set; }
    }
}
