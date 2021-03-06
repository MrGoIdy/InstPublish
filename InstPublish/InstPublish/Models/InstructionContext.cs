﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InstPublish.Models
{
    public class InstructionContext : DbContext
    {
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        //public InstructionContext() : base("DefaultConnection") { }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Instruction>().HasMany(c => c.Tags)
        //        .WithMany(s => s.Instructions)
        //        .Map(t => t.MapLeftKey("InstructionId")
        //        .MapRightKey("TagId")
        //        .ToTable("InstructionTag"));
        //}

    }
} 