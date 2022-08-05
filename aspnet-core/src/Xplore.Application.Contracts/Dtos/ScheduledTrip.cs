using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ScheduledTripDto : AuditedEntityDto<Guid>
    {
        public DateTime? Date { get; set; }

        public string Description { get; set; }

        public Guid TripId { get; set; }

        public TripDto Trip { get; set; }

        public ICollection<PriceDto> Prices { get; set; }

        public ICollection<ReviewDto> Reviews { get; set; }

        public ICollection<SubscribeAtDto> subscribedTourists { get; set; }
    }

    public partial class CreateUpdateScheduledTripDto
    {
        public DateTime? Date { get; set; }

        public string Description { get; set; }

        public Guid TripId { get; set; }
    }
}
