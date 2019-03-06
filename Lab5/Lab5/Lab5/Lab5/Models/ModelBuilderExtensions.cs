using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Пяна за вана", Description = "Мега доза, XXL 1000 мл", ImagePath = "images/b1.jpg", UnitPrice = 7.50, CategoryID = 1 },
                new Product { ProductID = 2, ProductName = "Ободряваш душ", Description = "Режим 'Събуди се', XL 500 мл", ImagePath = "images/b2.jpg", UnitPrice = 2.79, CategoryID = 1 },
                new Product { ProductID = 3, ProductName = "Грижа за крака", Description = "Сециални продукти с джинджифил и бял чай", ImagePath = "images/b3.jpg", UnitPrice = 4.90, CategoryID = 1 },
                new Product { ProductID = 4, ProductName = "Естествена грижа", Description = "Козметика за оформяне на тялото", ImagePath = "images/b4.jpg", UnitPrice = 4.90, CategoryID = 1 },
                new Product { ProductID = 5, ProductName = "Романтичен душ", Description = "11 различни ухания за сензационен душ", ImagePath = "images/b5.jpg", UnitPrice = 3.99, CategoryID = 1 },
                new Product { ProductID = 6, ProductName = "Грижа за ръце", Description = "Подранващи кремове за ръце", ImagePath = "images/b6.jpg", UnitPrice = 4.90, CategoryID = 1 },
                new Product { ProductID = 7, ProductName = "Течна очна линия", Description = "Очертават прецизни линии и перфектно подчертават очите", ImagePath = "images/f1.jpg", UnitPrice = 6.90, CategoryID = 2 },
                new Product { ProductID = 8, ProductName = "Спирала", Description = "Максимално обемни мигли - до 15x пъти повече обем", ImagePath = "images/f2.jpg", UnitPrice = 9.90, CategoryID = 2 },
                new Product { ProductID = 9, ProductName = "Крем за лице", Description = "Значително по-стегнат и по-младежки видна кожата само след две седмици", ImagePath = "images/f3.jpg", UnitPrice = 26.00, CategoryID = 2 },
                new Product { ProductID = 10, ProductName = "Грим за лице", Description = "Нежен блясък и хидратация, лек цвят и грижа", ImagePath = "images/f4.jpg", UnitPrice = 5.90, CategoryID = 2 },
                new Product { ProductID = 11, ProductName = "Сенки за очи и грим", Description = "Диамантен блясък, матиран цвят и хидратиращо усещане", ImagePath = "images/f5.jpg", UnitPrice = 4.90, CategoryID = 2 },
                new Product { ProductID = 12, ProductName = "Червила", Description = "Блестящ цвят без изсушване на устните", ImagePath = "images/f6.jpg", UnitPrice = 6.90, CategoryID = 2 },
                new Product { ProductID = 13, ProductName = "Боя за коса", Description = "Професионален ефект -дълготраен цвят, 100% покритие на белите коси", ImagePath = "images/h1.jpg", UnitPrice = 8.90, CategoryID = 3 },
                new Product { ProductID = 14, ProductName = "Нова прическа", Description = "Аксесоари за оформяне на прическа", ImagePath = "images/h2.jpg", UnitPrice = 2.90, CategoryID = 3 },
                new Product { ProductID = 15, ProductName = "Четка за коса", Description = "Четки за лесно разресване и изправяне на коса", ImagePath = "images/h3.jpg", UnitPrice = 5.90, CategoryID = 3 },
                new Product { ProductID = 16, ProductName = "Балсами и шампоани", Description = "Балсами и шампоани за коса за блясък, обем, възстановяване и против пърхут", ImagePath = "images/h4.jpg", UnitPrice = 5.00, CategoryID = 3 },
                new Product { ProductID = 17, ProductName = "Шампоан за здрава коса", Description = "Терапия с арганово масло", ImagePath = "images/h5.jpg", UnitPrice = 4.50, CategoryID = 3 },
                new Product { ProductID = 18, ProductName = "Луксозна терапия", Description = "Най-добрата грижа за красива прическа", ImagePath = "images/h6.jpg", UnitPrice = 5.50, CategoryID = 3 }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Грижа за тялото" },
                new Category { CategoryID = 2, CategoryName = "Грижа за кожата" },
                new Category { CategoryID = 3, CategoryName = "Грижа за косата" }
            );

        }
    }
}
