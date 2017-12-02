using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Entities
{
    [Table("JOGO")]
    public class Jogo
    {
        [Column("IDJOGO")]
        public long IdJogo { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("DATAMODIFICACAO")]
        public DateTime DataModificacao { get; set; }

        [Column("FLAGATIVO")]
        public bool FlagAtivo { get; set; }
    }
}
