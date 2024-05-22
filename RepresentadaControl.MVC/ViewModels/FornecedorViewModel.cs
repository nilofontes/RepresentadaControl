using RepresentadaControl.MVC.ViewModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RepresentadaControl.Data
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Document { get; set; }

        [DisplayName("Tipo")]
        public int TipoFornecedor { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }



    }
}