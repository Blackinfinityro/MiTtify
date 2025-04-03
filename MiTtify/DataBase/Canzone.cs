using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiTtify.DataBase
{
    public class Canzone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;

        [Required] public string Nome { get; set; }
        [Required] public string Autore { get; set; } = null!;
    }
}
