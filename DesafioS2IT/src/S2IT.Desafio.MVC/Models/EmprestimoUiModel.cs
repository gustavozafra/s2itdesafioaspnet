using S2IT.Desafio.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S2IT.Desafio.MVC.Models
{
    public class EmprestimoUiModel
    {
        public IEnumerable<AmigoViewModel> Amigos { get; set; }
        public IEnumerable<JogoViewModel> Jogos { get; set; }
    }
}