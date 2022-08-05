using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class PriceDto : AuditedEntityDto<Guid>
    {
        public PriceCategory Category { get; set; }

        public decimal? Value { get; set; }

        public Guid ScheduledTripId { get; set; }

        public virtual ScheduledTripDto ScheduledTrip { get; set; }
    }

    public partial class CreateUpdatePriceDto
    {
        public PriceCategory Category { get; set; }

        public decimal? Value { get; set; }

        public Guid ScheduledTripId { get; set; }
    }
}
