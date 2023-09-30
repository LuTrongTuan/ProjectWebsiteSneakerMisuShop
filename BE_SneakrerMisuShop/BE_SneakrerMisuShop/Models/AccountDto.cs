using BE_SneakrerMisuShop.Models.ModelBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class AccountDto: FullAuditedAggregateRootDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RoleCode { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public string? AddressDetail { get; set; }
    }
    public class FilterAccount
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
    }

    public class LoginDto : AccountDto
    {
        public string? token { get; set; }
    }
    public class LoginParamDto 
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
