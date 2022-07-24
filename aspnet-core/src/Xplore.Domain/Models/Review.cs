using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Review : FullAuditedAggregateRoot<Guid>
    { 
        public string IdTourist { get; set; }
        public string IdComment { get; set; }
        public string Rating { get; set; }
        public string IdTrip { get; set; }
        public DateOnly Date { get; set; }
    }
}
