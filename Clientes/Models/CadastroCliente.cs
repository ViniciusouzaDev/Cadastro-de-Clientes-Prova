using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class CadastroCliente
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "Este endereço de e-mail não é válido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Este telefone não é válido")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP inserido não é válido. Utilize o formato 00000-000.")]
        public string cep { get; set; }

        [Required]
        [Display(Name = "Rua")]
        public string rua { get; set; }

        [Required]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string estado { get; set; }
    }
}
