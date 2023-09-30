using BE_SneakrerMisuShop.Enitites.EntitiBases;
using BE_SneakrerMisuShop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_SneakrerMisuShop.Enitites
{
    public class Comment: FullAuditedAggregateRoot
    {
        [Required]
        public int AccountId { get; set; }
        public string Comments { get; set; }
        public int ProductId { get; set; }
        public int Star { get; set; }

        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
