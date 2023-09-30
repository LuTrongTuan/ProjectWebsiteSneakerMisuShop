using BE_SneakrerMisuShop.Models.ModelBases;

namespace BE_SneakrerMisuShop.Models.Products
{
    public class CreateUpdateProductDto: FullAuditedAggregateRootDto
    {
        public int BranchId { get; set; }
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Origin { get; set; }
        public string? Material { get; set; }
        public string? Sole { get; set; }
    }
}
