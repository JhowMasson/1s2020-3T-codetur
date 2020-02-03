using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Usuarios")]
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Nome", TypeName = "varchar(100)")]
        [Required]
        public string Nome { get; set; }

        [Column("Email", TypeName = "300")]
        [Required]
        public string Email { get; set; }

        [Column("Senha", TypeName = "20")]
        [Required]
        public string Senha { get; set; }

        [Column("Tipo", TypeName = "varchar(20)")]
        [Required]
        public string Tipo { get; set; }
    }
}
