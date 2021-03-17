using Microsoft.EntityFrameworkCore;
using MidTerm.Data.Entities;
using System;

namespace MidTerm.Data
{
    public class MidTermDbContext : DbContext
    {
        public MidTermDbContext(DbContextOptions<MidTermDbContext> options)
        : base(options)
        {
        }

        public DbSet<Answers> Answers { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SurveyUser> SurveyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Option>(option =>
            {
                option.Property(o => o.Id).IsRequired();
                option.HasKey(o => o.Id);
                option.Property(o => o.Text).HasMaxLength(800).IsRequired();
                option.Property(o => o.Order);

                option.HasOne(o => o.Question);
            });

            modelBuilder.Entity<Question>(question =>
            {
                question.Property(q => q.Id).IsRequired();
                question.HasKey(q => q.Id);
                question.Property(q => q.Text).HasMaxLength(800).IsRequired();
                question.Property(q => q.Description).HasMaxLength(800).IsRequired();

                question.HasMany(q => q.Options);
            });
        }
    }
}
