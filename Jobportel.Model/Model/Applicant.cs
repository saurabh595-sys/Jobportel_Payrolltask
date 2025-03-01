﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Jobportel.Data.Model
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        public int  jobId { get; set; }
        public int AppliedBy { get; set; }
        public DateTime AppliedAt { get; set; }
        public bool isActive { get; set; }
    }
}
