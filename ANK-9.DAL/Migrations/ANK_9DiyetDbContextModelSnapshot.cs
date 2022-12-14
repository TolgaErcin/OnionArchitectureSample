// <auto-generated />
using System;
using ANK_9.DAL.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ANK_9.DAL.Migrations
{
    [DbContext(typeof(ANK_9DiyetDbContext))]
    partial class ANK_9DiyetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ANK_9.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime2(7)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Süt Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9890),
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Et Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9894),
                            IsActive = true
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "KuruBaklagil Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9895),
                            IsActive = true
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Ekmek Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9895),
                            IsActive = true
                        },
                        new
                        {
                            ID = 5,
                            CategoryName = "Sebze Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9896),
                            IsActive = true
                        },
                        new
                        {
                            ID = 6,
                            CategoryName = "Meyve Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9897),
                            IsActive = true
                        },
                        new
                        {
                            ID = 7,
                            CategoryName = "Yağ Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9927),
                            IsActive = true
                        },
                        new
                        {
                            ID = 8,
                            CategoryName = "Tatlı Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9929),
                            IsActive = true
                        },
                        new
                        {
                            ID = 9,
                            CategoryName = "Kuruyemiş Grubu",
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9929),
                            IsActive = true
                        });
                });

            modelBuilder.Entity("ANK_9.Entities.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("Calorie")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime2(7)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Calorie = 11400.0,
                            CategoryId = 1,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2312),
                            Description = "Bir su bardağı,200 ml",
                            FoodName = "Süt",
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            Calorie = 69000.0,
                            CategoryId = 2,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2315),
                            Description = "1 köfte, 30gr",
                            FoodName = "Kıyma",
                            IsActive = true
                        },
                        new
                        {
                            ID = 3,
                            Calorie = 80000.0,
                            CategoryId = 3,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2333),
                            Description = "4 yemek kaşığı, 25gr",
                            FoodName = "Mercimek",
                            IsActive = true
                        },
                        new
                        {
                            ID = 4,
                            Calorie = 68000.0,
                            CategoryId = 4,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2334),
                            Description = "3 yemek kaşığı, 50gr",
                            FoodName = "Makarna",
                            IsActive = true
                        },
                        new
                        {
                            ID = 5,
                            Calorie = 25000.0,
                            CategoryId = 5,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2335),
                            Description = "4 yemek kaşığı, 200gr",
                            FoodName = "Brokoli(Pişmiş)",
                            IsActive = true
                        },
                        new
                        {
                            ID = 6,
                            Calorie = 60000.0,
                            CategoryId = 6,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2336),
                            Description = "1 küçük boy, 120gr",
                            FoodName = "Elma",
                            IsActive = true
                        },
                        new
                        {
                            ID = 7,
                            Calorie = 45000.0,
                            CategoryId = 7,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2337),
                            Description = "1 tatlı kaşığı, 5gr",
                            FoodName = "Tereyağ",
                            IsActive = true
                        },
                        new
                        {
                            ID = 8,
                            Calorie = 68000.0,
                            CategoryId = 8,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2337),
                            Description = "1 yemek kaşığı, 30gr",
                            FoodName = "Bal",
                            IsActive = true
                        },
                        new
                        {
                            ID = 9,
                            Calorie = 45000.0,
                            CategoryId = 9,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2338),
                            Description = "2 adet, 8gr",
                            FoodName = "Ceviz içi",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("ANK_9.Entities.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime2(7)");

                    b.HasKey("ID");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(971),
                            IsActive = true,
                            MealName = "Kahvaltı"
                        },
                        new
                        {
                            ID = 2,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(973),
                            IsActive = true,
                            MealName = "Öğle Yemeği"
                        },
                        new
                        {
                            ID = 3,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(973),
                            IsActive = true,
                            MealName = "Akşam Yemeği"
                        });
                });

            modelBuilder.Entity("ANK_9.Entities.MealFood", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2(7)");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("Portion")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime2(7)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FoodId");

                    b.HasIndex("MealId");

                    b.HasIndex("UserId");

                    b.ToTable("MealsFoods");
                });

            modelBuilder.Entity("ANK_9.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(130)
                        .HasColumnType("nvarchar(130)");

                    b.Property<string>("UserTypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateOn = new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(8517),
                            Email = "adin@gmail.com",
                            IsActive = true,
                            Password = "admin123",
                            UserName = "admin",
                            UserTypes = "Admin"
                        });
                });

            modelBuilder.Entity("ANK_9.Entities.Food", b =>
                {
                    b.HasOne("ANK_9.Entities.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ANK_9.Entities.MealFood", b =>
                {
                    b.HasOne("ANK_9.Entities.Food", "Food")
                        .WithMany("MealFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ANK_9.Entities.Meal", "Meal")
                        .WithMany("MealFoods")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ANK_9.Entities.User", "User")
                        .WithMany("MealFoods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Meal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ANK_9.Entities.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("ANK_9.Entities.Food", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("ANK_9.Entities.Meal", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("ANK_9.Entities.User", b =>
                {
                    b.Navigation("MealFoods");
                });
#pragma warning restore 612, 618
        }
    }
}
