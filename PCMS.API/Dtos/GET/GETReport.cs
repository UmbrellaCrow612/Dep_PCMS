﻿using PCMS.API.Models;

namespace PCMS.API.DTOS.GET
{
    /// <summary>
    /// DTO for GET a report
    /// </summary>
    public class GETReport
    {
        /// <summary>
        /// Get or set the report ID.
        /// </summary>
        public required string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the report Title.
        /// </summary>
        public required string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the report CreatedById.
        /// </summary>
        public required GETApplicationUser Creator { get; set; }

        /// <summary>
        /// Gets or sets the report LastEditedBy.
        /// </summary>
        public GETApplicationUser? LastEditor { get; set; }

        /// <summary>
        /// Gets or sets the report CreatedAt.
        /// </summary>
        public required DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the report LastModifiedDate.
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the report Details.
        /// </summary>
        public required string Details { get; set; }

        /// <summary>
        /// Gets or sets the report CaseId it is linked to.
        /// </summary>
        public required string CaseId { get; set; }
    }
}