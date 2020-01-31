using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Usuarios")]
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Nome", TypeName = "varchar(100)")];
        public string Nome { get; set; }

        [Column("Email", TypeName = "300")];
        public string Email { get; set; }

        [Column("Senha", TypeName = "20")];
        public string Senha { get; set; }

    }
}
