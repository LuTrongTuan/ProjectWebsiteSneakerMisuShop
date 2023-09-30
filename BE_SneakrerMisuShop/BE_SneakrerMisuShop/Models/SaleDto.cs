using BE_SneakrerMisuShop.Models.ModelBases;

namespace BE_SneakrerMisuShop.Models
{
    public class SaleDto: FullAuditedAggregateRootDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public decimal Value { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiredDate { get; set; }
    }

    public class FilterSale
    {
        public string? Code { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
