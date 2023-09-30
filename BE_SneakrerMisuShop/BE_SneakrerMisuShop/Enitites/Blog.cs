using BE_SneakrerMisuShop.Enitites.EntitiBases;

namespace BE_SneakrerMisuShop.Enitites
{
    public class Blog: FullAuditedAggregateRoot
    {
        public string ContentHTML { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
