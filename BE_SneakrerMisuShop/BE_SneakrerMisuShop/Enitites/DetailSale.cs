using BE_SneakrerMisuShop.Enitites.EntitiBases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_SneakrerMisuShop.Enitites
{
    public class DetailSale: FullAuditedAggregateRoot
    {
        [Required]
        public int SaleId { get; set; }
        [Required]
        public int DetailId { get; set; }

        [ForeignKey(nameof(SaleId))]
        public Sale Sale { get; set; }
        [ForeignKey(nameof(DetailId))]
        public ProductDetail Detail { get; set; }
    }
}
