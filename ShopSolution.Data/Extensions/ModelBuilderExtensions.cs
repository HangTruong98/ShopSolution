using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.Entities;
using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of ShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of ShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of ShopSolution" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,

                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active

                }

                );
            modelBuilder.Entity<CategoryTranslation>().HasData(

                    new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                    new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                    new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                    new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }

                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,


                }
                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam",
                    Details = "Mô tả sản phẩm",
                    Description = ""
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Men shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt products for men",
                    SeoTitle = "The shirt products for men",
                    Details = "Description for product",
                    Description = ""
                }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    ProductId = 1,
                    CategoryId = 1
                }
                );
            // any guid
            var roleId = new Guid("CCCF417D-88AF-4FAE-9434-ED2464311AA4");
            var adminId = new Guid("7D9B1FA1-56E8-4D15-817A-B1F540C77BC5");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "hangtruong11398@gmail.com",
                NormalizedEmail = "hangtruong11398@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "@Abcd12345"),
                SecurityStamp = string.Empty,
                FirstName = "Hang",
                LastName = "Truong",
                Dob = new DateTime(1998, 03, 11)

            }) ;
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
