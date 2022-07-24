using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Trip : FullAuditedAggregateRoot<Guid>
    { 

        public string Title { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        public string Duration { get; set; }

        public string Glanguages { get; set; }

        public double? TripSize { get; set; }

        public DurationUnit DurationUnit { get; set; }

        public DateOnly? Date { get; set; }

        public DateTime? StartingTime { get; set; }

        public string Agency { get; set; }

        public string IdAchived { get; set; }

        public string Activities { get; set; }

        public string Risks { get; set; }

        public string NotAllowedStuff { get; set; }

        public string RequiredStuff { get; set; }

        public string NotSuitableFor { get; set; }

        public string IncludedStuff { get; set; }

        public string Loging { get; set; }
    }
}
