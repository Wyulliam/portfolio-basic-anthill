﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nursery.Data;

namespace Nursery.Data.Migrations
{
    [DbContext(typeof(NurseryContext))]
    [Migration("20190706143029_Changing DueDate to GeneratedDate")]
    partial class ChangingDueDatetoGeneratedDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Nursery.Core.AntTypes.Entities.AntType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("AntTypes");
                });

            modelBuilder.Entity("Nursery.Core.Eggs.Entities.Eggs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GeneratedDate");

                    b.Property<int>("Quantity");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Eggs");
                });
#pragma warning restore 612, 618
        }
    }
}
