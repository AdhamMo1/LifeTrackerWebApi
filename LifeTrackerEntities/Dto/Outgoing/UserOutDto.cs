﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTrackerEntities.Dto.Outgoing
{
    public class UserOutDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
