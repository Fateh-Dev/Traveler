﻿using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class NotAllowedStuff : FullAuditedAggregateRoot<Guid>
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}