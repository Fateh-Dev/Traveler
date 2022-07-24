using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos; 

namespace Xplore.Models
{
    public partial class PriceDto: AuditedEntityDto<Guid>
    { 
        public PriceCategory Category { get; set; }
        public decimal? Price1 { get; set; }
        public string IdTrip { get; set; }
    }
    public partial class CreateUpdatePriceDto
    { 
        public PriceCategory Category { get; set; }=PriceCategory.Adult;
        public decimal? Price1 { get; set; }
        public string IdTrip { get; set; }
    }
}
