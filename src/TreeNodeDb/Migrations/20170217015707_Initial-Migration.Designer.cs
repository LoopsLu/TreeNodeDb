using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TreeNodeDb.Models;

namespace TreeNodeDb.Migrations
{
    [DbContext(typeof(TreeNodeDbContext))]
    [Migration("20170217015707_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TreeNodeDb.Models.Node", b =>
                {
                    b.Property<string>("NodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ParentId");

                    b.HasKey("NodeId");

                    b.HasIndex("ParentId");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("TreeNodeDb.Models.Node", b =>
                {
                    b.HasOne("TreeNodeDb.Models.Node", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });
        }
    }
}
