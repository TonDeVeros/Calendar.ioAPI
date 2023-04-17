using System.ComponentModel.DataAnnotations;

namespace Calendar.ioWebAPI.Models
{
    public class Customers
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório!")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "O número do cliente é obrigatório!")]
        public int CustomerNumber { get; set; }

        [Required(ErrorMessage = "O endereço do cliente é obrigatório!")]
        public string CustomerAdress { get; set; }

        [Required(ErrorMessage = "A data em que será realizada a visita ao cliente é obrigatória!")]
        public DateTime ServiceDate { get; set; }
    }
}
