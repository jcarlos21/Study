using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models {
    public class Categoria {

        public int Id { get; set; }  // Foi criada
        [Display(Name = "Descrição")]  // Foi criada
        [Required(ErrorMessage = "O campo descrição é obrigatório")]  // Foi criada
        public string Descricao { get; set; }  // Foi criada

        // public List<Produto> Produtos { get; set; }  // Foi criada

    }
}
