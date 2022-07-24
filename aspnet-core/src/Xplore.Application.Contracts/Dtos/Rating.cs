using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class RatingDto : AuditedEntityDto<Guid>
    {
        public string Value { get; set; }

        public RatingType Type { get; set; }

        public string IdReview { get; set; }
    }

    public partial class CreateUpdateRatingDto
    {
        [Required]
        [StringLength(128)]
        public string Value { get; set; }

        [Required]
        public RatingType Type { get; set; } = RatingType.Guide;

        public string IdReview { get; set; }
    }
}
