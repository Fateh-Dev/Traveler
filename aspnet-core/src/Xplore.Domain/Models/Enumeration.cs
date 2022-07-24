using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Enumeration : FullAuditedAggregateRoot<Guid>
    { 
        public string Code { get; set; }
        public string Value { get; set; }
        public string DisplayEn { get; set; }
        public string DisplayAn { get; set; }
        public string DisplayFr { get; set; }
        public EnumType Type { get; set; }
    }
}
