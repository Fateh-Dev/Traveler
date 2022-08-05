using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class SubscribeAtDto : AuditedEntityDto<Guid>
    {
        public Guid ScheduledTripId { get; set; }

        public ScheduledTripDto ScheduledTrip { get; set; }

        public Guid TouristId { get; set; }

        public TouristDto Tourist { get; set; }
    }

    public partial class CreateUpdateSubscribeAtDto
    {
        public Guid ScheduledTripId { get; set; }

        public Guid TouristId { get; set; }
    }
}
