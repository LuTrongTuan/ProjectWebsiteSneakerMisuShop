using BE_SneakrerMisuShop.Enitites.EntitiBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Enitites
{
    public class Voucher: FullAuditedAggregateRoot
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public decimal PercentPrice { get; set; }
        [Required]
        public int Value { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal MinimumAmount { get; set; }
        [Required]
        public DateTime EffectiveDate { get; set; }
        [Required]
        public DateTime ExpiredDate { get; set; }

    }
}
