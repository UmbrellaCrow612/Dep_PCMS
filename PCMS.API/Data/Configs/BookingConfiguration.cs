﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCMS.API.Models;

namespace PCMS.API.Data.Configs
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User).WithMany(x => x.CreatedBookings).HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Person).WithMany(x => x.Bookings).HasForeignKey(x => x.PersonId);

            builder.HasMany(x => x.Charges).WithOne(x => x.Booking).HasForeignKey(x => x.BookingId);

            builder.HasOne(x => x.Release).WithOne(x => x.Booking).HasForeignKey<Booking>(x => x.ReleaseId);

            builder.HasOne(x => x.Location).WithMany(x => x.Bookings).HasForeignKey(x => x.LocationId);
        }
    }
}