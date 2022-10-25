﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DatadeLancamento { get; set; }
        public string Genero { get; set; } = string.Empty;
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal (18,2)")]
        public decimal Preço { get; set; }  
        public int? Pontos { get; set; } 
    }
}
