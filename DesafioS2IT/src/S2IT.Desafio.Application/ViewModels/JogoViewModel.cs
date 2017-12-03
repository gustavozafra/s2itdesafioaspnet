using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.ViewModels
{
    public class JogoViewModel
    {
        public long IdJogo { get; set; }

        public string Nome { get; set; }

        public DateTime DataModificacao { get; set; }

        public bool FlagAtivo { get; set; }

        public long IdUsuario { get; set; }

        public UsuarioViewModel Usuario { get; set; }

        public List<EmprestimoViewModel> Emprestimos { get; set; }
    }
}
