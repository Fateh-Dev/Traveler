using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ReviewDto : AuditedEntityDto<Guid>
    {
        public string IdTourist { get; set; }

        public string IdComment { get; set; }

        public string Rating { get; set; }

        public string IdTrip { get; set; }

        public DateTime Date { get; set; }
    }

    public partial class CreateUpdateReviewDto
    {
        public string IdTourist { get; set; }

        public string IdComment { get; set; }

        public string Rating { get; set; }

        public string IdTrip { get; set; }

        public DateTime Date { get; set; }
    }
}
