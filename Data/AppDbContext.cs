//using System.Data.Entity;
using K_Accounting.Extensions;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

// Основной класс для работы с базой данных
namespace K_Accounting.Data
{
    public class AppDbContext : DbContext
    {

        public const int CurrentDbVersion = 1; // Увеличивать при изменениях

        // Таблицы в базе данных
        public DbSet<DbVersion> DbVersions { get; set; }
        public DbSet<Account> Accounts { get; set; }  // Счета (кошельки, карты)
        public DbSet<Expense> Expenses { get; set; }  // Записи о расходах
        public DbSet<Income> Incomes { get; set; }    // Записи о доходах
        public DbSet<Source> Sources { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Additional> Additionals { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<DebtPayment> DebtPayments { get; set; }
        public DbSet<Counterparty> Counterparties { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }

        // Настройка подключения к базе SQLite

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "K_Accounting", "budget.db");
            options.UseSqlite($"Data Source={dbPath}");

            options.EnableSensitiveDataLogging()
               .LogTo(Console.WriteLine, LogLevel.Information); // Логи в консоль
        }


        // Настройка отношений между таблицами
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Глобальный фильтр мягкого удаления
            modelBuilder.ApplyGlobalFilters<Interfaces.ISoftDelete>(e => e.IsDeleted == false);

            // Конфигурация для Expense
            modelBuilder.Entity<Expense>(e =>
            {
                e.HasOne(x => x.Account)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);

                e.HasIndex(x => new { x.Date, x.Amount });

                e.Property(x => x.Quantity)
                    .HasDefaultValue(1m);

                e.Property(x => x.IsAutoUnit)
                    .HasDefaultValue(true);
            });

            // Конфигурация для SubCategory
            modelBuilder.Entity<SubCategory>(s =>
            {
                s.HasOne(x => x.Category)
                    .WithMany()
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // Индексы для Account и Income
            modelBuilder.Entity<Account>().HasIndex(a => a.Name);
            modelBuilder.Entity<Income>().HasIndex(i => i.Date);

            // Конфигурация для DbVersion
            modelBuilder.Entity<DbVersion>(entity =>
            {
                entity.HasIndex(v => v.Version).IsUnique();
                entity.Property(v => v.MigrationId).HasMaxLength(100);
            });

            // Единый блок конфигурации для Debt
            modelBuilder.Entity<Debt>(d =>
            {
                // Настройка свойств
                d.Property(x => x.Type)
                    .HasConversion<string>()
                    .HasMaxLength(20);

                d.Property(x => x.Status)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .HasDefaultValue(DebtStatus.Active);

                d.Property(x => x.InitialAmount)
                    .HasPrecision(18, 2);

                d.Property(x => x.RemainingAmount)
                    .HasPrecision(18, 2);

                // Индексы
                d.HasIndex(x => x.DueDate);
                d.HasIndex(x => x.Status);
                d.HasIndex(x => x.Type);

                // Связи
                d.HasMany(x => x.Payments)
                    .WithOne(x => x.Debt)
                    .OnDelete(DeleteBehavior.Cascade);

                d.HasOne(x => x.Counterparty)
                    .WithMany()
                    .HasForeignKey(x => x.CounterpartyId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // Конфигурация для DebtPayment
            modelBuilder.Entity<DebtPayment>(d =>
            {
                d.HasIndex(x => x.PaymentDate);
                d.Property(x => x.Amount)
                    .HasPrecision(18, 2);
                d.Property(x => x.Comment)
                    .HasMaxLength(1000);
            });

            // Конфигурация для Counterparty
            modelBuilder.Entity<Counterparty>(c =>
            {
                c.HasIndex(x => x.Name).IsUnique();
                c.Property(x => x.Phone).HasMaxLength(20);
                c.Property(x => x.Email).HasMaxLength(100);
            });

            // Конфигурация для Goal
            modelBuilder.Entity<Goal>(g =>
            {
                // Индексы
                g.HasIndex(x => x.TargetDate);
                g.HasIndex(x => x.Status);
                g.HasIndex(x => x.ReminderDate);

                // Ограничения
                g.Property(x => x.Title)
                    .HasMaxLength(200)
                    .IsRequired();

                g.Property(x => x.TargetAmount)
                    .HasPrecision(18, 2)
                    .IsRequired();

                // Связь с Currency
                g.HasOne(x => x.Currency)
                    .WithMany()
                    .HasForeignKey(x => x.CurrencyId)
                    .OnDelete(DeleteBehavior.Restrict); // Запрещаем удаление валюты с целями
            });

            modelBuilder.Entity<MeasurementUnit>().HasData(
                new MeasurementUnit
                {
                    Id = 1,
                    Name = "БЕИ",
                    Symbol = "",
                    CreatedAt = new DateTime(2024, 1, 1) // Фиксированная дата
                }
            );
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