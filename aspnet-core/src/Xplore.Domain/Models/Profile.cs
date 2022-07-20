﻿using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Profile : FullAuditedAggregateRoot<Guid>
    {
        public int Id { get; set; }
        public string IdPersonne { get; set; }
    }
}
