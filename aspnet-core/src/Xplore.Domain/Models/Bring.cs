﻿using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Bring : FullAuditedAggregateRoot<Guid>
    {
        public Guid IdStuff { get; set; }
        public Guid IdTrip { get; set; }
    }
}
