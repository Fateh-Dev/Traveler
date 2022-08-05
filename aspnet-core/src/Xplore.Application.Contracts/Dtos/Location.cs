using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Xplore.Models
{
    public partial class LocationDto : AuditedEntityDto<Guid>
    {
        public string Description { get; set; }

        public string GpsLocation { get; set; }

        public Guid TripId { get; set; }
        // public TripDto Trip { get; set; }

        public LocationType Type { get; set; }

        public int? Order { get; set; }
    }

    public partial class CreateUpdateLocationDto
    {
        [Required]
        [StringLength(128)]
        public string Description { get; set; }

        [Required]
        [StringLength(128)]
        public string GpsLocation { get; set; }

        [Required]
        public Guid TripId { get; set; }

        [Required]
        public LocationType Type { get; set; } = LocationType.Undefined;

        public int? Order { get; set; }
    }
}
