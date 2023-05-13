﻿// <auto-generated />
using CoffeeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeShop.Migrations
{
    [DbContext(typeof(CoffeeShopDbContext))]
    partial class CoffeeShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoffeeShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrendingProduct")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Detail = "The Americano coffee is a classic espresso-based drink.",
                            ImageUrl = "https://images.unsplash.com/photo-1509042239860-f550ce710b93?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = true,
                            Name = "Americano",
                            Price = 7m
                        },
                        new
                        {
                            Id = 2,
                            Detail = "Cortado coffee is a traditional Spanish coffee beverage.",
                            ImageUrl = "https://images.unsplash.com/photo-1542312594-641a1d9a4d63?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29ydGFkb3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = true,
                            Name = "Cortado",
                            Price = 9m
                        },
                        new
                        {
                            Id = 3,
                            Detail = "Mocha coffee is a rich and creamy blend.",
                            ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = false,
                            Name = "Mocha",
                            Price = 8m
                        },
                        new
                        {
                            Id = 4,
                            Detail = "Macchiato coffee is a classic beverage that is rich and creamy.",
                            ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = true,
                            Name = "Macchiato",
                            Price = 8m
                        },
                        new
                        {
                            Id = 5,
                            Detail = "Flat White is a staple in the coffee drink arena.",
                            ImageUrl = "https://images.unsplash.com/photo-1497636577773-f1231844b336?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8ZmxhdCUyMHdoaXRlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = false,
                            Name = "Flat White",
                            Price = 8m
                        },
                        new
                        {
                            Id = 6,
                            Detail = "Coffee without caffine.",
                            ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = false,
                            Name = "Decaf",
                            Price = 7m
                        },
                        new
                        {
                            Id = 7,
                            Detail = "Irish coffee is a warm, comforting drink with bold flavor.",
                            ImageUrl = "https://images.unsplash.com/photo-1461023058943-07fcbe16d735?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8aXJpc2glMjBjb2ZmZWV8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = false,
                            Name = "Irish Coffee",
                            Price = 9m
                        },
                        new
                        {
                            Id = 8,
                            Detail = "Iced coffee is a refreshing and delicious way to enjoy coffee.",
                            ImageUrl = "https://images.unsplash.com/photo-1517701550927-30cf4ba1dba5?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8aWNlZCUyMGNvZmZlZXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            IsTrendingProduct = false,
                            Name = "Iced Coffee",
                            Price = 7m
                        });
                });

            modelBuilder.Entity("CoffeeShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("CoffeeShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CoffeeShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
