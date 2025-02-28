using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using K_Accounting.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.ComponentModel;
using K_Accounting.Extensions;

// Основной класс для работы с базой данных
namespace K_Accounting.Data
{
    public class AppDbContext : DbContext
    {
        // Таблицы в базе данных
        public DbSet<Account> Accounts { get; set; }  // Счета (кошельки, карты)
        public DbSet<Expense> Expenses { get; set; }  // Записи о расходах
        public DbSet<Income> Incomes { get; set; }    // Записи о доходах
        public DbSet<Source> Sources { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Additional> Additionals { get; set; }

        // Настройка подключения к базе SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=budget.db");

        // Настройка отношений между таблицами
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Глобальный фильр мягкого удаления
            // Автоматическое скрытие удаленных записей
            modelBuilder.ApplyGlobalFilters<Interfaces.ISoftDelete>(e => e.IsDeleted == false);

            // Конфигурация связей
            // Связь расходов со счетами (нельзя удалять счет с расходами)
            modelBuilder.Entity<Expense>(e =>
            {
                e.HasOne(x => x.Account)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);

                e.HasIndex(x => new { x.Date, x.Amount });
            });

            modelBuilder.Entity<SubCategory>(s =>
            {
                s.HasOne(x => x.Category)
                    .WithMany()
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Currency>(c =>
            {
                c.HasIndex(x => x.Code).IsUnique();
            });

            // Индексы
            modelBuilder.Entity<Account>().HasIndex(a => a.Name);
            modelBuilder.Entity<Income>().HasIndex(i => i.Date);
        }

        // Автоматическое "мягкое удаление" - пометка IsDeleted вместо реального удаления
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<Interfaces.ISoftDelete>())
            {
                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.IsDeleted = true;
                }
            }
            return base.SaveChanges();
        }
    }
}