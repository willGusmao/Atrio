using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace atrio01.Models
{
    public class PacientesModel

    {   
        [Key]
        public int Id_Paciente{ get; set; }

        [Required(ErrorMessage ="Digite o nome")]
        public String? Nome { get; set; }


        [Required(ErrorMessage = "Digite o SobreNome")]
        public String SobreNome { get; set; }

        [Required(ErrorMessage = "Digite a data Nascimentoome")]
        public String? DataNascimento { get; set; }

        [Required(ErrorMessage = "Digite o RG")]
        public int RG{ get; set; }


        [Required(ErrorMessage = "Digite o CPF")]
        public int CPF{ get; set; }


        [Required(ErrorMessage = "Digite o EstadoCivil")]
        public String? EstadoCivil { get; set; }


        [Required(ErrorMessage = "Digite o Genero")]
        public String? Genero { get; set; }


        [Required(ErrorMessage = "Digite o Celular")]
        public String? Celular { get; set; }


        [Required(ErrorMessage = "Digite o Email")]
        public String? Email { get; set; }


        [Required(ErrorMessage = "Digite a Cidade")]
        public String? Cidade { get; set; }


        [Required(ErrorMessage = "Digite o Estado")]
        public String? Estado { get; set; }


        [Required(ErrorMessage = "Digite o Endereco")]
        public String? Endereco { get; set; }


        [Required(ErrorMessage = "Digite a Observacao")]
        public String? Observacao { get; set; }


        [Required(ErrorMessage = "Digite o nome")]
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
}
