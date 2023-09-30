using BE_SneakrerMisuShop.Models.ModelBases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_SneakrerMisuShop.Models
{
    public class ProductDto: FullAuditedAggregateRootDto
    {
        public int? BranchId { get; set; }
        public int? CategoryId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Origin { get; set; }
        public string? Material { get; set; }
        public string? Sole { get; set; }
        public string? BranchName { get; set; }
        public string? CategoryName { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string? FilterPrice { get; set; }
        public decimal? Price { get; set; }

        public int? SizeId { get; set; }
        public int? ColorId { get; set; }
        public string? Sku { get; set; }
        public decimal? ImportPrice { get; set; }
        public int? Amount { get; set; }
        public int? AmountCart { get; set; }
        public int? PoductDetailId { get; set; }
        public string? ColorName { get; set; }
        public string? SizeName { get; set; }

    }

    public class FilterProduct
    {
        public string? FilterPrice { get; set; }
        public int? BranchId { get; set; }
        public int? CategoryId { get; set; }
    }
    public class ProductFilter
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? BranchId { get; set; }
        public int? CategoryId { get; set; }
        public string? FilterPrice { get; set; }
    }
}
