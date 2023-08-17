﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please enter a valid number of days between 1 and 25.")]
        public int DefaultDays { get; set; }
    }
}