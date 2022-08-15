using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ImageDto : AuditedEntityDto<Guid>
    {
        public Byte[] Data { get; set; }

        public string Description { get; set; }

        public Guid TripId { get; set; }
        // public TripDto Trip { get; set; }
    }

    public partial class CreateUpdateImageDto
    {
        [Required]
        public Guid TripId { get; set; }

        public Byte[] Data { get; set; }

        public string Description { get; set; }
    }
}
