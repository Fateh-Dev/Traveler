using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class GuideDto : AuditedEntityDto<Guid>
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }

    public partial class CreateUpdateGuideDto
    {
        [Required]
        [StringLength(128)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(128)]
        public string Lastname { get; set; }
    }
}
