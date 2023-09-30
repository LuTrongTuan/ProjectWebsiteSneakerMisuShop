using BE_SneakrerMisuShop.Enitites.EntitiBases;

namespace BE_SneakrerMisuShop.Enitites
{
    public class Role: FullAuditedAggregateRoot
    {
        
        public string Code { get; set; }

        public string Name { get; set; }

    }
}
