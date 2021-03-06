// <auto-generated />
using OnTopOfIt.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace OnTopOfIt.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20210226183838_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnTopOfIt.Models.TodoItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("repeatFriday")
                        .HasColumnType("bit");

                    b.Property<bool>("repeatMonday")
                        .HasColumnType("bit");

                    b.Property<bool>("repeatSaturday")
                        .HasColumnType("bit");

                    b.Property<bool>("repeatSunday")
                        .HasColumnType("bit");

                    b.Property<bool>("repeatThursday")
                        .HasColumnType("bit");

                    b.Property<bool>("repeatTuesday")
                        .HasColumnType("bit");

                    b.Property<bool>("repeatWednesday")
                        .HasColumnType("bit");

                    b.Property<bool>("taskComplete")
                        .HasColumnType("bit");

                    b.Property<string>("timeofDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
