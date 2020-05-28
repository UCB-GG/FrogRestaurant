using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDataAccess.Database
{
    [Table("CORE_PERSON")]
    public class PizzaPersonTable
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [MaxLength(60)]
        public string Name { get; set; }
    }
}
