using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//---
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTravel.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        [Required, StringLength(20), Display(Name = "Número do Pedido")]
        public string NumPedido { get; set; }

        [Required, Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Display(Name = "Data de Criação do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data de Alteração do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAlteracao { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Item> ItemId { get; set; }
        public virtual ICollection<Passageiro> PassageiroId { get; set; }
    }
}