﻿using System;

namespace StudentAdminPortal.API.Domainmodel
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        public Guid StudentId { get; set; }
    }
}
