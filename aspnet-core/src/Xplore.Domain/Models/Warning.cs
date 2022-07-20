using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Warning : FullAuditedAggregateRoot<Guid>
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
