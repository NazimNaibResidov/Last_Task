using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Test.WebUI.Core.seeded;
using Task_Test.WebUI.Entity;

namespace Task_Test.WebUI.Core.Extension
{
    public static class IncludeMainContextExtension
    {
        public static void SaveContext(this IApplicationBuilder app)
        {
            MainDbContext context = Tools.MainContext(app);
            if (!context.Category.Any())
            {
                context.Category.AddRange(new Category[]
                {
                    new Category(){ Name = "Phone"},
                    new Category(){ Name = "Device"}
                }
                );
                context.SaveChanges();

            }
            if (!context.City.Any())
            {
                context.City.AddRange(new City[] { new City { Name = "Днепр" }, new City() { Name = " Одесса" }, new City() { Name = "Херсон" }, new City() { Name = "Запорожье" }, new City() { Name = "Львов" }, new City() { Name = "Киев" } });
                context.SaveChanges();
            }
            if (!context.Departrues.Any())

            {
                context.Departrues.AddRange(new Departrue[] {
                    new Departrue(){Name="Киев"},
                    new Departrue(){Name="Львов"},
                    new Departrue(){Name="Херсон"},
                    new Departrue(){Name="Одесса"},

                });
                context.SaveChanges();

            }
            if (!context.Arrivals.Any())
            {
                context.Arrivals.AddRange(new Arrival[] {
                    new Arrival(){Name="Одесса" },
                    new Arrival(){Name = "Херсон" } ,
                    new Arrival(){Name = "Львов" },
                    new Arrival(){Name = "Киев" }
                });
                context.SaveChanges();
            }
            if (!context.Product.Any())
            {
                context.Product.AddRange(new Product[]
                {
                    new Product
                {
                    Name = "Bir",
                    Kg = 12000,
                    Stok = 123,
                    Datetime=DateTime.Now,
                    ArrivalId = 1,
                    Departrueid = 2,
                    CategoryId = 1

                },
                    new Product
                {
                    Name = "Iki",
                    Kg = 12000,
                    Stok = 123,
                    Datetime=DateTime.Now,
                    ArrivalId = 2,
                    Departrueid = 1,
                    CategoryId = 1

                },
                    new Product
                {
                    Name = "Uc",
                    Kg = 16000,
                    Stok = 13,
                    Datetime=DateTime.Now,
                    ArrivalId = 3,
                    Departrueid = 2,
                    CategoryId = 1

                },
                    new Product
                {
                    Name = "Dord",
                    Kg = 40000,
                    Stok = 135,
                    Datetime=DateTime.Now,
                    ArrivalId = 3,
                    Departrueid = 3,
                    CategoryId = 1

                },
                    new Product
                {
                    Name = "Bes",
                    Kg = 19000,
                    Stok = 110,
                    Datetime=DateTime.Now,
                    ArrivalId = 4,
                    Departrueid = 3,
                    CategoryId = 1

                },
                    new Product
                {
                    Name = "Alti",
                    Kg = 18000,
                    Stok = 10,
                    Datetime=DateTime.Now,
                    ArrivalId = 4,
                    Departrueid = 4,
                    CategoryId = 2

                }
                });
                context.SaveChanges();
            }
            
        }
    }
}
