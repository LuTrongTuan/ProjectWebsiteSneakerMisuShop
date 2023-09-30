using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Enitites.EntitiBases
{
    public class FullAuditedAggregateRoot
    {
        [Key]
        public int Id { get; set; }
        public int? Status { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool? isDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
