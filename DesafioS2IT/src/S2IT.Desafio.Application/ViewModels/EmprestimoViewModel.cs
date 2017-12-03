using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.ViewModels
{
    public class EmprestimoViewModel
    {
        public long IdEmprestimo { get; set; }

        public long IdAmigo { get; set; }

        public long IdJogo { get; set; }

        public long IdUsuario { get; set; }

        /// <summary>
        /// 1 - Emprestado
        /// 2 - Devolvido
        /// </summary>
        public long IdStatusEmprestimo { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public Nullable<DateTime> DataDevolucao { get; set; }

        public DateTime DataModificacao { get; set; }

        public virtual StatusEmprestimoViewModel StatusEmprestimo { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }

        public virtual AmigoViewModel Amigo { get; set; }

        public virtual JogoViewModel Jogo { get; set; }
    }
}
