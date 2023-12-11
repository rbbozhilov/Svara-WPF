using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class EightSpatia: BaseCard
    {

        public EightSpatia()
        {
            this.Name = "Eight";
            this.Type = "Spatia";
            this.Points = 8;
            this.ImagePath = "/Images/eightspatia.png";
        }

    }
}
