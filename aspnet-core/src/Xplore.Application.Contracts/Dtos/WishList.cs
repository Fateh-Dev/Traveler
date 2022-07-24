using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class WishListDto : AuditedEntityDto<Guid>
    {
        public string IdTrip { get; set; }

        public string IdTourist { get; set; }
    }

    public partial class CreateUpdateWishListDto
    {
        public string IdTrip { get; set; }

        public string IdTourist { get; set; }
    }
}
