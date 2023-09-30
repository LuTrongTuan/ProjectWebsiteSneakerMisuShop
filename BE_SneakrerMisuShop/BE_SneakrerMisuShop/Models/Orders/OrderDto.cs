
using BE_SneakrerMisuShop.Models.ModelBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class OrderDto: FullAuditedAggregateRootDto
    {
        public string Code { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Phone { get; set; }
        public string OrderItem { get; set; }
        public bool? TypePayment { get; set; }
        public bool? BoughtType { get; set; }
        public decimal Total { get; set; }
        public decimal? FeeShiping { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public string? CityName { get; set; }
        public string? DistrictName { get; set; }
        public string? TownName { get; set; }
        public string? AddressDetail { get; set; }
        public string? AccountName { get; set; }
        public int? Type { get; set; }
        public string? VoucherCode { get; set; }
    }
    public class FilterOrderStatus
    {
        public int Status { get; set; }
    }
    public class FilterOrder
    {
        public int? Status { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool? isDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public bool? TypePayment { get; set; }
        public bool? BoughtType { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }

    public class OrderInfoDto
    {
        public int Id { get; set; }
        public string OrderItem { get; set; }
        public decimal Total { get; set; }
        public string ListAllProduct { get; set; }
    }

    public class OrderItemDto
    {
        public string OrderItem { get; set; }
    }


    public class UpdateOrderDto : FullAuditedAggregateRootDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public bool? TypePayment { get; set; }
        public bool? BoughtType { get; set; }
        public decimal? Total { get; set; }
        public decimal? FeeShiping { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public string? CityName { get; set; }
        public string? DistrictName { get; set; }
        public string? TownName { get; set; }
        public string? AddressDetail { get; set; }
        public int? Type { get; set; }
    }
}
