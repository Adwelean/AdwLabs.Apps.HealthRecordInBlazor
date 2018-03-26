using AdwLabs.Apps.HealthRecord.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HRecord = AdwLabs.Apps.HealthRecord.Shared.HealthRecord;

namespace AdwLabs.Apps.HealthRecord.Server.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("[action]")]
        public HRecord GetSampleHealthRecord()
        {
            return new HRecord() { Name = "John", LastName = "Doe", PlaceOfBirth = "nowhere", DateOfBirth = new DateTime(2000, 01, 01, 00, 42, 00), Sex = Shared.Enums.Sex.Male, BirthWeight = 4.2 };
        }
    }
}
