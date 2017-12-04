using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.ViewModels
{
    public class AmigoViewModel
    {
        public AmigoViewModel()
        {
            Emprestimos = new List<EmprestimoViewModel>();
        }

        public long IdAmigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataModificacao { get; set; }

        public bool FlagAtivo { get; set; }

        public long IdUsuario { get; set; }

        public UsuarioViewModel Usuario { get; set; }

        public List<EmprestimoViewModel> Emprestimos { get; set; }
    }
}
