using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//---
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTravel.Models
{
    [Table("Passageiros")]
    public class Passageiro
    {
        [Key]
        public int PassageiroId { get; set; }

        [Required, StringLength(20), Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required, StringLength(20), Display(Name = "SobreNome")]
        public string SobreNome { get; set; }

        [Required, Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required, Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required, Display(Name = "Data de Nascimento"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Data de Criação do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data de Alteração do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAlteracao { get; set; }

        public int PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public virtual Pedido Pedido { get; set; }
    }
}