using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class AsoSpatia: BaseCard
    {
        public AsoSpatia()
        {
            this.Name = "Aso";
            this.Type = "Spatia";
            this.Points = 11;
            this.ImagePath = "/Images/asospatia.png";
        }
    }
}
