using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ReviewDto : AuditedEntityDto<Guid>
    {
        public Guid TouristId { get; set; }

        public TouristDto Tourist { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public Guid ScheduledTripId { get; set; }

        public ScheduledTripDto ScheduledTrip { get; set; }

        public ICollection<RatingDto> Ratings { get; set; }
    }

    public partial class CreateUpdateReviewDto
    {
        public Guid TouristId { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public Guid ScheduledTripId { get; set; }
    }
}
