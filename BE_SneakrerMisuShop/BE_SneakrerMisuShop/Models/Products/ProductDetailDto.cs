using BE_SneakrerMisuShop.Models.ModelBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class ProductDetailDto: FullAuditedAggregateRootDto
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public string Sku { get; set; }
        public decimal ImportPrice { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int? AmountCart { get; set; }
        public int? ProductDetailId { get; set; }
        public string? ProductName { get; set; }
        public string? ColorName { get; set; }
        public string? SizeName { get; set; }
        public string? ProductCode { get; set; }
        public string? Origin{ get; set; }
        public string? Material { get; set; }
        public string? Sole { get; set; }
        public string? BrandName { get; set; }
        public string? CategoryName { get; set; }
        public bool? isChecked { get; set; }
        public List<int>? DetailId { get; set; }
        public List<int>? SaleId { get; set; }
        public List<bool?>? IsDelete { get; set; }
    }

    public class CheckStock
    {
        public int? Id { get; set; }
        public int? AmountCart { get; set; }
        public bool? isDeleted { get; set; }
    }
}
