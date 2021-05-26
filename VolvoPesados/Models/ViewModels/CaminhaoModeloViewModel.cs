using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace VolvoPesados.Models.ViewModels
{
    public class CaminhaoModeloViewModel
    {
        public List<Caminhao> Lista { get; set; }
        public List<SelectListItem> Modelo
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem("Modelo FH", "FH"),
                    new SelectListItem("Modelo FM", "FM"),
                };
            }
            private set { }
        }
    }
}
