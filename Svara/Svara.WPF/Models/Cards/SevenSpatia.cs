using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class SevenSpatia: BaseCard
    {
        public SevenSpatia()
        {
            this.Name = "Seven";
            this.Type = "Spatia";
            this.Points = 11;
            this.ImagePath = "/Images/sevenspatia.png";
        }
    }
}
