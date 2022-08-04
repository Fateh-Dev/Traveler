using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class EnumerationDto : AuditedEntityDto<Guid>
    {
          public string Code { get; set; }
        public string Value { get; set; }
        public string DisplayEn { get; set; }
        public string DisplayAn { get; set; }
        public string DisplayFr { get; set; }
        public EnumType Type { get; set; }
    }

    public partial class CreateUpdateEnumerationDto
    {
        [Required]
        [StringLength(128)]
        public string Code { get; set; }

        [Required]
        [StringLength(128)]
        public string Value { get; set; }

        [Required]
        public EnumType Type { get; set; }
        public string DisplayEn { get; set; }
        public string DisplayAn { get; set; }
        public string DisplayFr { get; set; }
    }
}
