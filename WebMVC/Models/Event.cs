﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public decimal Fee { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }
        public string EventStartTime { get; set; }
        public string EventEndTime { get; set; }
        public string Location { get; set; }
        public string EventImageUrl { get; set; }  
        public string Created { get; set; }
        public string Address { get; set; }
        public int EventCategoryId { get; set; }
        public int EventSubCatagoryId{ get; set; }
       
    }
}
