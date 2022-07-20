﻿using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Comment : FullAuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
