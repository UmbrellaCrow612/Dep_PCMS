﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PCMS.API.Data;

#nullable disable

namespace PCMS.API.Migrations.UserDb
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("PCMS.API.BusinessLogic.Models.Audit.TestAudit", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TestAudits");
                });
#pragma warning restore 612, 618
        }
    }
}
