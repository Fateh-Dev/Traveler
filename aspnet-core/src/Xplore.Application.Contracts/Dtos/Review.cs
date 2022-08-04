using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ReviewDto : AuditedEntityDto<Guid>
    {
        public Guid IdTourist { get; set; }
        public TouristDto Tourist { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public Guid IdTrip { get; set; }
        public TripDto Trip { get; set; }

        public DateTime Date { get; set; }
    }

    public partial class CreateUpdateReviewDto
    {
        public Guid IdTourist { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public Guid IdTrip { get; set; }

        public DateTime Date { get; set; }
 
    }
}
