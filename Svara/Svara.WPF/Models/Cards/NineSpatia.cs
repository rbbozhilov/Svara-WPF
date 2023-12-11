using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class NineSpatia: BaseCard
    {
        public NineSpatia()
        {
            this.Name = "Nine";
            this.Type = "Spatia";
            this.Points = 9;
            this.ImagePath = "/Images/ninespatia.png";
        }
    }
}
