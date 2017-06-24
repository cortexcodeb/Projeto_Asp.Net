using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Restaurante
    {
        [Key]
        public int RestauranteID { get; set; }
        [Required]
        public string NameOnwer { get; set; }
        [Required]
        public string Emailaddress { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public string RestaurantCountry { get; set; }
        [Required]
        public string RestaurantCity { get; set; }

        public string RestaurantState { get; set; }
        [Required]
        public string RestaurantPostalCode { get; set; }

        public bool Ativo { get; set; }
    }
}
