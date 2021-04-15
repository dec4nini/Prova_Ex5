using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaExLivro.Models
{
    public class Livro
    {
        [Key]
        public long? LivroID { get; set; }

        [Required]
        public string Autor { get; set; }
        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Editora { get; set; }

        [Required]
        public string Idioma { get; set; }
        [Display(Name = "Data de Publicação")]
        [Required]
        public string DataPub { get; set; }

        [Required]
        public int QtdePag { get; set; }
    }
}
