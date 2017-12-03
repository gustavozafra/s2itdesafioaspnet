using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public long IdUsuario { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime DataModificacao { get; set; }

        public bool FlagAtivo { get; set; }

        public List<AmigoViewModel> Amigos { get; set; }

        public List<JogoViewModel> Jogos { get; set; }

        public List<EmprestimoViewModel> Emprestimos { get; set; }
    }
}
