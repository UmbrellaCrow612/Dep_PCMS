﻿using Microsoft.EntityFrameworkCore;
using PCMS.API.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PCMS.API.Models
{
    /// <summary>
    /// Represents evidence in the system.
    /// </summary>
    [Index(nameof(Id), IsUnique = true)]
    public class Evidence : ISoftDeletable, IAuditable
    {
        [Key]
        public string Id { get; } = Guid.NewGuid().ToString();

        [Required]
        public required string FileUrl { get; set; }

        [Required]
        public required string Type { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required string Location { get; set; }

        [Required]
        public required string CollectedByDetails { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public required DateTime CollectionDateTime { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedAtUtc { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

        public DateTime? LastModifiedAtUtc { get; set; }


        [Required]
        public required string CaseId { get; set; }

        public Case? Case { get; set; } = null!;

        public string? DeletedById { get; set; }

        public ApplicationUser? UserWhoDeleted { get; set; }

        [Required]
        public required string CreatedById { get; set; }

        public ApplicationUser? Creator { get; set; }

        public string? LastModifiedById { get; set; }

        public ApplicationUser? LastModifiedBy { get; set; }
    }
}