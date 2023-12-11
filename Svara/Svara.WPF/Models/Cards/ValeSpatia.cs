using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class ValeSpatia: BaseCard
    {
        public ValeSpatia()
        {
            this.Name = "Vale";
            this.Type = "Spatia";
            this.Points = 10;
            this.ImagePath = "/Images/valespatia.png";
        }
    }
}
