using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Entities
{
    [Table("STATUSEMPRESTIMO")]
    public class StatusEmprestimo
    {
        [Column("IDEMPRESTIMO")]
        public long IdStatusEmprestimo { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }
    }
}
