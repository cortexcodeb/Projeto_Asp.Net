using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Reserva
    {
        [Key]
        public int ReservaID { set; get; }

        [Required]
        public string Qtdpessoa { set; get; }

        [Required]
        public DataType Date { set; get; }
        /*- CLIENTE -*/
        public int ClienteID { set; get; }
        public Cliente _Cliente { set; get; }
        /*- MESA -*/
        public int MesaID { set; get; }
        public Mesa _Mesa { set; get; }
        /*- RESTAURANTE -*/
        public int RestauranteID { set; get; }
        public Restaurante _Restaurante { set; get; }
    }
}
