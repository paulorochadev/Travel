using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//---
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTravel.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClientId { get; set; }

        [Required, StringLength(20), Display(Name = "Nome da Empresa")]
        public string Nome { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Display(Name = "Data de Criação do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data de Alteração do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAlteracao { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}