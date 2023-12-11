using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class PopSpatia : BaseCard
    {
        public PopSpatia()
        {
            this.Name = "Pop";
            this.Type = "Spatia";
            this.Points = 10;
            this.ImagePath = "/Images/popspatia.png";
        }
    }
}
