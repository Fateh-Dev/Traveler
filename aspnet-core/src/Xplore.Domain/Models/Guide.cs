using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Guide : FullAuditedAggregateRoot<Guid>
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Age { get; set; }
        public string Languages { get; set; }
        public string Rating { get; set; }
        public string Email { get; set; }
    }
}
