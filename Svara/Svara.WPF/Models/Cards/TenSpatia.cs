using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class TenSpatia : BaseCard
    {
        public TenSpatia()
        {
            this.Name = "Ten";
            this.Type = "Spatia";
            this.Points = 10;
            this.ImagePath = "/Images/tenspatia.png";
        }
    }
}
