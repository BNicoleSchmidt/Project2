﻿using System;

namespace MeramecNetFlixProject.BusinessObjects
{
    public class Member
    {
        public int Id { get; set; }
        public DateTime JoinDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string Phone { get; set; }
        public string MemberStatus { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ContactMethod { get; set; }
        public int SubscriptionId { get; set; }
        public string Photo { get; set; }
        public bool IsAdmin { get; set; }
    }
}
