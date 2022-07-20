using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Trip : FullAuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int Duration { get; set; }
        public string Glanguages { get; set; }
        public double? TripSize { get; set; }
        public string DurationUnit { get; set; }
        public DateOnly? Date { get; set; }
        public DateOnly? StartingTime { get; set; }
        public string Agency { get; set; }
        public bool IsAchived { get; set; }
    }
}
