using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//---
using AppTravel.Models;
using System.Data.Entity;

namespace AppTravel.DAO
{
    public class PedidoContext : DbContext
    {
        public PedidoContext() : base("Pedido")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}