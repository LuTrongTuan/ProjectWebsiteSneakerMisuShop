using BE_SneakrerMisuShop.Models.ModelBases;

namespace BE_SneakrerMisuShop.Models
{
    public class DetailSaleDto : FullAuditedAggregateRootDto
    {
        public int SaleId { get; set; }
        public int DetailId { get; set; }
        public decimal Price { get; set; }
        public string? SaleName { get; set; }
        public string? ProductName { get; set; }
        public string? SizeName { get; set; }
        public string? ColorName { get; set; }
        public decimal? ValueSale { get; set; }

    }
    public class CreateUpdateDetailSaleDto
    {
        public int SaleId { get; set; }
        public List<DetailSalesDto> DetailSales { get; set; }
    }
    public class DetailSalesDto
    {
        public int DetailId { get; set; }
    }
}
