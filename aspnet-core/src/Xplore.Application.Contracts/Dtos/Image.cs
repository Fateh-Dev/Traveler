using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ImageDto : AuditedEntityDto<Guid>
    {
        public string Url { get; set; }

        public string Description { get; set; }
        public Guid IdTrip { get; set; }
        public TripDto Trip { get; set; }
    }

    public partial class CreateUpdateImageDto
    {
        [Required]
        public Guid IdTrip { get; set; }
        public string Url { get; set; }

        public string Description { get; set; }
    }
}
