using BE_SneakrerMisuShop.Models.ModelBases;

namespace BE_SneakrerMisuShop.Models
{
    public class CommentDto: FullAuditedAggregateRootDto
    {
        public int AccountId { get; set; }
        public string Comments { get; set; }
        public int ProductId { get; set; }
        public int Star { get; set; }
        public string Username { get; set; }
    }
}
