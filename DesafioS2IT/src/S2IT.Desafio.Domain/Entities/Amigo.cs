using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Entities
{
    [Table("AMIGO")]
    public class Amigo
    {
        [Column("IDAMIGO")]
        public long IdAmigo { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [Column("DATANASCIMENTO")]
        public DateTime DataNascimento { get; set; }

        [Column("DATAMODIFICACAO")]
        public DateTime DataModificacao { get; set; }

        [Column("FLAGATIVO")]
        public bool FlagAtivo { get; set; }
    }
}
