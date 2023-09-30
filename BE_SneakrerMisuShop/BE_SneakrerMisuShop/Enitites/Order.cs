using BE_SneakrerMisuShop.Enitites.EntitiBases;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_SneakrerMisuShop.Models
{
    public class Order: FullAuditedAggregateRoot
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public int AccountId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string OrderItem { get; set; }
        public bool? TypePayment { get; set; }
        public bool? BoughtType { get; set; }
        [Required]
        public decimal Total { get; set; }
        public decimal? FeeShiping { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public string? CityName { get; set; }
        public string? DistrictName { get; set; }
        public string? TownName { get; set; }
        public string? AddressDetail { get; set; }
        public int? Type { get; set; }
        public string? VoucherCode { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }
    }
}
