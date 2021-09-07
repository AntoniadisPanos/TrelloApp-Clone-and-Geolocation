namespace WebApplication5.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication5.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication5.Models.ApplicationDbContext context)
        {


            Country c1 = new Country() { Name = "Greece" };
            Country c2 = new Country() { Name = "France" };

            Country c3 = new Country() { Name = "Egypt" };
            Country c4 = new Country() { Name = "Kongo" };

            Category cat1 = new Category() { Name = "Europe", Countries = new List<Country>() { c1, c2 } };
            Category cat2 = new Category() { Name = "Africa", Countries = new List<Country>() { c3, c4 } };
            Category cat3 = new Category() { Name = "UnClassified", Countries = new List<Country>() { } };

            List<Country> countries = new List<Country>() { c1, c2, c3, c4 };
            List<Category> categories = new List<Category>() { cat1, cat2, cat3 };

            foreach (var country in countries)
            {
                context.Countries.AddOrUpdate(x => x.Name, country);
            }

            foreach (var category in categories)
            {
                context.Categories.AddOrUpdate(x => x.Name, category);
            }
            context.SaveChanges();


            Shop s1 = new Shop() { Name = "Bakery", Lat = -33.727111M, Lng = 175.790222M };
            Shop s2 = new Shop() { Name = "Patissery", Lat = -34.227111M, Lng = 176.790222M };
            Shop s3 = new Shop() { Name = "Restaurant", Lat = -35.727111M, Lng = 172.790222M };
            Shop s4 = new Shop() { Name = "Fanouropita", Lat = -33.727111M, Lng = 174.790222M };

            List<Shop> shops = new List<Shop>() { s1,s2,s3,s4 };


            foreach (var shop in shops)
            {
                context.Shops.AddOrUpdate(x => x.Name, shop);
            }
            context.SaveChanges();



        }
    }
}
