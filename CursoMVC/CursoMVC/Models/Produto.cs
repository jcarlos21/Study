using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models {

    public class Produto {
        public int Id { get; set; }  // Foi criada
        [Display(Name = "Descrição")]  // Foi criada

        public string Descricao { get; set; }  // Foi criada
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }  // Foi criada

        public int CategoriaId { get; set; }  // Foi criada

        public Categoria Categoria { get; set; }  // Foi criada


    }
}
