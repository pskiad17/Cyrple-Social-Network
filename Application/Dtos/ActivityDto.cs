﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Application.Dtos
{
    public class ActivityDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }

        [JsonProperty("attendees")]
        public ICollection<AttendeeDto> UserActivities { get; set; }
    }
}
