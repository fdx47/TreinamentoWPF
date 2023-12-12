using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text.Json;
using TreinamentoWPF.Models;
using TreinamentoWPF.Models.Evoliz;

namespace TreinamentoWPF
{
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<SaleClassification> SaleClassifications { get; set; }
        public DbSet<PurchaseClassification> PurchaseClassifications { get; set; }
        public DbSet<Margin> Margins { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<CustomFields> CustomFields { get; set; }
        public DbSet<CustomFieldApi> CustomFieldsApi { get; set; }
        public DbSet<CustomFieldApi2> CustomFieldsApi2 { get; set; }
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string json = File.ReadAllText("appsettings.json");
            AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(json);
            string connectionString = appSettings.ConnectionStrings.DefaultConnection.Conn;
            // string conn = "server=localhost;user id=root;database=dbcomercio; password=qwe123!@#";
            string conn = connectionString + ";password=Brasil2023";

            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }
    }
}
