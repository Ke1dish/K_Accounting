using K_Accounting.Extensions;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

// Основной класс для работы с базой данных
namespace K_Accounting.Data
{
    public class AppDbContext : DbContext
    {
        public const int CurrentDbVersion = 2; // Увеличивать при изменениях

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

        // Настройка подключения к базе SQLite

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "K_Accounting", "budget.db");
            options.UseSqlite($"Data Source={dbPath}");


//            options.UseSqlite($"Data Source={dbPath}")
                //.ConfigureWarnings(warnings => warnings
                //.Ignore(CoreEventId.PendingModelChangesWarning));
        }


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

            modelBuilder.Entity<Expense>()
                .Property(e => e.Quantity)
                .HasDefaultValue(1m);

            modelBuilder.Entity<Expense>()
                .Property(e => e.IsAutoUnit)
                .HasDefaultValue(true);

            modelBuilder.Entity<SubCategory>(s =>
            {
                s.HasOne(x => x.Category)
                    .WithMany()
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // Индексы
            modelBuilder.Entity<Account>().HasIndex(a => a.Name);
            modelBuilder.Entity<Income>().HasIndex(i => i.Date);

            modelBuilder.Entity<DbVersion>(entity =>
            {
                entity.HasIndex(v => v.Version).IsUnique();
                entity.Property(v => v.MigrationId).HasMaxLength(100);
            });

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