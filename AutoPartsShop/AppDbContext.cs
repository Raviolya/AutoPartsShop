using System.Data.Entity;

namespace AutoPartsShop
{
    public class AppDbContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPart> OrderParts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<SmallProduction> SmallProductions { get; set; }
        public DbSet<SmallSupplier> SmallSuppliers { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestPart> RequestParts { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Defect> Defects { get; set; }

        public AppDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderPart>()
                .HasKey(op => new { op.OrderId, op.PartId });
            modelBuilder.Entity<OrderPart>()
                .HasRequired(op => op.Order)
                .WithMany(o => o.OrderParts)
                .HasForeignKey(op => op.OrderId);
            modelBuilder.Entity<OrderPart>()
                .HasRequired(op => op.Part)
                .WithMany(p => p.OrderParts)
                .HasForeignKey(op => op.PartId);
            modelBuilder.Entity<Order>()
                .HasRequired(o => o.Supplier)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.SupplierId);
            modelBuilder.Entity<Manufacturer>()
                .HasKey(m => m.SupplierId)
                .HasRequired(m => m.Supplier)
                .WithOptional(s => s.Manufacturer);
            modelBuilder.Entity<Dealer>()
                .HasKey(d => d.SupplierId)
                .HasRequired(d => d.Supplier)
                .WithOptional(s => s.Dealer);
            modelBuilder.Entity<SmallProduction>()
                .HasKey(sp => sp.SupplierId)
                .HasRequired(sp => sp.Supplier)
                .WithOptional(s => s.SmallProduction);
            modelBuilder.Entity<SmallSupplier>()
                .HasKey(ss => ss.SupplierId)
                .HasRequired(ss => ss.Supplier)
                .WithOptional(s => s.SmallSupplier);
            modelBuilder.Entity<Shop>()
                .HasKey(sh => sh.SupplierId)
                .HasRequired(sh => sh.Supplier)
                .WithOptional(s => s.Shop);
            modelBuilder.Entity<RequestPart>()
                .HasKey(rp => new { rp.RequestId, rp.PartId });
            modelBuilder.Entity<RequestPart>()
                .HasRequired(rp => rp.Request)
                .WithMany(r => r.RequestParts)
                .HasForeignKey(rp => rp.RequestId);
            modelBuilder.Entity<RequestPart>()
                .HasRequired(rp => rp.Part)
                .WithMany(p => p.RequestParts)
                .HasForeignKey(rp => rp.PartId);
            modelBuilder.Entity<Warehouse>()
                .HasRequired(w => w.Part)
                .WithMany(p => p.Warehouses)
                .HasForeignKey(w => w.PartId);
            modelBuilder.Entity<Defect>()
                .HasKey(d => d.WarehousePartId)
                .HasRequired(d => d.Warehouse)
                .WithOptional(w => w.Defect);
        }
    }
}