using BE_SneakrerMisuShop.Entities;
using BE_SneakrerMisuShop.Models.ModelBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class BrandDto: FullAuditedAggregateRootDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
