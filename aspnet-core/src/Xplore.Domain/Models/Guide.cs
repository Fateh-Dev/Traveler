using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Xplore.Models
{
    public partial class Guide : FullAuditedAggregateRoot<Guid>
    { 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Description { get; set; }
        public string Languages { get; set; }
        public string Picture { get; set;}
        public Gender Gender { get; set;}
        public string PhoneNumber { get; set;}
        public string Country { get; set;}
        public string Wilaya { get; set;}
        public string City { get; set;}
        public int ZipCode { get; set;}
        public string Address { get; set;}
        public string Address2 { get; set;}
        public string Activities { get; set;}
        public string facebook { get; set;}
        public string Instagram { get; set;}
        public string Twitter { get; set;}
        public string Youtube { get; set;}
    }
}
