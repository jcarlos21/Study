using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models {
    public class Contexto : DbContext{

        // Como eu criei uma classe "Categoria" eu preciso falar pro Entity que eu vou ter uma tabela de categoria.
        public DbSet<Categoria> Categorias { get; set; }  // Categorias é o nome da tabela

        public DbSet<Produto> Produtos { get; set; }  // Produtos é o nome da tabela

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // É dentro deste método que eu vou falar qual banco de dados irei utilizar

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");


        }
    }
}
