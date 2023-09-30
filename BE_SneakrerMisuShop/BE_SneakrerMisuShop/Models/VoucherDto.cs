using BE_SneakrerMisuShop.Models.ModelBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class VoucherDto: FullAuditedAggregateRootDto
    {
        public string Code { get; set; }
        public decimal PercentPrice { get; set; }

        public int Value { get; set; }
      
        public int Quantity { get; set; }

        public decimal MinimumAmount { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }

    public class FilterVoucher
    {
        public string? Code { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }

    public class ChangeStaus
    {
        public int? Id { get; set; }
    }

    public class MinusAmount
    {
        public string Code { get; set; }
        public decimal MinimumAmount { get; set; }
    }
}
