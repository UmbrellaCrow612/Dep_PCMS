﻿using System.ComponentModel.DataAnnotations;

namespace PCMS.API.Dtos.POST
{
    /// <summary>
    /// DTO for POST a department object
    /// </summary>
    public class POSTDepartment
    {
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required]
        [StringLength(250)]
        public required string Description { get; set; }

        [Required]
        [StringLength(20)]
        public required string ShortCode { get; set; }
    }
}