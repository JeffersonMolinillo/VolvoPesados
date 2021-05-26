using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VolvoPesados.Libraries.Lang;

namespace VolvoPesados.Models
{
    public class Caminhao
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_CMP_OBRIGÁTORIO")]
        public string Iniciais { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_CMP_OBRIGÁTORIO")]
        public string Modelo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_CMP_OBRIGÁTORIO")]
        public string Cor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_CMP_OBRIGÁTORIO")]
        public int Eixo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_CMP_OBRIGÁTORIO")]
        [Display(Name = "Ano de Fabricação")]
        public string AnoFabricacao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_CMP_OBRIGÁTORIO")]
        [Display(Name = "Ano Modelo")]
        public string AnoModelo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_CMP_OBRIGÁTORIO")]
        [Display(Name = "Transmissão")]
        public string Transmissao { get; set; }

    }
}
