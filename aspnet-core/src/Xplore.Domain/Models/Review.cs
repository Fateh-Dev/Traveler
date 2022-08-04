using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Review : FullAuditedAggregateRoot<Guid>
    { 
        public Guid IdTourist { get; set; }
        public Tourist Tourist { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public Guid IdTrip { get; set; }
        public Trip Trip { get; set; }
        public DateOnly Date { get; set; }
    }
}
