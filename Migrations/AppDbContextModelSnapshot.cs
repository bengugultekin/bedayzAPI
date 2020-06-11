﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bedayzAPI.Persistence.Contexts;

namespace bedayzAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("bedayzAPI.Core.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("bedayzAPI.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "deneme1@gmail.com",
                            LastName = "DSoyad1",
                            Name = "Deneme1",
                            Password = "1234",
                            UserName = "deneme1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "deneme2@gmail.com",
                            LastName = "DSoyad2",
                            Name = "Deneme2",
                            Password = "4567",
                            UserName = "deneme2"
                        });
                });

            modelBuilder.Entity("bedayzAPI.Core.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Name = "T-SHIRTS"
                        },
                        new
                        {
                            Id = 101,
                            Name = "HOODIES"
                        },
                        new
                        {
                            Id = 102,
                            Name = "AKSESUAR"
                        });
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Name = "TeoriV2-106687_large.jpg",
                            ProductId = 100,
                            Url = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/gold-vintage-kolye-de93.jpg"
                        },
                        new
                        {
                            Id = 101,
                            Name = "TeoriV2-97788_large.jpg",
                            ProductId = 101,
                            Url = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/silver-vintage-kolye-8181.jpg"
                        },
                        new
                        {
                            Id = 102,
                            Name = "TeoriV2-106613_large.jpg",
                            ProductId = 102,
                            Url = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/quarantine-t-shirt-7983.jpg"
                        },
                        new
                        {
                            Id = 103,
                            Name = "TeoriV2-105445-7_large.jpg",
                            ProductId = 103,
                            Url = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/betterdayz-oversize-t-shirt-b9f9.jpg"
                        },
                        new
                        {
                            Id = 104,
                            Name = "TeoriV2-106597_large.jpg",
                            ProductId = 104,
                            Url = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/tokyo-oversize-t-shirt-8171.jpg"
                        },
                        new
                        {
                            Id = 105,
                            Name = "TeoriV2-105271-4_large.jpg",
                            ProductId = 105,
                            Url = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/red-munchies-oversize-t-shirt-d1b2.jpg"
                        });
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cost")
                        .HasColumnType("REAL");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("KargoFiyatı")
                        .HasColumnType("REAL");

                    b.Property<byte>("Marka")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("NumberInStock")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PreviousCost")
                        .HasColumnType("REAL");

                    b.Property<byte>("Tag")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ToplamSiparisSayisi")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            CategoryId = 102,
                            Cost = 45.0,
                            Info = "GOLD VINTAGE",
                            KargoFiyatı = 0.0,
                            Marka = (byte)1,
                            Name = "GOLD VINTAGE KOLYE",
                            NumberInStock = 15,
                            PreviousCost = 50.0,
                            Tag = (byte)1,
                            ToplamSiparisSayisi = 0,
                            Url = "https://www.bedayz.com/gold-vintage-kolye"
                        },
                        new
                        {
                            Id = 101,
                            CategoryId = 102,
                            Cost = 45.0,
                            Info = "SILVER VINTAGE",
                            KargoFiyatı = 0.0,
                            Marka = (byte)1,
                            Name = "SILVER VINTAGE KOLYE",
                            NumberInStock = 9,
                            PreviousCost = 50.0,
                            Tag = (byte)3,
                            ToplamSiparisSayisi = 0,
                            Url = "https://www.bedayz.com/silver-vintage-kolye"
                        },
                        new
                        {
                            Id = 102,
                            CategoryId = 100,
                            Cost = 90.0,
                            Info = "BLUE",
                            KargoFiyatı = 0.0,
                            Marka = (byte)1,
                            Name = "QUARANTINE T-SHIRT",
                            NumberInStock = 10,
                            PreviousCost = 100.0,
                            Tag = (byte)1,
                            ToplamSiparisSayisi = 0,
                            Url = "https://www.bedayz.com/quarantine-t-shirt"
                        },
                        new
                        {
                            Id = 103,
                            CategoryId = 100,
                            Cost = 100.0,
                            Info = "BLACK",
                            KargoFiyatı = 0.0,
                            Marka = (byte)1,
                            Name = "BETTERDAYZ OVERSIZE T-SHIRT ",
                            NumberInStock = 8,
                            PreviousCost = 5000.0,
                            Tag = (byte)3,
                            ToplamSiparisSayisi = 0,
                            Url = "https://www.bedayz.com/betterdayz-oversize-t-shirt"
                        },
                        new
                        {
                            Id = 104,
                            CategoryId = 100,
                            Cost = 110.0,
                            Info = "WHITE",
                            KargoFiyatı = 0.0,
                            Marka = (byte)1,
                            Name = "TOKYO OVERSIZE T-SHIRT ",
                            NumberInStock = 15,
                            PreviousCost = 150.0,
                            Tag = (byte)2,
                            ToplamSiparisSayisi = 0,
                            Url = "https://www.bedayz.com/tokyo-oversize-t-shirt"
                        },
                        new
                        {
                            Id = 105,
                            CategoryId = 100,
                            Cost = 90.0,
                            Info = "RED",
                            KargoFiyatı = 0.0,
                            Marka = (byte)1,
                            Name = "RED MUNCHIES OVERSIZE T - SHIRT",
                            NumberInStock = 3,
                            PreviousCost = 100.0,
                            Tag = (byte)2,
                            ToplamSiparisSayisi = 0,
                            Url = "https://www.bedayz.com/red-munchies-oversize-t-shirt"
                        });
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Sepet", b =>
                {
                    b.Property<int>("SepetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Adet")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SepeteKonulmaTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SepetId");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserId");

                    b.ToTable("Sepet");

                    b.HasData(
                        new
                        {
                            SepetId = 1,
                            Adet = 1,
                            ProductID = 100,
                            SepeteKonulmaTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            SepetId = 2,
                            Adet = 1,
                            ProductID = 101,
                            SepeteKonulmaTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Siparis", b =>
                {
                    b.Property<int>("SiparisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Adet")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SiparisTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SiparisId");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserId");

                    b.ToTable("Siparis");

                    b.HasData(
                        new
                        {
                            SiparisId = 1,
                            Adet = 1,
                            ProductID = 100,
                            SiparisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            SiparisId = 2,
                            Adet = 1,
                            ProductID = 101,
                            SiparisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("bedayzAPI.Core.Models.UserRole", b =>
                {
                    b.HasOne("bedayzAPI.Core.Models.Role", "Role")
                        .WithMany("UsersRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bedayzAPI.Core.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Image", b =>
                {
                    b.HasOne("bedayzAPI.Domain.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Product", b =>
                {
                    b.HasOne("bedayzAPI.Domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Sepet", b =>
                {
                    b.HasOne("bedayzAPI.Domain.Models.Product", "Product")
                        .WithMany("Sepetler")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bedayzAPI.Core.Models.User", "User")
                        .WithMany("Sepetler")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bedayzAPI.Domain.Models.Siparis", b =>
                {
                    b.HasOne("bedayzAPI.Domain.Models.Product", "Product")
                        .WithMany("Siparisler")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bedayzAPI.Core.Models.User", "User")
                        .WithMany("Siparisler")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
