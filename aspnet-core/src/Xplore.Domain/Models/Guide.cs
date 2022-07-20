using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Guide : FullAuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Age { get; set; }
        public string Languages { get; set; }
        public int? Rating { get; set; }
        public string Email { get; set; }
    }
}
