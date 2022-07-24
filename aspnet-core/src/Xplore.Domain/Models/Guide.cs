using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Guide : FullAuditedAggregateRoot<Guid>
    { 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
