using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftDrinkDataAccess.Database
{
    [Table("CORE_SOFT_DRINK_PERSON")]
    public class SoftDrinkPersonTable
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }
}