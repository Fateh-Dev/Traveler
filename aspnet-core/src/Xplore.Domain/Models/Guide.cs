using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using Volo.Abp;
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

        public string Picture { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; } 

        public Wilaya Wilaya { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }

        public string Activities { get; set; }

        public string facebook { get; set; }

        public string Instagram { get; set; }

        public string Twitter { get; set; }

        public string Youtube { get; set; }

        // [JsonIgnore]
        public virtual ICollection<Trip> Trips { get; set; }

        public Guide()
        {
        }

        public Guide(
            Guid id,
            [NotNull] string Firstname,
            [NotNull] string Lastname,
            DateTime birthday
        ) :
            base(id)
        {
            SetName (Firstname, Lastname);
            Birthday = birthday;
        }

        public void SetName(
            [NotNull] string Firstname,
            [NotNull] string Lastname
        )
        {
            Firstname =
                Check
                    .NotNullOrWhiteSpace(Firstname,
                    nameof(Firstname),
                    maxLength: 50);
            Lastname =
                Check
                    .NotNullOrWhiteSpace(Lastname,
                    nameof(Lastname),
                    maxLength: 50);
        }
    }
}
