using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SponsorAnAFSer.Models
{
    public class StudentWidget
    {
        [Key]
        public Guid StudentWidgetId { get; set; }
        public string Name { get; set; }
        public string Srn { get; set; }
        public string State { get; set; }
        public string ProgramRefCode { get; set; }
        public string DestinationCountry { get; set; }
        public decimal FundraisingAmount { get; set; }
        public DateTime EndDate { get; set; }
        public string DisplayName { get; set; }
        public string BlogUrl { get; set; }
        public int EnabledStatus { get; set; }
        public decimal AmountRaised { get; set; }

        public virtual ICollection<Donation> Donations { get; set; }
    }

    public class Donation
    {
        [Key]
        public Guid DonationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonationDate { get; set; }
    }
}