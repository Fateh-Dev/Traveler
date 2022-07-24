using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class ScheduleDto : AuditedEntityDto<Guid>
    {
        public string IdTrip { get; set; }

        public string IdGuide { get; set; }

        public DateTime? Date { get; set; }
    }

    public partial class CreateUpdateScheduleDto
    {
        public string IdTrip { get; set; }

        public string IdGuide { get; set; }

        public DateTime? Date { get; set; }
    }
}
