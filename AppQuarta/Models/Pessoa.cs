using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppQuarta.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomePessoa { get; set; }
        public string Obs { get; set; }
        public string Login { get; set; }
        public string Senha{ get; set; }
    }
}