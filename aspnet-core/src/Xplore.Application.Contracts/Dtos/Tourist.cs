﻿using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos; 

namespace Xplore.Models
{
    public partial class TouristDto: AuditedEntityDto<Guid>
    {
     public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Username { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string Languages { get; set; }

        public string Picture { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string Wilaya { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }
    } public partial class CreateUpdateTouristDto 
    {
     public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Username { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string Languages { get; set; }

        public string Picture { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string Wilaya { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }
    }
}
