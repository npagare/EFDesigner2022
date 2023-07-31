﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Testing;

#nullable disable

namespace Testing.Migrations
{
    [DbContext(typeof(EFModel1))]
    [Migration("20230626162050_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity1Entity2", b =>
                {
                    b.Property<long>("Entity2_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Entity1_Id")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Entity1_Property1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Entity2_Id", "Entity1_Id", "Entity1_Property1");

                    b.HasIndex("Entity1_Id", "Entity1_Property1");

                    b.ToTable("Entity2_x_Entity1", "dbo");
                });

            modelBuilder.Entity("Testing.Entity1", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<Guid>("Property1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id", "Property1");

                    b.ToTable("Entity1", "dbo");
                });

            modelBuilder.Entity("Testing.Entity2", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Entity2", "dbo");
                });

            modelBuilder.Entity("Entity1Entity2", b =>
                {
                    b.HasOne("Testing.Entity2", null)
                        .WithMany()
                        .HasForeignKey("Entity2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Testing.Entity1", null)
                        .WithMany()
                        .HasForeignKey("Entity1_Id", "Entity1_Property1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
