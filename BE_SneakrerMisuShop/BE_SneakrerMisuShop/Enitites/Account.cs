using BE_SneakrerMisuShop.Enitites;
using BE_SneakrerMisuShop.Enitites.EntitiBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class Account: FullAuditedAggregateRoot
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string RoleCode { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public string? AddressDetail { get; set;}

        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
