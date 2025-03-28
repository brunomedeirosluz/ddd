﻿

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
	public class ProdutoViewModel
	{
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome deve ser preenchido")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha um valor")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}