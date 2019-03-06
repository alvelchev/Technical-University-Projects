﻿// <auto-generated />
using System;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab5.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20190116144335_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab4.Models.Category", b =>
                {
                    b.Property<int>("CategoryID");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryID = 1, CategoryName = "Грижа за тялото" },
                        new { CategoryID = 2, CategoryName = "Грижа за кожата" },
                        new { CategoryID = 3, CategoryName = "Грижа за косата" }
                    );
                });

            modelBuilder.Entity("Lab4.Models.Product", b =>
                {
                    b.Property<int>("ProductID");

                    b.Property<int>("CategoryID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000);

                    b.Property<string>("ImagePath");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double?>("UnitPrice");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ProductID = 1, CategoryID = 1, Description = "Мега доза, XXL 1000 мл", ImagePath = "images/b1.jpg", ProductName = "Пяна за вана", UnitPrice = 7.5 },
                        new { ProductID = 2, CategoryID = 1, Description = "Режим 'Събуди се', XL 500 мл", ImagePath = "images/b2.jpg", ProductName = "Ободряваш душ", UnitPrice = 2.79 },
                        new { ProductID = 3, CategoryID = 1, Description = "Сециални продукти с джинджифил и бял чай", ImagePath = "images/b3.jpg", ProductName = "Грижа за крака", UnitPrice = 4.9 },
                        new { ProductID = 4, CategoryID = 1, Description = "Козметика за оформяне на тялото", ImagePath = "images/b4.jpg", ProductName = "Естествена грижа", UnitPrice = 4.9 },
                        new { ProductID = 5, CategoryID = 1, Description = "11 различни ухания за сензационен душ", ImagePath = "images/b5.jpg", ProductName = "Романтичен душ", UnitPrice = 3.99 },
                        new { ProductID = 6, CategoryID = 1, Description = "Подранващи кремове за ръце", ImagePath = "images/b6.jpg", ProductName = "Грижа за ръце", UnitPrice = 4.9 },
                        new { ProductID = 7, CategoryID = 2, Description = "Очертават прецизни линии и перфектно подчертават очите", ImagePath = "images/f1.jpg", ProductName = "Течна очна линия", UnitPrice = 6.9 },
                        new { ProductID = 8, CategoryID = 2, Description = "Максимално обемни мигли - до 15x пъти повече обем", ImagePath = "images/f2.jpg", ProductName = "Спирала", UnitPrice = 9.9 },
                        new { ProductID = 9, CategoryID = 2, Description = "Значително по-стегнат и по-младежки видна кожата само след две седмици", ImagePath = "images/f3.jpg", ProductName = "Крем за лице", UnitPrice = 26.0 },
                        new { ProductID = 10, CategoryID = 2, Description = "Нежен блясък и хидратация, лек цвят и грижа", ImagePath = "images/f4.jpg", ProductName = "Грим за лице", UnitPrice = 5.9 },
                        new { ProductID = 11, CategoryID = 2, Description = "Диамантен блясък, матиран цвят и хидратиращо усещане", ImagePath = "images/f5.jpg", ProductName = "Сенки за очи и грим", UnitPrice = 4.9 },
                        new { ProductID = 12, CategoryID = 2, Description = "Блестящ цвят без изсушване на устните", ImagePath = "images/f6.jpg", ProductName = "Червила", UnitPrice = 6.9 },
                        new { ProductID = 13, CategoryID = 3, Description = "Професионален ефект -дълготраен цвят, 100% покритие на белите коси", ImagePath = "images/h1.jpg", ProductName = "Боя за коса", UnitPrice = 8.9 },
                        new { ProductID = 14, CategoryID = 3, Description = "Аксесоари за оформяне на прическа", ImagePath = "images/h2.jpg", ProductName = "Нова прическа", UnitPrice = 2.9 },
                        new { ProductID = 15, CategoryID = 3, Description = "Четки за лесно разресване и изправяне на коса", ImagePath = "images/h3.jpg", ProductName = "Четка за коса", UnitPrice = 5.9 },
                        new { ProductID = 16, CategoryID = 3, Description = "Балсами и шампоани за коса за блясък, обем, възстановяване и против пърхут", ImagePath = "images/h4.jpg", ProductName = "Балсами и шампоани", UnitPrice = 5.0 },
                        new { ProductID = 17, CategoryID = 3, Description = "Терапия с арганово масло", ImagePath = "images/h5.jpg", ProductName = "Шампоан за здрава коса", UnitPrice = 4.5 },
                        new { ProductID = 18, CategoryID = 3, Description = "Най-добрата грижа за красива прическа", ImagePath = "images/h6.jpg", ProductName = "Луксозна терапия", UnitPrice = 5.5 }
                    );
                });

            modelBuilder.Entity("Lab4.Models.Product", b =>
                {
                    b.HasOne("Lab4.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
