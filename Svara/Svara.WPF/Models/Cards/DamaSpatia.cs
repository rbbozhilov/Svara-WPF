using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class DamaSpatia: BaseCard
    {
        public DamaSpatia()
        {
            this.Name = "Dama";
            this.Type = "Spatia";
            this.Points = 10;
            this.ImagePath = "/Images/damaspatia.png";
        }
    }
}
