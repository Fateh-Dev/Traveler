using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos; 

namespace Xplore.Models
{
    public partial class SubscribeAtDto: AuditedEntityDto<Guid>
    {
        public string IdTrip { get; set; }
        public string IdTourist { get; set; }
        public DateTime? Date { get; set; }
    } public partial class CreateUpdateSubscribeAtDto
    {
        public string IdTrip { get; set; }
        public string IdTourist { get; set; }
        public DateTime? Date { get; set; }
    }
}
