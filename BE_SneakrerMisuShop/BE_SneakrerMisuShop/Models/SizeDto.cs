using BE_SneakrerMisuShop.Models.ModelBases;

namespace BE_SneakrerMisuShop.Models
{
    public class SizeDto: FullAuditedAggregateRootDto
    {
        public string Name { get; set; }
    }
    public class CreateSizeDto
    {
        public int? Status { get; set; }
        public DateTime? CreationTime { get; set; }
        public bool? isDeleted { get; set; }
        public string Name { get; set; }
    }
}
