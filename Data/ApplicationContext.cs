using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBotTest_2.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AppUser> appUsers { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Укажите строку подключения к вашей базе данных MS SQL Server
            optionsBuilder.UseSqlServer("Server=kalymzhanovvv;Database=TelegramBotTest#1_DB;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
