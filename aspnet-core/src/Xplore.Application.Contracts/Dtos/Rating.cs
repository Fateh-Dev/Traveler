using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class RatingDto : AuditedEntityDto<Guid>
    {
        public double Value { get; set; }

        public RatingType Type { get; set; }

        public Guid ReviewId { get; set; }

        public ReviewDto Review { get; set; }
    }

    public partial class CreateUpdateRatingDto
    {
        [Required]
        [StringLength(128)]
        public double Value { get; set; }

        [Required]
        public RatingType Type { get; set; } = RatingType.Guide;

        public Guid ReviewId { get; set; }
    }
}
