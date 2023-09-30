using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models.ModelBases
{
    public class FullAuditedAggregateRootDto
    {
        public int Id { get; set; }
        public int? Status { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool? isDeleted { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
