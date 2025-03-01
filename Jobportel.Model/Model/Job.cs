﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Jobportel.Data.Model
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public  DateTime EndAt { get; set; }
        public bool IsActive { get; set; }
    }
}
