using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ScheduleDto : AuditedEntityDto<Guid>
    {
        public Guid IdTrip { get; set; }
        public TripDto Trip { get; set; }

        public Guid IdGuide { get; set; }
        public GuideDto Guide { get; set; }

        public DateTime? Date { get; set; }
    }

    public partial class CreateUpdateScheduleDto
    {
        public Guid IdTrip { get; set; }

        public Guid IdGuide { get; set; }

        public DateTime? Date { get; set; }
    }
}
