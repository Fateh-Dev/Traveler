using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ImageDto : AuditedEntityDto<Guid>
    {
        public string IdTrip { get; set; }
    }

    public partial class CreateUpdateImageDto
    {
        [Required]
        public string IdTrip { get; set; }
    }
}
