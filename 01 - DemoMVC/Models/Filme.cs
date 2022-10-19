using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres.")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo data é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]", ErrorMessage = "Genero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "O campo genero é obrigatório!")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório")]
        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo avaliação é obrigatório")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente Números")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
