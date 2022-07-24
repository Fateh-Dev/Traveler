using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos; 

namespace Xplore.Models
{
    public partial class TouristDto: AuditedEntityDto<Guid>
    {
 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
    } public partial class CreateUpdateTouristDto 
    {
 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
    }
}
