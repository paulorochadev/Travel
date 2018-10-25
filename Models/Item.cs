using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTravel.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required, Display(Name = "Serviço Desejado")]
        public string Tipo { get; set; }

        [Required, StringLength(10), Display(Name = "Número do Voucher")]
        public string Voucher { get; set; }

        [Required, Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Display(Name = "Data de Criação do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data de Alteração do Registro"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAlteracao { get; set; }

        public int PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public virtual Pedido Pedido { get; set; }
    }
}