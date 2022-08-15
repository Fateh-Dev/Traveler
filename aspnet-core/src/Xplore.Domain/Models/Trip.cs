using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Trip : FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Rating { get; set; }

        public int Duration { get; set; }

        public string Glanguages { get; set; }
        public Byte[] Thumbnail { get; set; }

        public double? TripSize { get; set; }

        public DurationUnit DurationUnit { get; set; }

        public Difficulty Difficulty { get; set; }

        public DateTime? Date { get; set; }

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

        public Guid GuideId { get; set; }

        public Guide Guide { get; set; }

        public ICollection<Location> Locations { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<ScheduledTrip> ScheduledTrips { get; set; }

        public ICollection<WishList> PotentialClients { get; set; }

        public Trip()
        {
        }

        public Trip(Guid id, [NotNull] string title) :
            base(id)
        {
            SetTitle (title);
            ScheduledTrips = new Collection<ScheduledTrip>();
        }

        public void SetTitle(string title)
        {
            Title =
                Check.NotNullOrWhiteSpace(title, nameof(title), maxLength: 255);
        }
    }
}
