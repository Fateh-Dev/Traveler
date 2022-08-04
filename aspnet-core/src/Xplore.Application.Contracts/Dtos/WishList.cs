using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class WishListDto : AuditedEntityDto<Guid>
    {
        public Guid IdTrip { get; set; }
        public TripDto Trip { get; set; }

        public Guid IdTourist { get; set; }
        public TouristDto Tourist { get; set; }
    }

    public partial class CreateUpdateWishListDto
    {
        public Guid IdTrip { get; set; }

        public Guid IdTourist { get; set; }
    }
}
