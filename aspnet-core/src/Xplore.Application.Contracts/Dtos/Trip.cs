using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class TripDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ThumbnailPic { get; set; }

        public double Rating { get; set; }

        public int Duration { get; set; }

        public string Glanguages { get; set; }

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

        public GuideDto Guide { get; set; }

        public Byte[] ThumbnailImage { get; set; }

        public ICollection<LocationDto> Locations { get; set; }

        public ICollection<ImageDto> Images { get; set; }

        public ICollection<ScheduledTripDto> ScheduledTrips { get; set; }

        public ICollection<WishListDto> PotentialClients { get; set; }
    }

    public partial class CreateUpdateTripDto
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        [Required]
        [StringLength(128)]
        public string Description { get; set; }

        public double Rating { get; set; } = 5;

        [Required]
        public int Duration { get; set; }

        public string Glanguages { get; set; }

        public string ThumbnailPic { get; set; }

        public Difficulty Difficulty { get; set; }

        public double? TripSize { get; set; }

        public Guid? GuideId { get; set; }

        public DurationUnit DurationUnit { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? StartingTime { get; set; }

        public string Agency { get; set; }

        public bool IdAchived { get; set; } = false;

        public bool IsValidated { get; set; } = false;

        public string Activities { get; set; }

        public string Risks { get; set; }

        public string NotAllowedStuff { get; set; }

        public string RequiredStuff { get; set; }

        public string NotSuitableFor { get; set; }

        public string IncludedStuff { get; set; }

        public string Loging { get; set; }
    }

    public partial class TripMiniDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string ThumbnailPic { get; set; }
        public string Description { get; set; }

        public double Rating { get; set; }

        public int Duration { get; set; }

        public double? TripSize { get; set; }

        public DurationUnit DurationUnit { get; set; }

        public Difficulty Difficulty { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? StartingTime { get; set; }

        public string Activities { get; set; }

        public string Loging { get; set; }

        public Byte[] ThumbnailImage { get; set; }
    }
}
