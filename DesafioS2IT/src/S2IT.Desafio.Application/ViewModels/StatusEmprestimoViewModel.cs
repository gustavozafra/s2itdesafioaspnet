using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Application.ViewModels
{
    public class StatusEmprestimoViewModel
    {
        /// <summary>
        /// 1 - Emprestado
        /// 2 - Devolvido
        /// </summary>
        public long IdStatusEmprestimo { get; set; }

        public string Descricao { get; set; }

        public List<EmprestimoViewModel> Emprestimos { get; set; }
    }
}
