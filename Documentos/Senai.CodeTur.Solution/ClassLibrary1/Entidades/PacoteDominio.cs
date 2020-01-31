using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Pacotes")]
    public class PacoteDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Nome", TypeName = "varchar(85)")]
        public string Nome { get; set; }

        [Column("Pais", TypeName = "varchar(60)")]
        public string Pais { get; set; }

        [Column("Descricao", TypeName = "varchar(600)")]
        public string Descricao { get; set; }

        [Column("DataInicio", TypeName = "datetime")]
        public string DataInicio { get; set; }

        [Column("DataFim", TypeName = "datetime")]
        public string DataFim { get; set; }

        [Column("Imagem", TypeName = "varchar(350)")]
        public string Imagem { get; set; }
                
    }
}
