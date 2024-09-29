﻿using System.ComponentModel.DataAnnotations;

namespace PCMS.API.Dtos.POST
{
    /// <summary>
    /// DTO when you want to create a Vehicle
    /// </summary>
    public class POSTVehicle
    {
        [Required]
        [MaxLength(100)]
        public required string Make { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [MaxLength(17)]
        public required string VIN { get; set; }

        [Required]
        [MaxLength(20)]
        public required string LicensePlate { get; set; }

        public string? Description { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Color { get; set; }
    }
}
