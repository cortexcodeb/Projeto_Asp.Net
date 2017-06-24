using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Cliente
    {
        [Key]
        public int ClienteID { set; get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Local { set; get; }
    }
}
