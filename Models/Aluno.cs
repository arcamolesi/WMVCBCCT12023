using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCBCCT12023.Models
{
    public enum Periodo { Manha, Tarde, Noite}; 

    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "campo descrição é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Descrição: ")]
        public string nome { get; set; }

        [Required(ErrorMessage = "campo aniversário é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Aniversário: ")]
        public DateTime aniversario { get; set; }

        [Required(ErrorMessage = "campo e-mail é obrigatório")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail: ")]
        [StringLength(35)]
        public string email { get; set; }

        public int cursoID { get; set; }
        [ForeignKey("cursoID")]
        [Display(Name = "Curso: ")]
        public Curso curso { get; set; }

        [Required (ErrorMessage ="Campo período é obrigatório")]
        [Display(Name = "Período: ")]
        [ForeignKey("Periodo")]
        public int periodo { get; set; }
    }
}
