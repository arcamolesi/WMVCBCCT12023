using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCBCCT12023.Models
{
    public class Atendimento
    {

        [Key]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        public int alunoID { get; set; }
        [ForeignKey("alunoID")]
        [Display(Name = "Aluno: ")]
        public Aluno aluno { get; set; }


        public int salaID { get; set; }
        [ForeignKey("salaID")]
        [Display(Name = "Sala: ")]
        public Sala sala { get; set; }


        [Required(ErrorMessage = "campo data é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data: ")]
        public DateTime data { get; set; }

        [Required(ErrorMessage = "campo hora é obrigatório")]
        [DataType(DataType.Time)]
        [Display(Name = "Hora: ")]
        public DateTime hora { get; set; }
    }
}
