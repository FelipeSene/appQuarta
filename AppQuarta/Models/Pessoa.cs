using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppQuarta.Models
{
    public class Pessoa
    {
        [Range(1, 500, ErrorMessage ="O código deve estar entre 1 e 500")]
        [Required(ErrorMessage = "O código é obrigatório")]
        [DisplayName("Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [DisplayName("Nome e Sobrenome")]
        public string NomePessoa { get; set; }
        [StringLength(50, MinimumLength =5, ErrorMessage = "O campo deve conter no mínimo 5 caracteres e máximo 50")]
        public string Obs { get; set; }

        [DisplayName("E_mail")]
        [EmailAddress]
        [Required(ErrorMessage = "o E_mail é obrigatório")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-ZçÇ0-9]{6,15}",
        ErrorMessage ="Formato de Login incorreto! 'Deve conter somente letras e números de 6 a 15 caracteres'")]
        [Required(ErrorMessage = "O Login é obrigatório")]

        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha{ get; set; }

        [Compare("Senha", ErrorMessage ="As senhas são diferentes")]
        public string ConfirmaSenha { get; set; }
    }
}