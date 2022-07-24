using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class CommentDto : AuditedEntityDto<Guid>
    {
        public string Description { get; set; }
    }

    public partial class CreateUpdateCommentDto
    {
        [Required]
        [StringLength(2000)]
        public string Description { get; set; }
    }
}
