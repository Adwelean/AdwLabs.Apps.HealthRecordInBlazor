using AdwLabs.Apps.HealthRecord.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdwLabs.Apps.HealthRecord.Shared
{
    public class HealthRecord
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public Sex Sex { get; set; }
        public double BirthWeight { get; set; }
    }
}
