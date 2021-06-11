﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.ViewModels
{
    public class RegistroViewModels
    {
        [Required(ErrorMessage ="O campo {0} é obrigatorio")]
        [StringLength(40,ErrorMessage ="Use menos caracterer")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]

        public string Telefone { get; set; }
        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(40,ErrorMessage ="Use menos caracteres")]
        [EmailAddress(ErrorMessage ="Email invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirme sua senha")]
        [Compare("Senha",ErrorMessage ="As senhas não conferem")]
        public string SenhaConfirmada { get; set; }


    }
}
