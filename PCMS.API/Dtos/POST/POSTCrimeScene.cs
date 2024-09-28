﻿using System.ComponentModel.DataAnnotations;

namespace PCMS.API.Dtos.POST
{
    /// <summary>
    /// DTO when you want to create a crime scene
    /// </summary>
    public class POSTCrimeScene
    {
        [Required]
        public required string Type { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required DateTime ReportedDateTime { get; set; }

        [Required]
        public required DateTime DiscoveredDateTime { get; set; }
    }
}