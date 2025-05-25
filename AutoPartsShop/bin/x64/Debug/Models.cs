using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsShop
{
    public class Part
    {
        [Key]
        public int PartId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double SalePrice { get; set; }

        public List<OrderPart> OrderParts { get; set; }
        public List<RequestPart> RequestParts { get; set; }
        public List<Warehouse> Warehouses { get; set; }

        public Part() { }

        public Part (string Name, int SalePrice)
        {
            this.Name=Name;
            this.SalePrice=SalePrice;
        }
    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public string Status { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
        public List<OrderPart> OrderParts { get; set; }
    }

    public class OrderPart
    {
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        [Key, Column(Order = 1)]
        public int PartId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int Price { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("PartId")]
        public Part Part { get; set; }
    }

    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ContactInfo { get; set; }
        [Required]
        public string SupplierType { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public Dealer Dealer { get; set; }
        public SmallProduction SmallProduction { get; set; }
        public SmallSupplier SmallSupplier { get; set; }
        public Shop Shop { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Manufacturer
    {
        [Key, ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        [Required]
        public string WarrantyPeriod { get; set; }
        [Required]
        public string ContractDetails { get; set; }

        public Supplier Supplier { get; set; }
    }

    public class Dealer
    {
        [Key, ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        [Required]
        public string WarrantyPeriod { get; set; }
        [Required]
        public string ContractDetails { get; set; }
        [Required]
        public double DiscountRate { get; set; }

        public Supplier Supplier { get; set; }
    }

    public class SmallProduction
    {
        [Key, ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        [Required]
        public int ProductionCapacity { get; set; }

        public Supplier Supplier { get; set; }
    }

    public class SmallSupplier
    {
        [Key, ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        [Required]
        public string Specialization { get; set; }

        public Supplier Supplier { get; set; }
    }

    public class Shop
    {
        [Key, ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        [Required]
        public string Location { get; set; }

        public Supplier Supplier { get; set; }
    }

    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Status { get; set; }

        public List<RequestPart> RequestParts { get; set; }
    }

    

    public class RequestPart
    {
        [Key, Column(Order = 0)]
        public int RequestId { get; set; }
        [Key, Column(Order = 1)]
        public int PartId { get; set; }
        [Required]
        public int Count { get; set; }

        [ForeignKey("RequestId")]
        public Request Request { get; set; }
        [ForeignKey("PartId")]
        public Part Part { get; set; }
    }

    public class Warehouse
    {
        [Key]
        public int WarehousePartId { get; set; }
        [Required]
        public int PartId { get; set; }
        [Required]
        public string Cell { get; set; }

        [ForeignKey("PartId")]
        public Part Part { get; set; }
        public Defect Defect { get; set; }
        public List<WarehouseSale> WarehouseSale { get; set; }
    }

    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public string Date { get; set; }
        [Required]
        public double TotalPrice { get; set; }

        public List<WarehouseSale> WarehouseSale { get; set; }
    }

    public class WarehouseSale
    {
        [Key, Column(Order = 0)]
        public int WarehousePartId { get; set; }
        [Key, Column(Order = 1)]
        public int SaleId { get; set; }
        [Required]
        public double Price { get; set; }

        [ForeignKey("WarehousePartId")]
        public Warehouse Warehouse { get; set; }
        [ForeignKey("SaleId")]
        public Sale Sale { get; set; }
    }

    public class Defect
    {
        [Key, ForeignKey("Warehouse")]
        public int WarehousePartId { get; set; }
        public string Description { get; set; }
        [Required]
        public string Date { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
