using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Domain.Entities
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Column("IDUSUARIO")]
        public long IdUsuario { get; set; }

        [Column("LOGIN")]
        public string Login { get; set; }

        [Column("SENHA")]
        public string Senha { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [Column("DATAMODIFICACAO")]
        public DateTime DataModificacao { get; set; }

        [Column("FLAGATIVO")]
        public bool FlagAtivo { get; set; }

        public virtual ICollection<Amigo> Amigos { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }

        public virtual ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
