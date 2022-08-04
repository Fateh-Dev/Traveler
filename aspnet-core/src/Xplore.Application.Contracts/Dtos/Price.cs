using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos; 

namespace Xplore.Models
{
    public partial class PriceDto: AuditedEntityDto<Guid>
    { 
        public PriceCategory Category { get; set; }
        public decimal? Value { get; set; }
        public Guid IdTrip { get; set; }
        public TripDto Trip { get; set; }
    }
    public partial class CreateUpdatePriceDto
    { 
        public PriceCategory Category { get; set; }=PriceCategory.Adult;
        public decimal? Value { get; set; }
        public Guid IdTrip { get; set; }
    }
}
