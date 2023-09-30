using BE_SneakrerMisuShop.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BE_SneakrerMisuShop.Models.ModelBases;

namespace BE_SneakrerMisuShop.Models
{
    public class ProductImageDto: FullAuditedAggregateRootDto
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }

        public List<string>? ListImageChecked { get; set; }
    }
}
